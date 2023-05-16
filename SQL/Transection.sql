--Transection: Bir eylemin, belirli bir durumda geri alınabilir olmasını sağlayan kurallı akış

BEGIN TRY
	Begin tran T1
		--Çalışması gereken ilk sorgu
		begin tran T2
			--T1'in çalışmasına bağlı ikinci transaction
		Commit Tran t2
	Commit Tran T1
End TRY
Begin Catch
	rollback tran T1
End Catch