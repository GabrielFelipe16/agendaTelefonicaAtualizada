CREATE DATABASE IF NOT EXISTS dbagenda;
USE dbagenda;
CREATE TABLE IF NOT EXISTS usuarios(
	idUsuario INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(60) NOT NULL,
    usuario VARCHAR(45) NOT NULL,
    telefone VARCHAR(20),
    senha VARCHAR(20) NOT NULL
);
CREATE TABLE IF NOT EXISTS categorias(
	id_categoria INT PRIMARY KEY AUTO_INCREMENT,
    categoria VARCHAR(45) NOT NULL,
    usuario VARCHAR(45) NOT NULL
);

CREATE TABLE IF NOT EXISTS agenda(
	id_agenda INT PRIMARY KEY AUTO_INCREMENT,
    nome VARCHAR(45) NOT NULL,
    telefone VARCHAR(17) NOT NULL,
    categoria VARCHAR(50) NOT NULL,
    usuario VARCHAR(45) NOT NULL
);

CREATE TABLE IF NOT EXISTS log(
	idLog INT PRIMARY KEY AUTO_INCREMENT,
	usuario VARCHAR(45) NOT NULL,
    dataHora DATETIME NOT NULL,
    descricao VARCHAR(255) NOT NULL
);

DELIMITER $$
USE `dbagenda`$$
CREATE DEFINER=`root`@`localhost` TRIGGER `trInsertCategoria` BEFORE INSERT ON `categorias` FOR EACH ROW BEGIN
	SET NEW.usuario = USER();
END$$

CREATE DEFINER=`root`@`localhost` TRIGGER `trInsertAgenda` BEFORE INSERT ON `agenda` FOR EACH ROW BEGIN
	SET NEW.usuario = USER();
END$$

CREATE TRIGGER trlogcategoriadelete
AFTER
DELETE
ON categorias
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('A categoria: ', old.categoria, ' foi excluida')
    );
END$$


CREATE TRIGGER trlogcategoriainsert
AFTER
INSERT
ON categorias
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('A categoria: ', new.categoria, ' foi inserida')
    );
END$$


CREATE TRIGGER trlogcategoriaupdate
AFTER
UPDATE
ON categorias
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('A categoria: ', old.categoria, ' foi alterada para: ', new.categoria)
    );
END$$

CREATE TRIGGER trlogagendainsert
AFTER
INSERT
ON agenda
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('O contato: ', new.nome, ' foi adicionado com o telefône: ', new.telefone, ' e com a categoria: ', new.categoria)
    );
END$$

CREATE TRIGGER trlogagendaupdate
AFTER
UPDATE
ON agenda
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('O contato: ', old.nome, ' foi alterado para: ', new.nome, ' seu telefône foi de: ', old.telefone, ' para: ', new.telefone, ' e sua categoria foi de: ', old.categoria, ' para: ', new.categoria)
    );
END$$

CREATE TRIGGER trlogagendadelete
AFTER
DELETE
ON agenda
FOR EACH ROW
BEGIN
	INSERT INTO log (
		usuario, dataHora, descricao
    ) VALUES(
		USER(),
        NOW(3), 
        CONCAT('O contato: ', old.nome, ' com telefône: ', old.telefone, ' e categoria: ', old.categoria, ' foi DELETADO')
    );
END$$

DELIMITER ;