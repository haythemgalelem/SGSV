GO

/****** Object:  Table [dbo].[Localidad]    Script Date: 24/08/2013 05:58:59 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Localidad') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Localidad]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Localidad](
	[idLocalidad] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL UNIQUE,
 CONSTRAINT [PK_Localidad] PRIMARY KEY CLUSTERED 
(
	[idLocalidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


