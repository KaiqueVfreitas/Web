create database dbProjeto;
use dbProjeto;

create table tbCliente(
	idCli int primary key,
    nome varchar(50), 
    telefone varchar(20),
    email varchar(50)
);