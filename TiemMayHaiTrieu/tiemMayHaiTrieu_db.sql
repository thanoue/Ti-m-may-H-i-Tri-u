
create table KhachHang(
 Id int primary key identity(1,1),
tenKhachHang nvarchar(50),
soDienThoai nvarchar(20),
diaChi nvarchar(50),
ghiChu text)
go

create table LoaiNhanVien(
Id int primary key identity(1,1),
tenLoaiNhanVien nvarchar(20))
go
create table NhanVien(
Id int primary key identity(1,1),
soDienThoai nvarchar(20),
tenNhanVien nvarchar(30),
anhDaiDien nvarchar(30),
tenDangNhap nvarchar(20),		
matKhau nvarchar(15),
maLoaiNhanVien int ,
foreign key(maLoaiNhanVien) references LoaiNhanVien(Id))
go
create table MayAo(
Id int primary key identity(1,1),
maKhachHang int,
ngayDat datetime,
ngayHenLay datetime,
ngayHenThu datetime,
daiAo nvarchar(10), daiTay nvarchar(10), Nguc nvarchar(10),eoAo nvarchar(10),eoQuan nvarchar(10),vongMong nvarchar(10),Nach nvarchar(10),
bapTay nvarchar(10),vongCo nvarchar(10), haNguc nvarchar(10), haEo nvarchar(10),daiQuan nvarchar(10),chieuCaoGiay nvarchar(10),
ongQuan nvarchar(10),
ghiChu text,
anhAo nvarchar(100),anhQuan nvarchar(100),
loaiCo nvarchar(20),kichThuocCo nvarchar(10),
tinhTrang nvarchar(20),tienCong money,
maThoCat int,congThoCat money,
maThoMay int,congThoMay money,maThoLuong int,congThoLuong money
foreign key (maKhachHang) references KhachHang(Id),
foreign key (maThoCat) references NhanVien(Id),
foreign key (maThoMay) references NhanVien(Id),
foreign key (maThoLuong) references NhanVien(Id)
)
go
create table LuongThang(
maThang int,
maNam int,
maNhanVien int,
tongLuong money,
primary key (maThang,maNam,maNhanVien),
foreign key (maNhanVien) references NhanVien(Id))
go
create table KhoVai(
Id int primary key identity(1,1),
tenLoaiVai nvarchar(20),
soLuong int,
tamGia nvarchar(20),
anhDaiDien nvarchar(50),
)	
create table HoaDonBanVai(
Id int primary key identity(1,1),
maKhachHang int,
tongTien money,
ngayLapHoaDon money,
ghiChu text,
tongTienLoi money,
foreign key(maKhachHang) references KhachHang(Id)
)
create table ChiTietHoaDonBanVai(
maHoaDon int,
maLoaiVai int,
soLuong int,
donGia money,
tongTien money,
anhDaiDien nvarchar(50),
primary key (maHoaDon,maLoaiVai,anhDaiDien,donGia),
foreign key(maHoaDon) references HoaDonBanVai(Id),
foreign key( maLoaiVai) references KhoVai(Id),
)
create table SuaAo(
Id int primary key identity(1,1),
maKhachHang int,
maAo int,
Phi money,
ngayBatDauSua datetime,
daSuaXong bit,
foreign key(maKhachhang) references KhachHang(Id),
foreign key(maAo) references MayAo(Id),
)
create table HangDat(
Id int, 
maKhachHang int primary key identity(1,1),
tenHang nvarchar(30),
chiTiet nvarchar(max),
giaTien money,
tienCoc money,
tienConLai money,
ngayhenLay datetime,
ngayDatTho datetime,
ngayThoGiao datetime,
foreign key(maKhachHang) references KhachHang(Id)
)
