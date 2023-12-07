use master
go
IF EXISTS (SELECT * FROM SYS.databases WHERE NAME = 'QLDA')
drop database QLDA
go
create database QLDA
go
use QLDA
go
--WINDOWS-11

CREATE TABLE TaiKhoan (
	MaTK		VARCHAR(9) NOT NULL PRIMARY KEY,
	MatKhau		VARCHAR (10) NOT NULL,
)

CREATE TABLE ChucVu (
	MaChucVu	VARCHAR(9) NOT NULL PRIMARY KEY,
	TenChucVu	NVARCHAR(10) NOT NULL
)

CREATE TABLE NhanVien (
	MaNV		VARCHAR(9) NOT NULL PRIMARY KEY,
	TenNV		NVARCHAR(40) NOT NULL,
	DiaChi		NVARCHAR(20) NOT NULL,
	NgaySinh	Date	NOT NULL,
	CCCD		varchar(15)		NOT NULL,
	Sdt			varchar(10)		NOT NULL,
	MaTK		varchar(9)	NOT NULL FOREIGN KEY REFERENCES TaiKhoan(MaTK),
	MaChucVu	varchar(9) NOT NULL FOREIGN KEY REFERENCES ChucVu(MaChucVu)
)

CREATE TABLE KhachHang (
	MaKH		VARCHAR(9) NOT NULL PRIMARY KEY,
	TenKH		NVARCHAR(40) NOT NULL,
	Sdt			varchar (10)	NOT NULL,
	DiaChi		NVARCHAR(20) NOT NULL,
	MaSoThue	VARCHAR (10) NOT NULL
)

CREATE TABLE HopDong (
	MaHD		VARCHAR (9) NOT NULL PRIMARY KEY,
	TenHD		NVARCHAR(50) NOT NULL,
	NgayKyHD	Date NOT NULL,
	NgayKetThucHD Date NOT NULL,
	AnhHD		VARCHAR(50),
	MaKH		VARCHAR(9) NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH),
	MaNV		VARCHAR(9) NOT NULL FOREIGN KEY REFERENCES NhanVien (MaNV)
)

CREATE TABLE DuAn (
	MaDA		VARCHAR (9) NOT NULL PRIMARY KEY,
	TenDA		NVARCHAR(50) NOT NULL,
	NgayBD		Date NOT NULL,
	NgayKT		Date NOT NULL,
	NgayHT		Date NOT NULL,
	KeHoachDA	VARCHAR (100) NOT NULL,
	TienDoDA	char (2) not null FOREIGN KEY REFERENCES TienDo(MaTD),
	MaHD		VARCHAR (9) NOT NULL FOREIGN KEY REFERENCES HopDong(MaHD),
	MaKH		VARCHAR(9) NOT NULL FOREIGN KEY REFERENCES KhachHang(MaKH)
)

CREATE TABLE CongViec (
	MaCV		VARCHAR (9) NOT NULL PRIMARY KEY,
	TenCV		NVARCHAR(50) NOT NULL,
	MaLoai		char (2) NOT NULL FOREIGN KEY REFERENCES LoaiCV(MaLoai),
	ThoigianBD	date NOT NULL,
	ThoigianTH	Date NOT NULL,
	ThoigianKT	date NOT NULL,
	ThoigianHT	date NOT NULL,
	TienDoCV	char (2) not null FOREIGN KEY REFERENCES TienDo(MaTD),
	MaNV		VARCHAR(9) NOT NULL FOREIGN KEY REFERENCES NhanVien(MaNV),
	MaDA		VARCHAR (9) NOT NULL FOREIGN KEY REFERENCES DuAn(MaDA)
)

CREATE TABLE TienDo (
	MaTD		char (2) not null primary key,
	TenTD		nvarchar (20) not null
)

CREATE TABLE LoaiCV (
	MaLoai		char(2) not null primary key,
	TenLoai		varchar(20) not null
)

select * from TaiKhoan, ChucVu, NhanVien
where TaiKhoan.MaTK = 'TK001' and TaiKhoan.MatKhau = '123456' and NhanVien.MaTK = TaiKhoan.MaTK and ChucVu.TenChucVu = N'Nhân viên'

select MaNV, NhanVien.TenNV,TaiKhoan.MaTK, TenChucVu, DiaChi, NgaySinh, CCCD,SdtNV
                from TaiKhoan INNER JOIN NhanVien ON TaiKhoan.MaTK = NhanVien.MaTK
                INNER JOIN ChucVu ON NhanVien.MaChucVu = ChucVu.MaChucVu
                where TaiKhoan.MaTK = 'TK001'
alter table KhachHang alter column MaKH varchar(10)

drop table TaiKhoan
drop table ChucVu
drop table CongViec
drop table DuAn
drop table HopDong
drop table KhachHang
drop table NhanVien

select * from TaiKhoan
select * from ChucVu
select * from CongViec
select * from DuAn
select * from HopDong
select * from KhachHang
select * from NhanVien
select * from TienDo
select * from LoaiCV

select MaDA,TenDA,NgayBD,NgayKT,TienDoDA from DuAn where TienDoDA = '01'

SELECT distinct MaHD from HopDong
UPDATE DuAn set TenDA = N'IMS',NgayBD='2023-04-25',NgayKT= '2023-06-30',NgayHT='2023-06-30', 
KeHoachDA=N'https://docs.google.com/',TienDoDA= '02', MaHD='HD010',MaKH='KH011' where MaDA='DA011'
delete from DuAn where MaDA='DA012'
insert into DuAn values ('DA012', N'abc','2023-04-25', '2023-06-30','2023-06-30', N'https://docs.google.com/', '02', 'HD010','KH011')
update DuAn set 

insert into TienDo values ('01',N'Chưa thực hiện')
insert into TienDo values ('02',N'Đang thực hiện')
insert into TienDo values ('03',N'Hoàn thành')
insert into TienDo values ('04',N'Trễ hạn')

insert into LoaiCV values ('01','Coding')
insert into LoaiCV values ('02','Testing')
insert into LoaiCV values ('03','Business Analyzing')
insert into LoaiCV values ('04','Project Management')
insert into LoaiCV values ('05','Customer Supporting')

insert into TaiKhoan values ('TK001', '123456')
insert into TaiKhoan values ('TK002',  '123456')
insert into TaiKhoan values ('TK003',  '123456')
insert into TaiKhoan values ('TK004', '123456')
insert into TaiKhoan values ('TK005', '123456')
insert into TaiKhoan values ('TK006', '123456')
insert into TaiKhoan values ('TK007', '123456')
insert into TaiKhoan values ('TK008', '123456')
insert into TaiKhoan values ('TK009', '123456')
insert into TaiKhoan values ('TK010', '123456')
insert into TaiKhoan values ('TK011', '123456')
insert into TaiKhoan values ('TK012', '123456')
insert into TaiKhoan values ('TK013', '123456')
insert into TaiKhoan values ('TK014', '123456')
insert into TaiKhoan values ('TK015', '123456')
insert into TaiKhoan values ('TK016', '123456')
insert into TaiKhoan values ('TK017', '123456')
insert into TaiKhoan values ('TK018', '123456')
insert into TaiKhoan values ('TK019', '123456')
insert into TaiKhoan values ('TK020', '123456')
insert into TaiKhoan values ('TK021', '123456')
insert into TaiKhoan values ('TK022', '123456')
insert into TaiKhoan values ('TK023', '123456')
insert into TaiKhoan values ('TK024', '123456')
insert into TaiKhoan values ('TK025', '123456')

insert into ChucVu values ('NV', N'Nhân viên')
insert into ChucVu values ('QL', N'Quản lý')


insert into NhanVien values ('NV001', N'Nguyễn Thị Hồng Chuyên',N'Hà Nội',	'1997-06-15','025698753152','0956325845', 'TK001', 'NV')
insert into NhanVien values ('NV002', N'Phạm Thị Hiền',	N'Hà Nội',	'1994-09-03','0353058972',	'085632145', 'TK002', 'NV')
insert into NhanVien values ('NV003', N'Nguyễn Thị Trang',	N'Hà Nội',	'1998-01-22','015987456320','0529562365', 'TK003', 'NV')
insert into NhanVien values ('NV004', N'Vũ Thanh Loan',	N'Hà Nội',	'1999-05-30','025492351786','0358439410', 'TK004', 'QL')
insert into NhanVien values ('NV005', N'Vũ Thị Hải Yến', N'Hà Nội',	'1995-07-09','085469254763','0321896548', 'TK005', 'NV')
insert into NhanVien values ('NV006', N'Nguyễn Quốc Tuấn', N'Hà Nội','1992-02-16','020286493548','0956325845', 'TK006', 'NV')
insert into NhanVien values ('NV007', N'Nguyễn Thái Học', N'Hà Nội','2000-04-30','058635478202','0758962541', 'TK007', 'NV')
insert into NhanVien values ('NV008', N'Nguyễn Trung Dũng',N'Hà Nội',	'2001-03-06','026302458954','0854126595', 'TK008', 'NV')
insert into NhanVien values ('NV009', N'Chu Anh Cường',N'Hà Nội','1999-08-07','025302595621','0789452015', 'TK009', 'NV')
insert into NhanVien values ('NV010', N'Đoàn Mạnh Dũng',N'Hà Nội',	'1995-10-19','027560214589','0874202365', 'TK010', 'NV')
insert into NhanVien values ('NV011', N'Đoàn Vũ Long',N'Hà Nội','1997-08-26','026402789521','0984523654', 'TK011', 'NV')
insert into NhanVien values ('NV012', N'Nguyễn Văn Tùng',N'Hà Nội',	'1996-05-17','026302145879','0852463952', 'TK012', 'QL')
insert into NhanVien values ('NV013', N'Đỗ Lê Hồng Nhung',N'Hà Nội','1993-02-28','035302158632','0523651258', 'TK013', 'NV')
insert into NhanVien values ('NV014', N'Nguyễn Bích Hòa',N'Hà Nội','1997-12-25','036302548796','0123547802', 'TK014', 'NV')
insert into NhanVien values ('NV015', N'Nguyễn Hạnh Phương',N'Hà Nội','1994-11-06','0270254869123','0528796415', 'TK015', 'NV')
insert into NhanVien values ('NV016', N'Trần Hữu Đạt',N'Hà Nội','1999-02-15','0280630012548','0995412368', 'TK016', 'NV')
insert into NhanVien values ('NV017', N'Nguyễn Mạnh Hùng',N'Hà Nội','1996-05-18','029000254876','0254789651', 'TK017', 'NV')
insert into NhanVien values ('NV018', N'Nguyễn Minh Quang',N'Hà Nội','1995-07-12','025478521045','0854769523', 'TK018', 'NV')
insert into NhanVien values ('NV019', N'Đỗ Đức Trung',N'Hà Nội','1996-04-27','033002547891','0256314823', 'TK019', 'QL')
insert into NhanVien values ('NV020', N'Trần Minh Khôi',N'Hà Nội','1998-01-01','0370025419562','0980452195', 'TK020', 'NV')
insert into NhanVien values ('NV021', N'Vũ Anh Tuấn',N'Hà Nội','1998-06-20','026300254785','0335695214', 'TK021', 'QL')
insert into NhanVien values ('NV022', N'Nguyễn Xuân Hiếu',N'Hà Nội','1996-04-03','035300254698','0975296321', 'TK022', 'NV')
insert into NhanVien values ('NV023', N'Phạm Hoàng Nam',N'Hà Nội','1994-08-02','036002156894','0965812360', 'TK023', 'NV')
insert into NhanVien values ('NV024', N'Vũ Minh Tú',N'Hà Nội','1997-05-23','022003007895','0982546312', 'TK024', 'NV')
insert into NhanVien values ('NV025', N'Nguyễn Thùy Dương',	N'Hà Nội','1997-05-05','025400365892','0947852163', 'TK025', 'NV')

insert into KhachHang values ('KH001', N'Nguyễn Thị Mai Hương', '0954845236', N'Hà Nội','0214587965')
insert into KhachHang values ('KH002', N'Vũ Văn Hưng',			'0985214256', N'Hà Nội','1547896523')
insert into KhachHang values ('KH003', N'Nguyễn Bảo Vy',		'0975412845', N'Hà Nội','2541256398')
insert into KhachHang values ('KH004', N'Hoàng Kim Ngân',		'0365487541', N'Hà Nội','0125478965')
insert into KhachHang values ('KH005', N'Phạm Nam Khánh',		'0962547821', N'Hà Nội','1542369875')
insert into KhachHang values ('KH006', N'Tạ Phương Linh',		'0985423654', N'Hà Nội','2563941023')
insert into KhachHang values ('KH007', N'Nguyễn Tiến Nam',		'0984516234', N'Hà Nội','2541256398')
insert into KhachHang values ('KH008', N'Lê Thanh Mai',			'0989653456', N'Hà Nội','0125871696')
insert into KhachHang values ('KH009', N'Trần Văn Tuyên',		'0965623205', N'Hà Nội','2105486235')
insert into KhachHang values ('KH010', N'Nguyễn Đình Phúc',		'0985246240', N'Hà Nội','0512369795')
insert into KhachHang values ('KH011', N'Trần Bình Minh',		'0925463688', N'Hà Nội','1025635426')
insert into KhachHang values ('KH012', N'Lê Sỹ Trường Sơn',		'0975420236', N'Hà Nội','0215623254')

insert into HopDong values ('HD001', N'Hợp đồng cung cấp dịch vụ đăng ký tên miền',	'2022-12-09', '2023-04-12', N'https://www.google.com.vn/', 'KH002', 'NV004')
insert into HopDong values ('HD002', N'Hợp đồng cung cấp dịch vụ phần mềm ERP',	'2023-08-15', '2023-12-20', N'https://www.google.com.vn/', 'KH005', 'NV021')
insert into HopDong values ('HD003', N'Hợp đồng cung cấp giải pháp số cho doanh nghiệp','2023-02-19', '2023-10-30', N'https://www.google.com.vn/', 'KH011', 'NV012')
insert into HopDong values ('HD004', N'Hợp đồng cung cấp dịch vụ gia công phần mềm','2023-12-27', '2024-03-10', N'https://www.google.com.vn/', 'KH004', 'NV004')
insert into HopDong values ('HD005', N'Hợp đồng cung cấp dịch vụ nâng cấp phần mềm','2023-08-01', '2024-02-10', N'https://www.google.com.vn/', 'KH010', 'NV019')
insert into HopDong values ('HD006', N'Hợp đồng cung cấp dịch vụ bảo trì phần mềm',	'2023-04-21', '2023-12-31', N'https://www.google.com.vn/', 'KH001', 'NV012')
insert into HopDong values ('HD007', N'Hợp đồng kinh tế','2023-12-12', '2024-05-20', N'https://www.google.com.vn/', 'KH003', 'NV007')
insert into HopDong values ('HD008', N'Hợp đồng ủy quyền','2021-10-14', '2022-02-28', N'https://www.google.com.vn/', 'KH006', 'NV009')
insert into HopDong values ('HD009', N'Hợp đồng cung cấp dịch vụ triển khai phần mềm', '2022-03-11', '2022-09-12', N'https://www.google.com.vn/', 'KH009', 'NV008')
insert into HopDong values ('HD010', N'Hợp đồng cung cấp dịch vụ hỗ trợ cho doanh nghiệp','2023-04-10', '2023-07-03', N'https://www.google.com.vn/', 'KH011', 'NV012')

insert into DuAn values ('DA001', N'Metasign','2022-12-09', '2023-04-12','2023-04-12', N'https://docs.google.com/', '03', 'HD001','KH002')
insert into DuAn values ('DA002', N'Timesheet','2023-04-09', '2023-08-31','2023-08-31', N'https://docs.google.com/', '03', 'HD002','KH001')
insert into DuAn values ('DA003', N'X-volve','2023-08-31', '2023-12-12','2023-12-12', N'https://docs.google.com/', '02', 'HD003','KH011')
insert into DuAn values ('DA004', N'Blue Carbon','2023-12-30', '2024-03-01','2024-03-01', N'https://docs.google.com/', '01', 'HD004','KH004')
insert into DuAn values ('DA005', N'Mezon','2023-08-01', '2024-02-10','2024-02-10', N'https://docs.google.com/', '02', 'HD005','KH010')
insert into DuAn values ('DA006', N'Finfast','2023-04-21', '2023-12-31', '2023-12-31', N'https://docs.google.com/', '02', 'HD006','KH012')
insert into DuAn values ('DA007', N'Kith&Kin','2023-04-21', '2023-12-31','2023-12-31', N'https://docs.google.com/', '02', 'HD006','KH003')
insert into DuAn values ('DA008', N'Trudi','2023-04-21', '2023-12-31','2023-12-31', N'https://docs.google.com/', '02', 'HD008','KH006')
insert into DuAn values ('DA009', N'iTouch','2023-04-21', '2023-12-31','2023-12-31', N'https://docs.google.com/', '02', 'HD009','KH009')
insert into DuAn values ('DA010', N'Printapp','2023-04-21', '2023-12-31','2023-12-31', N'https://docs.google.com/', '02', 'HD010','KH011')
insert into DuAn values ('DA011', N'IMS','2023-04-25', '2023-06-30','2023-06-30', N'https://docs.google.com/', '03', 'HD010','KH011')


insert into CongViec values ('CV001',N'Login page','01', '2023-04-25','2023-04-25', '2023-04-26','2023-04-26', '02', 'NV015', 'DA011')
insert into CongViec values ('CV002',N'Manage widget','01', '2023-04-27','2023-04-27', '2023-04-29','2023-04-29', '02', 'NV010', 'DA011')
insert into CongViec values ('CV003',N'Manage email setting','01', '2023-04-27','2023-04-27', '2023-04-28','2023-04-28', '02', 'NV006', 'DA011')
insert into CongViec values ('CV004',N'Manage categories','01', '2023-04-28','2023-04-28', '2023-04-30','2023-04-30', '02', 'NV015', 'DA011')
insert into CongViec values ('CV005',N'Dashboard','01', '2023-04-29', '2023-04-29','2023-05-03','2023-05-03', '02', 'NV015', 'DA011')
insert into CongViec values ('CV006',N'Manage news','01', '2023-05-03', '2023-05-03','2023-05-08','2023-05-08', '02', 'NV015', 'DA011')
insert into CongViec values ('CV007',N'Manage users','01', '2023-05-03', '2023-05-03','2023-05-08','2023-05-08', '02', 'NV015', 'DA011')
insert into CongViec values ('CV008',N'Display album','01', '2023-05-04', '2023-05-04','2023-05-10','2023-05-10', '02', 'NV015', 'DA011')
insert into CongViec values ('CV009',N'Audit log','01', '2023-05-11','2023-05-11', '2023-05-12','2023-05-12','02', 'NV015', 'DA011')
insert into CongViec values ('CV010',N'Manage roles','01', '2023-05-12','2023-05-12', '2023-05-14','2023-05-14', '02', 'NV015', 'DA011')
insert into CongViec values ('CV011',N'Create user api for HRM trigger','01', '2023-05-15','2023-05-15', '2023-05-16','2023-05-16', '02', 'NV015', 'DA011')
insert into CongViec values ('CV012',N'Manage entity types','01', '2023-05-17','2023-05-17', '2023-05-20','2023-05-20', '02', 'NV015', 'DA011')
insert into CongViec values ('CV013',N'Upload image','01', '2023-05-21','2023-05-21', '2023-05-22','2023-05-22', '02', 'NV015', 'DA011')
insert into CongViec values ('CV014',N'Login page','02', '2023-05-23','2023-05-23', '2023-05-23','2023-05-23', '02', 'NV015', 'DA011')
insert into CongViec values ('CV015',N'Manage widget','02', '2023-05-24', '2023-05-24','2023-05-26','2023-05-26', '02', 'NV015', 'DA011')
insert into CongViec values ('CV016',N'Manage email setting','02', '2023-05-27', '2023-05-27','2023-05-27','2023-05-27', '02', 'NV015', 'DA011')
insert into CongViec values ('CV017',N'Manage categories','02', '2023-05-28', '2023-05-28','2023-05-30','2023-05-30', '02', 'NV015', 'DA011')
insert into CongViec values ('CV018',N'Dashboard','02', '2023-06-01', '2023-06-01','2023-06-02','2023-06-02', '02', 'NV015', 'DA011')
insert into CongViec values ('CV019',N'Manage news','02', '2023-06-03', '2023-06-03','2023-06-07','2023-06-07', '02', 'NV015', 'DA011')
insert into CongViec values ('CV020',N'Manage users','02', '2023-06-08', '2023-06-08','2023-06-10','2023-06-10', '02', 'NV015', 'DA011')
insert into CongViec values ('CV021',N'Dispaly album','02', '2023-06-11', '2023-06-11','2023-06-13','2023-06-13', '02', 'NV015', 'DA011')
insert into CongViec values ('CV022',N'Audit log','02', '2023-06-14', '2023-06-14','2023-06-16','2023-06-16', '02', 'NV015', 'DA011')
insert into CongViec values ('CV023',N'Manage roles','02', '2023-06-17', '2023-06-17','2023-06-20','2023-06-20', '02', 'NV015', 'DA011')
insert into CongViec values ('CV024',N'Create user api for HRM trigger','02', '2023-06-20', '2023-06-20','2023-06-23','2023-06-23', '02', 'NV015', 'DA011')
insert into CongViec values ('CV025',N'Manage entity types','02', '2023-06-24', '2023-06-24','2023-06-27','2023-06-27', '02', 'NV015', 'DA011')
insert into CongViec values ('CV026',N'Upload image','02', '2023-06-28', '2023-06-28','2023-06-30','2023-06-30', '02', 'NV015', 'DA011')
insert into CongViec values ('CV027',N'Fix conflict','01', '2023-08-31','2023-08-31', '2023-09-04','2023-09-04', '02', 'NV015', 'DA003')
insert into CongViec values ('CV028',N'Show banner about everyday date','01', '2023-09-05', '2023-09-05','2023-09-10','2023-09-10', '02', 'NV015', 'DA003')
insert into CongViec values ('CV029',N'Setting campain','01', '2023-09-11','2023-09-11', '2023-09-18','2023-09-18', '02', 'NV015', 'DA003')
insert into CongViec values ('CV030',N'Figma token sync with github','01', '2023-09-19','2023-09-19', '2023-09-23','2023-09-23', '02', 'NV015', 'DA003')
insert into CongViec values ('CV031',N'The rank system for female','01', '2023-09-24','2023-09-24', '2023-09-28','2023-09-28', '02', 'NV015', 'DA003')
insert into CongViec values ('CV032',N'[BUG] Splash screen','01', '2023-09-28','2023-09-28', '2023-09-29','2023-09-29', '02', 'NV015', 'DA003')
insert into CongViec values ('CV033',N'Registration-steps 2nd form','01', '2023-09-30','2023-09-30', '2023-10-05','2023-10-05', '02', 'NV015', 'DA003')
insert into CongViec values ('CV034',N'[BUG] Showing text with not correct typography','01', '2023-10-28','2023-10-28', '2023-10-29','2023-10-29', '02', 'NV015', 'DA003')
insert into CongViec values ('CV035',N'Premium banner','01', '2023-11-01','2023-11-01', '2023-11-04','2023-11-04', '02', 'NV015', 'DA003')
insert into CongViec values ('CV036',N'Tag for marketing','01', '2023-11-08','2023-11-08', '2023-11-15','2023-11-15', '02', 'NV015', 'DA003')
insert into CongViec values ('CV037',N'[BUG] premium popup do not appear','01', '2023-11-21','2023-11-21', '2023-11-25','2023-11-25', '02', 'NV015', 'DA003')
insert into CongViec values ('CV038',N'Change header color','01', '2023-11-29','2023-11-29', '2023-12-03','2023-12-03', '02', 'NV015', 'DA003')
insert into CongViec values ('CV039',N'Open link in web-view from push notification','01', '2023-12-08','2023-12-08', '2023-12-11','2023-12-11', '02', 'NV015', 'DA003')
insert into CongViec values ('CV040',N'[BUG]The tags are not fired','01', '2023-12-30','2023-12-30', '2024-01-05','2024-01-05', '02', 'NV015', 'DA003')
insert into CongViec values ('CV041',N'Participation pop-up bug','01', '2024-01-09','2024-01-09', '2024-01-12','2024-01-12', '02', 'NV015', 'DA003')
insert into CongViec values ('CV042',N'Implement sentry for web','01', '2024-01-16','2024-01-16', '2024-01-25','2024-01-25', '02', 'NV015', 'DA003')
insert into CongViec values ('CV043',N'[BUG] Unable to upload photos in some devices','01', '2023-01-31','2023-01-31', '2023-02-01', '2023-02-01', '02', 'NV015', 'DA003')
insert into CongViec values ('CV044',N'Change text of step 7 and last step','01', '2024-02-04','2024-02-04', '2024-02-05','2024-02-05', '02', 'NV015', 'DA003')
insert into CongViec values ('CV045',N'Manage banner in admin','01', '2024-02-17','2024-02-17', '2024-02-22','2024-02-22', '02', 'NV015', 'DA003')
insert into CongViec values ('CV046',N'Notification about invitation campaign','01', '2024-02-26','2024-02-26', '2024-02-28','2024-02-28', '02', 'NV015', 'DA003')
insert into CongViec values ('CV047',N'Create preview function','01', '2022-12-21','2022-12-21', '2022-12-24','2022-12-24', '02', 'NV015', 'DA004')
insert into CongViec values ('CV048',N'Algorithm','01', '2022-12-27','2022-12-27', '2023-01-08','2023-01-08', '02', 'NV015', 'DA003')
insert into CongViec values ('CV049',N'Optimize the request-participate API','01', '2023-01-13','2023-01-13', '2023-01-20','2023-01-20', '02', 'NV015', 'DA004')
insert into CongViec values ('CV050',N'Fix algorithm of Black Plan','01', '2023-01-15','2023-01-15', '2023-01-20','2023-01-20', '02', 'NV015', 'DA004')
insert into CongViec values ('CV051',N'[BUG] Notification has not been sent','01', '2023-01-25','2023-01-25', '2023-01-27','2023-01-27', '02', 'NV015', 'DA004')
insert into CongViec values ('CV052',N'Add the logic of reminders','01', '2022-12-09','2022-12-09', '2023-04-12','2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV053',N'Bachelor coupon page','01', '2022-12-09','2022-12-09', '2023-04-12','2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV054',N'Check the validation of participation','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV055',N'Check all schedule command and change the businessI','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV056',N'Change get-dating-days API','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV057',N'Implement match-profile API','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV058',N'Fix unit test','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV059',N'Fix comment pull request','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV060',N'Create specification document for Notification function','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV061',N'Automating face screening operations','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV062',N'Investigate issue stripe','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV063',N'Create System flow in Figma','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV064',N'Mini talk feedback','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV065',N'Improve UI/UX at 1st ~ 2nd form','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV066',N'Estimate API for faster loading','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV067',N'[BUG]Cannot access link in notification"','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV068',N'[BUG] Cancel_matching_black_plan_issue_coupon is not sent','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV069',N'[BUG] Wrong pop-up appears even though user has a ticket','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
--Tester
insert into CongViec values ('CV070',N'Fix conflict','02', '2023-10-05','2023-10-05', '2023-10-07','2023-10-07', '02', 'NV015', 'DA003')
insert into CongViec values ('CV071',N'Show banner about everyday date','02', '2023-10-08', '2023-10-08','2023-10-10','2023-10-10', '02', 'NV015', 'DA003')
insert into CongViec values ('CV072',N'Setting campain','02', '2023-10-11','2023-10-11', '2023-10-14','2023-10-14', '02', 'NV015', 'DA003')
insert into CongViec values ('CV073',N'Figma token sync with github','02', '2023-10-15','2023-10-15', '2023-10-17','2023-10-17', '02', 'NV015', 'DA003')
insert into CongViec values ('CV074',N'The rank system for female','02', '2023-10-18','2023-10-18', '2023-10-21','2023-10-21', '02', 'NV015', 'DA003')
insert into CongViec values ('CV075',N'[BUG] Splash screen','02', '2023-10-22','2023-10-22', '2023-10-23','2023-10-23', '02', 'NV015', 'DA003')
insert into CongViec values ('CV076',N'Registration-steps 2nd form','02', '2023-10-24','2023-10-24', '2023-10-27','2023-10-27', '02', 'NV015', 'DA003')
insert into CongViec values ('CV077',N'[BUG] Showing text with not correct typography','02', '2023-10-30','2023-10-30', '2023-10-31','2023-10-31', '02', 'NV015', 'DA003')
insert into CongViec values ('CV078',N'Premium banner','02', '2023-11-05','2023-11-05', '2023-11-07','2023-11-07', '02', 'NV015', 'DA003')
insert into CongViec values ('CV079',N'Tag for marketing','02', '2023-11-16','2023-11-16', '2023-11-20','2023-11-20', '02', 'NV015', 'DA003')
insert into CongViec values ('CV080',N'[BUG] premium popup do not appear','02', '2023-11-25','2023-11-25', '2023-11-28','2023-11-28', '02', 'NV015', 'DA003')
insert into CongViec values ('CV081',N'Change header color','02', '2023-12-04','2023-12-04', '2023-07-12','2023-07-12', '02', 'NV015', 'DA003')
insert into CongViec values ('CV082',N'Open link in web-view from push notification','02', '2023-12-11', '2023-12-12', '02', 'NV015', 'DA003')
insert into CongViec values ('CV083',N'[BUG]The tags are not fired','02', '2024-01-06','2024-01-06', '2023-01-08','2023-01-08', '02', 'NV015', 'DA003')
insert into CongViec values ('CV084',N'Participation pop-up bug','02', '2024-01-13','2024-01-13', '2024-01-15', '2024-01-15','02', 'NV015', 'DA003')
insert into CongViec values ('CV085',N'Implement sentry for web','02', '2024-01-26', '2023-01-30', '02', 'NV015', 'DA003')
insert into CongViec values ('CV086',N'[BUG] Unable to upload photos in some devices','02', '2024-02-02','2024-02-02', '2024-02-03','2024-02-03', '02', 'NV015', 'DA003')
insert into CongViec values ('CV087',N'Change text of step 7 and last step','02', '2024-02-06','2024-02-06', '2024-02-07','2024-02-07', '02', 'NV015', 'DA003')
insert into CongViec values ('CV088',N'Manage banner in admin','02', '2024-02-23','2024-02-23', '2024-02-25','2024-02-25', '02', 'NV015', 'DA003')
insert into CongViec values ('CV089',N'Notification about invitation campaign','02', '2024-02-29','2024-02-29', '2024-03-01','2024-03-01', '02', 'NV015', 'DA003')
insert into CongViec values ('CV090',N'Create preview function','02', '2022-12-24','2022-12-24', '2022-12-26','2022-12-26', '02', 'NV015', 'DA004')
insert into CongViec values ('CV091',N'Algorithm','02', '2023-01-09','2023-01-09', '2023-01-12','2023-01-12', '02', 'NV015', 'DA004')
insert into CongViec values ('CV092',N'Optimize the request-participate API','02', '2023-01-21','2023-01-21', '2023-01-25','2023-01-25', '02', 'NV015', 'DA004')
insert into CongViec values ('CV093',N'Fix algorithm of Black Plan','02', '2023-01-21','2023-01-21', '2023-01-24','2023-01-24', '02', 'NV015', 'DA004')
insert into CongViec values ('CV094',N'[BUG] Notification has not been sent','02', '2023-01-28','2023-01-28', '2023-01-31','2023-01-31', '02', 'NV015', 'DA004')
insert into CongViec values ('CV095',N'Add the logic of reminders','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV096',N'Bachelor coupon page','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV097',N'Check the validation of participation','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV098',N'Check all schedule command and change the businessI','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV099',N'Change get-dating-days API','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV100',N'Implement match-profile API','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV101',N'Fix unit test','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV102',N'Fix comment pull request','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV103',N'Create specification document for Notification function','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV104',N'Automating face screening operations','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV105',N'Investigate issue stripe','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV106',N'Create System flow in Figma','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV107',N'Mini talk feedback','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV108',N'Improve UI/UX at 1st ~ 2nd form','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV109',N'Estimate API for faster loading','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV110',N'[BUG]Cannot access link in notification"','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV111',N'[BUG] Cancel_matching_black_plan_issue_coupon is not sent','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
insert into CongViec values ('CV112',N'[BUG] Wrong pop-up appears even though user has a ticket','01', '2022-12-09', '2023-04-12', '02', 'NV015', 'DA001')
--PM
insert into CongViec values ('CV113','Add file Readme','04','2023-02-01','2023-02-01', '2023-02-03','2023-02-03','02', 'NV015', 'DA004')
insert into CongViec values ('CV114','Record video','04','2024-02-29','2024-02-29', '2024-03-01','2024-03-01','02', 'NV015', 'DA001')
insert into CongViec values ('CV115','BE intergration','04','2024-02-29','2024-02-29', '202-03-01','202-03-01','02', 'NV015', 'DA005')
insert into CongViec values ('CV116','Add license','04','2024-02-29','2024-02-29', '202-03-01','202-03-01','02', 'NV015', 'DA005')
insert into CongViec values ('CV117','Add file Readme','04','2024-02-29','2024-02-29', '202-03-01','202-03-01','02', 'NV015', 'DA005')
insert into CongViec values ('CV118','Add license','04','2024-02-29','2024-02-29', '202-03-01','202-03-01','02', 'NV015', 'DA005')
insert into CongViec values ('CV119','Manage issues','04','2024-02-29','2024-02-29', '2024-03-01','202-03-01','02', 'NV015', 'DA003')
insert into CongViec values ('CV120','Planning new project','04','2024-02-29','2024-02-29', '2024-03-01','2024-03-01','02', 'NV015', 'DA003')
--BA
insert into CongViec values ('CV121','Create SRS','03','2022-09-12','2022-09-12', '2022-09-20','2022-09-20','02', 'NV015', 'DA004')
insert into CongViec values ('CV122','SRS for admin role page','03','2024-02-29','2024-02-29', '2024-03-01','2024-03-01','02', 'NV015', 'DA005')
insert into CongViec values ('CV123','Review documents','03','2024-02-29','2024-02-29', '202-03-01','202-03-01','02', 'NV015', 'DA005')