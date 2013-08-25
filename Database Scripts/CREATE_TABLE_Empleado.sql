GO

--/****** Object:  Table [dbo].[Empleado]    Script Date: 24/08/2013 05:58:32 p.m. ******/

IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Empleado') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Empleado]

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Empleado](
	[idEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[idTipoEmpleado] [int] NOT NULL,
	[idSucursal] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[dni] [numeric] (8,0) NOT NULL UNIQUE,
	[inhabilitado] [char] default '0' check (inhabilitado = '0' OR inhabilitado = '1')
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[idEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo_sgsv].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Sucursal] FOREIGN KEY([idSucursal])
REFERENCES [dbo_sgsv].[Sucursal] ([idSucursal])
GO

ALTER TABLE [dbo_sgsv].[Empleado] CHECK CONSTRAINT [FK_Empleado_Sucursal]
GO

ALTER TABLE [dbo_sgsv].[Empleado]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_Tipo_Empleado] FOREIGN KEY([idTipoEmpleado])
REFERENCES [dbo_sgsv].[TipoEmpleado] ([idTipoEmpleado])
GO

ALTER TABLE [dbo_sgsv].[Empleado] CHECK CONSTRAINT [FK_Empleado_Tipo_Empleado]
GO


