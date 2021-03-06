USE [master]
GO
if 'GS_admin' in (SELECT name FROM master.sys.server_principals) begin
	drop login GS_admin;
	drop login GS_staff;
	drop login GS_stockmanager;
end
go
drop database if exists [GroceryStore]
go

/****** Object:  Database [GroceryStore]    Script Date: 11/18/2021 12:07:07 PM ******/
CREATE DATABASE [GroceryStore]
GO
ALTER DATABASE [GroceryStore] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GroceryStore].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GroceryStore] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GroceryStore] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GroceryStore] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GroceryStore] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GroceryStore] SET ARITHABORT OFF 
GO
ALTER DATABASE [GroceryStore] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GroceryStore] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GroceryStore] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GroceryStore] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GroceryStore] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GroceryStore] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GroceryStore] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GroceryStore] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GroceryStore] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GroceryStore] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GroceryStore] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GroceryStore] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GroceryStore] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GroceryStore] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GroceryStore] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GroceryStore] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GroceryStore] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GroceryStore] SET RECOVERY FULL 
GO
ALTER DATABASE [GroceryStore] SET  MULTI_USER 
GO
ALTER DATABASE [GroceryStore] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GroceryStore] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GroceryStore] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GroceryStore] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GroceryStore] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GroceryStore] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'GroceryStore', N'ON'
GO
ALTER DATABASE [GroceryStore] SET QUERY_STORE = OFF
GO

-- Create login
create login GS_admin with password = 'admin'
go
create login GS_staff with password = 'staff'
go
create login GS_stockmanager with password = 'stockmanager'
go

USE [GroceryStore]
GO
/****** Object:  User [stockmanager]    Script Date: 11/18/2021 12:07:08 PM ******/
CREATE USER [stockmanager] FOR LOGIN [GS_stockmanager] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [staff]    Script Date: 11/18/2021 12:07:08 PM ******/
CREATE USER [staff] FOR LOGIN [GS_staff] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  User [admin]    Script Date: 11/18/2021 12:07:08 PM ******/
CREATE USER [admin] FOR LOGIN [GS_admin] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CheckGoodsName]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_CheckGoodsName](@gname nvarchar(50)) 
returns bit as
begin
	if (@gname in (select gname from Goods))
		return 1;
	return 0;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CheckGoodsState]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_CheckGoodsState](@id int = null, @name nvarchar(50) = null)
returns varchar(12) as
begin
	declare @quantity int;
	declare @state bit;
	if (@id is not null)
		select @quantity = gquantity, @state = gstate
		from Goods 
		where goods_id = @id;
	else
		select @quantity = gquantity, @state = gstate
		from Goods 
		where gname = @name;
	if (@state = 0)
		return 'STOP SELLING';
	else if (@quantity = 0)
	    return 'SOLD OUT';
	return 'STOCKING';
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CheckLogin]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
---------- Function -------------
CREATE function [dbo].[ft_CheckLogin](@phoneNumber varchar(12), @password varchar(20))
returns varchar(max)
as begin
	declare @result varchar(max);
	if (@phoneNumber not in (select ephoneNumber from Employee))
		set @result = 'Invalid phone number!';
	else begin
		declare @check int;
		select @check = employee_id from Employee where ephoneNumber = @phoneNumber and password = @password;
		if @check is null
			set @result = 'Wrong password!';
		else
			set @result = cast(@check as varchar);
	end
	return @result;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CheckProviderName]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_CheckProviderName]
(@pname nvarchar(100))
returns bit
as
begin
	if (@pname in (select pname from Providers))
		return 1;
	return 0;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_ContainSource]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ft_ContainSource](@source varchar(10), @id int)
returns bit 
as begin
	declare @count int;
	select @count = count(*) from Cash_flow where source = @source and id = @id;
	if (@count > 0)
		return 1;
	return 0;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CreateBillId]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ft_CreateBillId]()
returns int
as begin
	declare @max int;
	select @max = max(bill_id) from Bills;
	return @max + 1;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_CreateContractId]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ft_CreateContractId]()
returns int
as begin
	declare @max int;
	select @max = max(contract_id) from Contracts;
	return @max + 1;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_FirstLoginInDay]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function	[dbo].[ft_FirstLoginInDay] (@eid int, @day date)
returns bit 
as begin
	declare @check int;
	select @check = count(*) from Login_manager
	where eid = @eid and time = @day;
	if (@check = 0)
		return 1;
	return 0;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_FirstLoginInMonth]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create function [dbo].[ft_FirstLoginInMonth](@time date)
returns bit
as begin
	declare @check int;
	select @check = count(*) from Login_manager
	where year(time) = year(@time) and month(time) = month(@time);
	if (@check = 1)
		return 1;
	return 0;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_GetGoodId]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_GetGoodId](@gname nvarchar(50))
returns int
as
begin
	declare @id int;
	select @id = Goods.goods_id from Goods where Goods.gname = @gname;
	return @id;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_GetMonthAmount]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_GetMonthAmount](@income bit)
returns float
as begin
	declare @sumAmount float;
	if (@income = 1)
		select @sumAmount = sum(amount) from Cash_flow where amount > 0;
	else 
		select @sumAmount = sum(amount) from Cash_flow where amount < 0;
	return @sumAmount;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_GetPrice]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_GetPrice](@id int = null, @name nvarchar(50) = null)
returns float as
begin
	declare @result float;
	if (@id is not null)
		select @result = gprice from Goods where goods_id = @id;
	else
		select @result = gprice from Goods where gname = @name;
	return @result;
end;
GO
/****** Object:  UserDefinedFunction [dbo].[ft_GetPriceOfSource]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_GetPriceOfSource] (@source varchar(10), @id int)
returns float
as begin
	declare @price float;
	select @price = amount from Cash_flow where source = @source and id = @id;
	return @price;
end
GO
/****** Object:  UserDefinedFunction [dbo].[ft_GetProviderId]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE function [dbo].[ft_GetProviderId](@pname nvarchar(100))
returns int
as
begin
	declare @id int;
	select @id = Providers.provider_id from Providers where Providers.pname = @pname;
	return @id;
end
GO
/****** Object:  Table [dbo].[Contracts]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contracts](
	[contract_id] [int] NOT NULL,
	[goods_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[provider_id] [int] NOT NULL,
	[cdate] [datetime] NOT NULL,
	[cquantity] [int] NOT NULL,
	[cprice] [float] NOT NULL,
 CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED 
(
	[contract_id] ASC,
	[goods_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Goods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Goods](
	[goods_id] [int] IDENTITY(1,1) NOT NULL,
	[gname] [nvarchar](50) NOT NULL,
	[gprice] [float] NULL,
	[gquantity] [int] NOT NULL,
	[gstate] [bit] NOT NULL,
	[gphoto] [nvarchar](255) NULL,
	[unit] [nvarchar](15) NULL,
 CONSTRAINT [PK_Goods] PRIMARY KEY CLUSTERED 
(
	[goods_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_GetComingSoonGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE view [dbo].[vw_GetComingSoonGoods]
as
select g.goods_id AS ID, gname AS Name, unit AS Unit, gprice AS Price, null AS Profit, gquantity AS Quantity, gstate AS Selling, CASE WHEN gphoto IS NULL THEN 0 ELSE 1 END AS Image
from Goods g
where goods_id not in (select goods_id from Contracts)
GO
/****** Object:  Table [dbo].[Providers]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Providers](
	[provider_id] [int] IDENTITY(1,1) NOT NULL,
	[pname] [nvarchar](100) NOT NULL,
	[paddress] [nvarchar](100) NOT NULL,
	[pphoneNumber] [varchar](20) NULL,
	[pstate] [bit] NOT NULL,
 CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED 
(
	[provider_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_GetAllProviders]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllProviders]
AS
SELECT provider_id AS ID, pname AS Name, paddress AS Address, pphoneNumber AS [Phone Number], pstate AS Providing
FROM     dbo.Providers
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[ename] [nvarchar](50) NOT NULL,
	[birthday] [date] NOT NULL,
	[eaddress] [nvarchar](100) NOT NULL,
	[gender] [bit] NOT NULL,
	[ephoneNumber] [varchar](12) NULL,
	[workDays] [int] NOT NULL,
	[salaryPerDay] [float] NOT NULL,
	[monthSalary] [float] NOT NULL,
	[password] [varchar](20) NOT NULL,
	[role] [varchar](13) NOT NULL,
	[estate] [bit] NOT NULL,
	[ephoto] [varchar](255) NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_GetAllContracts]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllContracts]
AS
SELECT c.contract_id AS CID, g.goods_id AS GID, g.gname AS [Goods name], c.cquantity AS Quantity, g.unit AS Unit, c.cprice AS Price, temp.Total AS [Total Price], c.employee_id AS EID, e.ename AS [Employee name], p.pname AS [Provider name], 
                  c.cdate AS Date
FROM     dbo.Contracts AS c INNER JOIN
                  dbo.Providers AS p ON c.provider_id = p.provider_id INNER JOIN
                  dbo.Goods AS g ON g.goods_id = c.goods_id INNER JOIN
                  dbo.Employee AS e ON e.employee_id = c.employee_id INNER JOIN
                      (SELECT contract_id AS ID, SUM(cprice) AS Total
                       FROM      dbo.Contracts
                       GROUP BY contract_id) AS temp ON temp.ID = c.contract_id
GO
/****** Object:  View [dbo].[vw_GetAllGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllGoods]
AS
SELECT goods_id AS ID, gname AS Name, unit, gprice AS Price, gquantity AS Quantity, gstate AS Selling, CASE WHEN gphoto IS NULL THEN 0 ELSE 1 END AS Image
FROM     dbo.Goods
GO
/****** Object:  View [dbo].[vw_GetAllGoodsWithProfit]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllGoodsWithProfit]
AS
SELECT g.goods_id AS ID, gname AS Name, unit AS Unit, gprice AS Price, CONVERT(int, gprice - t .price / t .quantity) AS Profit, gquantity AS Quantity, gstate AS Selling, CASE WHEN gphoto IS NULL THEN 0 ELSE 1 END AS Image

FROM     Goods g INNER JOIN
                      (SELECT goods_id, cquantity AS quantity, cprice AS price
                       FROM      (SELECT goods_id, cquantity, cprice, ROW_NUMBER() OVER (partition BY goods_id
                                          ORDER BY cdate DESC) rn
                       FROM      Contracts) a
WHERE  a.rn = 1) t ON g.goods_id = t .goods_id;
GO
/****** Object:  View [dbo].[vw_GetStockingGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetStockingGoods]
AS
SELECT ID, Name, Unit, Price, Profit, Quantity, Selling, Image
FROM     dbo.vw_GetAllGoodsWithProfit
WHERE  (Quantity > 0) AND (Selling = 1)
GO
/****** Object:  View [dbo].[vw_GetAllEmployees]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllEmployees]
AS
SELECT employee_id AS ID, ename AS Name, birthday AS Birthday, eaddress AS Address, CASE WHEN gender = 1 THEN 'Nam' ELSE N'Nữ' END AS Gender, ephoneNumber AS [Phone Number], workDays AS [Working Days], 
                  salaryPerDay AS [Day's Wage], monthSalary AS [Month Salary], password AS Password, role AS Role, estate AS Working, CAST((CASE WHEN ephoto IS NULL THEN 0 ELSE 1 END) AS bit) AS Image
FROM     dbo.Employee
WHERE  (estate = 1)
GO
/****** Object:  View [dbo].[vw_GetSoldOutGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetSoldOutGoods]
AS
SELECT ID, Name, Unit, Price, Profit, Quantity, Selling, Image
FROM     dbo.vw_GetAllGoodsWithProfit
WHERE  (Quantity = 0) AND (Selling = 1)
GO
/****** Object:  View [dbo].[vw_GetStaffs]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetStaffs]
AS
SELECT ID, Name, Birthday, Address, Gender, [Phone Number], [Working Days], [Day's Wage], [Month Salary], Password, Role, Working, Image
FROM     dbo.vw_GetAllEmployees
WHERE  (Role = 'STAFF')
GO
/****** Object:  View [dbo].[vw_GetStopSellingGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetStopSellingGoods]
AS
SELECT ID, Name, Unit, Price, Profit, Quantity, Selling, Image
FROM     dbo.vw_GetAllGoodsWithProfit
WHERE  (Selling = 0)
GO
/****** Object:  View [dbo].[vw_GetStockManagers]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetStockManagers]
AS
SELECT ID, Name, Birthday, Address, Gender, [Phone Number], [Working Days], [Day's Wage], [Month Salary], Password, Role, Working, Image
FROM     dbo.vw_GetAllEmployees
WHERE  (Role = 'STOCK MANAGER')
GO
/****** Object:  Table [dbo].[Bills]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bills](
	[bill_id] [int] NOT NULL,
	[goods_id] [int] NOT NULL,
	[employee_id] [int] NOT NULL,
	[bquantity] [int] NOT NULL,
	[bdate] [datetime] NOT NULL,
	[bprice] [float] NOT NULL,
 CONSTRAINT [PK_Bills] PRIMARY KEY CLUSTERED 
(
	[bill_id] ASC,
	[goods_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[vw_GetAllBills]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllBills]
AS
SELECT b.bill_id AS BID, g.goods_id AS GID, g.gname AS [Goods Name], b.bquantity AS Quantity, g.unit AS Unit, b.bprice AS Price, temp.Total AS [Total Price], b.employee_id AS EID, e.ename AS [Employee Name], b.bdate AS Date
FROM     dbo.Bills AS b INNER JOIN
                  dbo.Employee AS e ON b.employee_id = e.employee_id INNER JOIN
                  dbo.Goods AS g ON b.goods_id = g.goods_id INNER JOIN
                      (SELECT bill_id AS ID, SUM(bprice) AS Total
                       FROM      dbo.Bills
                       GROUP BY bill_id) AS temp ON temp.ID = b.bill_id
GO
/****** Object:  View [dbo].[vw_GetAllRetiredEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[vw_GetAllRetiredEmployee]
AS
SELECT employee_id AS ID, ename AS Name, birthday AS Birthday, eaddress AS Address, CASE WHEN gender = 1 THEN 'Nam' ELSE N'Nữ' END AS Gender, ephoneNumber AS [Phone Number], workDays AS [Working Days], 
                  salaryPerDay AS [Day's Wage], monthSalary AS [Month Salary], password AS Password, role AS Role, estate AS Working, CAST((CASE WHEN ephoto IS NULL THEN 0 ELSE 1 END) AS bit) AS Image
FROM     dbo.Employee
WHERE  (estate = 0)
GO
/****** Object:  Table [dbo].[Cash_flow]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cash_flow](
	[time] [datetime] NOT NULL,
	[source] [varchar](10) NOT NULL,
	[id] [int] NOT NULL,
	[amount] [float] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login_manager]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login_manager](
	[eid] [int] NOT NULL,
	[time] [date] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (1, 17, 5, 5, CAST(N'2021-10-17T10:32:26.000' AS DateTime), 30000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (1, 18, 5, 2, CAST(N'2021-10-17T10:32:26.000' AS DateTime), 22000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (1, 23, 5, 1, CAST(N'2021-10-17T10:32:26.000' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (1, 43, 5, 1, CAST(N'2021-10-17T10:32:26.000' AS DateTime), 25000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (2, 3, 5, 10, CAST(N'2021-10-17T22:43:16.603' AS DateTime), 40000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (2, 19, 5, 1, CAST(N'2021-10-17T22:43:16.603' AS DateTime), 10000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (2, 34, 5, 2, CAST(N'2021-10-17T22:43:16.603' AS DateTime), 10000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (2, 45, 5, 1, CAST(N'2021-10-17T22:43:16.603' AS DateTime), 15000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (3, 20, 6, 2, CAST(N'2021-10-17T22:45:47.390' AS DateTime), 20000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (3, 32, 6, 1, CAST(N'2021-10-17T22:45:47.390' AS DateTime), 350000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (3, 40, 6, 3, CAST(N'2021-10-17T22:45:47.390' AS DateTime), 54000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (3, 41, 6, 6, CAST(N'2021-10-17T22:45:47.390' AS DateTime), 84000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (4, 23, 8, 2, CAST(N'2021-10-17T23:18:39.077' AS DateTime), 36000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (4, 24, 8, 1, CAST(N'2021-10-17T23:18:39.077' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (4, 25, 8, 2, CAST(N'2021-10-17T23:18:39.077' AS DateTime), 36000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (4, 37, 8, 10, CAST(N'2021-10-17T23:18:39.077' AS DateTime), 70000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (5, 19, 7, 2, CAST(N'2021-11-13T19:43:04.170' AS DateTime), 20000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (5, 33, 7, 4, CAST(N'2021-11-13T19:43:04.187' AS DateTime), 20000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (5, 41, 7, 2, CAST(N'2021-11-13T19:43:04.183' AS DateTime), 28000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 2, 2, 10, CAST(N'2021-11-17T22:03:37.300' AS DateTime), 40000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 10, 2, 10, CAST(N'2021-11-17T22:03:37.310' AS DateTime), 50000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 16, 2, 10, CAST(N'2021-11-17T22:03:37.313' AS DateTime), 80000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 17, 2, 10, CAST(N'2021-11-17T22:03:37.313' AS DateTime), 60000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 23, 2, 1, CAST(N'2021-11-17T22:03:37.313' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 30, 2, 1, CAST(N'2021-11-17T22:03:37.317' AS DateTime), 160000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 32, 2, 1, CAST(N'2021-11-17T22:03:37.317' AS DateTime), 350000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (6, 39, 2, 3, CAST(N'2021-11-17T22:03:37.317' AS DateTime), 54000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 18, 6, 5, CAST(N'2021-11-18T10:46:24.227' AS DateTime), 55000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 26, 6, 2, CAST(N'2021-11-18T10:46:24.240' AS DateTime), 22000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 28, 6, 1, CAST(N'2021-11-18T10:46:24.240' AS DateTime), 75000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 33, 6, 2, CAST(N'2021-11-18T10:46:24.243' AS DateTime), 10000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 41, 6, 3, CAST(N'2021-11-18T10:46:24.243' AS DateTime), 42000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (7, 42, 6, 3, CAST(N'2021-11-18T10:46:24.243' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 23, 6, 1, CAST(N'2021-11-18T10:47:42.180' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 24, 6, 1, CAST(N'2021-11-18T10:47:42.180' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 25, 6, 1, CAST(N'2021-11-18T10:47:42.180' AS DateTime), 18000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 38, 6, 4, CAST(N'2021-11-18T10:47:42.173' AS DateTime), 28000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 39, 6, 3, CAST(N'2021-11-18T10:47:42.177' AS DateTime), 54000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (8, 1046, 6, 3, CAST(N'2021-11-18T10:47:42.163' AS DateTime), 30000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (9, 27, 6, 4, CAST(N'2021-11-18T10:50:27.707' AS DateTime), 40000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (9, 36, 6, 4, CAST(N'2021-11-18T10:50:27.713' AS DateTime), 28000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (9, 37, 6, 4, CAST(N'2021-11-18T10:50:27.717' AS DateTime), 28000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (9, 41, 6, 4, CAST(N'2021-11-18T10:50:27.717' AS DateTime), 56000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (10, 10, 6, 8, CAST(N'2021-11-18T10:52:17.480' AS DateTime), 40000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (10, 21, 6, 5, CAST(N'2021-11-18T10:52:17.490' AS DateTime), 50000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 6, 6, 11, CAST(N'2021-11-18T10:56:55.540' AS DateTime), 44000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 14, 6, 10, CAST(N'2021-11-18T10:56:55.540' AS DateTime), 80000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 19, 6, 4, CAST(N'2021-11-18T10:56:55.523' AS DateTime), 40000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 28, 6, 1, CAST(N'2021-11-18T10:56:55.537' AS DateTime), 75000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 29, 6, 1, CAST(N'2021-11-18T10:56:55.540' AS DateTime), 50000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 31, 6, 1, CAST(N'2021-11-18T10:56:55.540' AS DateTime), 110000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (11, 34, 6, 5, CAST(N'2021-11-18T10:56:55.540' AS DateTime), 25000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (12, 14, 7, 3, CAST(N'2021-11-18T10:58:44.787' AS DateTime), 24000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (12, 15, 7, 3, CAST(N'2021-11-18T10:58:44.797' AS DateTime), 24000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (12, 16, 7, 3, CAST(N'2021-11-18T10:58:44.800' AS DateTime), 24000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (12, 36, 7, 2, CAST(N'2021-11-18T10:58:44.800' AS DateTime), 14000)
INSERT [dbo].[Bills] ([bill_id], [goods_id], [employee_id], [bquantity], [bdate], [bprice]) VALUES (12, 45, 7, 2, CAST(N'2021-11-18T10:58:44.800' AS DateTime), 30000)
GO
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-16T05:14:17.170' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-15T00:00:00.000' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-15T08:30:00.000' AS DateTime), N'CONTRACT', 1, -174000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-15T09:12:00.000' AS DateTime), N'CONTRACT', 2, -1948000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-16T09:22:00.000' AS DateTime), N'CONTRACT', 3, -39552300)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-17T22:32:26.950' AS DateTime), N'BILL', 1, 95000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-17T22:43:16.603' AS DateTime), N'BILL', 2, 75000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-17T22:45:47.390' AS DateTime), N'BILL', 3, 508000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-29T04:21:36.000' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-17T23:18:39.077' AS DateTime), N'BILL', 5, 228000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-05T02:05:51.457' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-14T12:55:01.563' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-17T22:15:04.267' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-16T21:07:33.863' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:46:24.227' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:46:24.227' AS DateTime), N'BILL', 7, 222000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:47:42.163' AS DateTime), N'BILL', 8, 166000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:50:27.707' AS DateTime), N'BILL', 9, 152000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:52:17.480' AS DateTime), N'BILL', 10, 90000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:56:55.523' AS DateTime), N'BILL', 11, 424000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-18T10:58:44.787' AS DateTime), N'BILL', 12, 116000)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-10-29T04:21:36.000' AS DateTime), N'CONTRACT', 4, -874624)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-17T22:03:37.300' AS DateTime), N'TEMP', 0, 0)
INSERT [dbo].[Cash_flow] ([time], [source], [id], [amount]) VALUES (CAST(N'2021-11-17T22:03:37.300' AS DateTime), N'BILL', 6, 812000)
GO
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 1, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 76000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 2, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 3, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 4, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 5, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 6, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 7, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 8, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 9, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 10, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 11, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 12, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 13, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 14, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 15, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 16, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 17, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (1, 18, 3, 1, CAST(N'2021-10-15T12:00:00.000' AS DateTime), 24, 4000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 19, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 210000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 20, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 208000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 21, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 195000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 22, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 200000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 23, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 240000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 24, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 240000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 25, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 240000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 26, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 210000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (2, 27, 4, 2, CAST(N'2021-10-15T00:00:00.000' AS DateTime), 24, 205000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 28, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 50, 3000000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 29, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 100, 3500000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 30, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 20, 2580000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 31, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 100, 9200000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 32, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 10, 2800000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 33, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 60, 214800)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 34, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 50, 179000)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 35, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 120, 405300)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 36, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 80, 421100)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 37, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 80, 421100)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 38, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 160, 842200)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 39, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 216, 3117600)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 40, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 192, 2870200)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 41, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 288, 2916600)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 42, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 80, 357900)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 43, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 180, 3126400)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 44, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 180, 3126400)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (3, 45, 4, 3, CAST(N'2021-10-16T00:00:00.000' AS DateTime), 36, 473700)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (4, 33, 3, 1, CAST(N'2021-10-29T04:21:36.000' AS DateTime), 20, 312312)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (4, 36, 3, 1, CAST(N'2021-10-29T04:21:36.000' AS DateTime), 22, 312312)
INSERT [dbo].[Contracts] ([contract_id], [goods_id], [employee_id], [provider_id], [cdate], [cquantity], [cprice]) VALUES (4, 1046, 3, 1, CAST(N'2021-10-29T04:21:36.000' AS DateTime), 50, 250000)
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (1, N'Nguyễn Quang Vinh', CAST(N'2001-11-18' AS Date), N'Huỳnh Tấn Phát, Phú Thuận, Quận 7', 1, N'0962796418', 3, 0, 0, N'19110499', N'ADMIN', 1, N'Manager-Store\GUI\Images\Employees\0962796418.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (2, N'Cao Diễm Hiền', CAST(N'2003-12-03' AS Date), N'Lê Hồng Phong, Bình Thủy, Cần Thơ', 0, N'0921382591', 3, 0, 1000000, N'diemhiencute', N'ADMIN', 1, N'Manager-Store\GUI\Images\Employees\0921382591.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (3, N'Lê Trung Kiên', CAST(N'2001-07-10' AS Date), N'Võ Văn Ngân, Linh Chiểu, Quận Thủ Đức', 1, N'0336411934', 2, 200000, 800000, N'19110383', N'STOCK MANAGER', 1, N'Manager-Store\GUI\Images\Employees\0336411934.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (4, N'Dương Văn Nam', CAST(N'2001-01-02' AS Date), N'Quốc lộ 1, Linh Chiểu, Quận Thủ Đức', 1, N'0934723894', 3, 200000, 600000, N'19110400', N'STOCK MANAGER', 1, N'Manager-Store\GUI\Images\Employees\0934723894.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (5, N'Nguyễn Phương Nam', CAST(N'2001-02-01' AS Date), N'Nguyễn Huệ, Quận 1', 1, N'0128437495', 3, 160000, 480000, N'19110402', N'STAFF', 1, N'Manager-Store\GUI\Images\Employees\0128437495.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (6, N'Nguyễn Hoàng Việt Anh', CAST(N'2003-12-02' AS Date), N'Phú Mỹ Hưng, Quận 7', 1, N'0974623483', 2, 0, 480000, N'diemhiencute', N'STAFF', 1, N'Manager-Store\GUI\Images\Employees\0974623483.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (7, N'Nguyễn Hoàng Khả Vy', CAST(N'2003-12-01' AS Date), N'Quận 2, Hồ Chí Minh', 0, N'0192837465', 2, 160000, 0, N'diemhiencute', N'STAFF', 1, N'Manager-Store\GUI\Images\Employees\0192837465.png')
INSERT [dbo].[Employee] ([employee_id], [ename], [birthday], [eaddress], [gender], [ephoneNumber], [workDays], [salaryPerDay], [monthSalary], [password], [role], [estate], [ephoto]) VALUES (8, N'Phạm Thị Tường Vy', CAST(N'2001-03-18' AS Date), N'Nguyễn Văn Linh, Quận Bình Chánh', 0, N'0348947894', 2, 160000, 480000, N'tuongvy', N'STAFF', 1, N'Manager-Store\GUI\Images\Employees\0348947894.png')
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
SET IDENTITY_INSERT [dbo].[Goods] ON 

INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (1, N'Mì Gấu Đỏ tôm và gà 63g', 4000, 19, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_tôm_và_gà_63g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (2, N'Mì Gấu Đỏ thịt bằm 63g', 4000, 9, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_thịt_bằm_63g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (3, N'Mì Gấu Đỏ tôm chua cay 63g', 4000, 9, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_tôm_chua_cay_63g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (4, N'Mì Gấu Đỏ gà sợi phở 63g', 4000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_gà_sợi_phở_63g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (5, N'Mì Gấu Đỏ tôm gà sợi phở 63g', 4000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_tôm_gà_sợi_phở_63g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (6, N'Mì Gấu Đỏ chay rau nấm 62g', 4000, 13, 1, N'Manager-Store\GUI\Images\Goods\Mì_Gấu_Đỏ_chay_rau_nấm_62g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (7, N'Cháo thịt bằm Gấu Đỏ 50g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Cháo_thịt_bằm_Gấu_Đỏ_50g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (8, N'Cháo cá Gấu Đỏ 50g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Cháo_cá_Gấu_Đỏ_50g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (9, N'Mì 3 Miền tôm chua cay 65g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_3_Miền_tôm_chua_cay_65g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (10, N'Mì 3 Miền tôm hùm 65g', 5000, 6, 1, N'Manager-Store\GUI\Images\Goods\Mì_3_Miền_tôm_hùm_65g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (11, N'Mì chay lá đa 3 Miền 65g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_chay_lá_đa_3_Miền_65g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (12, N'Mì Tiến Vua tôm chua cay 65g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_Tiến_Vua_tôm_chua_cay_65g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (13, N'Mì Kokomi tôm chua cay 65g', 5000, 24, 1, N'Manager-Store\GUI\Images\Goods\Mì_Kokomi_tôm_chua_cay_65g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (14, N'Mì Omachi sườn hầm ngũ quả 80g', 8000, 11, 1, N'Manager-Store\GUI\Images\Goods\Mì_Omachi_sườn_hầm_ngũ_quả_80g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (15, N'Mì Omachi xốt bò hầm 80g', 8000, 21, 1, N'Manager-Store\GUI\Images\Goods\Mì_Omachi_xốt_bò_hầm_80g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (16, N'Mì khoai tây Omachi tôm chua cay 5 sao 78g', 8000, 11, 1, N'Manager-Store\GUI\Images\Goods\Mì_khoai_tây_Omachi_tôm_chua_cay_5_sao_78g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (17, N'Mì Hảo Hảo tôm chua cay 75g', 6000, 9, 1, N'Manager-Store\GUI\Images\Goods\Mì_Hảo_Hảo_tôm_chua_cay_75g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (18, N'Mì Handy Hảo Hảo tôm chua cay ly 67g', 11000, 17, 1, N'Manager-Store\GUI\Images\Goods\Mì_Handy_Hảo_Hảo_tôm_chua_cay_ly_67g.png', N'Ly')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (19, N'Nước ngọt Coca Cola 330ml', 10000, 17, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_Coca_Cola_330ml.png', N'Lon')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (20, N'Nước ngọt Pepsi Cola 330ml', 10000, 22, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_Pepsi_Cola_330ml.png', N'Lon')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (21, N'Nước ngọt 7 Up vị chanh 330ml', 10000, 19, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_7_Up_vị_chanh_330ml.png', N'Lon')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (22, N'Nước tăng lực Sting PET 330ml', 10000, 24, 1, N'Manager-Store\GUI\Images\Goods\Nước_tăng_lực_Sting_PET_330ml.png', N'Chai')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (23, N'Nước ngọt Coca Cola chai lớn 1.5l', 18000, 19, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_Coca_Cola_chai_lớn_1.5l.png', N'Chai')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (24, N'Nước ngọt Pepsi chai 1.5l', 18000, 22, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_Pepsi_chai_1.5l.png', N'Chai')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (25, N'Nước ngọt 7up lớn 1.5l', 18000, 21, 1, N'Manager-Store\GUI\Images\Goods\Nước_ngọt_7up_lớn_1.5l.png', N'Chai')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (26, N'Nước tăng lực number one', 11000, 22, 1, N'Manager-Store\GUI\Images\Goods\Nước_tăng_lực_number_one.png', N'Lon')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (27, N'Nước bò húc red bull', 10000, 20, 1, N'Manager-Store\GUI\Images\Goods\Nước_bò_húc_red_bull.png', N'Lon')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (28, N'Bánh trứng chảy Đài Loan', 75000, 47, 1, N'Manager-Store\GUI\Images\Goods\Bánh_trứng_chảy_Đài_Loan.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (29, N'Bánh trứng muối 3Q Đài Loan', 50000, 98, 1, N'Manager-Store\GUI\Images\Goods\Bánh_trứng_muối_3Q_Đài_Loan.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (30, N'Bánh mix Đài Loan', 160000, 19, 1, N'Manager-Store\GUI\Images\Goods\Bánh_mix_Đài_Loan.png', N'Kg')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (31, N'Bánh MoChi Đài Loan', 110000, 99, 1, N'Manager-Store\GUI\Images\Goods\Bánh_MoChi_Đài_Loan.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (32, N'Bánh sandwich Đài Loan', 350000, 8, 1, N'Manager-Store\GUI\Images\Goods\Bánh_sandwich_Đài_Loan.png', N'Thùng')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (33, N'Bánh snack Oishi 40g', 5000, 66, 1, N'Manager-Store\GUI\Images\Goods\Bánh_snack_Oishi_40g.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (34, N'Bánh snack Oishi Strip Fries khoai tây que 27g', 5000, 43, 1, N'Manager-Store\GUI\Images\Goods\Bánh_snack_Oishi_Strip_Fries_khoai_tây_que_27g.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (35, N'Snack tôm Thái Ruaypuan 20g', 75000, 117, 1, N'Manager-Store\GUI\Images\Goods\Snack_tôm_Thái_Ruaypuan_20g.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (36, N'Bánh snack Orion Ostar', 7000, 96, 1, N'Manager-Store\GUI\Images\Goods\Bánh_snack_Orion_Ostar.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (37, N'Swing khoai tây 28g', 7000, 66, 1, N'Manager-Store\GUI\Images\Goods\Swing_khoai_tây_28g.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (38, N'Snack Lay''s (Poca) khoai tây 26g', 7000, 155, 1, N'Manager-Store\GUI\Images\Goods\Snack_Lay''s_(Poca)_khoai_tây_26g.png', N'Bịch')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (39, N'Socola M&M đậu phộng 37g', 18000, 210, 1, N'Manager-Store\GUI\Images\Goods\Socola_M&M_đậu_phộng_37g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (40, N'Socola Snicker 51g', 18000, 189, 1, N'Manager-Store\GUI\Images\Goods\Socola_Snicker_51g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (41, N'Socola Kitkat 4F', 14000, 273, 1, N'Manager-Store\GUI\Images\Goods\Socola_Kitkat_4F.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (42, N'Kẹo Oishi 90g', 6000, 4, 1, N'Manager-Store\GUI\Images\Goods\Kẹo_Oishi_90g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (43, N'Gum Cool Air hủ 40v', 25000, 179, 1, N'Manager-Store\GUI\Images\Goods\Gum_Cool_Air_hủ_40v.png', N'Hủ')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (44, N'Gum Doublemint hủ 40v', 25000, 180, 1, N'Manager-Store\GUI\Images\Goods\Gum_Doublemint_hủ_40v.png', N'Hủ')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (45, N'Dynamite Chews gói 125g', 15000, 33, 1, N'Manager-Store\GUI\Images\Goods\Dynamite_Chews_gói_125g.png', N'Gói')
INSERT [dbo].[Goods] ([goods_id], [gname], [gprice], [gquantity], [gstate], [gphoto], [unit]) VALUES (1046, N'Bánh tráng xì ke', 10000, 47, 1, N'Manager-Store\GUI\Images\Goods\Bánh_tráng_xì_ke.png', N'Bịch')
SET IDENTITY_INSERT [dbo].[Goods] OFF
GO
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (6, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (7, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (8, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (3, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-10-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (6, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (7, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (8, CAST(N'2021-10-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (6, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (7, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (8, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (3, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (1, CAST(N'2021-10-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-11-02' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (3, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (8, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (1, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (7, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (6, CAST(N'2021-11-15' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (4, CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (1, CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (8, CAST(N'2021-11-16' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (6, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (7, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (2, CAST(N'2021-11-17' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (1009, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (5, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (3, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (9, CAST(N'2021-11-18' AS Date))
INSERT [dbo].[Login_manager] ([eid], [time]) VALUES (1, CAST(N'2021-11-18' AS Date))
GO
SET IDENTITY_INSERT [dbo].[Providers] ON 

INSERT [dbo].[Providers] ([provider_id], [pname], [paddress], [pphoneNumber], [pstate]) VALUES (1, N'Công Ty TNHH Công Nghệ Thực Phẩm Châu Á', N'Số 8, Đường TS15, KCN Tiên Sơn, X. Hoàn Sơn, H. Tiên Du, Bắc Ninh', N'(0222) 3714146', 1)
INSERT [dbo].[Providers] ([provider_id], [pname], [paddress], [pphoneNumber], [pstate]) VALUES (2, N'Công Ty TNHH Thương Mại và Xuất Nhập Khẩu Trang Việt Anh', N'12A, Đường Đồng Khởi, KP. 4, P. Tân Hiệp, TP. Biên Hoà, Đồng Nai', N'0976 915 265', 1)
INSERT [dbo].[Providers] ([provider_id], [pname], [paddress], [pphoneNumber], [pstate]) VALUES (3, N'Công Ty TNHH Sản Xuất Thương Mại Đông Anh', N'Số 30, Đường 36, P. Bình Trị Đông, Q. Bình Tân, Tp. Hồ Chí Minh', N'(028) 38865610', 1)
SET IDENTITY_INSERT [dbo].[Providers] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Employee__722CAB41612C18F8]    Script Date: 11/18/2021 12:07:08 PM ******/
ALTER TABLE [dbo].[Employee] ADD UNIQUE NONCLUSTERED 
(
	[ephoneNumber] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Goods__41FC4D5D19A35B94]    Script Date: 11/18/2021 12:07:08 PM ******/
ALTER TABLE [dbo].[Goods] ADD UNIQUE NONCLUSTERED 
(
	[gname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Goods__41FC4D5DC333B37E]    Script Date: 11/18/2021 12:07:08 PM ******/
ALTER TABLE [dbo].[Goods] ADD UNIQUE NONCLUSTERED 
(
	[gname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Provider__1FC9734C91378B0B]    Script Date: 11/18/2021 12:07:08 PM ******/
ALTER TABLE [dbo].[Providers] ADD UNIQUE NONCLUSTERED 
(
	[pname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cash_flow] ADD  DEFAULT (getdate()) FOR [time]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [workDays]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((0)) FOR [monthSalary]
GO
ALTER TABLE [dbo].[Employee] ADD  DEFAULT ((1)) FOR [estate]
GO
ALTER TABLE [dbo].[Goods] ADD  DEFAULT ((0)) FOR [gquantity]
GO
ALTER TABLE [dbo].[Goods] ADD  DEFAULT ((1)) FOR [gstate]
GO
ALTER TABLE [dbo].[Goods] ADD  DEFAULT (N'Gói') FOR [unit]
GO
ALTER TABLE [dbo].[Login_manager] ADD  DEFAULT (CONVERT([date],getdate())) FOR [time]
GO
ALTER TABLE [dbo].[Providers] ADD  DEFAULT ((1)) FOR [pstate]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_eid] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_eid]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [FK_Bills_gid] FOREIGN KEY([goods_id])
REFERENCES [dbo].[Goods] ([goods_id])
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [FK_Bills_gid]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contract_eid] FOREIGN KEY([employee_id])
REFERENCES [dbo].[Employee] ([employee_id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contract_eid]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contract_gid] FOREIGN KEY([goods_id])
REFERENCES [dbo].[Goods] ([goods_id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contract_gid]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [FK_Contract_pid] FOREIGN KEY([provider_id])
REFERENCES [dbo].[Providers] ([provider_id])
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [FK_Contract_pid]
GO
ALTER TABLE [dbo].[Bills]  WITH CHECK ADD  CONSTRAINT [checkQuantityInBillGreaterThanZero] CHECK  (([bquantity]>(0)))
GO
ALTER TABLE [dbo].[Bills] CHECK CONSTRAINT [checkQuantityInBillGreaterThanZero]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [checkContractPriceGreaterThanZero] CHECK  (([cprice]>(0)))
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [checkContractPriceGreaterThanZero]
GO
ALTER TABLE [dbo].[Contracts]  WITH CHECK ADD  CONSTRAINT [checkQuantityInContractGreaterThanZero] CHECK  (([cquantity]>(0)))
GO
ALTER TABLE [dbo].[Contracts] CHECK CONSTRAINT [checkQuantityInContractGreaterThanZero]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [checkEmployeeBirthday] CHECK  ((datediff(year,[birthday],getdate())<(51)))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [checkEmployeeBirthday]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [checkWorkDaysNotMinus] CHECK  (([salaryPerDay]>=(0)))
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [checkWorkDaysNotMinus]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD CHECK  (([salaryPerDay]>=(0)))
GO
ALTER TABLE [dbo].[Goods]  WITH CHECK ADD  CONSTRAINT [checkGoodsQuantityNotMinus] CHECK  (([gquantity]>(-1)))
GO
ALTER TABLE [dbo].[Goods] CHECK CONSTRAINT [checkGoodsQuantityNotMinus]
GO
ALTER TABLE [dbo].[Goods]  WITH CHECK ADD CHECK  (([gprice]>(0)))
GO
/****** Object:  StoredProcedure [dbo].[sp_AddAmountToSource]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_AddAmountToSource] (@source varchar(10), @id int, @amount float)
as begin
	update Cash_flow
	set amount += @amount
	where source = @source and id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_AddWorkDay]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_AddWorkDay](@id int) as
begin
	update Employee set workDays = workDays + 1
	where employee_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_DeleteBill](@bid int)
as begin
	delete from Bills where bill_id = @bid;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteCashFlow]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_DeleteCashFlow]
	@source varchar(10), 
	@id int
as
begin
	delete from Cash_flow where source = @source and id = @id
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DeleteContract] @cid int
as
delete from Contracts where contract_id = @cid
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DeleteEmployee]
	@id int
as begin
	if @id in (select employee_id from Bills) or 
		@id in (select employee_id from Contracts)
		return;
	delete from Employee where employee_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteGoodsInBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_DeleteGoodsInBill](@bid int, @gid int)
as begin
	delete from Bills where bill_id = @bid and goods_id = @gid;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteGoodsInContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_DeleteGoodsInContract](@cid int, @gname nvarchar(50))
as begin
	declare @gid int;
	exec @gid = ft_GetGoodId @gname;
	delete from Contracts where contract_id = @cid and goods_id = @gid;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DeleteProvider]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_DeleteProvider]
	@pid int = null,
	@pname nvarchar(100) = null
as begin
	if @pid is not null
		delete from Providers where provider_id = @pid;
	else if @pname is not null
		delete from Providers where pname = @pname;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_DetailGoodsInContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_DetailGoodsInContract]
	@cid int
as 
select * from Goods g
inner join Contracts c
on g.goods_id = c.goods_id
where c.contract_id = @cid
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllBills]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_GetAllBills] as 
begin
	select * from vw_GetAllBills;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllContracts]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllContracts]
as
begin
	select * from vw_GetAllContracts;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllEmployees]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
------------- Procedure -----------
CREATE proc [dbo].[sp_GetAllEmployees] 
as begin 
	select * from vw_GetAllEmployees ;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--------- Procedure -------------
CREATE procedure [dbo].[sp_GetAllGoods] as
begin
	select * from vw_GetAllGoods;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllGoodsStillSelling]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllGoodsStillSelling]
as 
select * from Goods g inner join Contracts c on g.goods_id = c.goods_id where g.gstate = 1
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllGoodsWithProfit]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllGoodsWithProfit] as
begin
	select * from vw_GetAllGoodsWithProfit;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllProviders]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--Procedure
CREATE procedure [dbo].[sp_GetAllProviders]
as
begin
	select * from vw_GetAllProviders
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetAllRetiredEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetAllRetiredEmployee] as
select * from vw_GetAllRetiredEmployee;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetCashFlow]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetCashFlow]
as
select time as Time, source as [Source], id as [ID], amount as Money from Cash_flow where source != 'TEMP'
GO
/****** Object:  StoredProcedure [dbo].[sp_GetComingSoonGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_GetComingSoonGoods]
as
select * from vw_GetComingSoonGoods
GO
/****** Object:  StoredProcedure [dbo].[sp_GetSoldOutGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetSoldOutGoods] as
begin
	select * from vw_GetSoldOutGoods;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStaffs]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_GetStaffs] 
as begin 
	select * from vw_GetStaffs  ;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStockingGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetStockingGoods] as
begin
	select * from vw_GetStockingGoods;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStockManagers]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_GetStockManagers] 
as begin 
	select * from vw_GetStockManagers  ;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_GetStopSellingGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_GetStopSellingGoods] as
begin
	select * from vw_GetStopSellingGoods;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[sp_InsertBill](@bid int, @gname nvarchar(50), @eid int, @quantity int, @bdate datetime = null) as
begin
	declare @gid int;
	exec @gid = ft_GetGoodId @gname;
	declare @goodPrice as float;
	declare @totalPrice as float;
	exec @goodPrice = ft_getPrice @id = @gid;
	set @totalPrice = @goodPrice * @quantity;
	if (@bdate is not null)
		insert into Bills values (@bid, @gid, @eid, @quantity, @bdate, @totalPrice);
	else	
		insert into Bills values (@bid, @gid, @eid, @quantity, getdate(), @totalPrice);
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertCashFlow]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertCashFlow]
	@time datetime,
	@source varchar(10), 
	@id int, 
	@amount float
as
begin
	declare @check int, @day date;
	set @day = cast(@time as date);
	select @check = count(*) from Cash_flow 
	where @day = cast(time as date) and amount = 0;
	if (@check = 0)
		insert into Cash_flow values (@time, 'TEMP', 0, 0);

	insert into Cash_flow(time, source, id, amount) 
	values(@time, @source, @id, @amount);
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertContract]
	@cid int,
	@gname nvarchar(50),
	@unit nvarchar(15) = null,
	@gprice float = null,
	@gphoto varchar(255) = null, 
	@pname nvarchar(100), 
	@paddress nvarchar(100) = null, 
	@pphoneNumber varchar(10) = null, 
	@eid int, 
	@date datetime = null,
	@cquantity int, 
	@cprice float
as
begin
	begin transaction;
	if @gname not in (select gname from Goods) begin
		exec sp_InsertGoods @gname, @unit, @gprice, @gphoto;
		declare @checkGname bit;
		exec @checkGname = ft_CheckGoodsName @gname;
		if (@checkGname = 0) begin
			print 'Can not add new good name: ' + @gname;
			commit;
			return;
		end
	end

	if @pname not in (select pname from Providers) begin
		exec sp_InsertProvider @pname, @paddress, @pphoneNumber;
		declare @checkPname bit;
		exec @checkPname = ft_CheckProviderName @pname;
		if (@checkPname = 0) begin
			print 'Can not add new provider: ' + @pname;
			rollback;
		end
	end

	declare @gid int, @pid int, @temp datetime;
	exec @gid = ft_GetGoodId @gname;
	exec @pid = ft_GetProviderId @pname;

	if (@date is null)
		set @temp = getdate();
	else 
		set @temp = @date;
	insert into Contracts values (@cid, @gid, @eid, @pid, @temp, @cquantity, @cprice);
	commit transaction
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertEmployee](
	@name nvarchar(50), 
	@birthday varchar(10), 
	@address nvarchar(100), 
	@gender bit, 
	@phoneNumber varchar(10), 
	@role varchar(13), 
	@photo nvarchar(255) = null)
as begin 
	if (@phoneNumber in (select ephoneNumber from Employee)) begin
		print 'Phone number already in use';
		return;
	end
	--declare @identity int;
	--select @identity = max(employee_id) from Employee;
	--dbcc checkident('Employee', RESEED, @identity);
	--dbcc checkident('Employee', RESEED, @identity);

	declare @salaryPerDay float;
	if @role like 'STAFF' begin 
		set @salaryPerDay = 160000; end;
	if @role like 'STOCK MANAGER' begin 
		set @salaryPerDay = 200000; end;
	if @role like 'ADMIN' begin 
		set @salaryPerDay = 0; end;
	if @photo is not null
		set @photo = @photo + @phoneNumber + '.png';
	insert into Employee(ename, birthday, eaddress, gender, ephoneNumber, 
						salaryPerDay, password, role, ephoto)
	values (@name, @birthday, @address, @gender, @phoneNumber, 
                   @salaryPerDay, @phoneNumber, @role, @photo);
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertGoods](
	@name nvarchar(50), 
	@unit nvarchar(15),
	@price float,
	@photo nvarchar(255)) as
begin
	--declare @identity int;
	--select @identity = max(goods_id) from Goods;
	--dbcc checkident('Goods', RESEED, @identity);
	--dbcc checkident('Goods', RESEED, @identity);

	insert into Goods (gname, unit, gprice, gphoto)
	values (@name, @unit, @price, @photo)
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertLogin]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertLogin] (@day date = null, @eid int)
as begin
	declare @check bit, @temp date;
	if (@day is null)
		set @temp = cast(getdate() as date);
	else 
		set @temp = @day;
	exec @check = ft_FirstLoginInDay @eid, @temp;
	if (@check = 1) begin
		insert into Login_manager values (@eid, @temp);
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_InsertProvider]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_InsertProvider]
@name nvarchar(100),
@address nvarchar(100), 
@phoneNumber varchar(20)
as
begin
	declare @identity int;
	select @identity = max(provider_id) from Providers;
	dbcc checkident('Providers', RESEED, @identity);
	dbcc checkident('Providers', RESEED, @identity);
	insert into Providers(pname, paddress, pphoneNumber) values(@name, @address, @phoneNumber);
end
GO
/****** Object:  StoredProcedure [dbo].[sp_LoadProfile]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_LoadProfile] @id int
as 
select * from Employee where employee_id = @id
GO
/****** Object:  StoredProcedure [dbo].[sp_ResetWorkDaysAllEmployees]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_ResetWorkDaysAllEmployees] as
begin
	update Employee set monthSalary = workDays * salaryPerDay, workDays=0
	where workDays > 0;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SearchBill]
	@id int = null,
	@eid int = null,
	@ename nvarchar(50) = null,
	@gid int = null,
	@gname nvarchar(50) = null
as begin 
	if (@id is not null) 
		select * from vw_GetAllBills
		where BID = @id;
	else if (@eid is not null)
		select * from vw_GetAllBills
		where EID = @eid;
	else if (@ename is not null)
		select * from vw_GetAllBills
		where [Employee Name] like concat('%', @ename, '%');
	else if (@gid is not null)
		select * from vw_GetAllBills
		where GID = @gid;
	else if (@gname is not null)
		select * from vw_GetAllBills
		where [Goods Name] like concat('%', @gname, '%');
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchContracts]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SearchContracts](
	@cid int = null,
	@gid int = null,
	@gname nvarchar(50) = null,
	@eid int = null,
	@ename nvarchar(50) = null,
	@pid int = null,
	@pname nvarchar(100) = null)
as begin
	if (@cid is not null)
		select * from vw_GetAllContracts where [CID] = @cid;
	else if (@gid is not null)
		select * from vw_GetAllContracts where [GID] = @gid;
	else if (@gname is not null)
		select * from vw_GetAllContracts where [Goods name] like concat('%', @gname, '%');
	else if (@eid is not null)
		select * from vw_GetAllContracts where [EID] = @eid;
	else if (@ename is not null)
		select * from vw_GetAllContracts where [Employee name] like concat('%', @ename, '%');
	else if (@pid is not null) begin
		declare @temp nvarchar(100);
		select @temp = pname from Providers where provider_id = @pid;
		select * from vw_GetAllContracts where [Provider name] = @temp;
	end
	else if (@pname is not null)
		select * from vw_GetAllContracts where [Provider name] like concat('%', @pname, '%');
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SearchEmployee] (
	@id int = null,
	@name nvarchar(50) = null,
	@phoneNumber varchar(12) = null,
	@address nvarchar(100) = null,
	@all nvarchar(100) = null,
	@role varchar(20) = null)
as begin
	if (@role is null) begin
		if (@id is not null)
			select * from vw_GetAllEmployees where ID = @id;
		else if (@name is not null)
			select * from vw_GetAllEmployees where Name like concat('%', @name, '%');
		else if (@phoneNumber is not null)
			select * from vw_GetAllEmployees where [Phone Number] like concat(@phoneNumber, '%');
		else if (@address is not null)
			select * from vw_GetAllEmployees where [Address] like concat('%', @address, '%');
		else
			select * from vw_GetAllEmployees 
			where Name like concat('%', @all, '%') 
				or [Phone Number] like concat(@all, '%') 
				or [Address] like concat('%', @all, '%');
	end
	else if (@role = 'ADMIN')
		select employee_id as ID, ename as Name, birthday as Birthday, 
			eaddress as Address, case when gender = 1 then 'Nam' else N'Nữ' end as Gender, 
			ephoneNumber as 'Phone Number', workDays as 'Salary Days', salaryPerDay as 'Daily Wage', 
			monthSalary as 'Month Salary', password as Password, role as Role, 
			case when estate = 1 then 'Still work' else 'Quit job' end as State, 
			ephoto as 'Emp Image' 
		from Employee 
		where role = 'ADMIN'; 
	else if (@role = 'STAFF') begin
		if (@id is not null)
			select * from vw_GetStaffs where ID = @id;
		else if (@name is not null)
			select * from vw_GetStaffs where Name like concat('%', @name, '%');
		else if (@phoneNumber is not null)
			select * from vw_GetStaffs where [Phone Number] like concat(@phoneNumber, '%');
		else if (@address is not null)
			select * from vw_GetStaffs where [Address] like concat('%', @address, '%');
		else
			select * from vw_GetStaffs 
			where Name like concat('%', @all, '%') 
				or [Phone Number] like concat(@all, '%') 
				or [Address] like concat('%', @all, '%');
	end
	else if (@role = 'STOCK MANAGER') begin
		if (@id is not null)
			select * from vw_GetStockManagers where ID = @id;
		else if (@name is not null)
			select * from vw_GetStockManagers where Name like concat('%', @name, '%');
		else if (@phoneNumber is not null)
			select * from vw_GetStockManagers where [Phone Number] like concat(@phoneNumber, '%');
		else if (@address is not null)
			select * from vw_GetStockManagers where [Address] like concat('%', @address, '%');
		else
			select * from vw_GetStockManagers 
			where Name like concat('%', @all, '%') 
				or [Phone Number] like concat(@all, '%') 
				or [Address] like concat('%', @all, '%');
	end
	else if (@role = 'RETIRED EMPLOYEE') begin
		if (@id is not null)
			select * from vw_GetAllRetiredEmployee where ID = @id;
		else if (@name is not null)
			select * from vw_GetAllRetiredEmployee where Name like concat('%', @name, '%');
		else if (@phoneNumber is not null)
			select * from vw_GetAllRetiredEmployee where [Phone Number] like concat(@phoneNumber, '%');
		else if (@address is not null)
			select * from vw_GetAllRetiredEmployee where [Address] like concat('%', @address, '%');
		else
			select * from vw_GetAllRetiredEmployee 
			where Name like concat('%', @all, '%') 
				or [Phone Number] like concat(@all, '%') 
				or [Address] like concat('%', @all, '%');
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_SearchGoods] (
	@id int = null,
	@name nvarchar(50) = null,
	@state varchar(12) = null)
as begin
	if (@state is null) begin
		if (@id is not null)
			select * from vw_GetAllGoodsWithProfit where ID = @id;
		else if (@name is not null)
			select * from vw_GetAllGoodsWithProfit where Name like concat('%',@name,'%');
	end
	else if (@state = 'STOCKING') begin
		if (@id is not null)
			select * from vw_GetStockingGoods where ID = @id;
		else if (@name is not null)
			select * from vw_GetStockingGoods where Name like concat('%',@name,'%');
	end
	else if (@state = 'SOLD OUT') begin
		if (@id is not null)
			select * from vw_GetSoldOutGoods where ID = @id;
		else if (@name is not null)
			select * from vw_GetSoldOutGoods where Name like concat('%',@name,'%');
	end
	else begin
		if (@id is not null)
			select * from vw_GetStopSellingGoods where ID = @id;
		else if (@name is not null)
			select * from vw_GetStopSellingGoods where Name like concat('%',@name,'%');
	end
end
GO
/****** Object:  StoredProcedure [dbo].[sp_SearchProvider]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[sp_SearchProvider]
	@id int = null,
	@name nvarchar(100) = null
as begin
	if @id is not null
		select * from vw_GetAllProviders where ID = @id;
	else if @name is not null
		select * from vw_GetAllProviders where Name like concat('%', @name, '%');
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateBill](
	@bid int, 
	@eid int = null,
	@time datetime = null,
	@gid int = null,
	@quantity int = null ) as
begin
	if (@eid is not null) 
		update Bills set employee_id = @eid, bdate = @time where bill_id = @bid;
	if (@gid is not null) begin
		declare @goodPrice as float, @totalPrice as float;
		exec @goodPrice = ft_getPrice @id = @gid;
		set @totalPrice = @goodPrice * @quantity;

		update Bills set bquantity = @quantity, bprice=@totalPrice
		where bill_id=@bid and goods_id=@gid;
	end
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateCashFlow]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE procedure [dbo].[sp_UpdateCashFlow]
	@time datetime = null,
	@source varchar(10), 
	@id int, 
	@amount float = null
as
begin
	if (@time is not null)
		update Cash_flow set time = @time where source = @source and id = @id;
	if (@amount is not null)
		update Cash_flow set amount = @amount where source = @source and id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateContract]
	@cid int,
	@gname nvarchar(50),
	@unit nvarchar(15) = null,
	@gprice float = null,
	@gphoto varchar(255) = null, 
	@pname nvarchar(100), 
	@paddress nvarchar(100) = null, 
	@pphoneNumber varchar(15) = null, 
	@eid int, 
	@cdate datetime,
	@cquantity int, 
	@cprice float
as
begin
	begin transaction;
	if @gname not in (select gname from Goods) begin
		exec sp_InsertGoods @gname, @unit, @gprice, @gphoto;
		declare @checkGname bit;
		exec @checkGname = ft_CheckGoodsName @gname;
		if (@checkGname = 0) begin
			print 'Can not add new good name: ' + @gname;
			rollback;
		end
	end
	if @pname not in (select pname from Providers) begin
		exec sp_InsertProvider @pname, @paddress, @pphoneNumber;
		declare @checkPname bit;
		exec @checkPname = ft_CheckProviderName @pname;
		if (@checkPname = 0) begin
			print 'Can not add new provider: ' + @pname;
			rollback;
		end
	end
	declare @gid int, @pid int;
	exec @gid = ft_GetGoodId @gname;
	exec @pid = ft_GetProviderId @pname;
	update Contracts
	set employee_id = @eid, provider_id = @pid, cdate = @cdate, cquantity = @cquantity, cprice = @cprice
	where contract_id = @cid and goods_id = @gid;
	commit transaction
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateEmployee]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[sp_UpdateEmployee](
	@id int,
	@name nvarchar(50) = null, 
	@birthday date = null, 
	@address nvarchar(100) = null, 
	@gender bit = null, 
	@phoneNumber varchar(10) = null, 
	@salary float = null,
	@workingDays int = null,
	@password varchar(20) = null, 
	@role varchar(13) = null, 
	@state bit = null,
	@photo varchar(255) = null)
as begin 
	if (@name is not null)
		update Employee set ename = @name, birthday = @birthday,eaddress = @address, gender = @gender, ephoneNumber = @phoneNumber,
			salaryPerDay = @salary, workDays = @workingDays, role = @role, ephoto = @photo
		where employee_id = @id;
	if (@state is not null)
		update Employee set estate = @state where employee_id = @id;
	if (@password is not null)
		update Employee set password = @password where employee_id = @id;
end;
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateGoods]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateGoods] (
	@id int,
	@name nvarchar(50) = null, 
	@unit nvarchar(15) = null,
	@price float = null,
	@state bit = null,
	@photo nvarchar(255) = null, 
	@forceUpdatePhoto bit = 0)
as begin
	if (@name is not null)
		update Goods
		set gname = @name
		where goods_id = @id;
	if (@unit is not null)
		update Goods
		set unit = @unit
		where goods_id = @id;
	if (@price is not null)
		update Goods
		set gprice = @price
		where goods_id = @id;
	if (@state is not null)
		update Goods
		set gstate = @state
		where goods_id = @id;
	if (@photo is not null or @forceUpdatePhoto = 1)
		update Goods
		set gphoto = @photo
		where goods_id = @id;
end
GO
/****** Object:  StoredProcedure [dbo].[sp_UpdateProvider]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[sp_UpdateProvider]
@id int, 
@name nvarchar(100), 
@address nvarchar(100), 
@phoneNumber varchar(20), 
@state bit
as
begin
	update Providers set pname = @name, paddress = @address, pphoneNumber = @phoneNumber, pstate = @state
	where provider_id = @id;
end
GO
/****** Object:  Trigger [dbo].[tg_ChangeQuantityGoodsForDeleteBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_ChangeQuantityGoodsForDeleteBill] on [dbo].[Bills] for delete
as begin
	declare @oldQuantity int, @gid int;
	declare cursorBill cursor for select bquantity, goods_id from deleted;
	open cursorBill;
	fetch next from cursorBill into @oldQuantity, @gid;
	while (@@FETCH_STATUS = 0) begin
		update Goods set gquantity += @oldQuantity where goods_id=@gid;
	fetch next from cursorBill into @oldQuantity, @gid;
	end
	close cursorBill;
	deallocate cursorBill;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_ChangeQuantityGoodsForDeleteBill]
GO
/****** Object:  Trigger [dbo].[tg_ChangeQuantityGoodsForUpdateBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_ChangeQuantityGoodsForUpdateBill] on [dbo].[Bills] for update
as begin
	declare @oldQuantity int, @newQuantity int, @gid int;
	select @oldQuantity = old.bquantity, @newQuantity=new.bquantity, @gid=new.goods_id 
	from inserted new, deleted old;

	update Goods set gquantity += @oldQuantity - @newQuantity
	where goods_id=@gid;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_ChangeQuantityGoodsForUpdateBill]
GO
/****** Object:  Trigger [dbo].[tg_DeleteRevenue]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_DeleteRevenue] on [dbo].[Bills]
for delete as
begin
	declare @bid int, @amount float;
	declare cursorBill cursor for select bill_id, -bprice from deleted;
	open cursorBill;
	fetch next from cursorBill into @bid, @amount;
	while (@@FETCH_STATUS = 0) begin
		exec sp_AddAmountToSource 'BILL', @bid, @amount;
		fetch next from cursorBill into @bid, @amount;
	end
	close cursorBill;
	deallocate cursorBill;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_DeleteRevenue]
GO
/****** Object:  Trigger [dbo].[tg_GetRevenue]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_GetRevenue] on [dbo].[Bills]
for insert as
begin
	declare @bid int, @amount float, @time datetime;
	select @bid = bill_id, @amount = bprice, @time = bdate from inserted;
	declare @check bit;
	exec @check = dbo.ft_ContainSource 'BILL', @bid;
	if (@check = 1)
		exec sp_AddAmountToSource 'BILL', @bid, @amount;
	else
		exec sp_InsertCashFlow @time, 'BILL', @bid, @amount;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_GetRevenue]
GO
/****** Object:  Trigger [dbo].[tg_ReduceQuantityGoodsForInsertBill]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_ReduceQuantityGoodsForInsertBill] on [dbo].[Bills] for insert
as begin
	declare @quantity int, @gid int;
	select @quantity = bquantity, @gid=goods_id from inserted;

	update Goods set gquantity -= @quantity where goods_id=@gid;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_ReduceQuantityGoodsForInsertBill]
GO
/****** Object:  Trigger [dbo].[tg_UpdateRevenue]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_UpdateRevenue] on [dbo].[Bills]
for update as
begin
	declare @bid int, @oldAmount float, @newAmount float;
	declare cursorBill cursor for select i.bill_id, d.bprice, i.bprice from inserted i
		inner join deleted d on i.bill_id = d.bill_id and i.goods_id = d.goods_id;
	open cursorBill;
	fetch next from cursorBill into @bid, @oldAmount, @newAmount;
	while (@@FETCH_STATUS = 0) begin
		declare @change float = @newAmount - @oldAmount;
		exec sp_AddAmountToSource 'BILL', @bid, @change;
		fetch next from cursorBill into @bid, @oldAmount, @newAmount;
	end
	close cursorBill;
	deallocate cursorBill;
end
GO
ALTER TABLE [dbo].[Bills] ENABLE TRIGGER [tg_UpdateRevenue]
GO
/****** Object:  Trigger [dbo].[tg_DeleteEmptySource]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_DeleteEmptySource] on [dbo].[Cash_flow]
for update, delete
as begin	
	declare @source varchar(10), @id int, @amount float;
	select @source = source, @id = id, @amount = amount from inserted;
	if (@amount = 0 and @source != 'TEMP')
		exec sp_DeleteCashFlow @source, @id;
end
GO
ALTER TABLE [dbo].[Cash_flow] ENABLE TRIGGER [tg_DeleteEmptySource]
GO
/****** Object:  Trigger [dbo].[tg_AddQuantity]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_AddQuantity] on [dbo].[Contracts]
for insert as
begin
	declare @good_id int, @cquantity int;
	select @cquantity = inserted.cquantity, @good_id = inserted.goods_id
	from inserted;
	update Goods set gquantity += @cquantity, gstate = 1 where goods_id = @good_id;
end
GO
ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [tg_AddQuantity]
GO
/****** Object:  Trigger [dbo].[tg_DeleteSpendFromContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_DeleteSpendFromContract] on [dbo].[Contracts] 
for delete as
begin
	declare @cid int, @gid int, @quantity int, @amount float;
	declare cursorCont cursor for select contract_id, goods_id, cquantity, cprice from deleted;
	open cursorCont;
	fetch next from cursorCont into @cid, @gid, @quantity, @amount;
	while (@@FETCH_STATUS = 0) begin
		exec sp_AddAmountToSource 'CONTRACT', @cid, @amount;
		update Goods set gquantity -= @quantity where goods_id = @gid;
		fetch next from cursorCont into @cid, @gid, @quantity, @amount;
	end
	close cursorCont;
	deallocate cursorCont;
end
GO
ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [tg_DeleteSpendFromContract]
GO
/****** Object:  Trigger [dbo].[tg_GetSpendFromContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE trigger [dbo].[tg_GetSpendFromContract] on [dbo].[Contracts] 
for insert as
begin
	declare @cid int, @amount float, @time datetime;
	select @cid = contract_id, @amount = -cprice, @time = cdate from inserted;
	declare @check bit;
	exec @check = dbo.ft_ContainSource 'CONTRACT', @cid;
	if (@check = 1)
		exec sp_AddAmountToSource 'CONTRACT', @cid, @amount;
	else
		exec sp_InsertCashFlow @time, 'CONTRACT', @cid, @amount;
end
GO
ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [tg_GetSpendFromContract]
GO
/****** Object:  Trigger [dbo].[tg_UpdateQuantity]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_UpdateQuantity] on [dbo].[Contracts]
for update as
begin
	declare @good_id int, @icquantity int, @dcquantity int;
	select @icquantity = inserted.cquantity, @dcquantity = deleted.cquantity, @good_id = deleted.goods_id
	from inserted, deleted;
	update Goods set gquantity = gquantity - @dcquantity + @icquantity, gstate = 1 
	where goods_id = @good_id;
end
GO
ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [tg_UpdateQuantity]
GO
/****** Object:  Trigger [dbo].[tg_UpdateSpendFromContract]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_UpdateSpendFromContract] on [dbo].[Contracts] 
for update as
begin
	declare @cid int, @oldAmount float, @newAmount float;
	declare cursorCont cursor for select i.contract_id, -d.cprice, -i.cprice from inserted i
		inner join deleted d on i.contract_id = d.contract_id and i.goods_id = d.goods_id;
	open cursorCont;
	fetch next from cursorCont into @cid, @oldAmount, @newAmount;
	while (@@FETCH_STATUS = 0) begin
		declare @change float = @newAmount - @oldAmount;
		exec sp_AddAmountToSource 'CONTRACT', @cid, @change;
		fetch next from cursorCont into @cid, @oldAmount, @newAmount;
	end
	close cursorCont;
	deallocate cursorCont;
end
GO
ALTER TABLE [dbo].[Contracts] ENABLE TRIGGER [tg_UpdateSpendFromContract]
GO
/****** Object:  Trigger [dbo].[tg_GetSpendFromSalary]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_GetSpendFromSalary] on [dbo].[Employee] 
for update as
begin
	declare @eid int, @monthSalary float, @workDay int;
	declare cursorEmp cursor for
	select employee_id, -monthSalary, workDays from inserted;

	open cursorEmp;
	fetch next from cursorEmp into @eid, @monthSalary, @workDay;
	while (@@FETCH_STATUS = 0) begin
		if (@monthSalary > 0 and @workDay = 0) begin
			declare @time datetime = getdate();
			exec sp_InsertCashFlow @time, 'SALARY', @eid, @monthSalary;
		end
		fetch next from cursorEmp into @eid, @monthSalary, @workDay;
	end
	close cursorEmp;
	deallocate cursorEmp;
end
GO
ALTER TABLE [dbo].[Employee] ENABLE TRIGGER [tg_GetSpendFromSalary]
GO
/****** Object:  Trigger [dbo].[tg_AddWorkDay]    Script Date: 11/18/2021 12:07:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create trigger [dbo].[tg_AddWorkDay] on [dbo].[Login_manager]
for insert
as begin
	declare @time date, @eid int, @check bit;
	select @time = time, @eid = eid from inserted;
	exec @check = ft_FirstLoginInMonth @time;
	if (@check = 1)
		exec sp_ResetWorkDaysAllEmployees;
	exec sp_AddWorkDay @eid;
end
GO
ALTER TABLE [dbo].[Login_manager] ENABLE TRIGGER [tg_AddWorkDay]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[41] 4[20] 2[12] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "b"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 163
               Left = 453
               Bottom = 326
               Right = 652
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 27
               Left = 702
               Bottom = 190
               Right = 896
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "temp"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 10
         Width = 284
         Width = 1200
         Width = 1200
         Width = 3744
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 2520
         Width = 2652
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1620
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllBills'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllBills'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllBills'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "c"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "p"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "g"
            Begin Extent = 
               Top = 343
               Left = 48
               Bottom = 506
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "e"
            Begin Extent = 
               Top = 511
               Left = 48
               Bottom = 674
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "temp"
            Begin Extent = 
               Top = 7
               Left = 290
               Bottom = 126
               Right = 484
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllContracts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllContracts'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Employee"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 9
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1992
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllEmployees'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllEmployees'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[28] 4[33] 2[25] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Goods"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 2004
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllGoodsWithProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllGoodsWithProfit'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Providers"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 248
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllProviders'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllProviders'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Employee"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 9
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllRetiredEmployee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetAllRetiredEmployee'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_GetAllGoodsWithProfit"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetSoldOutGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetSoldOutGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_GetAllEmployees"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStaffs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStaffs'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_GetAllGoodsWithProfit"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStockingGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStockingGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_GetAllEmployees"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 1524
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStockManagers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStockManagers'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "vw_GetAllGoodsWithProfit"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 242
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStopSellingGoods'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'vw_GetStopSellingGoods'
GO

-- Store procedure, function
grant execute to admin, staff, stockmanager
go

deny execute on dbo.sp_GetAllContracts to staff
go
deny execute on dbo.sp_GetAllProviders to staff
go
deny execute on dbo.sp_GetAllEmployees to staff
go
deny execute on dbo.sp_GetAllGoodsWithProfit to staff
go
deny execute on dbo.sp_GetCashFlow to staff
go

deny execute on dbo.sp_GetAllBills to stockmanager
go
deny execute on dbo.sp_GetAllEmployees to stockmanager
go
deny execute on dbo.sp_GetCashFlow to stockmanager
go

USE [master]
GO
ALTER DATABASE [GroceryStore] SET  READ_WRITE 
GO
