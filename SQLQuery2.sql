create table clientes (
id int identity primary key not null,
Nome varchar(100),
email varchar(100),
rua varchar(70),
bairro varchar(70),
cidade varchar(70),
estado varchar(40),
senha varchar(100),
cpf varchar(100),
cod int,
dataCod date,
statusCliente varchar(20)

);

create table Carrinho(

	ID INT PRIMARY KEY IDENTITY,
	IdUsuario Int,
	Nome VarChar(50),
	Quantidade Int,
	Valor VarChar(10)

);
