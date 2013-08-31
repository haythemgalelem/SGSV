GO

/****** Object:  Table [dbo_sgsv].[Stock]    Script Date: 24/08/2013 05:58:59 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Stock') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Stock]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Stock](
	[idStock] [int] IDENTITY(1,1) NOT NULL,
	[idPosicionOperacion] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
	[cantidadDisponible] [int] NOT NULL,
	[habilitado] [char] default '0' check (habilitado = '0' OR habilitado = '1')
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[idStock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO