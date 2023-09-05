USE [master]
GO
/****** Object:  Database [db_scep]    Script Date: 05/09/2023 15:25:03 ******/
CREATE DATABASE [db_scep]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'db_scep', FILENAME = N'/var/opt/mssql/data/db_scep.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'db_scep_log', FILENAME = N'/var/opt/mssql/data/db_scep_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [db_scep] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [db_scep].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [db_scep] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [db_scep] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [db_scep] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [db_scep] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [db_scep] SET ARITHABORT OFF 
GO
ALTER DATABASE [db_scep] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [db_scep] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [db_scep] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [db_scep] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [db_scep] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [db_scep] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [db_scep] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [db_scep] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [db_scep] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [db_scep] SET  ENABLE_BROKER 
GO
ALTER DATABASE [db_scep] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [db_scep] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [db_scep] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [db_scep] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [db_scep] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [db_scep] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [db_scep] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [db_scep] SET RECOVERY FULL 
GO
ALTER DATABASE [db_scep] SET  MULTI_USER 
GO
ALTER DATABASE [db_scep] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [db_scep] SET DB_CHAINING OFF 
GO
ALTER DATABASE [db_scep] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [db_scep] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [db_scep] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [db_scep] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'db_scep', N'ON'
GO
ALTER DATABASE [db_scep] SET QUERY_STORE = ON
GO
ALTER DATABASE [db_scep] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [db_scep]
GO
/****** Object:  Table [dbo].[tb_address]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_address](
	[id_address] [int] IDENTITY(1,1) NOT NULL,
	[cep] [varchar](9) NOT NULL,
	[city] [varchar](70) NOT NULL,
	[district] [varchar](70) NOT NULL,
	[street] [varchar](70) NOT NULL,
	[uf] [varchar](2) NULL,
	[number] [varchar](10) NOT NULL,
	[apartment] [varchar](50) NULL,
	[apartment_block] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[id_address] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_cep]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_cep](
	[cep] [varchar](9) NULL,
	[address] [varchar](100) NULL,
	[city] [varchar](100) NULL,
	[district] [varchar](100) NULL,
	[uf] [varchar](2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_client]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_client](
	[id_client] [int] IDENTITY(1,1) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[landline_phone] [varchar](14) NULL,
	[cell_phone] [varchar](15) NULL,
	[address_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_client] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_login]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_login](
	[id_login] [int] IDENTITY(1,1) NOT NULL,
	[cpf] [varchar](14) NOT NULL,
	[first_name] [varchar](150) NOT NULL,
	[last_name] [varchar](150) NOT NULL,
	[email] [varchar](200) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL,
	[status] [varchar](40) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_order]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_order](
	[id_order] [int] IDENTITY(1,1) NOT NULL,
	[order_date] [date] NOT NULL,
	[delivery_date] [date] NULL,
	[payment_method] [varchar](50) NULL,
	[client_id] [int] NOT NULL,
	[sellers_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_order] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_order_product]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_order_product](
	[id_order_prod] [int] IDENTITY(1,1) NOT NULL,
	[quantity] [int] NOT NULL,
	[final_price] [int] NOT NULL,
	[order_id] [int] NOT NULL,
	[prod_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_order_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_products]    Script Date: 05/09/2023 15:25:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_products](
	[id_prod] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](200) NOT NULL,
	[category] [varchar](50) NULL,
	[amount] [int] NOT NULL,
	[cost_price] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id_prod] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_login] ADD  DEFAULT ('seller') FOR [type]
GO
ALTER TABLE [dbo].[tb_login] ADD  DEFAULT ('active') FOR [status]
GO
ALTER TABLE [dbo].[tb_client]  WITH CHECK ADD FOREIGN KEY([address_id])
REFERENCES [dbo].[tb_address] ([id_address])
GO
ALTER TABLE [dbo].[tb_order]  WITH CHECK ADD FOREIGN KEY([client_id])
REFERENCES [dbo].[tb_client] ([id_client])
GO
ALTER TABLE [dbo].[tb_order]  WITH CHECK ADD FOREIGN KEY([sellers_id])
REFERENCES [dbo].[tb_login] ([id_login])
GO
ALTER TABLE [dbo].[tb_order_product]  WITH CHECK ADD FOREIGN KEY([order_id])
REFERENCES [dbo].[tb_order] ([id_order])
GO
ALTER TABLE [dbo].[tb_order_product]  WITH CHECK ADD FOREIGN KEY([prod_id])
REFERENCES [dbo].[tb_products] ([id_prod])
GO
USE [master]
GO
ALTER DATABASE [db_scep] SET  READ_WRITE 
GO
