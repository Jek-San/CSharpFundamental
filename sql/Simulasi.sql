--1. Menampilkan karyawan yang pertama kali masuk.	

select top 1 *	
from employee

--2. Menampilkan daftar karyawan yang saat ini sedang cuti. Daftar berisi nomor_induk, 
--nama, tanggal_mulai, lama_cuti dan keterangan.		

select 
		
		lr.start_date, 
		DATEDIFF(DAY,start_date,end_date) as lama_cuti
		
from leave_request as lr
join employee as e on lr.employee_id = e.id		

--3. Menampilkan daftar karyawan yang sudah mengajukan cuti lebih dari 2 kali. 
--Tampilkan data berisi no_induk, nama, jumlah pengajuan .	
select 
			e.nip, 
			CONCAT(b.first_name, ' ', b.last_name) as nama_lengkap, 
			COUNT(lr.employee_id) as ambilcuti
from biodata as b
join employee as e on b.id = e.biodata_id
join leave_request as lr on e.id = lr.employee_id
group by nip, CONCAT(b.first_name, ' ', b.last_name) 

having  COUNT(lr.employee_id) >2


--4. Menampilkan sisa cuti tiap karyawan tahun ini, jika di ketahui jatah cuti setiap karyawan 
--   tahun ini adalah sesuai dengan quota cuti. tampilan berisi no_induk, nama, quota, 
--	cuti yg sudah di ambil dan sisa_cuti			

select 
		nip, 
		concat(first_name, ' ', last_name) as nama_lengkap,
		regular_quota,
		sum(
		DATEDIFF(DAY,start_date,end_date) 
		
		) as cuti_diambil,
		(regular_quota - sum(
		DATEDIFF(DAY,start_date,end_date) 
		
		))as sisa
from employee as e
join biodata as b on e.biodata_id = b.id
join employee_leave as el on e.id=el.employee_id
join leave_request as lr on e.id = lr.employee_id
group by nip, concat(first_name, ' ', last_name),regular_quota
--group by nip, concat(first_name, ' ', last_name),regular_quota,DATEDIFF(DAY,start_date,end_date)


--5. Perusahaan akan meberikan bonus bagi karyawan yang sudah bekerja lebih dari 5 tahun sebanyak
-- 1.5 kali gaji. Tampilan No induk, Fullname, Berapa lama bekerja, Bonus, Total Gaji(gaji + bonus)													

select 
		nip, 
		concat(first_name, ' ', last_name) as nama_lengkap,
		DATEDIFF(YEAR,join_date,getdate()) as lama_bekerja,
		IIF(DATEDIFF(YEAR,join_date,getdate())>5,salary*1.5 ,0 )as bonus,
		IIF(DATEDIFF(YEAR,join_date,getdate())>5,(salary*1.5 )+salary ,salary )as Total_Gaji
		
from employee as e
join biodata as b on e.biodata_id = b.id

--6. Tampilkan nip, nama_lengkap, jika karyawan ada yg berulang tahun di hari ini akan 
--diberikan hadiah bonus sebanyak 5% dari gaji jika tidak ulang tahun maka bonus 0 dan total gaji .
-- Tampilkan No Induk, nama, Tgl lahir , Usia, Bonus, Total Gaji	
select 
		nip, 
		concat(first_name, ' ', last_name) as nama_lengkap,
		DATEDIFF(YEAR,join_date,getdate()) as lama_bekerja,
		IIF(month(dob) = month(getdate()) and day(dob) = day(getdate()),salary*0.05 ,0 )as bonus,
		IIF(DATEDIFF(YEAR,join_date,getdate())>5,salary*0.05+salary ,salary )as Total_Gaji
		
from employee as e
join biodata as b on e.biodata_id = b.id

--7. Tampilkan No Induk, nama, Tgl lahir , Usia. Urutkan biodata dari yg paling muda sampai yg tua	

select 
		nip, 
		concat(first_name, ' ', last_name) as nama_lengkap,
		dob,
		DATEdiff(year, dob,getdate()) as umur
from employee as e
join biodata as b on e.biodata_id = b.id	
order by dob DESC


--8. Tampikan Karyawan yg belum pernah Cuti	
	
select concat(b.first_name,' ',b.last_name) as 'nama lengkap',
		e.nip
		
from  leave_request as lr		
right join employee as e	on lr.employee_id = e.id
join biodata as b on b.id = e.biodata_id
where leave_id is null


--9. Tampikan Nama Lengkap, Jenis Cuti, Durasi Cuti, dan no telp yang sedang cuti							

select CONCAT(first_name, ' ' , last_name) as 'Nama Lengkap',
		cp.type,
		l.type as 'Jenis Cuti',
		sum(DATEDIFF(DAY,lr.start_date, lr.end_date) )as 'Durasi Cuti',
		cp.contact
		

from contact_person as cp
join biodata as b on cp.biodata_id = b.id
join employee as e on b.id = e.biodata_id
join leave_request as lr on lr.employee_id = e.id
join leave as l on l.id = leave_id

where cp.type = 'phone'
	
											
