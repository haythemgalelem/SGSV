GO

/****** Object:  Table [dbo].[Precio]    Script Date: 24/08/2013 05:59:38 p.m. ******/
IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Precio') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Precio]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo_sgsv].[Precio](
	[idProducto] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
	[fechaDesde] [date] NOT NULL,
	[fechaHasta] [date] NULL,
	[monto] [numeric](10,2) NOT NULL,
) ON [PRIMARY]

GO

