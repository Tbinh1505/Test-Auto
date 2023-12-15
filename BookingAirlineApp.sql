use master 
create database BookingAirline
go

use BookingAirline
go



create table Roles
(
	id int primary key,
	displayName nvarchar(10)
)

create table Staff
(
	id int primary key identity,
	roleId int default 1, --1: nhan vien 0: admin
	displayName nvarchar(50) not null, -- 
	password nvarchar(100) not null, -- mat khau
	email varchar(100) not null, -- email
	phone varchar(11) not null, --sdt
	status int default 1, -- 1: active 0: unactive
	createDate datetime not null,
	foreign key(roleId) references Roles(id)
)

create table Customer
(
	id bigint primary key identity,
	email varchar(100) not null,
	password nvarchar(100) not null,
	first_name nvarchar(50) not null,
	middle_name nvarchar(50) not null,
	last_name nvarchar(50) not null,
	Dob datetime, -- ngay sinh
	phone varchar(11) not null,
	address nvarchar(50) not null,
	gender nvarchar(10) not null,
	status int default 1 -- 1:active 0: unactive
)

create table Bank
(
	id int primary key identity,
	customerId bigint not null,
	displayName nvarchar(100) not null,
	bankAccountNum bigint not null

	foreign key(customerId) references Customer(id)
)

--create table Location
--(
--	id int primary key identity,
--	locaCode nvarchar(50) not null,
--	displayName nvarchar(50) not null
--)

create table Plane_type
(
	id bigint primary key identity,
	planeCode nvarchar(50) not null,
	displayName nvarchar(50) not null,
	totalSeat int not null
)
create table airport (
	id int primary key identity,
	airportCode varchar(20) not null,
	airportName nvarchar(50) not null,
	locationFly nvarchar(50) not null,
)
create table Flight
(
	id bigint primary key identity,
	planeTypeId bigint not null,
	locationId int not null,
	flightCode varchar(50) not null,
	goFrom nvarchar(100) not null,
	goTom nvarchar(100) not null, -- điểm đến
	price int not null,
	dateFlight datetime not null,
	dateTo datetime,
	status int not null --set giá trị: 1 - delay-- chuyến bay bị chậm hơn giờ khởi hành , 0 - đúng giờ 

	foreign key(planeTypeId) references Plane_type(id),
	foreign key(locationId) references airport(id)
)



create table Ticket
(
	id bigint primary key identity,
	customerId bigint not null,
	flightId bigint not null,
	createDate datetime not null,
	twoWay int not null,
	totalTicket int not null,
	totalPrice int not null,
	seatCode varchar(50) not null,
	nameTicket nvarchar(100) not null,
	status int not null,
	foreign key(customerId) references Customer(id),
	foreign key(flightId) references Flight(id)
)

-- ghế theo máy bay
create table Seat_flight
(
	id int primary key identity,
	flightid bigint,
	seatid int,
	status int default 0,

	foreign key(flightid) references Flight(id),
	foreign key(seatid) references Seat_detail(id)
)

create table Class
(
	id int primary key identity,
	displayName nvarchar(50) not null,
	price int not null
)

create table Seat_detail
(
	id int identity primary key,
	classId int not null,
	planeTypeId bigint not null,
	seatCode varchar(50) not null,
	status int default 1 --0: da dat 1: trong

	foreign key(classId) references Class(id),
	foreign key(planeTypeId) references Plane_type(id)
)

create table Recommend
(
	id int primary key identity,
	idFlight bigint not null,
	content nvarchar(200) not null

	foreign key(idFlight) references Flight(id)
)

insert Roles values
(0,N'Admin'),
(1,N'Nhân viên'),
(99,N'Mail')

insert Staff(roleId,displayName,password,email,phone) values
(1,N'Lê Văn Luyện','7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040','luyenlv@gmail.com','0129283738'),
(0,N'Lê Văn Hà','7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040','halv@gmail.com','0918877228'),
(99,N'Email send','spvhixkeagfawjqc','bookingairline1@gmail.com','0918877228')

insert Customer (email,password,first_name,last_name,middle_name,Dob,address,phone,gender) values
('cus1@gmail.com','7:3597@:?=<>A??FCBDMFOKILLTQMPXQT[SSXV78124193631341163019195242951291391040',N'Phan',N'Trung',N'Nam','2001-1-15','none','0191771271',N'Nam')

insert Class(displayName,price) values
(N'Thương Gia',1000000),
(N'Phổ Thông',500000)

insert Plane_type(planeCode,displayName,totalSeat) values
('Plane_1',N'Máy bay số 1',30),
('Plane_2',N'Máy bay số 2',50),
('Plane_3',N'Máy bay số 3',30),
('Plane_4',N'Máy bay số 4',30),
('Plane_5',N'Máy bay số 5',50),
('Plane_6',N'Máy bay số 6',30)

--insert Location(locaCode,displayName) values
--('TB',N'Thái Bình'),
--('SL',N'Sơn La'),
--('HT',N'Hà Tĩnh'),
--('HA',N'Hà Giang'),
--('CB',N'Cao Bằng'),
--('LC',N'Lào Cai'),
--('LCH',N'Lai Châu'),
--('BK',N'Bắc Kạn'),
--('LS',N'Lạng Sơn'),
--('TQ',N'Tuyên Quang'),
--('YB',N'Yên Bái'),
--('TN',N'Thái Nguyên'),
--('ĐB',N'Điện Biên'),
--('PT',N'Phú Thọ'),
--('VP',N'Vĩnh Phúc'),
--('BG',N'Bắc Giang'),
--('BN',N'Bắc Ninh'),
--('HN',N'Hà Nội'),
--('QN',N'Quảng Ninh'),
--('HD',N'Hải Dương'),
--('HP',N'Hải Phòng'),
--('HB',N'Hòa Bình'),
--('HY',N'Hưng Yên'),
--('HNM',N'Hà Nam'),
--('NĐ',N'Nam Định'),
--('NB',N'Ninh Bình'),
--('TH',N'Thanh Hóa'),
--('NA',N'Nghệ An'),
--('QB',N'Quảng Bình'),
--('QT',N'Quảng Trị'),
--('TTH',N'Thừa Thiên Huế'),
--('ĐN',N'Đà Nẵng'),
--('QN',N'Quảng Nam'),
--('QNI',N'Quảng Ngãi'),
--('KT',N'Kon Tum'),
--('GL',N'Gia Lai'),
--('BĐ',N'Bình Định'),
--('PY',N'Phú Yên'),
--('ĐL',N'Đắk Lắk'),
--('KH',N'Khánh Hòa'),
--('ĐN',N'Đắk Nông'),
--('LĐ',N'Lâm Đồng'),
--('NT',N'Ninh Thuận'),
--('BP',N'Bình Phước'),
--('TN',N'Tây Ninh'),
--('BD',N'Bình Dương'),
--('ĐN',N'Đồng Nai'),
--('BT',N'Bình Thuận'),
--('TPHCM',N'Thành phố Hồ Chí Minh'),
--('LA',N'Long An'),
--('BR-VT',N'Bà Rịa - Vũng Tàu'),
--('ĐT',N'Đồng Tháp'),
--('AG',N'An Giang'),
--('TG',N'Tiền Giang'),
--('VL',N'Vĩnh Long'),
--('BT',N'Bến Tren'),
--('CT',N'Cần Thơ'),
--('KG',N'Kiên Giang'),
--('TV',N'Trà Vinh'),
--('HG',N'Hậu Giang'),
--('ST',N'Sóc Trăng'),
--('BL',N'Bạc Liêu'),
--('CM',N'Cà Mau')

insert airport(airportCode,airportName,locationFly) values
(N'SGN',N'Sân bay quốc tế Tân Sơn Nhất',N'Tp.Hồ Chí Minh'),
(N'HAN',N'Sân bay quốc tế Nội Bài',N'Hà Nội'),
(N'DAD',N'Sân bay quốc tế Đà Nẵng',N'Đà Nẵng'),
(N'VDO',N'Sân bay quốc tế Vân Đồn, Hạ Long',N'Quảng Ninh'),
(N'PQC',N'Sân bay quốc tế Phú Quốc',N'Kiên Giang'),
(N'HPH',N'Sân bay Quốc tế Cát Bi',N'Hải Phòng'),
(N'VII',N'Sân bay Quốc tế Vinh',N'Nghệ An'),
(N'HUI',N'Sân bay Quốc tế Phú Bài',N'Huế'),
(N'CXR',N'Sân bay Quốc tế Cam Ranh',N'Khánh Hòa'),
(N'DLI',N'Sân bay Quốc tế Liên Khương',N'Lâm Đồng'),
(N'UIH',N'Sân bay Quốc tế Phù Cát',N'Bình Định'),
(N'VCA',N'Sân bay Quốc tế Cần Thơ',N'Cần Thơ')



go

select * from Staff