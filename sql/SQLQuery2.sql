ALTER

alter table peserta add email varchar(30) not null
alter table peserta drop



alter table peserta drop  asal_kampus,
alter table peserta ALTER column JENIS_KELAMIN varchar(10)  

Insert into PESERTA 
(NAME,JENIS_KELAMIN, ALAMAT, TANGGAL_LAHIR,email)
values
('Ihsan', 'L','Duri Kosambi','11/11/2001' , 'ihsanzack@gmail.com'),
('Rafli','L','Depok','11/11/1990','rafli@gmail.com'),
('Hedi','L', 'Jakarta Barat','02/02/2000', 'Hedi@gmail.com'),
('Bambang','L', 'Jakarta Timur','02/05/2011',  'Hedi@gmail.com'),
('ALISA', 'P', 'JAKARTA TIMUR', '02/07/2001', '�LISA@GMAIL.COM'),
('Santoso','L', 'Jakarta Utara','02/07/2000',  'Hedi@gmail.com')


select * from PESERTA;

SELECT * FROM PESERTA
WHERE ID > 5 OR NAMA='hedi'

UPDATE PESERTA SET ALAMAT = 'jAKARTA sEALAATAN' WHERE ALAMAT = 'jAKARTA tIMUR',

UPDATE PESEERTA SET ALAMAT = 'JAKARTA BARAT', NAME = 'ALISA'
WHERE ID = 5

SELECT * fROM PESERTA WHERE 
(JENIS_KELAMIN = 'PRIA' AND ALAMAT='JAKARTA BARAT') OR ID > 6
ORDER BY NAME DESC

SELECT * FROM PESERTA 

SELECT * FROM PESERTA 
WHERE ID BETWEEN 3 AND 6

SELECT * FROM PESERTA WHERE ALAMAT LIKE 'J%'


SELECT JENIS_KELAMIN,  COUNT(JENIS_KELAMIN) AS JML_ALAMAT FROM PESERTA
GROUP BY JENIS_KELAMIN

SELECT JENIS_KELAMIN,  COUNT(JENIS_KELAMIN) AS JML_ALAMAT FROM PESERTA
GROUP BY JENIS_KELAMIN
HAVING COUNT(JENIS_KELAMIN) > 2 

NILAI => ID, ID_PESERTA, NILAI(INT)
GAJI=> ID, ID_PESERTA, GAJI(DECIMAL(18,0))

CREATE TABLE NILAI (
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL, 
ID_PESERTA INT NOT NULL,
NILAI INT NOT NULL
)

CREATE TABLE GAJI (
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_PESERTA INT NOT NULL, 
GAJI DECIMAL(18,2))

CREATE TABLE PEGAWAI(
ID INT PRIMARY KEY IDENTITY(1,1) NOT NULL,
ID_PEGAWAI INT NOT NULL,
GAJI DECIMAL(18,2),
)

INSERT INTO 
GAJI
VALUES
(1,5000000),
(2,1500000),
(3,5500000),
(4,5600000),
(5,7000000)

INSERT INTO
NILAI
VALUES
(1,100),
(2,60),
(3,55),
(4,90),
(5,70)

ID, ID_PESERTA, GAJI

INSERT INTO 
 PESERTA
VALUES
()

  