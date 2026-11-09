create table Carrinho(

	ID INT PRIMARY KEY IDENTITY,
	IdUsuario Int,
	Nome VarChar(50),
	Quantidade Int,
	Valor VarChar(10)

);
drop table Carrinho;
select * from Carrinho;