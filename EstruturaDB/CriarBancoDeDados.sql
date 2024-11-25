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
    categoria VARCHAR(45) NOT NULL,
    usuario VARCHAR(45) NOT NULL
);

CREATE TABLE IF NOT EXISTS log(
	idLog INT PRIMARY KEY AUTO_INCREMENT,
	usuario VARCHAR(45) NOT NULL,
    dataHora DATETIME NOT NULL,
    descricao VARCHAR(100) NOT NULL
);

DELIMITER $$
USE `dbagenda`$$
CREATE DEFINER=`root`@`localhost` TRIGGER `trInsertCategoria` BEFORE INSERT ON `categorias` FOR EACH ROW BEGIN
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

DELIMITER ;