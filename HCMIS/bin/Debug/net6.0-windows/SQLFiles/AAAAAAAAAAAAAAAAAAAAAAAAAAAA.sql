USE [HCMISDB]
GO
/****** Object:  Table [dbo].[EmployeeAccount]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeAccount](
	[ID] [smallint] NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeContact]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeContact](
	[ID] [smallint] NULL,
	[Email] [varchar](250) NULL,
	[PhoneNumber] [varchar](12) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EmployeeInformation]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EmployeeInformation](
	[ID] [smallint] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[MiddleName] [varchar](50) NULL,
	[LastName] [varchar](50) NOT NULL,
	[Position] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientContact]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientContact](
	[ID] [int] NULL,
	[Email] [varchar](250) NULL,
	[PhoneNumber] [varchar](12) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PatientInformation]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PatientInformation](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [varchar](100) NOT NULL,
	[Gender] [varchar](6) NOT NULL,
	[Birthday] [datetime] NOT NULL,
	[Address] [varchar](150) NOT NULL,
	[Bloodtype] [varchar](4) NOT NULL,
	[MartialStatus] [varchar](20) NOT NULL,
	[NumberOfKids] [smallint] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Queue]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Queue](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[BloodPressure] [int] NOT NULL,
	[WeightKG] [int] NULL,
	[HeightFT] [decimal](10, 2) NOT NULL,
	[Reason] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Record]    Script Date: 12/15/2022 5:45:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Record](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PatientID] [int] NULL,
	[VisitDateTime] [datetime] NOT NULL,
	[BloodPressure] [int] NOT NULL,
	[WeightKG] [decimal](10, 2) NOT NULL,
	[HeightFT] [decimal](10, 2) NOT NULL,
	[Reason] [varchar](10) NOT NULL,
	[AssignedWorker] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[EmployeeAccount]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[EmployeeInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[EmployeeContact]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[EmployeeInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PatientContact]  WITH CHECK ADD FOREIGN KEY([ID])
REFERENCES [dbo].[PatientInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Queue]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientInformation] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Record]  WITH CHECK ADD FOREIGN KEY([PatientID])
REFERENCES [dbo].[PatientInformation] ([ID])
ON DELETE CASCADE
GO
