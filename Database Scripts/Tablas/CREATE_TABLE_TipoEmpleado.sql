GO

/****** Object:  Table [dbo_sgsv].[TipoEmpleado]    Script Date: 24/08/2013 06:00:28 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.TipoEmpleado') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[TipoEmpleado]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[TipoEmpleado](
	[idTipoEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](100) NOT NULL UNIQUE,
 CONSTRAINT [PK_Tipo_Empleado] PRIMARY KEY CLUSTERED 
(
	[idTipoEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


