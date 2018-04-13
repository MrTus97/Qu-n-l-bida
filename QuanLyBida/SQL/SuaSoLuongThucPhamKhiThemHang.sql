CREATE PROCEDURE SuaSoLuongThucPhamKhiThemHang
@id_hoadon int,
@soluong int,
@id_thucpham int
as
begin
	update CHITIETHD
	set SOLUONG = SOLUONG + @soluong
	where ID_HOADON = @id_hoadon and ID_THUCPHAM= @id_thucpham

	update THUCPHAM
	set SOLUONG = SOLUONG - @soluong
	where ID_THUCPHAM = @id_thucpham
end