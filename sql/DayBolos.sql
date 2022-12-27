select * from negara
select * from artis
select * from film
select * from genre
select * from produser


select *
from film as f
full outer join produser as p on p.kd_produser = f.produser


select *,
cast (
(select avg(pendapatan) from film)
as decimal (18,0))
as ratarata
from film
where pendapatan >= (select avg(pendapatan) from film)

--daftar film asal nya dari as
-- film ke artis

select * from film as f
join artis as a
on f.artis = a.kd_artis
where a.negara = 'ID'

-- in pada saaat kondisinya 4 atau 5 
select * from film as f
where artis in (select kd_artis from artis where negara = 'ID')

select * from artis
select * from film
select * from negara
select * from genre
select * from produser

--1. Menampilkan jumlah pendapatan produser marvel secara keseluruhan
select pro.nm_produser , sum(fil.pendapatan) pendapatan
from produser pro join film fil
on pro.kd_produser = fil.produser
where kd_produser ='PD01'
group  by nm_produser

--2. Menampilkan nama film dan nominasi yang tidak mendapatkan nominasi			
select nm_film,
nominasi
from film
where nominasi = 0

--3. Menampilkan nama film yang huruf depannya 'p' serta rata-rata pendapatan film yang awalan 'p'. 
--   jika pendapatannya diatas rata-rata maka pendapatan akan di tambah 10% dari pendapatan itu sendiri											
											
select
	kd_film
	nm_film,
	pendapatan,
	cast((select avg(pendapatan)from film) as decimal (18,2)) as rata_rata,
	case
	when pendapatan > (select avg(pendapatan)from film) then (pendapatan * 0.10 ) + pendapatan
	else pendapatan 
	end as pendapatan_bersih
	from film
where 
	nm_film like 'p%'


--4. Menampilkan nama film, genre, artis, produser, yang huruf terakhir filmnya 'n'.
--jika penapatan di atas rata-rata semua film. maka bayaran artis akan ditambah sebanyak 20% dari bayaran itu sendiri												
-- kolom yang belum dapat avg, bayaran, bayaran_bersih


select 
kd_film,
nm_film, 
nm_genre,
nm_artis,
nm_produser,
pendapatan,
cast((select avg(pendapatan)from film) as decimal (18,2)) as rata_rata,
case 
when pendapatan > (select avg(pendapatan)from film)  then (bayaran * 0.20 ) + pendapatan
	else pendapatan
	end as pendapatan_bersih
from film f join genre g
on f.genre = g.kd_genre
join produser p
on f.produser = p.kd_produser
join artis a
on f.artis = a.kd_artis
where nm_film like '%n'

select * from film
select * from genre
select * from produser
select * from artis
	
								
-- 5. Menampilkan nama film yang mengandung huruf 'd'									
select nm_film
from film 
where nm_film like '%d%'

--6. Menampilkan nama film dan artis						
select nm_film,
nm_artis
from film f join artis a
on f.artis = a.kd_artis

--7. Menampilkan nama film yang artisnya berasal dari negara hongkong
select nm_film,
n.kd_negara
from film f join artis a
on f.artis = a.kd_artis
join negara n
on n.kd_negara = a.negara
where n.kd_negara = 'HK'

--8. Menampilkan nama film yang artisnya bukan berasal dari negara yang mengandung huruf 'o'											
select nm_film,
n.nm_negara
from film f join artis a
on f.artis = a.kd_artis
join negara n
on n.kd_negara = a.negara
where n.nm_negara not like '%o%'

-- 9. Menampilkan nama artis yang tidak pernah bermain film	
select nm_artis 
from artis a  join film f
on a.kd_artis = f.artis
--where artis =1

-- 10. Menampilkan nama artis yang bermain film dengan genre drama											
select nm_artis,
nm_genre
from artis a join film f
on a.kd_artis = f.artis
join genre g
on f.genre = g.kd_genre
where nm_genre = 'drama'

--11. Menampilkan nama artis yang bermain film dengan genre Action											
select nm_artis,
nm_genre
from artis a join film f
on a.kd_artis = f.artis
join genre g
on f.genre = g.kd_genre
where nm_genre = 'action'

--12. Menampilkan data negara dengan jumlah filmnya
select kd_negara,
nm_negara,
sum(nm_film) as jumlah_film 
from negara n join artis a
on n.kd_negara = a.negara
join film f
on a.kd_artis = f.artis

select * from film
select * from produser
select * from negara
select * from artis

--13. Menampilkan nama film yang skala internasional
select  nm_film
from film f join produser p
on f.produser = p.kd_produser
where international = 'ya'

-- 14. Menampilkan jumlah film dari masing2 produser									
select p.nm_produser,
sum (f.produser) as jumlah_film
from film f join produser p
on f.produser = p.kd_produser
group by produser

--15. menampilkan nama film dan nominasi 
select *
from film
order by nominasi desc;

-- 16. menampilkan 2 data film yang pendapatannya di bawah rata rata dan yang paling lumaayan pendapatannya
select id,
kd_film,
nm_film,
genre,
artis, 
produser,
pendapatan, 
nominasi
--avg(nominasi)
from film 

-- 17. menampilkan seluruh data film dan rata rata pendapatan 
       --dimana pendapatan lebih dari rata rata 

 --18. Buatlah kolom kd_artis pada table artis,  sebagai kolom unique
 
 alter table artis add kdarts varchar (10) 

 --19. buatlah kolom kd_film pada table film sebagai index			
 create index kode_film
 on film (kd_film) 

 -- 20. buat lah view dari soal 4 lalu tambahkan pajak sebanyak 5 % dari bayaran bersih artis
 create view vwpendapatartis
 as select 
kd_film,
nm_film, 
nm_genre,
nm_artis,
nm_produser,
pendapatan,
cast((select avg(pendapatan)from film) as decimal (18,2)) as rata_rata,
case 
when pendapatan > (select avg(pendapatan)from film)  then (bayaran * 0.20 ) + pendapatan
	else pendapatan
	end as pendapatan_bersih
from film f join genre g
on f.genre = g.kd_genre
join produser p
on f.produser = p.kd_produser
join artis a
on f.artis = a.kd_artis
where nm_film like '%n'

select *,
cast(pendapatan_bersih * 0.05 as decimal(18,0))  as pajak
 from vwpendapatartis



