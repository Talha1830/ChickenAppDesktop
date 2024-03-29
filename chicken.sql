USE [master]
GO
/****** Object:  Database [Chiken]    Script Date: 19/01/2023 7:46:16 pm ******/
CREATE DATABASE [Chiken]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Chiken', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TALHA\MSSQL\DATA\Chiken.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Chiken_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.TALHA\MSSQL\DATA\Chiken_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Chiken] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Chiken].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Chiken] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Chiken] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Chiken] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Chiken] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Chiken] SET ARITHABORT OFF 
GO
ALTER DATABASE [Chiken] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Chiken] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Chiken] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Chiken] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Chiken] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Chiken] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Chiken] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Chiken] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Chiken] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Chiken] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Chiken] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Chiken] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Chiken] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Chiken] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Chiken] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Chiken] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Chiken] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Chiken] SET RECOVERY FULL 
GO
ALTER DATABASE [Chiken] SET  MULTI_USER 
GO
ALTER DATABASE [Chiken] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Chiken] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Chiken] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Chiken] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Chiken] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Chiken] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Chiken', N'ON'
GO
ALTER DATABASE [Chiken] SET QUERY_STORE = OFF
GO
USE [Chiken]
GO
/****** Object:  Table [dbo].[tbl_Admin]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Admin](
	[AdminId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](30) NULL,
	[Email] [nvarchar](20) NULL,
	[Password] [varchar](15) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[AdminId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Cart]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Cart](
	[CartId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[Weight/Qty] [float] NULL,
	[Rate] [float] NULL,
	[Amount] [float] NULL,
	[Status] [bit] NULL,
	[ItemType] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Cashier]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Cashier](
	[CashierId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](max) NULL,
	[Email] [varchar](20) NULL,
	[Password] [varchar](15) NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[CashierId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_DesiStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_DesiStock](
	[DesiStockId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseDesiId] [int] NULL,
	[Sold] [int] NULL,
	[Remaining] [int] NULL,
	[Status] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_EggStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_EggStock](
	[EggStockId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseEggId] [int] NULL,
	[Sold] [float] NULL,
	[Remaining] [float] NULL,
	[Status] [bit] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Expenses]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Expenses](
	[ExpensesId] [int] IDENTITY(1,1) NOT NULL,
	[CashierId] [int] NULL,
	[Description] [varchar](max) NULL,
	[Amount] [float] NULL,
	[E_date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[ExpensesId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Invoice]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Invoice](
	[InvoiceId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [varchar](max) NULL,
	[Total] [float] NULL,
	[Discount] [float] NULL,
	[NetTotal] [float] NULL,
	[I_date] [date] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvoiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_InvoiceItem]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_InvoiceItem](
	[InvItemId] [int] IDENTITY(1,1) NOT NULL,
	[InvoiceId] [int] NULL,
	[itemId] [int] NULL,
	[Weight] [float] NULL,
	[Price] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[InvItemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_item]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_item](
	[itemId] [int] IDENTITY(1,1) NOT NULL,
	[ItemName] [varchar](max) NULL,
	[ItemType] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[itemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PurchaseDesi]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PurchaseDesi](
	[PurchaseDesiId] [int] IDENTITY(1,1) NOT NULL,
	[VendorId] [int] NULL,
	[Qty] [int] NULL,
	[Rate] [float] NULL,
	[PurchaseDate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PurchaseEgg]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PurchaseEgg](
	[PurchaseEggId] [int] IDENTITY(1,1) NOT NULL,
	[VendorId] [int] NULL,
	[Dozen] [float] NULL,
	[Rate] [float] NULL,
	[PurchaseDate] [date] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_PurchaseStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_PurchaseStock](
	[PurchaseId] [int] IDENTITY(1,1) NOT NULL,
	[VendorId] [int] NULL,
	[Weight] [float] NULL,
	[Rate] [float] NULL,
	[PurchaseDate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[PurchaseId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_RateList]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_RateList](
	[RateListId] [int] IDENTITY(1,1) NOT NULL,
	[ItemId] [int] NULL,
	[PurchaseId] [int] NULL,
	[WholeSalePrice] [float] NULL,
	[RetailPrice] [float] NULL,
	[R_Type] [int] NULL,
	[R_Date] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[RateListId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Stock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Stock](
	[StockId] [int] IDENTITY(1,1) NOT NULL,
	[PurchaseId] [int] NULL,
	[Sold] [float] NULL,
	[Remaining] [float] NULL,
	[Status] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[StockId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_Vendor]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Vendor](
	[VendorId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](max) NULL,
	[Address] [varchar](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[VendorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Admin]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Sp_Admin]
@AdminID int =null,
@UserName nvarchar(30) =null,
@Email nvarchar(30)=null,
@Password nvarchar(30)=null,
@Status bit=null,
@Type int 
as
if(@Type=1)
select * from tbl_Admin where (@AdminID is null or AdminID=@AdminID) and
(@UserName is null or Email=@UserName or UserName=@UserName) and
(@Password is null or Password=@Password)
 else if(@Type=2)
 insert into tbl_Admin values(@UserName,@Email,@Password,@Status)
 else if (@type=3)
 update tbl_Admin set UserName=@UserName,Email=@Email,Password=@Password,Status=@Status where AdminId=@AdminID
 else if (@Type=4)
 delete tbl_Admin where AdminId=@AdminID
GO
/****** Object:  StoredProcedure [dbo].[Sp_Cart]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[Sp_Cart]
  @CartId int=null,
  @ItemId int=null ,
  @Weight float=null,
  @Rate float=null,
  @Amount float=null,
  @Status bit=null,
  @ItemType int=null,
  @Type int
  as
  if(@Type=1)
  select tbl_Item.ItemName,tbl_Cart.* from tbl_Cart inner join tbl_item on tbl_Cart.ItemId=tbl_item.itemId where (@CartId is null or  CartId=@CartId) and (@Status is  null or Status=@Status)
  else if (@Type=2)
  insert into tbl_Cart values(@ItemId,@Weight,@Rate,@Amount,@Status,@ItemType)
  else if (@Type=3)
  update tbl_Cart set ItemId=@ItemId,[Weight/Qty]=@Weight,Rate=@Rate,Amount=@Amount,Status=@Status where CartId=@CartId
  else if (@Type=4)
  delete tbl_Cart where (@CartId is null or CartId=@CartId)
  else if (@Type=5)
  select (select isnull(SUM([Weight/Qty]),0)  from tbl_Cart where Status=0) as Weight,(select IsNULL(SUM([Weight/Qty]),0)  from tbl_Cart where Status=1) as Qty ,SUM(Amount) as Amount from tbl_Cart
GO
/****** Object:  StoredProcedure [dbo].[Sp_Cashier]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_Cashier]
@CashierId int= null,
@UserName varchar(max)=null,
@Email varchar(max)=null,
@Password varchar(max)=null,
@Status bit=null,
@Type int
as
if(@Type=1)
select *,case Status when 1 then 'Yes' else 'No' end as [Admin Access] from tbl_Cashier where (@CashierId is null or CashierId=@CashierId) and
(@UserName is null or Email=@UserName or UserName=@UserName) and
(@Password is null or Password=@Password) and (@Status is null or Status=@Status)
else if (@Type=2)
insert into tbl_Cashier  Values (@UserName,@Email,@Password,@Status)
else if (@Type=3)
update tbl_Cashier set UserName=@UserName,Email=@Email,Password=@Password,Status=@Status where CashierId=@CashierId
else if (@Type=4)
delete tbl_Cashier where CashierId=@CashierId
GO
/****** Object:  StoredProcedure [dbo].[Sp_DesiStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Sp_DesiStock]
@DesiStockId int=null,
@PurchaseDesiId int=null,
@Sold int=null,
@Remaining int=null,
@Status bit=null,
@Type int 
as 
if(@Type=1)
select *,case Status when 1 then 'Open'  else 'Close' end as Status_ from tbl_DesiStock where (@DesiStockId is null or DesiStockId=@DesiStockId) and (@Status is null or Status=@Status)
else if (@Type=2)
begin
declare @PrevousStock int =(select Remaining from tbl_DesiStock where Status=1)
update tbl_DesiStock set Status=0 where Status=1
insert into tbl_DesiStock values(@PurchaseDesiId,@Sold,@Remaining+isnull(@PrevousStock,0),@Status)
end
else if (@Type=3)
 update tbl_DesiStock set Sold=@Sold,Remaining=(select Remaining-@Sold from tbl_DesiStock where Status=1) where Status=1
else if (@Type=4)
delete tbl_DesiStock where DesiStockId=@DesiStockId
else if (@Type=5)
select isnull(Remaining*(select Rate from tbl_PurchaseDesi where PurchaseDesiId=tbl_DesiStock.PurchaseDesiId),0) as Total from tbl_DesiStock where Status=1
GO
/****** Object:  StoredProcedure [dbo].[Sp_EggStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_EggStock]
@EggStockId int=null,
@PurchaseEggId int=null,
@Sold float=null,
@Remaining float=null,
@Status bit=null,
@Type int 
as 
if(@Type=1)
select *, case Status when 1 then 'Open' else 'close' end as Status_ from tbl_EggStock where (@EggStockId is null or EggStockId=@EggStockId) and (@Status is null or Status=@Status)
else if (@Type=2)
begin
declare @PrevousStock float =(select Remaining from tbl_EggStock where Status=1)
update tbl_EggStock set Status=0 where Status=1
insert into tbl_EggStock values(@PurchaseEggId,@Sold,@Remaining+isnull(@PrevousStock,0),@Status)
end
else if (@Type=3)
 update tbl_EggStock set Sold=@Sold,Remaining=(select Remaining-@Sold from tbl_EggStock where Status=1) where Status=1
else if (@Type=4)
delete tbl_EggStock where EggStockId=@EggStockId
else if (@Type=5)
select isnull(Remaining/12*(select Rate from tbl_PurchaseEgg where PurchaseEggId=tbl_EggStock.PurchaseEggId),0) as Total from tbl_EggStock where Status=1


GO
/****** Object:  StoredProcedure [dbo].[Sp_Expenses]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[Sp_Expenses]
 @ExpensesId int=null,
 @CashierId int=null,
 @Description varchar(max)=null,
 @Amount float=null,
 @E_date date=null,
 @Type int
 as
 if(@Type=1)
 select tbl_Expenses.* from tbl_Expenses where  (@ExpensesId is null or ExpensesId=@ExpensesId)
 else if(@Type=2)
 insert into tbl_Expenses values (@CashierId,@Description,@Amount,@E_date)
 else if(@Type=3)
 update tbl_Expenses set CashierId=@CashierId,Description=@Description,Amount=@Amount,E_date=@E_date where ExpensesId=@ExpensesId
 else if(@Type=4)
 delete tbl_Expenses where ExpensesId=@ExpensesId
 else if (@Type=5)
 select isnull(SUM(Amount),0) as Total  from tbl_Expenses where (@E_date is null or E_date=@E_date)
GO
/****** Object:  StoredProcedure [dbo].[Sp_Invoice]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
 CREATE proc [dbo].[Sp_Invoice]
 @InvoiceId int=null,
 @CustomerName varchar(max)=null,
 @Total float=null,
 @Discount float=null,
 @NetTotal float=null,
 @I_date date=null,
 @Status bit=null,
 @ID int=null output,
 @Type int
 as
 if(@Type=1)
 select * from tbl_Invoice where (@InvoiceId is  null or InvoiceId =@InvoiceId)
 else if(@Type=2)
 begin
 insert into tbl_Invoice values (@CustomerName,@Total,@Discount,@NetTotal,@I_date,@Status)
 set @ID=SCOPE_IDENTITY()
 end
 else if(@Type=3)
 update tbl_Invoice set CustomerName= @CustomerName,Total=@Total,Discount=@Discount,NetTotal=@NetTotal,I_date=@I_date,Status=@Status where InvoiceId =@InvoiceId
 else if(@Type=4)
 delete tbl_Invoice where InvoiceId =@InvoiceId
 else if (@Type=5)
 select isnull(SUM(NetTotal),0) as Total from tbl_Invoice where (@I_date is null or I_date=@I_date)
GO
/****** Object:  StoredProcedure [dbo].[Sp_InvoiceItem]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc  [dbo].[Sp_InvoiceItem]
 @InvItemId int=null,
 @InvoiceId int=null,
 @itemId int=null,
 @Weight float=null,
 @Price float=null,
 @type int
 as
 if(@type=1)
 select * from tbl_InvoiceItem where (@InvItemId is null or InvItemId=@InvItemId)
 else if(@type=2)
 insert into tbl_InvoiceItem  values (@InvoiceId,@itemId,@Weight,@Price)
 else if(@type=3)
 update tbl_InvoiceItem set InvoiceId=@InvoiceId,itemId=@itemId,Weight=@Weight,Price=@Price where InvItemId=@InvItemId
 else if(@type=4)
 delete tbl_InvoiceItem where InvItemId=@InvItemId
GO
/****** Object:  StoredProcedure [dbo].[Sp_Item]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE proc [dbo].[Sp_Item]
@itemId int =null,
@ItemName varchar(max)=null,
@ItemType int =null,
@Type int
as
if(@Type=1)
select *,case ItemType when 0 then 'Farmy' when 1 then 'Desi' when 2 then 'Egg' end as Type from tbl_item where (@itemId is null or itemId=@itemId)and
(@ItemName is null or ItemName=@ItemName) and (@ItemType is null or ItemType=@ItemType)
else if(@Type=2)
insert into tbl_item values (@ItemName,@ItemType)
else if(@Type=3)
update tbl_item set ItemName=@ItemName,ItemType=@ItemType where itemId=@itemId
else if(@Type=4)
delete tbl_item where itemId=@itemId
GO
/****** Object:  StoredProcedure [dbo].[Sp_PurchaseDesi]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_PurchaseDesi]
@PurchaseDesiId int =null,
 @VendorId int =null,
 @Qty int=null,
 @Rate float=null,
 @PurchaseDate date=null,
 @Type int,
 @ID int=null output
 as
if(@Type=1)
begin
select * from tbl_PurchaseDesi where (@PurchaseDesiId is null or PurchaseDesiId=@PurchaseDesiId)
end
else if (@Type=2)
begin
insert into tbl_PurchaseDesi values(@VendorId,@Qty,@Rate,@PurchaseDate)
set @ID=SCOPE_IDENTITY();
end
else if (@Type=3)
update tbl_PurchaseDesi set VendorId=@VendorId,Qty=@Qty,Rate=@Rate,PurchaseDate=@PurchaseDate where PurchaseDesiId=@PurchaseDesiId
else if (@Type=4)
delete tbl_PurchaseDesi where PurchaseDesiId=@PurchaseDesiId
else if(@Type=5)
select isnull(sum(Rate*Qty),0) as Total from tbl_PurchaseDesi where (@PurchaseDate is null or PurchaseDate=@PurchaseDate)
else if (@Type=6)
select MAX(PurchaseDesiId) as PurchaseDesiId  from tbl_PurchaseDesi
GO
/****** Object:  StoredProcedure [dbo].[Sp_PurchaseEgg]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_PurchaseEgg]
@PurchaseEggId int=null,
@VendorId int=null,
@Dozen float=null,
@Rate float=null,
@PurchaseDate date=null,
@Type int ,
@ID int=null output
as 
if(@Type=1)
begin
select Name as Vendor,tbl_PurchaseEgg.* from tbl_PurchaseEgg inner join tbl_Vendor on tbl_PurchaseEgg.VendorId=tbl_Vendor.VendorId where (@PurchaseEggId is null or PurchaseEggId=@PurchaseEggId)
end
else if (@Type=2)
begin
insert into tbl_PurchaseEgg values(@VendorId,@Dozen,@Rate,@PurchaseDate)
set @ID=SCOPE_IDENTITY();
end
else if (@Type=3)
update tbl_PurchaseEgg set VendorId=@VendorId,Dozen=@Dozen,Rate=@Rate,PurchaseDate=@PurchaseDate where PurchaseEggId=@PurchaseEggId
else if (@Type=4)
delete tbl_PurchaseEgg where PurchaseEggId=@PurchaseEggId
else if (@Type=5)
select isnull(sum(Dozen*Rate),0) as Total from tbl_PurchaseEgg where (@PurchaseDate is null or PurchaseDate=@PurchaseDate)
else if (@Type=6)
select MAX(PurchaseEggId) as PurchaseEggId  from tbl_PurchaseEgg
GO
/****** Object:  StoredProcedure [dbo].[Sp_PurchaseStock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Sp_PurchaseStock]
@PurchaseId int=null,
@VendorId int=null,
@Weight float=null,
@Rate float=null,
@PurchaseDate date=null,
@Type int,
@ID int=null output
as
if (@Type=1)
select Name as [Vendor Name],tbl_PurchaseStock.* from  tbl_PurchaseStock inner join tbl_Vendor on tbl_PurchaseStock.VendorId=tbl_Vendor.VendorId where (@PurchaseId is null or PurchaseId=@PurchaseId)
else if (@Type=2)
begin
insert into tbl_PurchaseStock values (@VendorId,@Weight,@Rate,@PurchaseDate)
set @ID=SCOPE_IDENTITY()
end
else if (@Type=3)
update tbl_PurchaseStock set VendorId=@VendorId,Weight=@Weight,Rate=@Rate,PurchaseDate=@PurchaseDate where PurchaseId=@PurchaseId
else if(@Type=4)
delete tbl_PurchaseStock where PurchaseId=@PurchaseId
else if(@Type=5)
select isnull(sum(Weight*Rate),0) as Total from tbl_PurchaseStock where (@PurchaseDate is null or PurchaseDate=@PurchaseDate)
else if (@Type=6)
select MAX(PurchaseId) as PurchaseId from tbl_PurchaseStock
GO
/****** Object:  StoredProcedure [dbo].[Sp_RateList]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[Sp_RateList]
 @RateListId int =null,
 @ItemId int=null,
 @PurchaseId int=null,
 @WholeSalePrice float=null,
 @RetailPrice float=null,
 @R_Date date=null,
 @R_Type int=null,
 @Type int
 as
if (@Type =1)
select ItemName as [Item Name],tbl_RateList.* from tbl_RateList inner join tbl_Item on tbl_RateList.ItemId=tbl_Item.ItemId  where (@RateListId is null or RateListId=@RateListId)
and (@R_Date is null or R_Date=@R_Date) and (@ItemId is null or tbl_RateList.ItemId=@ItemId) and (@R_Type is null or R_Type=@R_Type)
else if(@Type=2) 
insert into tbl_RateList values (@ItemId, @PurchaseId,@WholeSalePrice,@RetailPrice,@R_Type,@R_Date)
else if(@Type=3)
update tbl_RateList set @ItemId=@ItemId, PurchaseId=@PurchaseId,WholeSalePrice=@WholeSalePrice,RetailPrice=@RetailPrice,R_Type=@R_Type, R_Date=@R_Date where RateListId=@RateListId
else if(@Type=4)
delete  tbl_RateList where RateListId=@RateListId
GO
/****** Object:  StoredProcedure [dbo].[Sp_Stock]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE proc [dbo].[Sp_Stock]
 @StockId int=null,
 @PurchaseId int=null,
 @Sold float=null,
 @Remaining float=null,
 @Status bit=null,
 @Type int
 as
 if(@Type=1)
 select *,case Status when 1 then 'Open' else 'Close' end as Status_ from tbl_Stock where (@StockId is null or StockId=@StockId) and (@Status is null or Status=@Status)
 else if(@Type=2)
 begin
 declare @PrevousStock float =(select Remaining from tbl_Stock where Status=1)
  update tbl_Stock set Status=0 where Status=1
 insert into tbl_Stock values (@PurchaseId,@Sold,@Remaining+isnull(@PrevousStock,0),@Status)
 end
 else if(@Type=3)
 update tbl_Stock set Sold=@Sold,Remaining=(select Remaining-@Sold from tbl_Stock where Status=1) where Status=1
 else if(@Type=4)
 delete tbl_Stock where StockId=@StockId
 else if (@Type=5)
 select isnull(Remaining*(select Rate from tbl_PurchaseStock where PurchaseId=tbl_Stock.PurchaseId),0) as Total from tbl_Stock where Status=1


GO
/****** Object:  StoredProcedure [dbo].[Sp_Vendor]    Script Date: 19/01/2023 7:46:16 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[Sp_Vendor]
@VendorId int=null,
@Name varchar(max)=null,
@Address varchar(max) =null,
@Type int
as
if(@Type=1)
select * from tbl_Vendor where(@VendorId is null or VendorId=@VendorId)and
(@Name is null or Name=@Name)
else if (@Type=2)
insert into tbl_Vendor values (@Name,@Address)
else if (@Type=3)
update tbl_Vendor set Name=@Name,Address=@Address where VendorId=@VendorId
else if (@Type=4)
delete tbl_Vendor where VendorId=@VendorId
GO
USE [master]
GO
ALTER DATABASE [Chiken] SET  READ_WRITE 
GO
