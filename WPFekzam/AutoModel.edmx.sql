
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/17/2017 09:49:34
-- Generated from EDMX file: C:\Users\Есипов.Александр\Desktop\WPFekzam последняя версия\WPFekzam\AutoModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ShopAuto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__OrdersDet__Order__15502E78]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdersDetail] DROP CONSTRAINT [FK__OrdersDet__Order__15502E78];
GO
IF OBJECT_ID(N'[dbo].[FK__OrdersDet__Produ__164452B1]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[OrdersDetail] DROP CONSTRAINT [FK__OrdersDet__Produ__164452B1];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Customers]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Customers];
GO
IF OBJECT_ID(N'[dbo].[Employee]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employee];
GO
IF OBJECT_ID(N'[dbo].[Orders]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Orders];
GO
IF OBJECT_ID(N'[dbo].[OrdersDetail]', 'U') IS NOT NULL
    DROP TABLE [dbo].[OrdersDetail];
GO
IF OBJECT_ID(N'[dbo].[Products]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Products];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Customers'
CREATE TABLE [dbo].[Customers] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(128)  NOT NULL,
    [Adress] nvarchar(128)  NOT NULL,
    [Phone] nvarchar(20)  NOT NULL
);
GO

-- Creating table 'Employee'
CREATE TABLE [dbo].[Employee] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FIO] nvarchar(128)  NOT NULL,
    [Post] nvarchar(50)  NOT NULL,
    [Date_start] datetime  NOT NULL,
    [Date_end] datetime  NULL,
    [Birthday] datetime  NOT NULL,
    [Passport_data] nvarchar(200)  NOT NULL,
    [Phone1] nvarchar(20)  NOT NULL,
    [Phone2] nvarchar(20)  NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Order_details] nvarchar(500)  NULL,
    [Order_status] nvarchar(50)  NOT NULL,
    [Waybill_num] nvarchar(50)  NULL,
    [Sum_final] decimal(19,4)  NOT NULL,
    [Sum_payed] decimal(19,4)  NOT NULL,
    [Order_date] datetime  NOT NULL,
    [Date_send] datetime  NOT NULL,
    [Date_arrive] datetime  NULL,
    [Delivery] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'OrdersDetail'
CREATE TABLE [dbo].[OrdersDetail] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Order_id] int  NOT NULL,
    [Product_id] int  NOT NULL,
    [Quantity] int  NOT NULL
);
GO

-- Creating table 'Products'
CREATE TABLE [dbo].[Products] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Brand] nvarchar(50)  NOT NULL,
    [Category] nvarchar(50)  NOT NULL,
    [Name] nvarchar(200)  NOT NULL,
    [ART] nvarchar(50)  NOT NULL,
    [Catalogue_num] nvarchar(50)  NULL,
    [Manufacturer] nvarchar(50)  NOT NULL,
    [Price_first] decimal(19,4)  NOT NULL,
    [Price_sale] decimal(19,4)  NOT NULL,
    [Color] nvarchar(20)  NULL,
    [Product_rest] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Customers'
ALTER TABLE [dbo].[Customers]
ADD CONSTRAINT [PK_Customers]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employee'
ALTER TABLE [dbo].[Employee]
ADD CONSTRAINT [PK_Employee]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrdersDetail'
ALTER TABLE [dbo].[OrdersDetail]
ADD CONSTRAINT [PK_OrdersDetail]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Products'
ALTER TABLE [dbo].[Products]
ADD CONSTRAINT [PK_Products]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Order_id] in table 'OrdersDetail'
ALTER TABLE [dbo].[OrdersDetail]
ADD CONSTRAINT [FK__OrdersDet__Order__15502E78]
    FOREIGN KEY ([Order_id])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrdersDet__Order__15502E78'
CREATE INDEX [IX_FK__OrdersDet__Order__15502E78]
ON [dbo].[OrdersDetail]
    ([Order_id]);
GO

-- Creating foreign key on [Product_id] in table 'OrdersDetail'
ALTER TABLE [dbo].[OrdersDetail]
ADD CONSTRAINT [FK__OrdersDet__Produ__164452B1]
    FOREIGN KEY ([Product_id])
    REFERENCES [dbo].[Products]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__OrdersDet__Produ__164452B1'
CREATE INDEX [IX_FK__OrdersDet__Produ__164452B1]
ON [dbo].[OrdersDetail]
    ([Product_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------