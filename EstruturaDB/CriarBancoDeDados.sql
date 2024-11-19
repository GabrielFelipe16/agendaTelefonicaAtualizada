CREATE DATABASE IF NOT EXISTS dbagenda;
USE dbagenda;
CREATE TABLE IF NOT EXISTS usuarios(
	idUsuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(45) NOT NULL,
    telefone VARCHAR(15),
    senha VARCHAR(20) NOT NULL
);
CREATE TABLE IF NOT EXISTS categorias(
	id_categoria INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(45) NOT NULL
);

DELIMITER $$
USE `dbagenda`$$
CREATE DEFINER=`root`@`localhost` TRIGGER `trInsertCategoria` BEFORE INSERT ON `categorias` FOR EACH ROW BEGIN
	SET NEW.usuario = USER();
END$$
DELIMITER ;
