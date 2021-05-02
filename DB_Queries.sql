create database fake_entegrasyondb
use fake_entegrasyondb

CREATE TABLE [dbo].[Connects]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ModelType] INT NOT NULL, 
    [DatabaseName] VARCHAR(80) NOT NULL, 
    [UserGroupCode] VARCHAR(80) NOT NULL, 
    [UserName] VARCHAR(80) NOT NULL, 
    [Password] VARCHAR(80) NOT NULL
);

CREATE TABLE [dbo].[Procedures]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ModelType] INT NOT NULL, 
    [ProcName] VARCHAR(50) NOT NULL, 
    [ParametersId] INT NOT NULL
);

CREATE TABLE [dbo].[Products] (
    [Id]                 INT          NOT NULL IDENTITY,
    [ModelType]          INT          NOT NULL,
    [ItemTypeCode]       TINYINT      NOT NULL,
    [ItemCode]           VARCHAR (50) NOT NULL,
    [ItemDescription]    VARCHAR (50) NULL,
    [ItemDimTypeCode]    TINYINT      NOT NULL,
    [UnitOfMeasureCode1] VARCHAR (50) NULL,
    [ItemTaxGrCode]      VARCHAR (50) NULL,
    [ProductHierarchyID] INT          NULL,
    [UsePOS]             BIT          NULL,
    [UseStore]           BIT          NULL,
    [UseInternet]        BIT          NULL,
    [AttributesId]       INT          NULL,
    [VariantsId]         INT          NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

CREATE TABLE [dbo].[Queries]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ModelType] INT NOT NULL, 
    [QueryName] VARCHAR(50) NOT NULL, 
    [Criteria] VARCHAR(50) NULL, 
    [Skip] INT NULL, 
    [Take] INT NULL
);

--Retail
CREATE TABLE [dbo].[RetailCustomers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ModelType] INT NOT NULL,
    [CurrAccCode] VARCHAR(30) NOT NULL, 
    [FirstName] VARCHAR(60) NULL, 
    [LastName] VARCHAR(60) NULL, 
    [IdentityNum] VARCHAR(20) NULL, 
    [OfficeCode] VARCHAR(5) NULL, 
    [RetailSalePriceGroupCode] VARCHAR(10) NULL, 
    [CreditLimit] MONEY NULL, 
    [CurrencyCode] VARCHAR(10) NULL, 
    [PostalAddressesId] INT NOT NULL, 
    [AttributesId] INT NULL, 
    [CommunicationsId] INT NULL
);
CREATE TABLE [dbo].[RetailInvoices] (
    [Id]                     INT           IDENTITY (1, 1) NOT NULL,
    [ModelType]              INT           NOT NULL,
    [CustomerCode]           VARCHAR (30)  NOT NULL,
    [OfficeCode]             VARCHAR (5)   NOT NULL,
    [StoreCode]              VARCHAR (30)  NOT NULL,
    [WareHouseCode]          VARCHAR (30)  NOT NULL,
    [DeliveryCompanyCode]    VARCHAR (10)  NULL,
    [ShipmentMethodCode]     VARCHAR (10)  NULL,
    [PosTerminalID]          SMALLINT      NULL,
    [Series]                 VARCHAR (5)   NULL,
    [SeriesNumber]           INT           NULL,
    [InvoiceDate]            DATETIME      NULL,
    [IsCompleted]            BIT           NULL,
    [IsReturn]               BIT           NULL,
    [IsSalesViaInternet]     BIT           NULL,
    [Description]            VARCHAR (200) NULL,
    [LinesId]                INT           NULL,
    [SalesViaInternetInfoId] INT           NULL,
    [SumLinesId]             INT           NULL,
    [DiscountsId]            INT           NULL,
    [PaymentsId]             INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[RetailOrders] (
    [Id]                      INT           IDENTITY (1, 1) NOT NULL,
    [ModelType]               INT           NOT NULL,
    [CustomerCode]            VARCHAR (30)  NOT NULL,
    [OfficeCode]              VARCHAR (5)   NOT NULL,
    [StoreCode]               VARCHAR (30)  NOT NULL,
    [StoreWareHouseCode]      VARCHAR (10)  NOT NULL,
    [DeliveryCompanyCode]     VARCHAR (10)  NULL,
    [ShipmentMethodCode]      VARCHAR (10)  NULL,
    [PosTerminalID]           SMALLINT      NULL,
    [OrderDate]               DATETIME      NULL,
    [IsCompleted]             BIT           NULL,
    [IsSalesViaInternet]      BIT           NULL,
    [DocumentNumber]          VARCHAR (30)  NULL,
    [Description]             VARCHAR (200) NULL,
    [LinesId]                 INT           NULL,
    [OrdersViaInternetInfoId] INT           NULL,
    [DiscountsId]             INT           NULL,
    [PaymentsId]              INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

--Wholesale
CREATE TABLE [dbo].[WholesaleCustomers]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ModelType] INT NOT NULL,
    [CurrAccCode] VARCHAR(30) NOT NULL, 
    [CurrAccDescription] VARCHAR(100) NULL, 
    [IdentityNum] VARCHAR(20) NULL, 
    [OfficeCode] VARCHAR(5) NULL, 
    [WholeSalePriceGroupCode] VARCHAR(10) NULL, 
    [CreditLimit] MONEY NULL, 
    [CurrencyCode] VARCHAR(10) NULL,
	[CustomerTypeCode] TINYINT NULL,
	[TaxNumber] VARCHAR(20) NULL,
	[TaxOfficeCode] VARCHAR(10) NULL,
	[MersisNum] VARCHAR(20) NULL,
    [PostalAddressesId] INT NULL, 
    [AttributesId] INT NULL, 
    [CommunicationsId] INT NULL, 
);
CREATE TABLE [dbo].[WholesaleInvoices] (
    [Id]                     INT              IDENTITY (1, 1) NOT NULL,
    [ModelType]              INT              NOT NULL,
    [CustomerCode]           VARCHAR (30)     NOT NULL,
    [CompanyCode]            INT              NULL,
    [OfficeCode]             VARCHAR (5)      NOT NULL,
    [WareHouseCode]          VARCHAR (30)     NOT NULL,
    [DeliveryCompanyCode]    VARCHAR (10)     NULL,
    [ShipmentMethodCode]     VARCHAR (10)     NULL,
    [InvoiceDate]            DATETIME         NULL,
    [Series]                 VARCHAR (5)      NULL,
    [SeriesNumber]           INT              NULL,
    [IsCompleted]            BIT              NULL,
    [IsReturn]               BIT              NULL,
    [IsSalesViaInternet]     BIT              NULL,
    [SubCurrAccID]           UNIQUEIDENTIFIER NULL,
    [Description]            VARCHAR (200)    NULL,
    [LinesId]                INT              NULL,
    [SumLinesId]             INT              NULL,
    [SalesViaInternetInfoId] INT              NULL,
    [DiscountsId]            INT              NULL,
    [PaymentsId]             INT              NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);
CREATE TABLE [dbo].[WholesaleOrders] (
    [Id]                     INT           IDENTITY (1, 1) NOT NULL,
    [ModelType]              INT           NOT NULL,
    [CustomerCode]           VARCHAR (30)  NOT NULL,
    [OfficeCode]             VARCHAR (5)   NOT NULL,
    [WareHouseCode]          VARCHAR (10)  NOT NULL,
    [DeliveryCompanyCode]    VARCHAR (10)  NULL,
    [ShipmentMethodCode]     VARCHAR (10)  NULL,
	[OrderDate]            DATETIME      NULL,
    [IsCompleted]            BIT           NULL,
    [IsSalesViaInternet]     BIT           NULL,
	[DocumentNumber]		VARCHAR(30)    NULL,
	[SubCurrAccID]           UNIQUEIDENTIFIER NULL,
    [Description]            VARCHAR (200) NULL,
	[LinesId]                INT           NULL,
	[SumLinesId]             INT           NULL,
    [OrdersViaInternetInfoId] INT           NULL,
    [DiscountsId]            INT           NULL,
    [PaymentsId]             INT           NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);



CREATE TABLE [dbo].[Attributes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [AttributeTypeCode] TINYINT NOT NULL, 
    [AttributeCode] VARCHAR(20) NOT NULL
);

CREATE TABLE [dbo].[Communications]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    CommunicationTypeCode TINYINT NOT NULL, 
    CommAddress VARCHAR(20) NOT NULL
);

CREATE TABLE [dbo].[Discounts]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [DiscountTypeCode] VARCHAR(10) NOT NULL, 
    [Value] FLOAT NOT NULL, 
    [DiscountReasonCode] INT NOT NULL, 
    [IsPercentage] BIT NOT NULL
);

CREATE TABLE [dbo].[Lines]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ColorCode] VARCHAR(10) NOT NULL, 
	[ItemCode] VARCHAR(30) NOT NULL, 
	[ItemDim1Code] VARCHAR(10) NOT NULL,
	[UsedBarcode] VARCHAR(30) NOT NULL, 
	    [Qty1] FLOAT NULL,
    [LDisRate1] FLOAT NOT NULL, 
    [LineDescription] VARCHAR(200) NOT NULL, 
    [PriceVI] MONEY NOT NULL, 
);

CREATE TABLE [dbo].[SumLines]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[LotBarcode] VARCHAR(30) NOT NULL, 
	[Qty1] FLOAT NULL,
);

CREATE TABLE [dbo].[ModelTypes]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ModelTypeDescription] VARCHAR(30) NOT NULL,
);

CREATE TABLE [dbo].[OrdersViaInternetInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SalesURL] VARCHAR(30) NOT NULL, 
    [PaymentTypeCode] TINYINT NOT NULL, 
    [PaymentTypeDescription] VARCHAR(100) NOT NULL, 
    [PaymentAgent] VARCHAR(100) NOT NULL, 
    [PaymentDate] DATETIME NULL, 
    [SendDate] DATETIME NULL,
);

CREATE TABLE [dbo].[SalesViaInternetInfo]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[SalesURL] VARCHAR(30) NOT NULL, 
    [PaymentTypeCode] TINYINT NOT NULL, 
    [PaymentTypeDescription] VARCHAR(100) NOT NULL, 
    [PaymentAgent] VARCHAR(100) NOT NULL, 
    [PaymentDate] DATETIME NULL, 
    [SendDate] DATETIME NULL,
);

CREATE TABLE [dbo].[Parameters]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL, 
    [Value] VARCHAR(50) NOT NULL,
);

CREATE TABLE [dbo].[Payments]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[PaymentType] TINYINT NULL,
	[Code] VARCHAR(30) NOT NULL, 
    [CreditCardTypeCode] VARCHAR(10) NOT NULL, 
    [InstallmentCount] TINYINT NULL, 
    [CurrencyCode] VARCHAR(10) NULL, 
    [Amount] MONEY NULL, 
);

CREATE TABLE [dbo].[Variants]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[ColorCode] VARCHAR(10) NOT NULL,
	[ItemDim1Code] VARCHAR(10) NOT NULL, 
);
