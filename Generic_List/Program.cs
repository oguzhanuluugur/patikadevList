using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> Class
            //System.Collections.Generic
            // T=>Object türündedir nesne alabilir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(22);
            sayiListesi.Add(23);
            sayiListesi.Add(32);
            sayiListesi.Add(40);
            sayiListesi.Add(44);
            sayiListesi.Add(45);

            List<string> renk = new List<string>();
            renk.Add("kırmızı");
            renk.Add("mavi");
            renk.Add("turuncu");
            renk.Add("sarı");
            renk.Add("yeşil");

            //Count

            Console.WriteLine(renk.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ile elemanlara erişimi
            foreach (var item in sayiListesi)
            {
                Console.WriteLine(item);
            }
            foreach (var item in renk)
            {
                Console.WriteLine(item);
            }
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renk.ForEach(item => Console.WriteLine(item));

            //Listeden elemean çıkarma

            sayiListesi.Remove(4);
            renk.Remove("yeşil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renk.ForEach(item => Console.WriteLine(item));

            sayiListesi.RemoveAt(0);
            renk.RemoveAt(1);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renk.ForEach(item => Console.WriteLine(item));

            //Liste içerisinde aramak
            if(sayiListesi.Contains(23))
            {
                Console.WriteLine("Liste içerisinde 23 bulundu!");
            }
            //Eleman ile index'e erişmek 

            Console.WriteLine(renk.BinarySearch("Sarı"));

            //Diziyi listeye çevirmee

            string[] hayvanlar = { "Kedi", "Köpek", "Kuş" };
            List<string> hayvanlarListesi = new List<string>(hayvanlar);
            //Listeyi Temizleme

            hayvanlarListesi.Clear();

            //Liste içerisinde nesne tutma

            List<Kullanıcılar> kullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanici1 = new Kullanıcılar();
            kullanici1.Isim = "Oğuzhan";
            kullanici1.Soyisim = "Uluuğur";
            kullanici1.Yas = 22;
            Kullanıcılar kullanici2 = new Kullanıcılar();
            kullanici2.Isim = "Oğuzhan";
            kullanici2.Soyisim = "Uluuğur";
            kullanici2.Yas = 22;
            kullanıcıListesi.Add(kullanici1);
            kullanıcıListesi.Add(kullanici2);

            List<Kullanıcılar> yeniliste = new List<Kullanıcılar>();
            yeniliste.Add(new Kullanıcılar()
            {

                Isim = "Ali",
                Soyisim="Kaya",
                Yas=25
            });
            foreach (var kullanıcı in kullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı : "+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı : "+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı : "+kullanıcı.Yas);
            }
            yeniliste.Clear();
        }
    }
    public class Kullanıcılar
    {
        string isim;
        string soyisim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
