CREATE PROCEDURE BATGIO
@id int
as
begin
	insert into HOADON
	values (@id,NULL,NULL,NULL,NULL,NULL,0,0,0,0);

	update BAN 
	set trangthai = 1, GIOVAO = GETDATE(), GIORA = NULL 
	where ID_BAN = @id;
end
