CREATE DATABASE BATCH_309;

CREATE TABLE PESERTA(
ID BIGINT PRIMARY KEY IDENTITY (1,1) NOT NULL,
NAME VARCHAR (50) NOT NULL,
JENIS_KELAMIN VARCHAR(1),
ALAMAT VARCHAR(MAX),
ASAL_KAMPUS VARCHAR(50) ,
TANGGAL_LAHIR DATETIME
)