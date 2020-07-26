CREATE DATABASE IF NOT EXISTS userInfoDB;
USE userInfoDB;

CREATE TABLE IF NOT EXISTS user(
    id 			INT	   AUTO_INCREMENT PRIMARY KEY,
    username		CHAR(25)   NOT NULL,
    password		CHAR(25)   NOT NULL
)ENGINE = INNODB CHARACTER SET=utf8;

INSERT INTO `user`(id,username,password) values(1,'Admin','Admin');

CREATE TABLE IF NOT EXISTS user_detail (
    id                  INT         AUTO_INCREMENT PRIMARY KEY,
    user_type           CHAR(25)    NOT NULL,
    first_name          CHAR(25)    NOT NULL,
    last_name           CHAR(25)    NOT NULL,
    email               CHAR(64)    NOT NULL,
    contact_number      CHAR(15)    NOT NULL,
    pan_number		CHAR(15)    NOT NULL,
    address             CHAR(255)   NOT NULL,
    amount_paid		FLOAT(10,4) NOT NULL,
    paid_date		DATETIME    NOT NULL,
    application_no	CHAR(50)    UNIQUE,
    updated_by          INT         NOT NULL DEFAULT 0,
    deleted             TINYINT(1)  NOT NULL DEFAULT 0,
    creation_date       DATETIME    DEFAULT CURRENT_TIMESTAMP,
    last_update         DATETIME    DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP
)ENGINE = INNODB CHARACTER SET=utf8;
