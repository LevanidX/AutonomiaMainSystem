USE [master]
GO
/****** Object:  Database [AUTONOMIA]    Script Date: 21.06.2023 18:31:18 ******/
CREATE DATABASE [AUTONOMIA]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AUTONOMIA', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AUTONOMIA.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AUTONOMIA_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\AUTONOMIA_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [AUTONOMIA] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AUTONOMIA].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [AUTONOMIA] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [AUTONOMIA] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [AUTONOMIA] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [AUTONOMIA] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [AUTONOMIA] SET ARITHABORT OFF 
GO
ALTER DATABASE [AUTONOMIA] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [AUTONOMIA] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [AUTONOMIA] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [AUTONOMIA] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [AUTONOMIA] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [AUTONOMIA] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [AUTONOMIA] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [AUTONOMIA] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [AUTONOMIA] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [AUTONOMIA] SET  ENABLE_BROKER 
GO
ALTER DATABASE [AUTONOMIA] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [AUTONOMIA] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [AUTONOMIA] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [AUTONOMIA] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [AUTONOMIA] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [AUTONOMIA] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [AUTONOMIA] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [AUTONOMIA] SET RECOVERY FULL 
GO
ALTER DATABASE [AUTONOMIA] SET  MULTI_USER 
GO
ALTER DATABASE [AUTONOMIA] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [AUTONOMIA] SET DB_CHAINING OFF 
GO
ALTER DATABASE [AUTONOMIA] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [AUTONOMIA] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [AUTONOMIA] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [AUTONOMIA] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'AUTONOMIA', N'ON'
GO
ALTER DATABASE [AUTONOMIA] SET QUERY_STORE = ON
GO
ALTER DATABASE [AUTONOMIA] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [AUTONOMIA]
GO
/****** Object:  Table [dbo].[car_brands]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car_brands](
	[car_brand_ID] [int] IDENTITY(1000,1) NOT NULL,
	[car_brand_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_brand_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car_models]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car_models](
	[car_model_ID] [int] IDENTITY(10000,1) NOT NULL,
	[car_model_brand_ID] [int] NOT NULL,
	[car_model_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_model_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[car_services]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[car_services](
	[car_service_ID] [int] IDENTITY(5000,1) NOT NULL,
	[car_service_name] [varchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[car_service_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detail_services]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detail_services](
	[detail_service_ID] [int] IDENTITY(50000,1) NOT NULL,
	[detail_service_car_service_ID] [int] NOT NULL,
	[detail_service_name] [varchar](200) NOT NULL,
	[detail_service_minimum_price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[detail_service_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[auto_orders]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[auto_orders](
	[auto_order_ID] [int] IDENTITY(500,1) NOT NULL,
	[auto_order_client_name] [varchar](100) NOT NULL,
	[auto_order_client_phone_number] [varchar](20) NOT NULL,
	[auto_order_car_brand_ID] [int] NOT NULL,
	[auto_order_car_model_ID] [int] NOT NULL,
	[auto_order_car_service_ID] [int] NOT NULL,
	[auto_order_detail_service_ID] [int] NOT NULL,
	[auto_order_price] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[auto_order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[auto_orders_view]    Script Date: 21.06.2023 18:31:18 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE VIEW [dbo].[auto_orders_view]
AS
SELECT auto_order_ID, auto_order_client_name, auto_order_client_phone_number, car_brand_name,
	car_model_name, car_service_name, detail_service_name, auto_order_price
FROM auto_orders, car_brands, car_models, car_services, detail_services
WHERE auto_order_car_brand_ID = car_brand_ID AND
	auto_order_car_model_ID = car_model_ID AND
	auto_order_car_service_ID = car_service_ID AND
	auto_order_detail_service_ID = detail_service_ID
GO
SET IDENTITY_INSERT [dbo].[auto_orders] ON 

INSERT [dbo].[auto_orders] ([auto_order_ID], [auto_order_client_name], [auto_order_client_phone_number], [auto_order_car_brand_ID], [auto_order_car_model_ID], [auto_order_car_service_ID], [auto_order_detail_service_ID], [auto_order_price]) VALUES (500, N'Степан', N'79210945081', 1000, 10004, 5001, 50043, 1790)
INSERT [dbo].[auto_orders] ([auto_order_ID], [auto_order_client_name], [auto_order_client_phone_number], [auto_order_car_brand_ID], [auto_order_car_model_ID], [auto_order_car_service_ID], [auto_order_detail_service_ID], [auto_order_price]) VALUES (501, N'Александр', N'79201940104', 1011, 10048, 5011, 50146, 1390)
INSERT [dbo].[auto_orders] ([auto_order_ID], [auto_order_client_name], [auto_order_client_phone_number], [auto_order_car_brand_ID], [auto_order_car_model_ID], [auto_order_car_service_ID], [auto_order_detail_service_ID], [auto_order_price]) VALUES (502, N'Николай', N'79198219841', 1011, 10048, 5011, 50147, 1390)
SET IDENTITY_INSERT [dbo].[auto_orders] OFF
GO
SET IDENTITY_INSERT [dbo].[car_brands] ON 

INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1000, N'Skoda')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1001, N'Mazda')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1002, N'Ford')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1003, N'Opel')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1004, N'Audi')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1005, N'Hyundai')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1006, N'VW')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1007, N'Kia')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1008, N'Suzuki')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1009, N'Lada')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1010, N'Renault')
INSERT [dbo].[car_brands] ([car_brand_ID], [car_brand_name]) VALUES (1011, N'Haval')
SET IDENTITY_INSERT [dbo].[car_brands] OFF
GO
SET IDENTITY_INSERT [dbo].[car_models] ON 

INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10000, 1000, N'Fabia')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10002, 1000, N'Octavia')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10003, 1000, N'Rapid')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10004, 1000, N'Roomster')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10005, 1000, N'Karoq')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10006, 1000, N'Kodiaq')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10007, 1000, N'Yeti')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10008, 1001, N'2')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10009, 1001, N'3')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10010, 1001, N'5')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10011, 1001, N'6')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10012, 1001, N'CX-3')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10013, 1001, N'CX-5')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10015, 1001, N'CX-7')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10016, 1001, N'CX-9')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10018, 1001, N'MX-5')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10019, 1001, N'RX-8')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10020, 1001, N'TRIBUTE')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10022, 1001, N'BT-50')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10023, 1002, N'C-MAX')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10024, 1002, N'EcoSport')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10025, 1002, N'Fiesta')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10026, 1002, N'Focus')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10027, 1002, N'Fusion')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10028, 1002, N'Galaxy')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10029, 1002, N'Mondeo')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10030, 1002, N'S-MAX')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10031, 1002, N'Escape-Maverick')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10032, 1002, N'Explorer')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10033, 1002, N'Kuga')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10034, 1002, N'Ranger')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10035, 1002, N'Transit')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10036, 1002, N'Transit-Tourneo')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10037, 1003, N'Antara')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10038, 1003, N'Astra')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10039, 1003, N'Corsa')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10040, 1003, N'Insignia')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10041, 1003, N'Meriva')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10042, 1003, N'Mokka')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10043, 1003, N'Vectra')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10044, 1003, N'Zafira')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10045, 1004, N'A1')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10046, 1004, N'A3')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10047, 1004, N'A5')
INSERT [dbo].[car_models] ([car_model_ID], [car_model_brand_ID], [car_model_name]) VALUES (10048, 1011, N'F7')
SET IDENTITY_INSERT [dbo].[car_models] OFF
GO
SET IDENTITY_INSERT [dbo].[car_services] ON 

INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5000, N'Тормозная система')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5001, N'Ходовая часть')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5002, N'Рулевое управление')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5003, N'Двигатель')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5004, N'Топливная система')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5005, N'Коробка передач')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5006, N'Лампы')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5007, N'Отопление и кондиционер')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5008, N'Система охлаждения')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5009, N'Диагностика')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5010, N'Электрика')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5011, N'Техническое обслуживание')
INSERT [dbo].[car_services] ([car_service_ID], [car_service_name]) VALUES (5012, N'Профессиональная диагностика')
SET IDENTITY_INSERT [dbo].[car_services] OFF
GO
SET IDENTITY_INSERT [dbo].[detail_services] ON 

INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50000, 5000, N'Замена передних колодок', 1290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50001, 5000, N'Замена задних колодок', 1890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50002, 5000, N'Обслуживание суппортов', 390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50003, 5000, N'Замена заднего тормозного суппорта', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50004, 5000, N'Замена передних тормозных дисков', 1890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50005, 5000, N'Замена задних тормозных дисков', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50007, 5000, N'Замена передних тормозных дисков с колодками', 1990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50009, 5000, N'Замена задних тормозных дисков с колодками', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50010, 5000, N'Замена тормозных дисков и колодок', 3290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50011, 5000, N'Замена тормозной жидкости', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50012, 5000, N'Прокачка тормозной системы', 1090)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50013, 5000, N'Замена задних тормозных колодок (дисковые тормоза с электронным стояночным тормозом)', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50014, 5000, N'Замена тросика ручного тормоза', 2590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50015, 5000, N'Замена вакуумного насоса', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50016, 5000, N'Замена датчика АБС', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50017, 5000, N'Замена тормозного цилиндра', 5690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50018, 5000, N'Замена задних тормозных барабанов и колодок', 3490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50019, 5000, N'Замена передних тормозных шлангов', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50020, 5000, N'Замена вакуумного усилителя тормозов', 5190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50021, 5000, N'Замена задних тормозных шлангов', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50022, 5000, N'Замена тормозных барабанов', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50023, 5000, N'Замена выключателя стоп-сигнала', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50024, 5000, N'Замена модулятора АБС', 7690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50025, 5000, N'Регулировка стояночного тормоза', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50026, 5000, N'Замена бачка тормозной жидкости', 1990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50027, 5001, N'Шиномонтаж и балансировка', 2990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50028, 5001, N'Замена задних сайлентблоков', 4890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50029, 5001, N'Замена передних сайлентблоков', 7790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50030, 5001, N'Замена задних рычагов', 2990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50033, 5001, N'Замена передних рычагов', 2990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50036, 5001, N'Замена ступиц', 2990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50037, 5001, N'Замена левого продольного рычага задней подвески', 3890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50038, 5001, N'Замена правого продольного рычага задней подвески', 3890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50039, 5001, N'Замена поперечного подпружинного рычага', 3490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50040, 5001, N'Замена подшипников', 3190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50041, 5001, N'Замена стойки стабилизатора', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50042, 5001, N'Замена стабилизатора', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50043, 5001, N'Замена шаровой', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50044, 5001, N'Замена передних амортизаторов', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50045, 5001, N'Замена втулок стабилизатора', 1390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50046, 5001, N'Замена пружин', 1990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50047, 5002, N'Замена жидкости ГУР', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50048, 5002, N'Замена рулевой тяги', 4990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50049, 5002, N'Замена пыльника рулевой тяги', 1990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50051, 5002, N'Замена рулевого наконечника', 4590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50052, 5002, N'Замена насоса гидроусилителя ГУР', 3490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50053, 5002, N'Замена шланга высокого давления насоса ГУРа', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50054, 5002, N'Замена шланга низкого давления ГУРа', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50055, 5002, N'Замена рулевой рейки', 9990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50056, 5002, N'Замена обратного шланга рулевой рейки с усилителем', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50057, 5002, N'Замена бачка жидкости гидроусилителя', 1890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50058, 5002, N'Замена масла в гидроусилителе руля', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50060, 5003, N'Замена масла и масляного фильтра в двигателе', 1090)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50062, 5003, N'Замена воздушного фильтра', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50063, 5003, N'Замена свечей зажигания', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50064, 5003, N'Замена приводного ремня', 1290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50065, 5003, N'Замена ремня генератора', 890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50066, 5003, N'Замена ремня кондиционера', 1290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50067, 5003, N'Замена ГРМ', 6990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50068, 5003, N'Замена натяжного ролика приводного ремня', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50069, 5003, N'Замена водяного насоса', 4990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50070, 5003, N'Замена подушек двигателя', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50071, 5003, N'Замена стартера', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50072, 5003, N'Замена свечи накаливания', 1190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50073, 5003, N'Замена прокладки впускного коллектора', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50074, 5003, N'Замена прокладки выпускного коллектора', 5490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50075, 5003, N'Замена шкива коленвала', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50076, 5003, N'Замена кислородного датчика (лямбда зонд)', 1690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50077, 5003, N'Замена генератора', 3290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50078, 5003, N'Замена глушителя', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50079, 5003, N'Замена катушки зажигания\модуля зажигания', 1290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50080, 5004, N'Замена топливного фильтра, бензиновый двигатель', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50081, 5004, N'Замена топливного фильтра, дизельный двигатель', 1090)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50082, 5004, N'Замена топливного насоса (тнвд) бензиновый двигатель', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50083, 5004, N'Замена топливного насоса (тнвд) дизельный двигатель', 10190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50084, 5004, N'Замена топливного насоса', 2190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50085, 5005, N'Замена цилиндра сцепления', 15690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50086, 5005, N'Замена главного цилиндра сцепления', 5990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50087, 5005, N'Замена МКПП (переднеприводные версии)', 14790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50088, 5005, N'Замена МКПП (полноприводные версии)', 20790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50091, 5005, N'Замена АКПП (переднеприводные версии)', 18790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50092, 5005, N'Замена АКПП (полноприводные версии)', 28390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50093, 5005, N'Замена троса управления КПП', 3690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50094, 5005, N'Замена масла в АКПП', 2590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50095, 5005, N'Замена масла в DSG', 2590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50097, 5005, N'Снятие КПП', 10990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50099, 5005, N'Замена комплекта сцепления МКПП', 14490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50100, 5005, N'Замена сальника приводного вала', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50101, 5005, N'Замена правого переднего шарнира равных угловых скоростей', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50102, 5005, N'Замена карданного вала', 3990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50103, 5005, N'Замена масла в муфте подключения полного привода', 1190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50104, 5005, N'Замена пыльников шруса', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50105, 5005, N'Замена ШРУСа', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50106, 5005, N'Замена приводного вала', 1890)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50107, 5006, N'Замена ламп ближнего света', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50108, 5006, N'Замена ламп габарита', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50109, 5006, N'Замена ламп стоп-сигнала', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50110, 5006, N'Замена ламп противотуманных фар', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50112, 5006, N'Замена ламп ксенона', 990)
GO
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50113, 5006, N'Замена ламп дальнего света', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50115, 5006, N'Замена ламп заднего хода', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50116, 5007, N'Замена отопителя', 3790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50117, 5008, N'Замена охлаждающей жидкости', 1490)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50118, 5008, N'Замена вентилятора охлаждения', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50119, 5009, N'Проверка системы гидроусилителя рулевого управления на отсутствие течи', 390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50120, 5009, N'Диагностика подвески и рулевого управления', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50121, 5009, N'Диагностика АКБ', 390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50122, 5009, N'Компьютерная диагностика', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50123, 5009, N'Диагностика тормозной системы', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50124, 5009, N'Диагностика системы охлаждения', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50125, 5009, N'Диагностика шумов в двигателе', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50126, 5009, N'Диагностика утечки технических жидкостей', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50127, 5009, N'Диагностика системы кондиционирования', 2790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50128, 5009, N'Проверка системы охлаждения на отсутствие течи', 390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50129, 5009, N'Диагностика системы выпуска отработавших газов', 790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50130, 5010, N'Замена АКБ', 990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50131, 5010, N'Замена печки', 36290)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50132, 5010, N'Замена предохранителя', 390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50133, 5010, N'Замена стеклоочистителя лобового стекла в сборе', 1690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50134, 5010, N'Замена фары', 2390)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50135, 5010, N'Программирование блоков', 3690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50136, 5010, N'Замена противотуманных фар', 2590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50138, 5010, N'Замена замка двери', 1990)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50139, 5010, N'Замена замка зажигания', 1190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50140, 5010, N'Замена батарейки', 590)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50141, 5010, N'Адаптация АКПП/обновление ПО', 3690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50142, 5010, N'Программирование / Калибровка электрической рулевой рейки', 3690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50143, 5010, N'Замена модуля двигателя', 4790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50144, 5010, N'Замена заднего фонаря', 690)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50145, 5009, N'Полная диагностика', 3790)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50146, 5011, N'Замена масла в двигателе', 1190)
INSERT [dbo].[detail_services] ([detail_service_ID], [detail_service_car_service_ID], [detail_service_name], [detail_service_minimum_price]) VALUES (50147, 5011, N'Замена фильтров', 1090)
SET IDENTITY_INSERT [dbo].[detail_services] OFF
GO
ALTER TABLE [dbo].[auto_orders]  WITH CHECK ADD FOREIGN KEY([auto_order_car_brand_ID])
REFERENCES [dbo].[car_brands] ([car_brand_ID])
GO
ALTER TABLE [dbo].[auto_orders]  WITH CHECK ADD FOREIGN KEY([auto_order_car_model_ID])
REFERENCES [dbo].[car_models] ([car_model_ID])
GO
ALTER TABLE [dbo].[auto_orders]  WITH CHECK ADD FOREIGN KEY([auto_order_car_service_ID])
REFERENCES [dbo].[car_services] ([car_service_ID])
GO
ALTER TABLE [dbo].[auto_orders]  WITH CHECK ADD FOREIGN KEY([auto_order_detail_service_ID])
REFERENCES [dbo].[detail_services] ([detail_service_ID])
GO
ALTER TABLE [dbo].[car_models]  WITH CHECK ADD FOREIGN KEY([car_model_brand_ID])
REFERENCES [dbo].[car_brands] ([car_brand_ID])
GO
ALTER TABLE [dbo].[detail_services]  WITH CHECK ADD FOREIGN KEY([detail_service_car_service_ID])
REFERENCES [dbo].[car_services] ([car_service_ID])
GO
USE [master]
GO
ALTER DATABASE [AUTONOMIA] SET  READ_WRITE 
GO
