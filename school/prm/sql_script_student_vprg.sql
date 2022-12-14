-- MySQL Script generated by MySQL Workbench
-- Thu Oct 17 10:10:44 2019
-- Model: New Model    Version: 1.0
-- MySQL Workbench Forward Engineering

SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0;
SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0;
SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='ONLY_FULL_GROUP_BY,STRICT_TRANS_TABLES,NO_ZERO_IN_DATE,NO_ZERO_DATE,ERROR_FOR_DIVISION_BY_ZERO,NO_ENGINE_SUBSTITUTION';

-- -----------------------------------------------------
-- Schema Student
-- -----------------------------------------------------
DROP SCHEMA IF EXISTS `Student` ;

-- -----------------------------------------------------
-- Schema Student
-- -----------------------------------------------------
CREATE SCHEMA IF NOT EXISTS `Student` DEFAULT CHARACTER SET utf8 ;
USE `Student` ;

-- -----------------------------------------------------
-- Table `Student`.`Docent`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Student`.`Docent` ;

CREATE TABLE IF NOT EXISTS `Student`.`Docent` (
  `afkorting` VARCHAR(4) NOT NULL,
  `naam` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `geboortedatum` DATE NOT NULL,
  `geslacht` CHAR(1) NOT NULL,
  `createDate` DATETIME NOT NULL DEFAULT now(),
  `updateDate` DATETIME NOT NULL DEFAULT now(),
  PRIMARY KEY (`afkorting`))
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Student`.`Klas`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Student`.`Klas` ;

CREATE TABLE IF NOT EXISTS `Student`.`Klas` (
  `afkorting` VARCHAR(5) NOT NULL,
  `omschrijving` VARCHAR(100) NOT NULL,
  `locatie` VARCHAR(45) NOT NULL,
  `mentor` VARCHAR(4) NOT NULL,
  `createDate` DATETIME NOT NULL DEFAULT now(),
  `updateDate` DATETIME NOT NULL DEFAULT now(),
  PRIMARY KEY (`afkorting`),
  INDEX `fk_Klas_Docent_idx` (`mentor` ASC),
  CONSTRAINT `fk_Klas_Docent`
    FOREIGN KEY (`mentor`)
    REFERENCES `Student`.`Docent` (`afkorting`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Student`.`Student`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Student`.`Student` ;

CREATE TABLE IF NOT EXISTS `Student`.`Student` (
  `id` INT NOT NULL,
  `naam` VARCHAR(45) NOT NULL,
  `email` VARCHAR(100) NOT NULL,
  `straat` VARCHAR(45) NOT NULL,
  `woonplaats` VARCHAR(45) NOT NULL,
  `klas` VARCHAR(5) NOT NULL,
  `createDate` DATETIME NOT NULL DEFAULT now(),
  `updateDate` DATETIME NOT NULL DEFAULT now(),
  PRIMARY KEY (`id`),
  UNIQUE INDEX `email_UNIQUE` (`email` ASC),
  INDEX `fk_Student_Klas_idx` (`klas` ASC),
  CONSTRAINT `fk_Student_Klas`
    FOREIGN KEY (`klas`)
    REFERENCES `Student`.`Klas` (`afkorting`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


-- -----------------------------------------------------
-- Table `Student`.`Login`
-- -----------------------------------------------------
DROP TABLE IF EXISTS `Student`.`Login` ;

CREATE TABLE IF NOT EXISTS `Student`.`Login` (
  `email` VARCHAR(100) NOT NULL,
  `password` VARCHAR(256) NOT NULL,
  `createDate` DATETIME NOT NULL DEFAULT now(),
  `updateDate` DATETIME NOT NULL DEFAULT now(),
  PRIMARY KEY (`email`),
  CONSTRAINT `fk_Login_Student`
    FOREIGN KEY (`email`)
    REFERENCES `Student`.`Student` (`email`)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION)
ENGINE = InnoDB;


SET SQL_MODE=@OLD_SQL_MODE;
SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS;
SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS;

-- -----------------------------------------------------
-- Data for table `Student`.`Docent`
-- -----------------------------------------------------
START TRANSACTION;
USE `Student`;
INSERT INTO `Student`.`Docent` (`afkorting`, `naam`, `email`, `geboortedatum`, `geslacht`, `createDate`, `updateDate`) VALUES ('Jan', 'jansen', 'jan@mail.nl', '1990/3/12', 'M', DEFAULT, DEFAULT);

COMMIT;


-- -----------------------------------------------------
-- Data for table `Student`.`Klas`
-- -----------------------------------------------------
START TRANSACTION;
USE `Student`;
INSERT INTO `Student`.`Klas` (`afkorting`, `omschrijving`, `locatie`, `mentor`, `createDate`, `updateDate`) VALUES ('AM2A', '2de jaars programmeren', 'daltonlaan', 'Jan', DEFAULT, DEFAULT);
INSERT INTO `Student`.`Klas` (`afkorting`, `omschrijving`, `locatie`, `mentor`, `createDate`, `updateDate`) VALUES ('AM2B', '2de jaars programmeren', 'Australienlaan', 'Jan', DEFAULT, DEFAULT);

COMMIT;


-- -----------------------------------------------------
-- Data for table `Student`.`Student`
-- -----------------------------------------------------
START TRANSACTION;
USE `Student`;
INSERT INTO `Student`.`Student` (`id`, `naam`, `email`, `straat`, `woonplaats`, `klas`, `createDate`, `updateDate`) VALUES (1, 'Peters', 'peters@mail.nl', 'laan 4', 'Amsterdam', 'AM2A', DEFAULT, DEFAULT);
INSERT INTO `Student`.`Student` (`id`, `naam`, `email`, `straat`, `woonplaats`, `klas`, `createDate`, `updateDate`) VALUES (2, 'Groen', 'groen@mail.nl', 'weg 45', 'Utrecht', 'AM2B', DEFAULT, DEFAULT);

COMMIT;


-- -----------------------------------------------------
-- Data for table `Student`.`Login`
-- -----------------------------------------------------
START TRANSACTION;
USE `Student`;
INSERT INTO `Student`.`Login` (`email`, `password`, `createDate`, `updateDate`) VALUES ('groen@mail.nl', 'groen123', DEFAULT, DEFAULT);
INSERT INTO `Student`.`Login` (`email`, `password`, `createDate`, `updateDate`) VALUES ('peters@mail.nl', 'peters123', DEFAULT, DEFAULT);

COMMIT;

