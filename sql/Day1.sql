create database DBPenerbit;

--drop table tblPengarang

create table tblPengarang(
id int identity(1,1) primary key not null,
Kd_Pengarang varchar(7) not null,
Nama varchar(30) not null,
Alamat Varchar(80) not null,
kota varchar(15) not null,
Kelamin varchar(1) not null
)

insert into tblPengarang
values 
('P0001', 'Ashadi', 'Jl.Beo 25', 'Yogya', 'P'), 
('P0002', 'Rian', 'Jl.Solo 123', 'Yogya', 'P'),
('P0003', 'Suwadi', 'Jl.Semangka 13', 'Bandung', 'P'),
('P0004', 'Siti', 'Jl.Durian 15', 'Solo', 'W'),
('P0005', 'Amir', 'Jl.Gajah 33', 'Kudus', 'P'),
('P0006', 'Suparman', 'Jl.Harimau 25', 'Jakarta', 'P'),
('P0007', 'Jaja', 'Jl.Singa 7', 'Bandung', 'P'),
('P0008', 'Saman', 'Jl.Naga 12', 'Yogya', 'P'),
('P0009', 'Anwar', 'Jl.Tidar 6A', 'Magelang', 'P'),
('P0010', 'Fatmawati', 'Jl.Renjana 4', 'Bogor', 'W')

--drop table tblGaji
alter table tblGaji drop column id
create table tblGaji(
id int identity(1,1) primary key not null,
Kd_Pengarang varchar(7) not null,
Nama varchar(30) not null,
Gaji decimal(18,4) not null
)


insert into tblGaji
values
('P0002','Rian', '600000' ),
('P0005','Amir', '700000' ),
('P0004','Siti', '500000' ),
('P0003','Suwadi', '1000000' ),
('P0010','Fatmawati', '600000' ),
('P0008','Saman', '750000' )

---------------------------------------------------------------------------------------------------------------------------------
----------------------

select * From tblPengarang
select * From tblGaji

---------------------1
select Count(Kd_Pengarang) from tblPengarang

-------------------------------------------2

select Count(Kd_Pengarang) from tblPengarang where Kelamin='P'
select Count(Kd_Pengarang) from tblPengarang where Kelamin='W'

select kelamin, count(kelamin) as 'Jumlah Kelamin' from tblPengarang group by Kelamin
--------------------------------------------3
select kota, Count(kota) as 'Jumlah kota' from tblPengarang group By kota 

-------------------------------------------4

select kota, Count(kota) as 'Jumlah_kota' from tblPengarang group By kota having COUNT(Kota) > 1

-------------------------------------------5

select  Max(Kd_Pengarang) as 'max', Min(Kd_Pengarang) as 'min' from tblPengarang


-----------------------------------------6

select Max(Gaji) as 'Max', Min(Gaji) as 'min' from tblGaji


-----------------------------------------7

select Nama,  Gaji from tblGaji where Gaji > 600000

-------------------------------------------8

select Sum(Gaji) as 'Jumlah Gaji' from tblGaji

-------------------------------------------9
select kota, Sum(Gaji) as 'jumlah gaji' from tblGaji Join tblPengarang on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang
Group by kota  order by kota asc
 

-------------------------------------------10

select * from tblPengarang where Kd_Pengarang Between 'P0003' AND 'P0006'



-------------------------------------------11

select * from tblPengarang where kota='yogya' or kota= 'solo' or kota='magelang'

-------------------------------------------12

select * from tblPengarang where kota!='yogya';


--===========================================13
---a

select * from tblPengarang where Nama like 'a%'
select * from tblPengarang where Nama like '%i'
select * from tblPengarang where Nama like '__%'
select * from tblPengarang where Nama not like '%n'  

---------------------------------------------14


select * from tblGaji join tblPengarang on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang   



---------------------------------------------15
select * from tblGaji join tblPengarang on tblGaji.Kd_Pengarang = tblPengarang.Kd_Pengarang where Gaji<'1000000'


---------------------------------------------16

alter table tblPengarang alter column kelamin varchar(10)


----------------------------------------------17

alter table tblPengarang add gelar varchar(12) 

----------------------------------------------18

Update tblPengarang set Alamat='Jl. Cendrawasih 65', kota='PekanBaru' where id='2'

select * from tblPengarang


create view vwPengarang2 as 
select tp.Kd_Pengarang, tp.Nama, tp.kota, tg.Gaji from tblPengarang as tp left join tblGaji as tg on tp.Kd_Pengarang = tg.Kd_Pengarang

select * from vwPengarang

select * from vwPengarang1

select * from vwPengarang2

update vwPengarang2 set Gaji = 1500000 where Kd_Pengarang = 'P0002'

update NILAI set NILAI = 100 where id = '1'
update NILAI set NILAI = 85 where id = '2'
update NILAI set NILAI = 87 where id = '3'
update NILAI set NILAI = 89 where id = '4'
update NILAI set NILAI = 0 where id = '5'


select *,
	CASE 
		when nilai >80 and nilai <=100 THEN 'A'
		when NILAI >70 and nilai < 80 THEN 'B'
		when NILAI <= 70 THEN 'C'
		else 'Not Defined'
 	END as Grade
from
[NILAI]

select * from GAJI

select * from NILAI


select *,
		cast((gaji * 0.05) as INT) as tax, 
		CASE 
			when id = 1 or id = 2 then 50000
			when id = 3 or id = 4 then 30000
			else 0
		END as bonus,

		Cast(gaji -(gaji * 0.05)+
		CASE 
			when id = 1 or id = 2 then 50000
			when id = 3 or id = 4 then 30000
		END as INT) as Total_Gaji   


		--cast((gaji -(gaji * 0.05)) as INT) as Total_Gaji

from tblGaji



select *, 
YEAR(TANGGAL_LAHIR) AS TAHUN_LAHIR, 
MONTH(TANGGAL_LAHIR) AS BULAN_LAHIR,  
DATENAME()
DATE
DATEDIFF
DATE
getdate() as datenow from peserta
