using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seyrusefer
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

           // Liste liste = new Liste();

           // liste.nesne_ekle_araya(1, 3, true);

           // liste.nesne_ekle_basa(2);//int
           // liste.nesne_ekle_sona(2.5f);//float
           // liste.nesne_ekle_basa(2.5);//double
           // liste.nesne_ekle_basa('a');//char
           // liste.nesne_ekle_basa("kelime");//String vb...
           // liste.nesne_ekle_araya("veli", 4, true);//"veli" nesnesini 4.indisin sağına(true) ekler
           // liste.nesne_ekle_araya("veli2", 4, false);//"veli2" nesnesini 4.indisin soluna(false) ekler
           // liste.nesne_ekle_araya("veli3", 4);//"veli3" nesnesini 4.indisin soluna ekler otomatik false
           // liste.nesne_ekle_araya("veli4");//"veli4" nesnesini 0. indisin soluna ekler yani en başa ekler
           // liste.nesne_verileri_goster();//ekleme sırasına göre sıralar

           // Console.WriteLine("\nnesnelerin listesi: \n");
           // foreach (Nesne nesne in liste.nesne_nesnelerin_listesini_ver())//List<Nesne> listesi verir
           // {
           //     Console.WriteLine("\nNesnenin Tipi: " + nesne.GetType());
           //     Console.WriteLine("Verinin Tipi: " + nesne.veri.GetType());
           //     Console.WriteLine("Verinin Degeri: " + nesne.veri);
           // }

           // Nesne ikinci_nesne = liste.nesne_nesnelerin_listesini_ver()[1];//List<Nesne> listesi verir ve bunun [1] . indisini Nesne olarak alabiliriz
           // Nesne birinci_nesne = ikinci_nesne.onceki_nesne;//ikincinin öncesi
           // Nesne ucuncu_nesne = ikinci_nesne.sonraki_nesne;//ikincinin sonrası

           // Console.WriteLine(ikinci_nesne.veri.ToString() + "   " + birinci_nesne.veri.ToString() + "    " + ucuncu_nesne.veri.ToString());

           // int silme_sonucu = liste.nesne_sil("asdf"); //istenilen türdeki veriyi hem siler hemde kaç tane veri sildiğini verir

           // int silme_sonucu2 = liste.nesne_sil("asdf", true); //eğer true girilir ise "asdf" objesinden kaç tane varsa hepsini siler

           // bool bulma_sonucu = liste.nesne_bul("ali"); //istenilen türdeki veriyi bulup bulmadığına dair sonuc döndürür

           // int uzunluk = liste.nesne_uzunluk();//listenin toplam eleman sayısını verir

           // int indis = liste.nesne_contains(2);//listedeki nesnelerin içeriklerinde "2" elemanı var ise nesnenin indis numarasını verir

           // int indis2 = liste.nesne_indexof(2);//listedeki nesnelerde 2 nesnesi bulunur ise nesnenin bulunduğu indis numarasını verir

           //// Console.ReadKey();
        }

    }

    //class Nesne//Her eklenen nesnenin özelliklerinin bulunduğu ve değerlerinin saklandığı sınıf
    //{
    //    public object veri;//veriyi her zaman String şekilde kayıt eder

    //    public Nesne onceki_nesne;
    //    public Nesne sonraki_nesne;

    //    public Nesne(object gelenVeri)
    //    {
    //        veri = gelenVeri;
    //    }

    //    public void yazdir()
    //    {
    //        Console.WriteLine(veri.ToString());
    //    }
    //}

    //class Liste
    //{
    //    private Nesne nesne_bas, nesne_son;

    //    public Liste()
    //    {
    //        nesne_bas = null;
    //        nesne_son = null;
    //    }

    //    public void nesne_ekle_basa(object deger)
    //    {//tam sayılar için
    //        Nesne yeni_nesne = new Nesne(deger);
    //        yeni_nesne.onceki_nesne = null;//her oluşturulacak nesnenin ilk başta önceki ve sonraki bağını null yapıyoruz
    //        yeni_nesne.sonraki_nesne = null;
    //        if (nesne_son != null)//yani listede kesin 1 ve 1 den fazla eleman varsa
    //        {
    //            yeni_nesne.sonraki_nesne = nesne_bas;//başıncı nesneyi yeni oluşturulacak nesnenin "sonraki bağlantısı" yapıyoruz
    //            nesne_bas.onceki_nesne = yeni_nesne;//başıncı nesnenin "önceki bağlantısı" nı yeni nesne yapıyoruz
    //            nesne_bas = yeni_nesne;//yeni oluşturduğumuz nesneyi başıncı nesne yapıyoruz
    //        }
    //        else//Listede hiç eleman yoksa
    //        {
    //            nesne_bas = yeni_nesne;
    //            nesne_son = yeni_nesne;
    //        }
    //    }

    //    public void nesne_ekle_araya(object deger, int indis = 0, bool saga_sola = false)//otomatik istenilen konumun soluna ekler, ister isek bunu true değeri ile değiştirebilirz
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        int sayac = 0;
    //        while (siradaki_nesne != null)
    //        {
    //            if (sayac == indis)//istenilen konum
    //            {
    //                if (saga_sola)//sağa ekle
    //                {
    //                    if (siradaki_nesne.sonraki_nesne != null)//sağdaki nesne son nesne değil ise
    //                    {
    //                        Nesne yeni_nesne = new Nesne(deger);
    //                        yeni_nesne.sonraki_nesne = siradaki_nesne.sonraki_nesne;
    //                        siradaki_nesne.sonraki_nesne.onceki_nesne = yeni_nesne;
    //                        yeni_nesne.onceki_nesne = siradaki_nesne;
    //                        siradaki_nesne.sonraki_nesne = yeni_nesne;
    //                    }
    //                    else//sağdaki nesne son nesne ise 
    //                    {
    //                        nesne_ekle_sona(deger);
    //                    }
    //                }
    //                else//sola ekle
    //                {
    //                    if (siradaki_nesne.onceki_nesne != null)//soldaki nesne 1. nesne değil ise
    //                    {
    //                        Nesne yeni_nesne = new Nesne(deger);
    //                        yeni_nesne.sonraki_nesne = siradaki_nesne;
    //                        siradaki_nesne.onceki_nesne.sonraki_nesne = yeni_nesne;
    //                        yeni_nesne.onceki_nesne = siradaki_nesne.onceki_nesne;
    //                        siradaki_nesne.onceki_nesne = yeni_nesne;


    //                        /*siradaki_nesne.onceki_nesne.sonraki_nesne = yeni_nesne;
    //                        siradaki_nesne.onceki_nesne = yeni_nesne;
    //                        yeni_nesne.sonraki_nesne = siradaki_nesne;
    //                        yeni_nesne.onceki_nesne = siradaki_nesne.onceki_nesne;*/

    //                    }
    //                    else//soldaki nesne 1.nesne ise
    //                    {
    //                        nesne_ekle_basa(deger);
    //                    }
    //                }
    //            }
    //            sayac++;
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //    }

    //    public void nesne_ekle_sona(object deger)
    //    {
    //        Nesne yeni_nesne = new Nesne(deger);
    //        yeni_nesne.onceki_nesne = null;//her oluşturulacak nesnenin ilk başta önceki ve sonraki bağını null yapıyoruz
    //        yeni_nesne.sonraki_nesne = null;
    //        if (nesne_son == null)//eğer sonuncu nesne yok ise 
    //        {
    //            nesne_bas = yeni_nesne;//başıncı ve sonuncu nesneyi ilk nesne kabul ediyoruz
    //            nesne_son = yeni_nesne;
    //        }
    //        else//eğer sonuncu nesne belli ise
    //        {
    //            yeni_nesne.onceki_nesne = nesne_son;//sonuncu nesneyi yeni oluşturulacak nesnenin "önceki bağlantısı" yapıyoruz
    //            nesne_son.sonraki_nesne = yeni_nesne;//sonuncu nesnenin "sonraki bağlantısı" nı yeni nesne yapıyoruz
    //            nesne_son = yeni_nesne;//yukarıda bağlantıları oluşturdultan sonra sonuncu nesnemizin yeni nesne olduğunu tanıtıyoruz
    //        }
    //    }

    //    public bool nesne_bul(object anahtar)
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        while (!siradaki_nesne.veri.Equals(anahtar))//siradaki nesnenin verisi gelen veriye eşit olana kadar döner
    //        {
    //            if (siradaki_nesne.sonraki_nesne == null)//eğer bütün nesneleri dolaştığını sonraki nesnenin null olduğundan anlar ise
    //            {
    //                return false;//geriye bulamadığına dair false değeri döndürür
    //            }
    //            else
    //            {
    //                siradaki_nesne = siradaki_nesne.sonraki_nesne;//her döngü döndüğünde kontrolcü nesneyi yani sıradaki_nesne Nesnesini bir sonraki nesneye aktarır
    //            }
    //        }
    //        return true;//eğer veriler eşit ise döngüden çıkar ve buradan geriye true döndürür
    //    }

    //    public int nesne_sil(object anahtar, bool hepsi = false)
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        int silinen_adet = 0;
    //        while (siradaki_nesne != null)//siradaki nesnemiz boş değil ise
    //        {
    //            if (siradaki_nesne.veri.Equals(anahtar))//eğer istenen veri ile sıradaki nesnenin verisi eşit ise
    //            {
    //                if (siradaki_nesne.onceki_nesne == null)//listenin başı için silme işlemi
    //                {
    //                    if (siradaki_nesne.sonraki_nesne != null)//bir nesnenin öncesi yok ama sonrası var ise
    //                    {
    //                        nesne_bas = siradaki_nesne.sonraki_nesne;//örneğin başıncı nesne 1.nesne ise artık başıncı nesne = 1.nesneden sonrakisi olsun, yani 2.nesne olsun
    //                        nesne_bas.onceki_nesne = null;//başıncı nesneden öncesi olmayacağı için boş yapıyoruz
    //                    }
    //                    else//bir nesnenin hem başı hemde sonu yok ise yani listedeki tek eleman o ise
    //                    {
    //                        nesne_bas = siradaki_nesne.sonraki_nesne;
    //                    }
    //                }
    //                else if (siradaki_nesne.sonraki_nesne == null)//listenin sonu için silme işlemi
    //                {
    //                    nesne_son = siradaki_nesne.onceki_nesne;//örneğin sonuncu nesne 4.nesne ise artık sonuncu nesne = 4.nesneden öncekisi olsun, yani 3.nesne olsun
    //                    nesne_son.sonraki_nesne = null;//sonuncu nesne olduğu için sonraki nesne boş olsun
    //                }
    //                else//listenin ortaları için silme işlemi
    //                {
    //                    siradaki_nesne.sonraki_nesne.onceki_nesne = siradaki_nesne.onceki_nesne;//örneğin 2.nesne silinecekse 3.nesnenin başı 1.nesneye bağlanır
    //                    siradaki_nesne.onceki_nesne.sonraki_nesne = siradaki_nesne.sonraki_nesne;//örneğin 2.nesne silinecekse 1.nesnenin sonu 3.nesneye bağlanır
    //                }
    //                silinen_adet++;
    //                if (!hepsi)//hepsi true ise return yapmayacağı için istenilen kelimeden ne kadar varsa hepsine silme işlemi uygulanacaktır
    //                {
    //                    break;//şarta girdiği için birkere silme işlemi yapıldı ve döngüden çıkartılıyor
    //                }
    //            }
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;//kontrole devam etmesi için sıradaki nesnenin işi bittiğinde sıradaki nesneyi bir sonraki nesneye aktarıyoruz
    //        }
    //        return silinen_adet;
    //    }

    //    public void nesne_verileri_goster()//ekleme sırasına göre listeler
    //    {
    //        Console.WriteLine("\nlisteleniyor: ");
    //        Nesne siradaki_nesne = nesne_bas;
    //        while (siradaki_nesne != null)//sıradaki nesne null olana kadar bütün nesneleri dolaş ve yazdirma işlemi yap
    //        {
    //            siradaki_nesne.yazdir();
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //    }

    //    public List<Nesne> nesne_nesnelerin_listesini_ver()//bütün nesneleri liste halinde döndürür
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        List<Nesne> nesneler = new List<Nesne>();//Nesne türünden liste oluşturulur
    //        while (siradaki_nesne != null)//bütün nesneleri dolaşığ bitene kadar herbirini oluşturulan listeye ekler
    //        {
    //            nesneler.Add(siradaki_nesne);
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //        return nesneler;//Nesne türündeki listeyi geri döndürür
    //    }

    //    public int nesne_uzunluk()//listedeki toplam nesne sayısını verir
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        int topla = 0;
    //        while (siradaki_nesne != null)
    //        {
    //            topla++;
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //        return topla;
    //    }

    //    public int nesne_contains(object aranan)//listedeki nesnelerin içeriklerinde arama yapar ve bulur ise bulduğu nesnenin kaçıncı indis olduğunu verir
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        int topla = -1;
    //        bool var_mi = false;
    //        while (siradaki_nesne != null)
    //        {
    //            topla++;
    //            if (siradaki_nesne.veri.ToString().Contains(aranan.ToString()))
    //            {
    //                var_mi = true;
    //                break;
    //            }
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //        if (var_mi)
    //        {
    //            return topla;
    //        }
    //        else
    //        {
    //            return -1;
    //        }
    //    }
    //    public int nesne_indexof(object aranan)//listedeki nesnelerden herhangi birisi aranan ile aynı ise bulduğu nesnenin kaçıncı indis olduğunu verir
    //    {
    //        Nesne siradaki_nesne = nesne_bas;
    //        int topla = -1;
    //        bool var_mi = false;
    //        while (siradaki_nesne != null)
    //        {
    //            topla++;
    //            if (siradaki_nesne.veri.Equals(aranan))
    //            {
    //                var_mi = true;
    //                break;
    //            }
    //            siradaki_nesne = siradaki_nesne.sonraki_nesne;
    //        }
    //        if (var_mi)
    //        {
    //            return topla;
    //        }
    //        else
    //        {
    //            return -1;
    //        }
    //    }
    //}


}
