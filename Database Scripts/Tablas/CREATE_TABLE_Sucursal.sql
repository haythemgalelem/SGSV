GO

/****** Object:  Table [dbo].[Sucursal]    Script Date: 24/08/2013 06:00:11 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Sucursal') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Sucursal]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Sucursal](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[idLocalidad] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL UNIQUE,
	[direccion] [varchar](100) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[codigoPostal] [varchar](15) NOT NULL,
	[habilitado] [char] default '1' check (habilitado = '0' OR habilitado = '1')
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


