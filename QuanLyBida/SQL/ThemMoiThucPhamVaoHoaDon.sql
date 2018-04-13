CREATE PROCEDURE ThemMoiThucPhamVaoHoaDon
@id_hoadon int,
@soluong int,
@id_thucpham int
as
begin
	insert into CHITIETHD
	Values (@id_hoadon,@id_thucpham,@soluong)

	update THUCPHAM
	set SOLUONG = SOLUONG - @soluong
	where ID_THUCPHAM = @id_thucpham
end