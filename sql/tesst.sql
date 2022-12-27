select kota, count(kota) as 'jumlah kota' from tblPengarang group by kota having count(kota)>1

select Min(kd_pengarang) as 'Min', Max(kd_pengarang) as 'Max' from tblPengarang

select Min(gaji) as Min, Max(gaji) as max from tblGaji

select tp.nama,  gaji from tblGaji as tg join tblPengarang as tp on tg.kd_pengarang = tp.Kd_Pengarang  where gaji>'600000'

select * from tblPengarang 
select * from tblGaji

