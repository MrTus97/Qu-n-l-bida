CREATE PROCEDURE XOAMATHANG
@idHoaDon int,
@idThucPham int,
@soluong int
as
begin
	delete CHITIETHD
	where ID_HOADON = @idHoaDon and @idThucPham = @idThucPham

	update THUCPHAM
	SET SOLUONG = SOLUONG + @soluong
	where ID_THUCPHAM= @idThucPham
end