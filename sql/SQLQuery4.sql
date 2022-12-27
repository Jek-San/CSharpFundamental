--7. Tampilkan No Induk, nama, Tgl lahir , Usia. 
--Urutkan biodata dari yg paling muda sampai yg tua	

select 
		e.nip,
		CONCAT(first_name,' ',last_name) as 'Nama lengkap',
		b.dob as 'tgl lahir',
		cast(DATEDIFF(day,b.dob,'2021-12-22 00:00:00')/365.25 as int) as usia
from employee as e
join biodata as b on e.biodata_id = b.id
order by dob desc
update biodata set dob = '1990-12-30' where id = '2'

--8. Tampikan Karyawan yg belum pernah Cuti	

select 
		CONCAT(first_name,' ',last_name) as 'Nama lengkap',
		e.nip
from employee as e
left join leave_request as lr on e.id = lr.employee_id 	
join biodata as b on b.id = e.biodata_id
where lr.id is null

--9. Tampikan Nama Lengkap, Jenis Cuti, Durasi Cuti, dan no telp yang sedang cuti							

select 
		CONCAT(first_name,' ',last_name) as 'Nama lengkap',
		l.type,
		cp.contact,
		sum(datediff(day,lr.start_date,end_date)) as durasi_cuti 


from contact_person as cp
join biodata as b on cp.biodata_id = b.id
join employee as e on e.biodata_id = b.id
join leave_request as lr on lr.employee_id = e.id
join leave as l on l.id = lr.leave_id
where cp.type = 'phone' and  '2021-12-22' between start_date and end_date
--start_date<='2021-12-22' and end_date>='2021-12-22'
group by  
		CONCAT(first_name,' ',last_name),
		l.type,
		cp.contact		

--10. Tampilkan nama-nama pelamar yang tidak 
--    diterima sebagai karyawan	

select 
		*
from biodata
where biodata.id  in 
		(
			select biodata_id from employee
		) 				














																		