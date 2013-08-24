GO

/****** Object:  Table [dbo].[Sucursal]    Script Date: 24/08/2013 06:00:11 p.m. ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Sucursal](
	[idSucursal] [int] IDENTITY(1,1) NOT NULL,
	[idLocalidad] [int] NOT NULL,
	[nombre] [varchar](100) NOT NULL,
	[direccion] [varchar](100) NOT NULL,
	[telefono] [nvarchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[codigo_postal] [varchar](15) NOT NULL,
 CONSTRAINT [PK_Sucursal] PRIMARY KEY CLUSTERED 
(
	[idSucursal] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Sucursal]  WITH CHECK ADD  CONSTRAINT [FK_Sucursal_Localidad] FOREIGN KEY([idLocalidad])
REFERENCES [dbo].[Localidad] ([idLocalidad])
GO

ALTER TABLE [dbo].[Sucursal] CHECK CONSTRAINT [FK_Sucursal_Localidad]
GO


