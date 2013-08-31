GO

/****** Object:  Table [dbo].[Operacion]    Script Date: 24/08/2013 05:58:59 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Operacion') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Operacion]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Operacion](
	[idOperacion] [int] IDENTITY(1,1) NOT NULL,
	[idTipoOperacion] [int] NOT NULL,
	[idEmpleado] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,	
	[fecha] [date] NOT NULL,
	[montoTotal] [numeric] (18,2) NOT NULL,
	[observaciones] [varchar] (250),
	[nroAltaStock] [int],
 CONSTRAINT [PK_Operacion] PRIMARY KEY CLUSTERED 
(
	[idOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO