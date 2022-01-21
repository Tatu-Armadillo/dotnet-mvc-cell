create database cell_db;
use cell_db;

create table phones (
	id bigint primary key auto_increment,
    marca varchar(255),
    modelo varchar(255),
    cor varchar(255),
    tela varchar(255),
    camera varchar(255),
    memoria varchar(255),
    bateria varchar(255)
);

INSERT INTO `cell_db`.`phones` (`id`, `marca`, `modelo`, `cor`, `tela`, `camera`, `memoria`, `bateria`) VALUES ('1', 'Xiomi', 'Poco X3 Pro ', 'cinza', '60', 'sem embelezamento', '128', 'MIUI 12');
