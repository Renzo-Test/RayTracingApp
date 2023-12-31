USE [RayTracingAppDB]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](max) NULL,
	[Password] [nvarchar](max) NULL,
	[DefaultFov] [int] NOT NULL,
	[DefaultLookFrom_X] [float] NOT NULL,
	[DefaultLookFrom_Y] [float] NOT NULL,
	[DefaultLookFrom_Z] [float] NOT NULL,
	[DefaultLookAt_X] [float] NOT NULL,
	[DefaultLookAt_Y] [float] NOT NULL,
	[DefaultLookAt_Z] [float] NOT NULL,
	[DefaultRenderProperties_ResolutionX] [int] NOT NULL,
	[DefaultRenderProperties_ResolutionY] [int] NOT NULL,
	[DefaultRenderProperties_AspectRatio] [float] NOT NULL,
	[DefaultRenderProperties_SamplesPerPixel] [int] NOT NULL,
	[DefaultRenderProperties_MaxDepth] [int] NOT NULL,
 CONSTRAINT [PK_dbo.Clients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Figures]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Figures](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Radius] [float] NULL,
	[Owner_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Figures] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Logs]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RenderTime] [int] NOT NULL,
	[RenderDate] [nvarchar](max) NULL,
	[TimeSpan] [nvarchar](max) NULL,
	[SceneName] [nvarchar](max) NULL,
	[RenderedElements] [int] NOT NULL,
	[Owner_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Logs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Materials]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Materials](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Color_Red] [int] NOT NULL,
	[Color_Green] [int] NOT NULL,
	[Color_Blue] [int] NOT NULL,
	[Type] [int] NOT NULL,
	[Blur] [float] NULL,
	[Discriminator] [nvarchar](128) NOT NULL,
	[Owner_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Materials] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Models]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Models](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Preview] [varbinary](max) NULL,
	[showPreview] [bit] NOT NULL,
	[Name] [nvarchar](max) NULL,
	[Figure_Id] [int] NULL,
	[Material_Id] [int] NULL,
	[Owner_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Models] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PosisionatedModels]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PosisionatedModels](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SceneId] [int] NOT NULL,
	[Position_X] [float] NOT NULL,
	[Position_Y] [float] NOT NULL,
	[Position_Z] [float] NOT NULL,
	[Model_Id] [int] NULL,
 CONSTRAINT [PK_dbo.PosisionatedModels] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Scenes]    Script Date: 14/6/2023 16:01:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Scenes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Preview] [varbinary](max) NULL,
	[Name] [nvarchar](max) NULL,
	[RegisterTime] [nvarchar](max) NULL,
	[LastModificationDate] [nvarchar](max) NULL,
	[LastRenderDate] [nvarchar](max) NULL,
	[Fov] [int] NOT NULL,
	[LensAperture] [float] NOT NULL,
	[LookFrom_X] [float] NOT NULL,
	[LookFrom_Y] [float] NOT NULL,
	[LookFrom_Z] [float] NOT NULL,
	[LookAt_X] [float] NOT NULL,
	[LookAt_Y] [float] NOT NULL,
	[LookAt_Z] [float] NOT NULL,
	[Owner_Id] [int] NULL,
 CONSTRAINT [PK_dbo.Scenes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [DefaultRenderProperties_ResolutionX]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [DefaultRenderProperties_ResolutionY]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [DefaultRenderProperties_AspectRatio]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [DefaultRenderProperties_SamplesPerPixel]
GO
ALTER TABLE [dbo].[Clients] ADD  DEFAULT ((0)) FOR [DefaultRenderProperties_MaxDepth]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LensAperture]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookFrom_X]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookFrom_Y]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookFrom_Z]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookAt_X]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookAt_Y]
GO
ALTER TABLE [dbo].[Scenes] ADD  DEFAULT ((0)) FOR [LookAt_Z]
GO
ALTER TABLE [dbo].[Figures]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Figures_dbo.Clients_Owner_Id] FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Figures] CHECK CONSTRAINT [FK_dbo.Figures_dbo.Clients_Owner_Id]
GO
ALTER TABLE [dbo].[Logs]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Logs_dbo.Clients_Owner_Id] FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Logs] CHECK CONSTRAINT [FK_dbo.Logs_dbo.Clients_Owner_Id]
GO
ALTER TABLE [dbo].[Materials]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Materials_dbo.Clients_Owner_Id] FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Materials] CHECK CONSTRAINT [FK_dbo.Materials_dbo.Clients_Owner_Id]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Models_dbo.Clients_Owner_Id] FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_dbo.Models_dbo.Clients_Owner_Id]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Models_dbo.Figures_Figure_Id] FOREIGN KEY([Figure_Id])
REFERENCES [dbo].[Figures] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_dbo.Models_dbo.Figures_Figure_Id]
GO
ALTER TABLE [dbo].[Models]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Models_dbo.Materials_Material_Id] FOREIGN KEY([Material_Id])
REFERENCES [dbo].[Materials] ([Id])
GO
ALTER TABLE [dbo].[Models] CHECK CONSTRAINT [FK_dbo.Models_dbo.Materials_Material_Id]
GO
ALTER TABLE [dbo].[PosisionatedModels]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PosisionatedModels_dbo.Models_Model_Id] FOREIGN KEY([Model_Id])
REFERENCES [dbo].[Models] ([Id])
GO
ALTER TABLE [dbo].[PosisionatedModels] CHECK CONSTRAINT [FK_dbo.PosisionatedModels_dbo.Models_Model_Id]
GO
ALTER TABLE [dbo].[PosisionatedModels]  WITH CHECK ADD  CONSTRAINT [FK_dbo.PosisionatedModels_dbo.Scenes_SceneId] FOREIGN KEY([SceneId])
REFERENCES [dbo].[Scenes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[PosisionatedModels] CHECK CONSTRAINT [FK_dbo.PosisionatedModels_dbo.Scenes_SceneId]
GO
ALTER TABLE [dbo].[Scenes]  WITH CHECK ADD  CONSTRAINT [FK_dbo.Scenes_dbo.Clients_Owner_Id] FOREIGN KEY([Owner_Id])
REFERENCES [dbo].[Clients] ([Id])
GO
ALTER TABLE [dbo].[Scenes] CHECK CONSTRAINT [FK_dbo.Scenes_dbo.Clients_Owner_Id]
GO
