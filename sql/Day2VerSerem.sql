select * from tb_karyawan

select * from tb_divisi

select * from tb_jabatan

select * from tb_pekerjaan

 









-----------------------------------------------------1

select CONCAT(nama_depan, ' ' , nama_belakang) as nama_lengkap,
		nama_jabatan,
		gaji_pokok+tunjangan_jabatan as gaji_tunjangan
from tb_pekerjaan as pekerjaan
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan 
join tb_karyawan as karyawan on pekerjaan.nip = karyawan.nip

where gaji_pokok+tunjangan_jabatan+tunjangan_kinerja < 5000000

order by nama_depan desc


-----------------------------------------------------2
select concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
		nama_jabatan,
		nama_divisi,
		gaji_pokok+tunjangan_jabatan+tunjangan_kinerja as total_gaji,
		(gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*0.05 as pajak,
		(gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)- ((gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*0.05) as gaji_bersih
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi
where kota_penempatan != 'sukabumi'

------------------------------------------------------3
--belum sesuai urutan
select 
	karyawan.nip,
	concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
	nama_jabatan,
	nama_divisi,
	0.25*((gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*7) as bonus
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi

------------------------------------------------------4
select karyawan.nip,
		concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
		nama_jabatan,
		nama_divisi,
		gaji_pokok+tunjangan_jabatan+tunjangan_kinerja as total_gaji,
		0.05*(gaji_pokok+tunjangan_jabatan+tunjangan_kinerja ) as infak
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi
where kd_jabatan = 'MGR'

-------------------------------------------------------5

select karyawan.nip,
		concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
		nama_jabatan,
		CASE 
			when pendidikan_terakhir LIKE 'S1%' then 2000000
			else 0
		END as tunjangan_pendidikan,
		gaji_pokok+tunjangan_jabatan+tunjangan_kinerja as total_gaji
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi


-------------------------------------------------------6

select  karyawan.nip,
		concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
		nama_jabatan,
		nama_divisi,
		CASE 
			when kode_jabatan = 'mgr' then 0.25*((gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*7)
			when kode_jabatan = 'st' then 0.25*((gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*5)
			else 0.25*((gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)*2)
		end as bonus
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi


--------------------------------------------------------7

select  
		concat(nama_depan, ' ', upper(nama_belakang)) as nama_lengkap

from tb_karyawan
where nama_belakang like 'W%'


--------------------------------------------------------8
select  karyawan.nip,
		concat(nama_depan, ' ', nama_belakang) as nama_lengkap,
		nama_jabatan,
		nama_divisi,
		gaji_pokok+tunjangan_jabatan+tunjangan_kinerja as total_gaji,
		Case 
			when DATEDIFF(YEAR,tgl_masuk,getdate()) >= 8 then 0.1*(gaji_pokok+tunjangan_jabatan+tunjangan_kinerja)
			else 0
		END as bonus,
		datediff(year,tgl_masuk,getdate()) as lama_bekerja 
from tb_karyawan as karyawan
join tb_pekerjaan as pekerjaan on karyawan.nip = pekerjaan.nip
join tb_jabatan as jabatan on pekerjaan.kode_jabatan = jabatan.kd_jabatan
join tb_divisi as divisi on pekerjaan.kode_divisi = divisi.kd_divisi

