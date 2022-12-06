using System;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myObj = new Car();
            Console.WriteLine(myObj.color);
            Console.WriteLine(myObj.name);

            var person = myObj.person;
            for (int i = 0; i < person.Length; i++)
            {
                Console.WriteLine(person[i]);
            }

            Program pg = new Program();
            Console.WriteLine("==========Kaljulator bangun datar =============");
            Console.WriteLine("--Persegi Panjang--");
            Console.Write("Masukkan Panjang Persegi: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Masukkan Lebar Persegi: ");
            int y = int.Parse(Console.ReadLine());
            pg.methodRumusPersegi(x,y);
            Console.WriteLine("\n\n--Persegi Panjang--");
            Console.Write("Masukkan nilai sisi: ");
            int s = int.Parse(Console.ReadLine());
            var hasilBujurSangkar = pg.rumusBujurSangkar(s);
            Console.WriteLine($"hasil dari luas bujur sangkar dengan sisi bernilai {hasilBujurSangkar.sisi} adalah {hasilBujurSangkar.luas}");
            Console.WriteLine("===============================================");
            Soal myObj1 = new Soal();
            myObj1.S1();


            /*Console.WriteLine("====Progam Day1=====");
            Console.Write("Input Nama :");
            string inputname = Console.ReadLine();
            Console.Write("No HP :");
            var contact = Console.ReadLine();
            Console.Write("Umur :");
            int umur = int.Parse(Console.ReadLine());
            Console.Write("Asal Kampus :");
            string campus = Console.ReadLine();
            Console.WriteLine($"Hello, {inputname} sekamat datang. Umur anda {umur} tahun");
            Console.WriteLine($"Nomor telp anda {contact}");
            Console.WriteLine($"Lulusan dari kampus {campus}");*/
        }

        public void methodRumusPersegi(int p, int l)
        {
            
            int hasil = p * l;
            Console.WriteLine($"Luas persegi dengan panjang {p} dan lebar {l} adalah {hasil}");
        }

        public Data rumusBujurSangkar(int s)
        {
            Data dt = new Data();


            int luas = s * s;
            dt.sisi = s;
            dt.luas = luas;
            return dt;
        }

    }

    public class Data
    {
        public int sisi { get; set; }
        public int luas { get; set; }
    }

    /*public static multiply(int a, int b)
        {
        
        return (a* b )
        }*/
}


