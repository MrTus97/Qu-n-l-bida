CREATE PROCEDURE TATBAN
@id_ban int,
@id_hoadon int
as
begin
	-- Cập nhật trạng thái cho bàn
	UPDATE BAN
	SET TRANGTHAI = 0,GIORA = getdate()
	where ID_BAN = @id_ban
	-- Tính tổng số giờ chơi của bàn có id_hoadon
	UPDATE HOADON 
	SET TONGGIOCHOI = (SELECT GIORA-GIOVAO FROM BAN WHERE ID_BAN =@id_ban) 
	where ID_HOADON = @id_hoadon
end