USE [CWMD]
GO
/****** Object:  Table [dbo].[FlowTypes]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FlowTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Role] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Roles] ON
INSERT [dbo].[Roles] ([Id], [Role]) VALUES (1, N'Admin')
SET IDENTITY_INSERT [dbo].[Roles] OFF
/****** Object:  Table [dbo].[Persons]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Persons](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON
INSERT [dbo].[Persons] ([Id], [RoleId], [FirstName], [LastName]) VALUES (1, 1, N'Alisa', N'Budur')
SET IDENTITY_INSERT [dbo].[Persons] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] NOT NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](250) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Users] ([Id], [UserName], [Password]) VALUES (1, N'alisa@test.com', N'aaa')
/****** Object:  Table [dbo].[Documents]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documents](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Type] [varchar](50) NOT NULL,
	[AddedDate] [datetime] NOT NULL,
	[UpdatedDate] [datetime] NOT NULL,
	[PersonId] [int] NOT NULL,
	[PrincipalDocumentId] [int] NULL,
	[Version] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Documents] ON
INSERT [dbo].[Documents] ([Id], [Name], [Type], [AddedDate], [UpdatedDate], [PersonId], [PrincipalDocumentId], [Version]) VALUES (2, N'Doc1', N'type1', CAST(0x0000A701012B929F AS DateTime), CAST(0x0000A701012B929F AS DateTime), 1, NULL, N'1')
SET IDENTITY_INSERT [dbo].[Documents] OFF
/****** Object:  Table [dbo].[FlowTypes_Contributors]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FlowTypes_Contributors](
	[Id] [int] NOT NULL,
	[PersonId] [int] NOT NULL,
	[PersonOrder] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC,
	[PersonId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Flows]    Script Date: 01/20/2017 19:02:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Flows](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[FlowTypeId] [int] NOT NULL,
	[PrincipalDocumentId] [int] NOT NULL,
	[CurrentPersonOrder] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF__Documents__Added__0D7A0286]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Documents] ADD  DEFAULT (getdate()) FOR [AddedDate]
GO
/****** Object:  Default [DF__Documents__Updat__0E6E26BF]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Documents] ADD  DEFAULT (getdate()) FOR [UpdatedDate]
GO
/****** Object:  ForeignKey [FK__Documents__Perso__0F624AF8]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persons] ([Id])
GO
/****** Object:  ForeignKey [FK__Documents__Princ__10566F31]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Documents]  WITH CHECK ADD FOREIGN KEY([PrincipalDocumentId])
REFERENCES [dbo].[Documents] ([Id])
GO
/****** Object:  ForeignKey [FK__Flows__FlowTypeI__151B244E]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Flows]  WITH CHECK ADD FOREIGN KEY([FlowTypeId])
REFERENCES [dbo].[FlowTypes] ([Id])
GO
/****** Object:  ForeignKey [FK__Flows__Principal__160F4887]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Flows]  WITH CHECK ADD FOREIGN KEY([PrincipalDocumentId])
REFERENCES [dbo].[Documents] ([Id])
GO
/****** Object:  ForeignKey [FK__FlowTypes__FlowT__07C12930]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[FlowTypes_Contributors]  WITH CHECK ADD FOREIGN KEY([Id])
REFERENCES [dbo].[FlowTypes] ([Id])
GO
/****** Object:  ForeignKey [FK__FlowTypes__Perso__08B54D69]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[FlowTypes_Contributors]  WITH CHECK ADD FOREIGN KEY([PersonId])
REFERENCES [dbo].[Persons] ([Id])
GO
/****** Object:  ForeignKey [FK__Persons__RoleId__7A672E12]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Persons]  WITH CHECK ADD FOREIGN KEY([RoleId])
REFERENCES [dbo].[Roles] ([Id])
GO
/****** Object:  ForeignKey [FK__Users__Id__1AD3FDA4]    Script Date: 01/20/2017 19:02:20 ******/
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK__Users__Id__1AD3FDA4] FOREIGN KEY([Id])
REFERENCES [dbo].[Persons] ([Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK__Users__Id__1AD3FDA4]
GO
