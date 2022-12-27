--12. Menampilkan data negara dengan jumlah filmnya									


--kode negara, namanegara, jml film

select  kd_negara,
		n.nm_negara,
		count(negara) as jml_negara
from film as f
join artis as a on f.artis = a.kd_artis
right join negara as n on a.negara = n.kd_negara
group by negara,nm_negara,kd_negara
order by kd_negara asc


select * from artis
select * from film
select * from negara
select * from genre
select * from produser




select 
		kd_film,
		nm_film,
		nm_genre,
		nm_artis,
		nm_produser,
		f.pendapatan,
		(select avg(pendapatan) from film) as avg_allfilm,
		a.bayaran,
		(
		cast(sintak as apagitu)
			cast(bayaran + IIF(pendapatan> (select avg(pendapatan) from film), 0.2*bayaran, 0)as int)
		) as bayaran_besih
from film as f
join artis as a on f.artis = a.kd_artis
join genre as g on f.genre = g.kd_genre
join produser as p on f.produser = p.kd_produser
where nm_film LIKE '%n'

select nm_film,
	   nominasi
from film
where nominasi = (select max(nominasi) from film)




--4. Menampilkan nama film, genre, artis, produser, yang huruf terakhir filmnya 'n'. jika penapatan di atas rata-rata semua film. maka bayaran artis akan ditambah sebanyak 20% dari bayaran itu sendiri												
												
												
select 