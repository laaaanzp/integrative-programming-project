using FinalsCollab.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalsCollab.CustomControls
{
    public partial class CComboBox : UserControl
    {
        public event EventHandler OnValueChanged = delegate { };

        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items 
        { 
            get => comboBox.Items;
            set
            {
                comboBox.Items.Clear();
                foreach (object item in value)
                {
                    comboBox.Items.Add(item);
                }
            }
        }
        public string LabelText
        {
            get => label1.Text;
            set => label1.Text = value;
        }
        public string Value
        {
            get => comboBox.SelectedItem != null ? comboBox.SelectedItem.ToString() : "";
            set => comboBox.SelectedItem = value;
        }
        public bool ReadOnly
        {
            get => BackColor == Color.Gainsboro;
            set
            {
                comboBox.Enabled = !value;

                if (value)
                {
                    comboBox.Cursor = Cursors.Arrow;
                    comboBox.BackColor = Globals.DefaultColors.READONLY_BACKGROUND;
                    comboBox.BorderColor = Globals.DefaultColors.READONLY_BACKGROUND;
                    BackColor = Globals.DefaultColors.READONLY_BACKGROUND;
                }
                else
                {
                    comboBox.BackColor = Color.White;
                    comboBox.BorderColor = Color.White;
                    BackColor = Color.White;
                }
            }
        }
        public Color ActiveColor { get; set; } = DefaultColors.THEME_COLOR;
        public Color InactiveColor { get; set; } = DefaultColors.INACTIVE_COLOR;

        public CComboBox()
        {
            InitializeComponent();

            comboBox.OnDropDownOpened += _setAsActive;
            comboBox.OnDropDownClosed += _setAsInactive;
        }        

        private void _setAsActive(object sender, EventArgs e)
        {
            label1.ForeColor = ActiveColor;
            comboBox.ForeColor = ActiveColor;
            panel1.BackColor = ActiveColor;
            comboBox.IconColor = ActiveColor;
        }

        private void _setAsInactive(object sender, EventArgs e)
        {
            label1.ForeColor = InactiveColor;
            comboBox.ForeColor = InactiveColor;
            panel1.BackColor = InactiveColor;
            comboBox.IconColor = InactiveColor;
        }

 
        public void AddItems(List<string> items)
        {
            items.ForEach((s) =>
            {
                AddItem(s);
            });
        }

        public void AddItem(string item)
        {
            comboBox.Items.Add(item);
        }

        
        public void Clear()
        {
            comboBox.SelectedItem = null;
        }

        public new void Focus()
        {
            comboBox.Focus();
        }

        private void comboBox_OnSelectedIndexChanged(object sender, EventArgs e)
        {
            OnValueChanged(sender, e);
        }
    }

    [DefaultEvent("OnSelectedIndexChanged")]
    public class _CComboBox : UserControl
    {
        //Fields
        private Color backColor = Color.White;
        private Color iconColor = DefaultColors.BORDER_COLOR;
        private Color listBackColor = DefaultColors.THEME_COLOR;
        private Color listTextColor = DefaultColors.INACTIVE_COLOR;
        private Color borderColor = DefaultColors.BORDER_COLOR;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Events
        public event EventHandler OnSelectedIndexChanged;
        public event EventHandler OnDropDownOpened = delegate { };
        public event EventHandler OnDropDownClosed = delegate { };

        //Constructor
        public _CComboBox()
        {
            cmbList = new ComboBox();
            lblText = new Label();
            btnIcon = new Button();
            SuspendLayout();

            //ComboBox: Dropdown list
            cmbList.BackColor = listBackColor;
            cmbList.Font = new Font(Font.Name, 10F);
            cmbList.ForeColor = listTextColor;
            cmbList.SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            cmbList.TextChanged += new EventHandler(ComboBox_TextChanged);
            cmbList.DropDownClosed += new EventHandler(ComboBox_DropDownClosed);
            cmbList.MinimumSize = new Size(50, cmbList.Size.Width);

            //Button: Icon
            btnIcon.Dock = DockStyle.Right;
            btnIcon.FlatStyle = FlatStyle.Flat;
            btnIcon.FlatAppearance.BorderSize = 0;
            btnIcon.BackColor = backColor;
            btnIcon.Size = new Size(30, 30);
            btnIcon.Cursor = Cursors.Hand;
            btnIcon.Click += new EventHandler(Icon_Click);//Open dropdown list
            btnIcon.Paint += new PaintEventHandler(Icon_Paint);//Draw icon

            //Label: Text
            lblText.Dock = DockStyle.Fill;
            lblText.AutoSize = false;
            lblText.BackColor = backColor;
            lblText.TextAlign = ContentAlignment.MiddleLeft;
            lblText.Padding = new Padding(8, 0, 0, 0);
            lblText.Font = new Font(this.Font.Name, 10F);
            //->Attach label events to user control event
            lblText.Click += new EventHandler(Surface_Click);//Select combo box
            lblText.MouseEnter += new EventHandler(Surface_MouseEnter);
            lblText.MouseLeave += new EventHandler(Surface_MouseLeave);

            //User Control
            this.Controls.Add(lblText);//2
            this.Controls.Add(btnIcon);//1
            this.Controls.Add(cmbList);//0
            this.MinimumSize = new Size(20, 32);
            this.Size = new Size(200, 32);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(borderSize);//Border Size
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = borderColor; //Border Color
            this.ResumeLayout();
            AdjustComboBoxDimensions();
        }

        //Properties
        //-> Appearance
        [Category("Appearance")]
        public new Color BackColor
        {
            get { return backColor; }
            set
            {
                backColor = value;
                lblText.BackColor = backColor;
                btnIcon.BackColor = backColor;
            }
        }

        [Category("Appearance")]
        public Color IconColor
        {
            get { return iconColor; }
            set
            {
                iconColor = value;
                btnIcon.Invalidate();//Redraw icon
            }
        }

        [Category("Appearance")]
        public Color ListBackColor
        {
            get => listBackColor;
            set
            {
                listBackColor = value;
                cmbList.BackColor = listBackColor;
            }
        }

        [Category("Appearance")]
        public Color ListTextColor
        {
            get { return listTextColor; }
            set
            {
                listTextColor = value;
                cmbList.ForeColor = listTextColor;
            }
        }

        [Category("Appearance")]
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                base.BackColor = borderColor; //Border Color
            }
        }

        [Category("Appearance")]
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Padding = new Padding(borderSize);
                AdjustComboBoxDimensions();
            }
        }

        [Category("Appearance")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set
            {
                base.ForeColor = value;
                lblText.ForeColor = value;
            }
        }

        [Category("Appearance")]
        public override Font Font
        {
            get { return base.Font; }
            set
            {
                base.Font = value;
                lblText.Font = value;
                cmbList.Font = value;
            }
        }

        [Category("Appearance")]
        public string Value
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        [Category("Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get { return cmbList.DropDownStyle; }
            set
            {
                if (cmbList.DropDownStyle != ComboBoxStyle.Simple)
                    cmbList.DropDownStyle = value;
            }
        }

        [Category("Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items
        {
            get { return cmbList.Items; }
        }

        [Category("Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get { return cmbList.DataSource; }
            set { cmbList.DataSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get { return cmbList.AutoCompleteCustomSource; }
            set { cmbList.AutoCompleteCustomSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get { return cmbList.AutoCompleteSource; }
            set { cmbList.AutoCompleteSource = value; }
        }

        [Category("Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get { return cmbList.AutoCompleteMode; }
            set { cmbList.AutoCompleteMode = value; }
        }

        [Category("Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => cmbList.SelectedItem;
            set => cmbList.SelectedItem = value;
        }

        [Category("Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => cmbList.SelectedIndex;
            set => cmbList.SelectedIndex = value;
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get => cmbList.DisplayMember;
            set => cmbList.DisplayMember = value;
        }

        [Category("Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get => cmbList.ValueMember;
            set => cmbList.ValueMember = value;
        }

        private void AdjustComboBoxDimensions()
        {
            cmbList.Width = lblText.Width;
            cmbList.Visible = false;
            cmbList.Location = new Point()
            {
                X = Width - Padding.Right - cmbList.Width,
                Y = lblText.Bottom - cmbList.Height
            };
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);

            lblText.Text = cmbList.Text;
        }

        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            int iconWidht = 14;
            int iconHeight = 6;
            var rectIcon = new Rectangle((btnIcon.Width - iconWidht) / 2, (btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + (iconWidht / 2), rectIcon.Bottom);
                path.AddLine(rectIcon.X + (iconWidht / 2), rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        private void Icon_Click(object sender, EventArgs e)
        {
            OnDropDownOpened(sender, e);
            cmbList.Select();
            cmbList.DroppedDown = true;
        }
        private void Surface_Click(object sender, EventArgs e)
        {
            OnDropDownOpened(sender, e);

            OnClick(e);
            cmbList.Select();
            if (cmbList.DropDownStyle == ComboBoxStyle.DropDownList)
                cmbList.DroppedDown = true;
        }
        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            lblText.Text = cmbList.Text;
        }

        private void ComboBox_DropDownClosed(object sender, EventArgs e)
        {
            OnDropDownClosed(sender, e);
        }

        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            OnMouseEnter(e);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            AdjustComboBoxDimensions();
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            Name = "CustomComboBox";
            Size = new System.Drawing.Size(240, 79);
            ResumeLayout(false);
        }
    }
}
