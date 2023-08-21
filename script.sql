USE [ProyectoProgra]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 7/14/2023 6:20:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryId] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 7/14/2023 6:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] NOT NULL,
	[ProductName] [varchar](50) NOT NULL,
	[Description] [varchar](200) NOT NULL,
	[Price] [int] NOT NULL,
	[UserId] [int] NOT NULL,
	[CategoyId] [int] NOT NULL,
	[PurchanseOrderId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PurchanseOrder]    Script Date: 7/14/2023 6:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PurchanseOrder](
	[PurchanseOrderId] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 7/14/2023 6:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Type_Rol] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/14/2023 6:20:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdRol] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User]
GO;

--- aditional

use  ProyectoProgra

alter table "User" add ClaveTemporal bit (200);

alter table "User" add Caducidad datetime(200);

Insert into  "Rol" (Type_Rol) values ('Administrador');

Insert into  "Rol" (Type_Rol) values ('Cliente');


select * from "User"

select * from "Rol";


------------------------------- NUEVO

Create database ProyectoProgra;
USE [ProyectoProgra]
GO
/****** Object:  Table [dbo].[Products]    Script Date: 8/17/2023 10:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [varchar](50) NULL,
	[Description] [varchar](8000) NULL,
	[Price] [int] NULL,
    [Image] [varchar](8000)
PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rol]    Script Date: 8/17/2023 10:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rol](
	[IdRol] [int] IDENTITY(1,1) NOT NULL,
	[Type_Rol] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 8/17/2023 10:19:45 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [bigint] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Estado] [bit] NOT NULL,
	[IdRol] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_User]
GO

--- aditional

use  ProyectoProgra

alter table "User" add ClaveTemporal bit;

alter table "User" add Caducidad datetime;

Insert into  "Rol" (Type_Rol) values ('Administrador');

Insert into  "Rol" (Type_Rol) values ('Cliente');



insert into "Products" (ProductName , Description , Price , Image) values
('Bocinas carro' , 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut' , 80000 , 'https://firebasestorage.googleapis.com/v0/b/proyecto-progra-web-c9327.appspot.com/o/Carros%2FBocinas%20carro.png?alt=media&token=84de8cdb-5afd-4a38-bbb8-da987542e679' );
insert into "Products" (ProductName , Description , Price , Image) values
('Aros' , 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut' , 85000 , 'https://firebasestorage.googleapis.com/v0/b/proyecto-progra-web-c9327.appspot.com/o/Carros%2Faros.png?alt=media&token=cfb3d33c-2eb3-4cca-be09-723a55367667' );
insert into "Products" (ProductName , Description , Price , Image) values
('Pintura' , 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut' , 6000 , 'https://firebasestorage.googleapis.com/v0/b/proyecto-progra-web-c9327.appspot.com/o/Carros%2FPintura.PNG?alt=media&token=2888c540-8d01-4014-a2be-17d19c622870' );
insert into "Products" (ProductName , Description , Price , Image) values
('Radio' , 'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut' , 5000 , 'https://firebasestorage.googleapis.com/v0/b/proyecto-progra-web-c9327.appspot.com/o/Carros%2FRadio.png?alt=media&token=66cdad96-9213-4744-8ed1-8b758f6be024' );


--- select * from "User"

--- select * from "Rol";

---select * from "Products"