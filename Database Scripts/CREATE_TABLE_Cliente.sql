GO

/****** Object:  Table [dbo].[Cliente]    Script Date: 24/08/2013 05:57:28 p.m. ******/
IF  EXISTS (SELECT * 
			FROM sys.objects 
			WHERE object_id = OBJECT_ID(N'dbo_sgsv.Cliente') 
				AND type in (N'U')) 
DROP TABLE [dbo_sgsv].[Cliente]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo_sgsv].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[idLocalidad] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[apellido] [varchar](100) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[inhabilitado] [char] default '0' check (inhabilitado = '0' OR inhabilitado = '1')
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo_sgsv].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo_sgsv].[Localidad] ([idLocalidad])
GO

ALTER TABLE [dbo_sgsv].[Cliente] CHECK CONSTRAINT [FK_Cliente_Localidad]
GO


