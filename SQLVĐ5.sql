﻿create database QL_HieuSach
go 
use QL_HieuSach

create table SACH
(
MaSach int identity (1,2) primary key,
TenSach nvarchar(50),
SoTrang smallint, 
LanTaiBanThu tinyint, 
NamXB smallint,
CHECK (NamXB < YEAR(CURRENT_TIMESTAMP))
)
go 
create table TACGIA 
(
MaTacGia smallint identity (2,2) primary key, 
TenTacGia nvarchar(30),
GioiTinh nchar(3),
QuocTich nvarchar(15) not null,
CHECK (GioiTinh=N'Nam' or GioiTinh=N'Nữ')
)
go 
create table CHITIETVESACH 
(
	MaTacGia smallint foreign key references TACGIA(MaTacGia),
	MaSach int foreign key references SACH(MaSach)
)
GO 
create proc sp_SACH_ThemSach 
@TenSach nvarchar(50),
@SoTrang smallint, 
@LanTaiBanThu tinyint, 
@NamXB smallint
AS
Begin
Insert into SACH ( TenSach, SoTrang, LanTaiBanThu, NamXB) Values ( @TenSach, @SoTrang, @LanTaiBanThu, @NamXB)
end
go
create proc sp_SACH_UpdateSach
@MaSach int,
@TenSach nvarchar(50),
@SoTrang smallint, 
@LanTaiBanThu tinyint, 
@NamXB smallint
AS
Begin 
Update SACH SET TenSach = @TenSach, SoTrang= @SoTrang, LanTaiBanThu= @LanTaiBanThu, NamXB= @NamXB Where MaSach= @MaSach
end
go
create proc sp_SACH_DeleteSach 
@MaSach int
as 
begin 
Delete from SACH where MaSach=@MaSach
end 
go

create proc sp_TACGIA_ThemSach 
@TenTacGia nvarchar(30),
@GioiTinh nchar(3),
@QuocTich nvarchar(15)
AS
Begin
Insert into TACGIA ( TenTacGia, GioiTinh, QuocTich) Values (@TenTacGia, @GioiTinh, @QuocTich)
end
go
create proc sp_TACGIA_UpdateSach
@MaTacGia smallint, 
@TenTacGia nvarchar(30),
@GioiTinh nchar(3),
@QuocTich nvarchar(15)
AS
Begin 
Update TACGIA SET TenTacGia = @TenTacGia, GioiTinh= @GioiTinh, QuocTich= @QuocTich Where MaTacGia= @MaTacGia
end
go

after procedure sp_SACH_TimKiemTheoNamXBTenSach
	@NamXB nvarchar(30),
	@TenTacGia nvarchar(30)
	as
	begin
	SELECT S.MaSach , S.TenSach , S.NamXB , TG.TenTacGia
	From SACH as S inner join CHITIETVESACH as CT on S.MaSach = CT.MaSach inner join TACGIA as TG on TG.MaTacGia = CT.MaTacGia
	Where S.NamXB like '%' + @NamXB + '%' or TG.TenTacGia like '%' + @TenTacGia + '%'
	end
create proc sp_TACGIA_DeleteSach 
@MaTacGia smallint
as 
begin 
Delete from TACGIA where MaTacGia= @MaTacGia
end 
go
create proc sp_TACGIA_GetByAll
as
begin 
Select * from TACGIA
end 
go

create proc sp_Sach_GetByAll
as
select * from SACH

exec sp_SACH_GetByTacGiaVaNamXB , TacGia.TenTacGia like '% '