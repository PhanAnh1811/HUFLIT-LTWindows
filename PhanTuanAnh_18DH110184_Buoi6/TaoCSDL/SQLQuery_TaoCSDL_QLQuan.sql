CREATE DATABASE QLQuan

USE QLQuan

CREATE TABLE ThucUong(
	MSHH nvarchar(10) NOT NULL PRIMARY KEY ,
	TenHang nvarchar(20) NOT NULL,
	Gia int NOT NULL,
	TinhTrang bit NOT NULL
);

CREATE TABLE HoaDonDatHang(
	MSDH nvarchar(10) NOT NULL,
	MSHH nvarchar(10) NOT NULL,
	SoLuong int,
	TiLeGiam int
	PRIMARY KEY(MSDH),
	FOREIGN KEY (MSHH) REFERENCES ThucUong(MSHH)
);

CREATE TABLE BangHoaDon(
	MSDH nvarchar(10),
	NgayDat datetime,
	PRIMARY KEY (MSDH), 
	FOREIGN KEY (MSDH) REFERENCES HoaDonDatHang(MSDH)
);
