﻿use QLQuan

-- thêm thông tin vào bảng thức uống
INSERT INTO ThucUong(MSHH,TenHang,Gia,TinhTrang)
VALUES ('TS002',N'Trà sữa',35000,0)

INSERT INTO ThucUong(MSHH,TenHang,Gia,TinhTrang)
VALUES ('TS003',N'Trà đào',40000,1)

INSERT INTO ThucUong(MSHH,TenHang,Gia,TinhTrang)
VALUES ('TS004',N'Trà bạc hà',52000,1)

-- thêm thông tin vào bảng hóa đơn đặt hàng
INSERT INTO HoaDonDatHang(MSDH,MSHH,SoLuong,TiLeGiam)
VALUES ('TM002','TS002',100,50);

INSERT INTO HoaDonDatHang(MSDH,MSHH,SoLuong,TiLeGiam)
VALUES ('TM003','TS003',5,0);

INSERT INTO HoaDonDatHang(MSDH,MSHH,SoLuong,TiLeGiam)
VALUES ('TM004','TS004',200,10);

INSERT INTO HoaDonDatHang(MSDH,MSHH,SoLuong,TiLeGiam)
VALUES ('TM006','TS004',5,20);

INSERT INTO HoaDonDatHang(MSDH,MSHH,SoLuong,TiLeGiam)
VALUES ('TM007','TS004',5,20);

-- thêm thông tin vào bảng hóa đơn
INSERT INTO BangHoaDon(MSDH,NgayDat)
VALUES ('TM002','2020-4-3 13:32:11')

INSERT INTO BangHoaDon(MSDH,NgayDat)
VALUES ('TM003','2020-4-3 23:32:11')

INSERT INTO BangHoaDon(MSDH,NgayDat)
VALUES ('TM004','2020-5-3 7:32:11')

INSERT INTO BangHoaDon(MSDH,NgayDat)
VALUES ('TM006','2020-5-3 5:32:11')

INSERT INTO BangHoaDon(MSDH,NgayDat)
VALUES ('TM007','5/3/2020 6:37:42 PM')

DELETE FROM ThucUong WHERE MSHH='TS002';
UPDATE ThucUong SET Gia=20000,TinhTrang=1,TenHang=N'Cacao sữa'WHERE MSHH ='TS001'

-- test
SELECT * FROM ThucUong
SELECT * FROM HoaDonDatHang
SELECT * FROM BangHoaDon