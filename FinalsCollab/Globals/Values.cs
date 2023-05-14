using FinalsCollab.Forms;
using FinalsCollab.Forms.ContentPanels;
using FinalsCollab.Models;

namespace FinalsCollab.Globals
{
    internal static class DefaultColors
    {
        public static readonly Color BORDER_COLOR = Color.LimeGreen;
        public static readonly Color THEME_COLOR = Color.LimeGreen;
        public static readonly Color INACTIVE_COLOR = Color.DimGray;
        public static readonly Color READONLY_BACKGROUND = Color.Gainsboro;
    }

    internal static class AppState
    {
        public static EmployeeInformation LoggedInEmployee;
        public static MenuForm MenuFormInstance;
    }
}
