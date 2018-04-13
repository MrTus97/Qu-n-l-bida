USE [QL_BILLARD]
GO
/****** Object:  StoredProcedure [dbo].[ShowBill]    Script Date: 09/04/2018 8:06:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[ShowBill] 
@idhoadon int = null
as
begin
SELECT tp.TENTHUCPHAM,ct.SOLUONG
FROM CHITIETHD ct,THUCPHAM tp
WHERE ID_HOADON = @idhoadon and (tp.ID_THUCPHAM = ct.ID_THUCPHAM)
end