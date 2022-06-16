--create database ATOSUFN;

use ATOSUFN;

		--public string nome;
  --      public int idade;
  --      public string cpf;
  --      public string end;
  --      public string bairro;
  --      public string cep;
  --      public string cidade;

create table pessoa(
id integer primary key not null identity,
nome varchar(50),
idade integer,
cpf varchar(20),
endereco varchar(100),
bairro varchar(50),
cep varchar(10),
cidade varchar(50)
);

insert into pessoa values('Andrea Silvestre',44,'03455498647', 'Rua João Pessoa, 250', 'Santana','01520-035', 'São Paulo');
insert into pessoa values('Gata Alice',3,'03455498647', 'Rua João Pessoa, 250', 'Santana','01520-035', 'São Paulo');
insert into pessoa values('Joaozinho',15,'03455498647', 'Rua João Pessoa, 250', 'Santana','01520-035', 'São Paulo');

select * from pessoa;

select * from INFORMATION_SCHEMA.TABLES; -- ve tabelas
select * from INFORMATION_SCHEMA.COLUMNS;

select nome, cpf from pessoa;