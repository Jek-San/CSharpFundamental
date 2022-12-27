
select mhs.nama, matkul.nama_mk from ambil_mk as am 
join tbl_Matakuliah as matkul on am.kode_mk = matkul.kode_mk
join tbl_Mahasiswa as mhs on am.nim = mhs.nim

mhs.nim, mhs.nama, mhs.jenis_kelamin, mhs.alamat
select * 
from ambil_mk as am 
left join tbl_Mahasiswa as mhs  on mhs.nim = am.nim
where am.nim is null 