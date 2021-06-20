create database PhamKhuyenDB
use PhamKhuyenDB
create table UserAcount
(
	id int identity(1,1) primary key,
	UserName nchar(50) not null,
	Password nchar(50) not null,
	Status nchar(30) 
)
create table Category
(
	CateID int identity(1,1) primary key,
	Name nvarchar(70)not null,
	Description nvarchar(150) 
)
create table Product
(
	proID int identity(1,1) primary key,
	CateID int foreign key references Category(CateID),
	Name nvarchar(70) not null,
	UnitCost decimal(18,0) not null,
	quantity int not null,
	img image,
	Description nvarchar(150),
	Status nchar(30) 
)
insert into UserAcount(UserName,Password,Status) values('admin','admin','Actived')
insert into UserAcount(UserName,Password,Status) values('hang','hang','Actived')
insert into UserAcount(UserName,Password,Status) values('duc','duc','Blocked')
insert into UserAcount(UserName,Password,Status) values('minhhao','abc123','Actived')
insert into UserAcount(UserName,Password,Status) values('lapbinh','binh123','Actived')
insert into UserAcount(UserName,Password,Status) values('luffy','luffy','Blocked')
insert into UserAcount(UserName,Password,Status) values('hoanpa','aaa','Actived')
insert into UserAcount(UserName,Password,Status) values('hoan','abc123','Blocked')
insert into UserAcount(UserName,Password,Status) values('parate','parate','Blocked')
insert into UserAcount(UserName,Password,Status) values('anh','anh','Actived')
insert into UserAcount(UserName,Password,Status) values('wano','111111','Blocked')
insert into UserAcount(UserName,Password,Status) values('provip','provip','Actived')
insert into UserAcount(UserName,Password,Status) values('joyboy','111111','Blocked')
insert into Category(Name,Description) values('Áo','Mặc ở thân trên')
insert into Category(Name,Description) values('Quần','Mặc ở thân dưới')
insert into Category(Name,Description) values('Khuyên tai','Trang trí tai')
insert into Category(Name,Description) values('Mũ','Đội trên đầu')
insert into Category(Name,Description) values('Tất','Mang ở chân')
insert into Category(Name,Description) values('Vòng tay','Đeo ở cổ tay')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(1,'Áo khoát Hoodies',150000,20,'Màu trắng','Con','https://hotloko.com/wp-content/uploads/2021/03/Ao-khoac-hoodie-flexible-toi-gian-mau-den.jpg')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(1,'Áo Thun LV',75000,15,'Màu trắng','Con','https://centimet.vn/wp-content/uploads/01-29.jpg')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(1,'Áo Thun Gucci',50000,20,'Màu đen','Con','https://bizweb.dktcdn.net/100/106/923/products/1-384b2ef4-65dd-4cb4-b040-3f5c6aa31e29.jpg?v=1531413556520')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(2,'Quần jeans rách gối',250000,20,'Màu Xám','Rach','https://foxseventy.vn/wp-content/uploads/2020/12/quan-jean-nam-14.jpg')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(2,'Quần đùi vãi đũi',75000,60,'Màu đen','Lanh','https://cf.shopee.vn/file/245000a2adc7fb8b18c3d8fae4b7ced4')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(2,'Quần thể thao Adidas',250000,20,'Màu đen','Lanh','https://quanjogger.net/wp-content/uploads/2020/04/112.jpg')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(3,'Khuyên tai lấp lánh',250000,20,'Lấp lánh','Con','https://cf.shopee.vn/file/19d85f0cfc8f6414ad0dad2af6ee8bb4')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(3,'Khuyên tai Hồng',150000,50,'Màu Hồng','Con','https://cf.shopee.vn/file/6c16f1f78d981b5c8d37fa0a3b4d2297')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(6,'Vòng tay LV',25000,70,'Vòng FAKE','Fake','https://centimet.vn/wp-content/uploads/1wqwqe.jpg')
insert into Product(CateID,Name,UnitCost,quantity,Description,Status,img) values(6,'Vòng tay Gucci',1500000,5,'Vòng Real','Real','https://cf.shopee.vn/file/735132bdae66bd9e2cc588b5661ad561')
