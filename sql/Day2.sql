Create database DB_Univ_XA;

--alter table tbl_Mahasiswa alter column alamat varchar(30)

--drop table tbl_Mahasiswa

create table tbl_Mahasiswa(
nim bigint identity(101,1) primary key not null,
nama varchar(30) not null,
jenis_kelamin varchar(1) not null,
alamat varchar(30) not null
)

create table tbl_Matakuliah(
kode_mk varchar(10) not null,
nama_mk varchar(30) not null,
sks int not null,
semester int not null
)

--drop table ambil_mk

create table ambil_mk(
nim int not null,
kode_mk varchar(10)
)

select * from tbl_Mahasiswa

insert into tbl_Mahasiswa
values
('Arif', 'L','Jl. Kenangan' ),
('Budi', 'L','Jl. Jombang' ),
('Wati', 'P','Jl. Surabaya' ),
('Ika', 'P','Jl. Jombang' ),
('Tono', 'L','Jl. Jakarta' ),
('Iwan', 'L','Jl. Bandung' ),
('Sari', 'P','Jl. Malang' )



insert into tbl_Matakuliah
values
('PTI447','Praktikum Basis Data', '1', '3' ),
('TIK342','Praktikum Basis Data', '1', '3' ),
('PTI333','Basis Data Terdistribusi', '3', '5' ),
('TIK123','Jaringan Komputer', '2', '5' ),
('TIK333','Sisten Operasi', '3', '5' ),
('PTI123','Grafika Multimedia', '3', '5' ),
('PTI777','Sistem Informasi', '2', '3' )

select * from tbl_Mahasiswa

update tbl_Matakuliah set kode_mk = 'PTI777' where kode_mk='PTI177'

insert into ambil_mk
values
('101', 'PTI447'),
('103', 'TKI333'),
('104', 'PTI333'),
('104', 'PTI777'),
('111', 'PTI123'),
('123', 'PTI999')


select * from ambil_mk

select * from tbl_Matakuliah

select * from tbl_Mahasiswa

update ambil_mk set kode_mk = 'TIK333' where kode_mk = 'TKI333'

---------------------------------------1
select *  from ambil_mk as am 
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim 
join tbl_Matakuliah as matkul on am.kode_mk=matkul.kode_mk 

select mahasiswa.nama  from ambil_mk as am 
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim 
join tbl_Matakuliah as matkul on am.kode_mk=matkul.kode_mk 



select * from ambil_mk as am join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim

select * from tbl_Mahasiswa as mahasiswa join ambil_mk as am on mahasiswa.nim = am.nim
join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk 


---------------------------------------------2

select mhs.nim, mhs.nama, mhs.jenis_kelamin, mhs.alamat from tbl_Mahasiswa as mhs left join ambil_mk as am on mhs.nim = am.nim 
where am.nim is null


---------------------------------------------3

select COUNT(jenis_kelamin), jenis_kelamin as jml from tbl_Mahasiswa as mhs left join ambil_mk as am on mhs.nim = am.nim 
where am.nim is null
group by jenis_kelamin

-----------------------------------------4

select mahasiswa.nim, mahasiswa.nama, matkul.kode_mk, matkul.nama_mk from ambil_mk as am join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim


------------------------------------------5

select * from ambil_mk as am join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim
group by am.kode_mk
having Sum(am.kode_mk) > 4 and Sum(am.kode_mk) <10


select mahasiswa.nim, mahasiswa.nama, Sum(sks) as jml from ambil_mk as am join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
join tbl_Mahasiswa as mahasiswa on am.nim = mahasiswa.nim
group by mahasiswa.nim,mahasiswa.nama
having SUM(sks) >4 and sum(sks)<10



-------------------------------------------6

select * from tbl_Mahasiswa as mhs left join ambil_mk as am on mhs.nim = am.nim
left join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk

select nama_mk from ambil_mk as am left join tbl_Mahasiswa as mhs on am.nim=mhs.nim
right join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
where mhs.nim is null


----------=====================================================================================================================




