DROP DATABASE QLSV;
CREATE DATABASE QLSV;
USE QLSV;
CREATE TABLE GIANGVIEN
(
	MaGV nvarchar(10) primary key NOT NULL,
	TenGV nvarchar(50) NULL,
)
CREATE TABLE HOCKY
(
	MaHK nvarchar(10) primary key NOT NULL,
	TenHK nvarchar(50) NULL,
)
CREATE TABLE DIEM
(
	MaSV nvarchar(10)  primary key NOT NULL,
	MaMH nvarchar(10) NOT NULL,
	DiemCC int NULL,
	DiemKT float NULL,
	DiemGK float NULL,
	DiemThi float NULL,
	DiemTB float NULL,
	MaGV nvarchar(10) NOT NULL,
	MaHK nvarchar(10) NOT NULL,
	FOREIGN KEY (MaGV) REFERENCES GIANGVIEN(MaGV),
	FOREIGN KEY (MaHK) REFERENCES HOCKY(MaHK)
 )
CREATE TABLE KHOA
(
	MaKhoa nvarchar(10) primary key NOT NULL,
	TenKhoa nvarchar(50) NULL,
)
CREATE TABLE LOP
(
	MaLop nvarchar(10) primary key NOT NULL,
	TenLop nvarchar(50) NULL,
	MaKhoa nvarchar(10) NOT NULL,
	MaGV nvarchar(10) NOT NULL,
	FOREIGN KEY (MaGV) REFERENCES GIANGVIEN(MaGV)
 )
CREATE TABLE MONHOC
(
	MaMH nvarchar(10) primary key NOT NULL,
	TenMH nvarchar(50) NULL,
	MaGV nvarchar(10) NOT NULL,
	FOREIGN KEY (MaGV) REFERENCES GIANGVIEN(MaGV)
 )


CREATE TABLE SINHVIEN
(
	MaSV nvarchar(10) primary key  NOT NULL,
	HoSV nvarchar(30) not null,
	TenSV nvarchar(50) NULL,
	GioiTinh bit not null,
	NgaySinh date not null,
	MaLop nvarchar(10) NOT NULL,
	MaKhoa nvarchar(10) NOT NULL,
	FOREIGN KEY (MaLop) REFERENCES LOP(MaLop),
	FOREIGN KEY (MaKhoa) REFERENCES KHOA(MaKhoa)
)

insert into HOCKY values('KH1',N'Học kỳ 1'),('HK2','Học kỳ 2')
insert into GIANGVIEN values('GV001',N'Đinh Văn Thế'),('GV002',N'Nguyễn Hoàn Quân'),('GV003',N'Mai Cường Thọ')


create proc dssinhvientheokhoa
@makhoa nvarchar(10)
as
begin
select ROW_NUMBER() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên], TenSV as [Tên sinh viên],NgaySinh as [Ngày sinh], MaLop as [Mã lớp],MaKhoa as [Mã khoa] from SINHVIEN where MaKhoa = @makhoa
end

create proc dssinhvientheolop
@malop nvarchar(10)
as
begin
select ROW_NUMBER() over (order by MaSV) as STT, MaSV as [Mã Sinh Viên], TenSV as [Tên sinh viên],NgaySinh as [Ngày sinh], MaLop as [lớp],MaKhoa as [khoa] from SINHVIEN where MaKhoa = @malop
end


create proc diemtheolop
@MaLop nvarchar(10)
as
begin
	select ROW_NUMBER() over (order by SINHVIEN.MaSV) as STT, SINHVIEN.MaSV, MONHOC.TenMH,LOP.MaLop, DiemCC,DiemGK,DiemKT,DiemThi, DiemTB,MaHK  from MONHOC, DIEM,SINHVIEN,LOP where SINHVIEN.MaSV = DIEM.MaSV and SINHVIEN.MaLop = @MaLop
end

