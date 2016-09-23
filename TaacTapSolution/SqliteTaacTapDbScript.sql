-- Script Date: 2016-09-20 10:49 PM  - ErikEJ.SqlCeScripting version 3.5.2.58
SELECT 1;
PRAGMA foreign_keys=OFF;
BEGIN TRANSACTION;
CREATE TABLE [User] (
  [UserId] int NOT NULL
, [FirstName] nvarchar(20) NOT NULL
, [LastName] nvarchar(30) NOT NULL
, [Email] nvarchar(30) NOT NULL
, [Password] nvarchar(30) NOT NULL
, [AccountType] nvarchar(20) NOT NULL
, CONSTRAINT [PK_User] PRIMARY KEY ([UserId])
);
CREATE TABLE [RestaurantTable] (
  [RestaurantTableId] int NOT NULL
, CONSTRAINT [PK_RestaurantTable] PRIMARY KEY ([RestaurantTableId])
);
CREATE TABLE [RestaurantInfo] (
  [RestaurantInfoId] int NOT NULL
, [Name] nvarchar(30) NOT NULL
, [Address] nvarchar(30) NULL
, [City] nvarchar(30) NULL
, [Phone] nvarchar(30) NULL
, [NumberOfTables] int NULL
, CONSTRAINT [PK_RestaurantInfo] PRIMARY KEY ([RestaurantInfoId])
);
CREATE TABLE [Reservation] (
  [ReservationId] int NOT NULL
, [RestaurantTableId] int NOT NULL
, [UserId] int NOT NULL
, [Date] nvarchar(20) NOT NULL
, [Status] nvarchar(20) NULL
, CONSTRAINT [PK_Reservation] PRIMARY KEY ([ReservationId])
, FOREIGN KEY ([RestaurantTableId]) REFERENCES [RestaurantTable] ([RestaurantTableId]) ON DELETE NO ACTION ON UPDATE NO ACTION
, FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Order] (
  [OrderId] int NOT NULL
, [UserId] int NOT NULL
, [TableId] int NOT NULL
, [DateTimeCreated] datetime NOT NULL
, [TotalPrice] money NOT NULL
, CONSTRAINT [PK_Order] PRIMARY KEY ([OrderId])
, FOREIGN KEY ([TableId]) REFERENCES [RestaurantTable] ([RestaurantTableId]) ON DELETE NO ACTION ON UPDATE NO ACTION
, FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Menu] (
  [MenuId] int NOT NULL
, [MenuName] nvarchar(30) NULL
, [RestaurantInfoId] int NOT NULL
, CONSTRAINT [PK_Menu] PRIMARY KEY ([MenuId])
, FOREIGN KEY ([RestaurantInfoId]) REFERENCES [RestaurantInfo] ([RestaurantInfoId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [MenuItem] (
  [MenuItemId] int NOT NULL
, [Name] nvarchar(30) NOT NULL
, [Price] money NOT NULL
, [Description] nvarchar(100) NULL
, [MenuId] int NOT NULL
, CONSTRAINT [PK_MenuItem] PRIMARY KEY ([MenuItemId])
, FOREIGN KEY ([MenuId]) REFERENCES [Menu] ([MenuId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [OrderDetails] (
  [OrderId] int NOT NULL
, [MenuItemId] int NOT NULL
, CONSTRAINT [PK_OrderDetails_1] PRIMARY KEY ([OrderId])
, FOREIGN KEY ([MenuItemId]) REFERENCES [MenuItem] ([MenuItemId]) ON DELETE NO ACTION ON UPDATE NO ACTION
, FOREIGN KEY ([OrderId]) REFERENCES [Order] ([OrderId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Bill] (
  [OrderId] int NOT NULL
, [BillId] int NOT NULL
, [SubTotal] money NOT NULL
, [TaxRate] money NOT NULL
, [TipP] money NULL
, CONSTRAINT [PK_Bill] PRIMARY KEY ([BillId])
, FOREIGN KEY ([OrderId]) REFERENCES [Order] ([OrderId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
CREATE TABLE [Payment] (
  [BillOrderId] int NOT NULL
, [BillId] int NOT NULL
, [PaymentId] int NOT NULL
, [Amount] money NOT NULL
, [Type] nvarchar(20) NULL
, CONSTRAINT [PK_Payment] PRIMARY KEY ([PaymentId])
, FOREIGN KEY ([BillId]) REFERENCES [Bill] ([BillId]) ON DELETE NO ACTION ON UPDATE NO ACTION
);
COMMIT;

