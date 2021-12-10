Create Database QLDonHang
GO
use QLDonHang
GO

Create Table Product
(
	ProductID nvarchar(30) primary key,
	ProductName nvarchar(100) not null,
	Unit nvarchar(20) not null,
	BuyPrice decimal(18,0) null,
	SellPrice decimal(18,0) null,
)

Create Table Invoice
(
	[InvoiceID] nvarchar(30) primary key,
	[OrderDate] [datetime] NOT NULL,
	[DeliveryDate] [datetime] NOT NULL,
	[Note] [nvarchar](255) NULL,
)

CREATE Table [Order]
(
	[ProductID] nvarchar(30) NOT NULL,
	[InvoiceID] nvarchar(30) NOT NULL,
	[Price] [decimal](18, 0) NOT NULL,
	[Quantity] [int] NOT NULL,
	Primary Key(ProductID,InvoiceID),
	FOREIGN KEY (ProductID) REFERENCES Product(ProductID),
	FOREIGN KEY (InvoiceID) REFERENCES Invoice(InvoiceID)
)

INSERT INTO Product VALUES('1',N'Kem đánh răng', N'Hộp', 15000,20000),
							('2',N'Muối mè', N'Bịch', 10000,15000),
							('3',N'Xúc xích', N'Vỉ/10 cái', 20000,30000),
							('4',N'Phô mai', N'Hộp/5 cái', 5000,10000),
							('5',N'Mì Hảo Hảo', N'Thùng/30 gói', 100000,150000)



