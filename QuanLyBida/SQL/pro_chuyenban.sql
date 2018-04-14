CREATE PROCEDURE chuyenban
@curr int,
@taget int
as
begin
update ban set TRANGTHAI =1,GIOVAO=(select GIOVAO from BAN where ID_BAN=@curr),GIORA = null where ID_BAN=@taget
Update ban set TRANGTHAI = 0,GIOVAO=null,GIORA=null where ID_BAN=@curr
update HOADON set ID_BAN = @taget where ID_HOADON = (select top 1 (ID_HOADON) from HOADON where ID_BAN = @curr order by ID_HOADON desc)
end
