USE [GestionVentas]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 28/09/2021 18:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[colorName] [varchar](50) NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 28/09/2021 18:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[precio] [float] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 28/09/2021 18:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[precio] [float] NOT NULL,
	[descripcion] [varchar](150) NULL,
	[idColor] [int] NOT NULL,
	[idTipoPrenda] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoPrenda]    Script Date: 28/09/2021 18:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoPrenda](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tipo] [varchar](50) NULL,
 CONSTRAINT [PK_TipoPrenda] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 28/09/2021 18:41:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NULL,
	[fecha] [date] NOT NULL,
	[observaciones] [varchar](150) NULL,
	[precio] [float] NOT NULL,
	[apellidoCliente] [varchar](50) NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([id], [colorName]) VALUES (4, N'Rojo')
INSERT [dbo].[Color] ([id], [colorName]) VALUES (5, N'Celeste oscuro')
INSERT [dbo].[Color] ([id], [colorName]) VALUES (7, N'Amarillo')
INSERT [dbo].[Color] ([id], [colorName]) VALUES (8, N'Verde')
INSERT [dbo].[Color] ([id], [colorName]) VALUES (9, N'Negro')
INSERT [dbo].[Color] ([id], [colorName]) VALUES (10, N'Blanco')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[DetalleVenta] ON 

INSERT [dbo].[DetalleVenta] ([id], [idVenta], [idProducto], [precio]) VALUES (1, 18, 18, 1200)
INSERT [dbo].[DetalleVenta] ([id], [idVenta], [idProducto], [precio]) VALUES (2, 18, 15, 3000)
INSERT [dbo].[DetalleVenta] ([id], [idVenta], [idProducto], [precio]) VALUES (3, 19, 17, 4000)
INSERT [dbo].[DetalleVenta] ([id], [idVenta], [idProducto], [precio]) VALUES (4, 19, 15, 3200)
SET IDENTITY_INSERT [dbo].[DetalleVenta] OFF
GO
SET IDENTITY_INSERT [dbo].[Producto] ON 

INSERT [dbo].[Producto] ([id], [precio], [descripcion], [idColor], [idTipoPrenda]) VALUES (15, 123123, N'', 4, 1)
INSERT [dbo].[Producto] ([id], [precio], [descripcion], [idColor], [idTipoPrenda]) VALUES (16, 300, N'', 8, 6)
INSERT [dbo].[Producto] ([id], [precio], [descripcion], [idColor], [idTipoPrenda]) VALUES (17, 4, N'', 10, 4)
INSERT [dbo].[Producto] ([id], [precio], [descripcion], [idColor], [idTipoPrenda]) VALUES (18, 1200, N'', 9, 7)
SET IDENTITY_INSERT [dbo].[Producto] OFF
GO
SET IDENTITY_INSERT [dbo].[TipoPrenda] ON 

INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (1, N'Camisa')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (4, N'Buzo')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (5, N'Remera')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (6, N'Chomba')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (7, N'Visera')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (8, N'Vestido')
INSERT [dbo].[TipoPrenda] ([id], [tipo]) VALUES (9, N'Pantalon')
SET IDENTITY_INSERT [dbo].[TipoPrenda] OFF
GO
SET IDENTITY_INSERT [dbo].[Venta] ON 

INSERT [dbo].[Venta] ([id], [nombreCliente], [fecha], [observaciones], [precio], [apellidoCliente]) VALUES (18, N'Alejo', CAST(N'2021-09-27' AS Date), N'', 0, N'Percudani')
INSERT [dbo].[Venta] ([id], [nombreCliente], [fecha], [observaciones], [precio], [apellidoCliente]) VALUES (19, N'Miguel', CAST(N'2021-09-27' AS Date), N'', 0, N'Percudani')
SET IDENTITY_INSERT [dbo].[Venta] OFF
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Producto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([idVenta])
REFERENCES [dbo].[Venta] ([id])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Color] FOREIGN KEY([idColor])
REFERENCES [dbo].[Color] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Color]
GO
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_TipoPrenda] FOREIGN KEY([idTipoPrenda])
REFERENCES [dbo].[TipoPrenda] ([id])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_TipoPrenda]
GO
