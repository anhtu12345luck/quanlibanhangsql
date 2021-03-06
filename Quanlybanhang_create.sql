-- Created by Vertabelo (http://vertabelo.com)
-- Last modification date: 2016-01-22 13:56:50.067


CREATE DATABASE Quanlybanhang
GO
USE Quanlybanhang

CREATE TABLE ChiTietHoaDon (
    MaSP nvarchar(10)  NOT NULL,
    MaHD nvarchar(10)  NOT NULL,
    Soluongmua nvarchar(10)  NOT NULL,
    Giaban money  NOT NULL,
    HoaDon_MaHD nvarchar(10)  NOT NULL,
    SanPham_MaSP nvarchar(10)  NOT NULL,
    CONSTRAINT ChiTietHoaDon_pk PRIMARY KEY  (MaSP)
)
;



-- Table: HoaDon
CREATE TABLE HoaDon (
    MaHD nvarchar(10)  NOT NULL,
    NgayLap datetime  NOT NULL,
    MaKH nvarchar(10)  NOT NULL,
    KhachHang_MaKH nvarchar(10)  NOT NULL,
    CONSTRAINT HoaDon_pk PRIMARY KEY  (MaHD)
)
;



-- Table: KhachHang
CREATE TABLE KhachHang (
    MaKH nvarchar(10)  NOT NULL,
    Hoten nvarchar(50)  NOT NULL,
    Diachi nvarchar(200)  NOT NULL,
    SDT nvarchar(15)  NOT NULL,
    CONSTRAINT KhachHang_pk PRIMARY KEY  (MaKH)
)
;



-- Table: LoaiSanPham
CREATE TABLE LoaiSanPham (
    Maloai nvarchar(10)  NOT NULL,
    Tenloai nvarchar(50)  NOT NULL,
    CONSTRAINT LoaiSanPham_pk PRIMARY KEY  (Maloai)
)
;



-- Table: SanPham
CREATE TABLE SanPham (
    MaSP nvarchar(10)  NOT NULL,
    TenSP nvarchar(200)  NOT NULL,
    Maloai nvarchar(10)  NOT NULL,
    Soluong nvarchar(10)  NOT NULL,
    Mota nvarchar(200)  NOT NULL,
    LoaiSanPham_Maloai nvarchar(10)  NOT NULL,
    CONSTRAINT SanPham_pk PRIMARY KEY  (MaSP)
)
;









-- foreign keys
-- Reference:  ChiTietHoaDon_HoaDon (table: ChiTietHoaDon)

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_HoaDon 
    FOREIGN KEY (HoaDon_MaHD)
    REFERENCES HoaDon (MaHD)
;

-- Reference:  ChiTietHoaDon_SanPham (table: ChiTietHoaDon)

ALTER TABLE ChiTietHoaDon ADD CONSTRAINT ChiTietHoaDon_SanPham 
    FOREIGN KEY (SanPham_MaSP)
    REFERENCES SanPham (MaSP)
;

-- Reference:  HoaDon_KhachHang (table: HoaDon)

ALTER TABLE HoaDon ADD CONSTRAINT HoaDon_KhachHang 
    FOREIGN KEY (KhachHang_MaKH)
    REFERENCES KhachHang (MaKH)
;

-- Reference:  SanPham_LoaiSanPham (table: SanPham)

ALTER TABLE SanPham ADD CONSTRAINT SanPham_LoaiSanPham 
    FOREIGN KEY (LoaiSanPham_Maloai)
    REFERENCES LoaiSanPham (Maloai)
;

-- End of file.
---Chèn dữ liệu
-----Bảng Khách Hàng
select * from dbo.KhachHang
delete from dbo.Khachhang
	insert into dbo.Khachhang values (N'KH01',N'Hoàng Anh Tú',N'Thanh Hóa',N'01233040396')
	insert into dbo.Khachhang values (N'KH02',N'Khương Văn Minh',N'Thanh Hóa',N'01672579157')
	insert into dbo.Khachhang values (N'KH03',N'Nguyễn Văn Hà',N'Bắc Giang',N'01623654879')
	insert into dbo.Khachhang values (N'KH04',N'Phạm Ngọc Ninh',N'Thái Bình',N'01685326245')
	insert into dbo.Khachhang values (N'KH05',N'Nguyễn Tuấn Anh',N'Bắc Giang',N'0974365326')
	insert into dbo.Khachhang values (N'KH06',N'Dương Văn Hoàng',N'Thái Bình',N'0916325647')
	insert into dbo.Khachhang values (N'KH07',N'Vũ Văn Mạnh',N'Hà Nội',N'01648563215')
-----Bảng Hóa Đơn
select * from dbo.HoaDon
delete from dbo.HoaDon
	insert into dbo.HoaDon values (N'HD01','01/01/2016',N'KH01',N'KH01')
	insert into dbo.HoaDon values (N'HD02','01/05/2016',N'KH02',N'KH02')
	insert into dbo.HoaDon values (N'HD03','01/09/2016',N'KH03',N'KH03')
	insert into dbo.HoaDon values (N'HD04','01/11/2016',N'KH04',N'KH04')
	insert into dbo.HoaDon values (N'HD05','01/12/2016',N'KH05',N'KH05')
	insert into dbo.HoaDon values (N'HD06','01/18/2016',N'KH06',N'KH06')
	insert into dbo.HoaDon values (N'HD07','01/22/2016',N'KH07',N'KH07')
-----Bảng Loại Sản Phẩm
select * from dbo.LoaiSanPham
delete from dbo.LoaiSanPham
	insert into dbo.LoaiSanPham values (N'ML01',N'Điện Tử - Âm Thanh')
	insert into dbo.LoaiSanPham values (N'ML02',N'Đồ Gia Dụng')
	insert into dbo.LoaiSanPham values (N'ML03',N'Điện Lạnh')
	insert into dbo.LoaiSanPham values (N'ML04',N'Điện Thoại')
	insert into dbo.LoaiSanPham values (N'ML05',N'Máy Tính')
	insert into dbo.LoaiSanPham values (N'ML06',N'Mỹ Phẩm')
	insert into dbo.LoaiSanPham values (N'ML07',N'Đồ Chơi Trẻ Em')

-----Bảng Sản Phẩm
select * from dbo.SanPham
delete from dbo.SanPham
	insert into dbo.SanPham values (N'SP01',N'Tivi',N'ML01',N'10',N'Tivi LED Full HD',N'ML01')
	insert into dbo.SanPham values (N'SP02',N'Nồi cơm điện',N'ML02',N'10',N'Đa năng',N'ML02')
	insert into dbo.SanPham values (N'SP03',N'Tủ lạnh',N'ML03',N'10',N'Tiệt kiệm năng',N'ML03')
	insert into dbo.SanPham values (N'SP04',N'Smart Phone',N'ML04',N'10',N'Thông minh',N'ML04')
	insert into dbo.SanPham values (N'SP05',N'Laptop',N'ML05',N'10',N'Cấu hình mạnh',N'ML05')
	insert into dbo.SanPham values (N'SP06',N'Son',N'ML06',N'10',N'Màu đẹp',N'ML06')
	insert into dbo.SanPham values (N'SP07',N'Ô tô điểu khiển',N'ML07',N'10',N'Đẹp',N'ML07')

------Bảng Chi Tiết Hóa Đơn
select * from dbo.ChiTietHoaDon
delete from dbo.ChiTietHoaDon
	insert into dbo.ChiTietHoaDon values (N'SP01',N'HD01',N'2','100000',N'HD01',N'SP01')
	insert into dbo.ChiTietHoaDon values (N'SP02',N'HD02',N'5','500000',N'HD02',N'SP02')
	insert into dbo.ChiTietHoaDon values (N'SP03',N'HD03',N'3','300000',N'HD03',N'SP03')
	insert into dbo.ChiTietHoaDon values (N'SP04',N'HD04',N'6','600000',N'HD04',N'SP04')
	insert into dbo.ChiTietHoaDon values (N'SP05',N'HD05',N'5','500000',N'HD05',N'SP05')
	insert into dbo.ChiTietHoaDon values (N'SP06',N'HD06',N'10','1000000',N'HD06',N'SP06')
	insert into dbo.ChiTietHoaDon values (N'SP07',N'HD07',N'9','900000',N'HD07',N'SP07')

