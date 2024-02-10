using Business.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;


namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Degiskenler();

            Vatandas vatandas1 = new Vatandas();

            SelamVer(isim: "Ali");
            SelamVer(isim: "Can");
            SelamVer();

            int sonuc = Topla(3, 5);


            // diziler / Arrays

            string ogrenci1 = "Engin";
            string ogrenci2 = "Ali";
            string ogrenci3 = "Can";

            //Console.WriteLine(ogrenci1);
            //Console.WriteLine(ogrenci2);
            //Console.WriteLine(ogrenci3);

            string[] ogrenciler = new string[3];
            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Ali";
            ogrenciler[2] = "Can";
            Console.WriteLine();

            for (int i = 0; i < ogrenciler.Length; i++)
            {
                Console.WriteLine(ogrenciler[i]);
            }
            Console.WriteLine();
            string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" }; 
            string[] sehirler2= new[] { "Bursa", "Antalya", "Muğla" };
            sehirler2 = sehirler1;
            sehirler1[0]= "Aydın";
            Console.WriteLine(sehirler2[0]);

            //int sayi1 = 10;
            //int sayi2 = 20;
            //sayi2=sayi1;
            //sayi1 = 30;

            Person person1 = new Person();
            person1.Firstname = "Ali";
            person1.LastName = "YILMAZ";
            person1.DateOfBirthYear = 2000;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.Firstname = "Can";

            foreach (string sehir in sehirler1)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();
            // MyLöist
            List<string> yeniSehirler1= new List<string>{ "Ankara", "İstanbul", "İzmir" };
            yeniSehirler1.Add(item: "Eskişehir");
            foreach (var sehir in yeniSehirler1)
            {
                Console.WriteLine(sehir);
            }
            Console.WriteLine();
            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);

            



            Console.ReadLine();
        }

        //resharper
        static void SelamVer(string isim = "İSİMSİZ")
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine("Toplam : " + sonuc);
            return sonuc;
        }





        private static void Degiskenler()
        {
            string mesaj = "Merhaba";
            double tutar = 10000; // db den gelir
            int sayi = 100;
            bool girisYapmisMi = false;

            string ad = "Orcun";
            string soyad = "Yıldırım";
            int dogumyili = 2001;
            long tcno = 12345678910;

            Person person = new Person();
            Console.WriteLine(tutar * 1.18);
            Console.WriteLine(tutar * 1.18);
        }
    }

    //pascal casing
    public class Vatandas
    {
        public string ad = "Orcun";
        public string soyad = "Yıldırım";
        public int dogumyili = 2001;
        public long tcno = 12345678910;
    }
}
