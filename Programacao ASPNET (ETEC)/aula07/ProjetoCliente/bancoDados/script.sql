create database dbProjeto;
use dbProjeto;

create table tbCliente(
	codCli int primary key auto_increment,
    nome varchar(50), 
    telefone varchar(20),
    email varchar(50)
);

insert into tbCliente (codCli, nome, telefone, email) values (1, "Kaique Vieira", "11933156578", "kaique@gmail.com");

use crud01;
select * from tbcadastro;