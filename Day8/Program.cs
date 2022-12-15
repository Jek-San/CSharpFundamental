using System;
using System.Collections.Generic;
using System.Linq;

namespace Day8
{
    internal class Program
    {

        static void Main(string[] args)
        {

            int menu = 0;
            do
            {
                Console.Clear();
                Console.WriteLine(" Soal 1. Julius Caesar ");
                Console.WriteLine(" Soal 2. A");
                Console.WriteLine(" Soal 3 ");
                Console.WriteLine(" Soal 4 ");
                Console.WriteLine(" Soal 5 ");
                Console.WriteLine();
                Console.WriteLine(" 6. Exit ");


                Console.Write("Masukkan Pilihan Menu Soal: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Soal1();
                        break;
                    case 2:
                        Soal2();
                        break;
                    case 3:
                        Soal3();
                        break;
                    case 4:
                        Soal4();
                        break;
                    case 5:
                        Soal5();
                        break;
                    default:
                        Console.WriteLine("Anda memilih yang lain ");
                        break;
                }
            } while (menu != 6);



        }
        static void Soal1()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();

                Console.WriteLine("Progr");
                Console.WriteLine("====================");
                /*DateTime dtNow = new DateTime();
                dtNow = DateTime.Now;
                DateTime dt1 = new DateTime(2022, 12, 14, 12, 9, 10);
                Console.WriteLine(dtNow);
                Console.WriteLine(dt1.ToString("dd-MMMM-yyyyy"));
*/
                int biayaParkir = 3000;
                Console.Write("Mican Masuk Gedung pada jam :");
                string checkIn = Console.ReadLine();
                DateTime chekInParse = DateTime.Parse(checkIn);

                /*string[] checkInFormat = checkIn.Split(" ");
                int[] checkInDate = Array.ConvertAll(checkInFormat[0].Split("/"), int.Parse);
                int[] checkInTime = Array.ConvertAll(checkInFormat[1].Split(":"), int.Parse);*/
                Console.Write("Mican Keluar Gedung pada jam :");
                string checkOut = Console.ReadLine();
                /*string[] checkOutFormat = checkIn.Split(" ");
                int[] checkOutDate = Array.ConvertAll(checkOutFormat[0].Split("/"), int.Parse);
                int[] checkOutTime = Array.ConvertAll(checkOutFormat[1].Split(":"), int.Parse);*/
                DateTime chekOutParse = DateTime.Parse(checkOut);

                TimeSpan diff = chekOutParse - chekInParse;
                Console.Write("Biaya Parkirnya = ");
                

                if (diff.TotalMinutes > 0)
                {
                    int diffInt = ((int)diff.Hours + 1) * biayaParkir;


                    Console.WriteLine(diffInt);

                }
                else
                {
                    int diffInt = (int)diff.Hours * biayaParkir;
                    Console.WriteLine(diffInt);
                }
                Console.ReadLine();
            } while (ulang);
        }

        static void Soal2()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Program Peminjaman Waktu");
                Console.WriteLine("========================");

                //Jika dayNya lebih dari 3 hari maka akan ada denda 500 perHari

                /*DateTime dtNow = new DateTime();
                dtNow = DateTime.Now;
                DateTime dt1 = new DateTime(2022, 12, 14, 12, 9, 10);
                Console.WriteLine(dtNow);
                Console.WriteLine(dt1.ToString("dd-MMMM-yyyyy"));
*/
                int biayaDenda = 500;
                Console.Write("Tgl Peminjaman Buku : ");
                string checkIn = Console.ReadLine();
                DateTime chekInParse = DateTime.Parse(checkIn);

                /*string[] checkInFormat = checkIn.Split(" ");
                int[] checkInDate = Array.ConvertAll(checkInFormat[0].Split("/"), int.Parse);
                int[] checkInTime = Array.ConvertAll(checkInFormat[1].Split(":"), int.Parse);*/
                Console.Write("Tgl Pengembalian Buku :");
                string checkOut = Console.ReadLine();
                /*string[] checkOutFormat = checkIn.Split(" ");
                int[] checkOutDate = Array.ConvertAll(checkOutFormat[0].Split("/"), int.Parse);
                int[] checkOutTime = Array.ConvertAll(checkOutFormat[1].Split(":"), int.Parse);*/
                DateTime chekOutParse = DateTime.Parse(checkOut);

                TimeSpan diff = chekOutParse - chekInParse;
                Console.Write("Biaya Denda = ");
                if (diff.TotalDays > 3)
                {
                    int diffInt = ((int)diff.TotalDays + 1) * biayaDenda;


                    Console.WriteLine(diffInt);

                }
                else
                {
                    
                    Console.WriteLine("Gratis Biaya Pengembalian");
                }
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal3()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.Clear();
                //setiap weekend maka something ditambah 1
                //Berarti kita harus ngecek dulu apakah setiap minggu yang dilawati ada melewati week day
                Console.WriteLine("Program Menentukan Tanggal FT1");
                Console.WriteLine("==============================");
                Console.WriteLine();

                Console.WriteLine("Tanggal Mulai :");
                string checkIn = Console.ReadLine();
                DateTime checkInParse = DateTime.Parse(checkIn);
                Console.WriteLine("Hari Libur : ");
                string dLibur = Console.ReadLine();
                string[] dLiburArr = dLibur.Split(',');
                int[] dLiburInt = Array.ConvertAll(dLiburArr, int.Parse);
                double jumlahHariSemula = 10;
                
                DateTime dDay;
                for (int i = 0; i < jumlahHariSemula; i++)
                {
                    dDay = checkInParse.AddDays(i);
                    int weekDay = (int)dDay.DayOfWeek;
                    // Console.Write(weekDay);
                    int dayLibur = dDay.Day;
                    int index = Array.IndexOf(dLiburInt, dayLibur);
                    // jika -1 maka dia pasti hari libur, dia itu di weekday atau bukan

                    if (weekDay == 6 || weekDay == 0)
                    {

                        jumlahHariSemula++;
                    }
                    if (index !=-1 )
                    {
                        if (weekDay>0 && weekDay<6)
                        {
                            jumlahHariSemula++;
                        }
                        

                    }


                    // Console.WriteLine($"D-Day : {dDay}");
                }

                //Console.WriteLine($"Count = {count}");
                dDay = checkInParse.AddDays(jumlahHariSemula);


                Console.WriteLine($"Output : {dDay}");


                Console.ReadLine();
            } while (ulang);
        }
        static void Soal4()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Program Billing Warnet");
                Console.WriteLine("======================");
                Console.WriteLine("Tarif perjam Rp. 3500\n");


                Console.WriteLine("Anak Masuk Warnet Jam : ");
                string checkIn = Console.ReadLine();
                DateTime checkInParse = DateTime.Parse(checkIn);
                int jamCheckIn = checkInParse.Hour;

                Console.WriteLine("Main berapa jam : ");
                int billing = int.Parse(Console.ReadLine());
                int tarif = 3500;
                int biaya = tarif * jamCheckIn;

                Console.WriteLine($"Dia Harus keluar pada jam :{checkInParse.AddHours(billing)} dan biaya Rp. {biaya} ");
                Console.WriteLine($"Apabila dia menambah 2 jam maka harga menjadi Rp.{biaya = biaya + (tarif * jamCheckIn)} dan Harus keluar pada jam : {checkInParse.AddHours(billing)}");
                /*Console.WriteLine("Jam Keluar Warnet : ");
                string checkOut = Console.ReadLine();
                DateTime checkOutParse = DateTime.Parse(checkOut);
                int jamCheckOut = checkOutParse.Hour;
                Console.WriteLine(jamCheckOut);*/
                Console.ReadLine();
            } while (ulang);
        }
        static void Soal5()
        {
            Console.Clear();
            bool ulang = true;
            do
            {
                Console.Clear();
                Console.WriteLine("Program Validasi Umur");
                Console.WriteLine("=====================");

                Console.WriteLine("Tanggal Lahir :");
                string tglLahir = Console.ReadLine();
                DateTime tglLahirDt = DateTime.Parse(tglLahir);
                DateTime dtNow = DateTime.Now;
                TimeSpan diff = dtNow - tglLahirDt;
                int umur = (int)diff.TotalDays;
                umur = umur / 365;

                if (umur > 18)
                {
                    if (tglLahirDt.Day == dtNow.Day)
                    {
                        Console.WriteLine($"Umur Anda = {umur}");
                        Console.WriteLine("Selamat Ulang tahun. Konser Gratis Untukmu");
                        Console.WriteLine("Biaya Konser Rp. 0");

                    }
                    else
                    {
                        Console.WriteLine($"Umur Anda = {umur}");
                        Console.WriteLine("Biaya Konser Rp. 1.500.000");
                        Console.WriteLine("Silahkan lakukan pembayaran");


                    }

                }
                else
                {
                    Console.WriteLine($"Umur Anda = {umur}");
                    Console.WriteLine("Maaf Anda belum Cukup Umur untuk menonton konser ini");
                }


                Console.ReadLine();
            } while (ulang);
        }





    }
}







