using System.ComponentModel.Design;
using System.Runtime.ConstrainedExecution;

namespace tekrar1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //Console.Write("kaç adet defter alacağınızı giriniz:");
            //int sayı = int.Parse(Console.ReadLine()!);
            //Console.WriteLine($"aldıgınız defter sayısı, {sayı}, toplam tutar:{sayı*45}");


            //Console.Write("kaç adet defter alacağınızı giriniz:");
            //int sayı = int.Parse(Console.ReadLine());
            //Console.WriteLine($"aldığınız defter sayısı: {sayı} toplam tutar: {sayı * 45}");




            //Console.WriteLine("ürün adı giriniz");
            //string ürünAdı = Console.ReadLine()!;
            //Console.WriteLine("alacağınız adet");
            //int ürünSayısı = int.Parse(Console.ReadLine()!);
            //Console.WriteLine($"ürün adı:{ürünAdı}, alacığınız adet:{ürünSayısı},toplam tutar:{ürünSayısı*45.50}");



            //int toplamPuan = 14;
            //int sayı = 8;
            //double sonuc1 = toplamPuan / sayı;
            //double sonuc2 = (double)toplamPuan / sayı;
            //Console.WriteLine(sonuc1);
            //Console.WriteLine(sonuc2);



            //Console.WriteLine("isim-soyisim:");
            //string ad = Console.ReadLine();
            //Console.WriteLine("en sevdiğiniz hayvanın ismi:");
            //string hayvan=Console.ReadLine();
            //Console.WriteLine($"merhaba:{ad}, siz bir{hayvan}sınız");




            //string ilk = "12";
            //string ikinci = "3";
            //Console.WriteLine(ilk + ikinci);
            //int toplam = int.Parse(ilk) + int.Parse(ikinci);
            //Console.WriteLine(toplam);
            //burada eğer direkt değerleri toplama işaretiyle toplarsak yanyana yazar ama ayrı ayrı sayıları toplarsak toplam değeri yazar.


            //int toplam = 18;
            //int sayi = 4;
            //double ortalama = (double)toplam / sayi;
            //Console.WriteLine(ortalama);


            //Console.WriteLine("ürün adını giriniz:");
            //string ürad = Console.ReadLine()!;
            //Console.WriteLine("ürün adedini giriniz");
            //int adet = int.Parse(Console.ReadLine()!);
            //Console.WriteLine("birim fiyatı giriniz:");
            //double birimfiyat=double.Parse(Console.ReadLine()!);
            //Console.WriteLine($"ürünadı:{ürad}, ürün adedi:{adet},toplam tutar:{adet*birimfiyat}");




            //Console.WriteLine("ürün adı nedir?:");
            //string ad = Console.ReadLine()!;
            //Console.WriteLine("ürünün birim fiyatı nedir?:");
            //double birimfiyat=double.Parse(Console.ReadLine()!);
            //Console.WriteLine("kaç adet alacaksınız:");
            //int ürünadedi=int.Parse(Console.ReadLine()!);
            //Console.WriteLine($"ürün adı:{ad},toplam tutar:{birimfiyat*ürünadedi}");




            //Console.WriteLine("ürün adı nedir?:");
            //string ad = Console.ReadLine()!;

            //Console.WriteLine("ürünün birim fiyatı nedir?:");
            //decimal birimfiyat = decimal.Parse(Console.ReadLine()!); // double yerine decimal kullandık

            //Console.WriteLine("kaç adet alacaksınız:");
            //int ürünadedi = int.Parse(Console.ReadLine()!);

            //Console.WriteLine($"ürün adı:{ad}, toplam tutar:{birimfiyat * ürünadedi}");




            //Console.WriteLine("aldığınız ürünün fiyatını giriniz:");
            //decimal ürünFiyat=decimal.Parse(Console.ReadLine()!);
            //Console.WriteLine($"bugün agzi üniversitesinin 100. yılı olduğu için %30 indişrim kazandınız. indirim sonrası ürününz{ürünFiyat*0.70m}oldu");

            //bunu şimdi ifle yapalım.

            //Console.WriteLine("aldığınız ürünün fiyatını giriniz:");
            //decimal ürünFiyat = decimal.Parse(Console.ReadLine()!);
            //if (ürünFiyat < 250)
            //    Console.WriteLine($"%10indşrşm kazandınız tutar:{ürünFiyat * 0.90m}");
            //else if (ürünFiyat >= 250 && ürünFiyat < 500)
            //    Console.WriteLine($"%30indirim kazandınız ödenecek:{ürünFiyat * 0.70m}");
            //else
            //    Console.WriteLine($"%45 indirim kazandınız ödenecek:{ürünFiyat*0.55m}");




            //    Console.WriteLine("lütfen isminizi giriniz..");
            //    string ad=Console.ReadLine()!;
            //    if (ad == "eyup")
            //        Console.WriteLine("sen adamın dibisin");
            //    else if (ad == "elif")
            //       Console.WriteLine("sen farklısın..");
            //   else if (ad == "resul")
            //      Console.WriteLine("sen maraşlısın");
            //else if (ad == "ulfet")
            //    Console.WriteLine("sen bodrumlusun");
            //else if (ad == "kerem")
            //    Console.WriteLine("sen de tam bir kilislisin");
            //else
            //    Console.WriteLine("güzel insan...");




            //Console.WriteLine("1. sayıyı gir");
            //double sayı1 = double.Parse(Console.ReadLine());
            //Console.WriteLine("2. sayıyı gir");
            //double sayı2 = double.Parse(Console.ReadLine());
            //Console.WriteLine("yapmak sitediğiniz işlem nedir");
            //string islem = Console.ReadLine();
            //double sonuc = 0;

            //if (islem == "+")
            //{
            //    sonuc = sayı1 + sayı2;
            //    Console.WriteLine($"sonuc,{sonuc}");
            //}

            //else if (islem == "-")

            //{
            //    sonuc = sayı1 - sayı2;
            //    Console.WriteLine($"sonuc:,{sonuc}");

            //}
            //else if (islem == "*")
            //{
            //    sonuc = sayı1 * sayı2;
            //    Console.WriteLine($"sonuc,{sonuc}");
            //}

            //else if (islem == "/")
            //{
            //    if (sayı2 != 0)
            //    {
            //        sonuc = sayı1 / sayı2;
            //        Console.WriteLine($"sonuc:,{sonuc}");
            //    }

            //    else
            //    {
            //        Console.WriteLine("sayıların sıfıra bölümü sonsuz/tanımsızdır..");
            //    }
            //}
            //else 
            //    Console.WriteLine("geçersiz girdi");



            //havanın derecesine göre dışarı çıkma çıkmama kodunu yaz


            //Console.WriteLine("havanın şuanki derecesini yazın");
            //double derece=double.Parse(Console.ReadLine()!);
            //if (derece < 0)
            //    Console.WriteLine("hava çok soğuk boşver çıkma");
            //else if (derece > 0 && derece < 10)
            //    Console.WriteLine("erzurumluysan çık değilsen çıkma");
            //else if (derece >= 10 && derece < 25)
            //    Console.WriteLine("çık ya çık");
            //else
            //    Console.WriteLine("çık iyi hava kısa kol giy");



            //Console.WriteLine("havanın derecesini yaz");
            //int.TryParse(Console.ReadLine(), out int derece);
            //if (derece < 0)
            //    Console.WriteLine("hava çok soğuk boşver çıkma");
            //else if (derece > 0 && derece < 10)
            //    Console.WriteLine("erzurumluysan çık değilsen çıkma");
            //else if (derece >= 10 && derece < 25)
            //    Console.WriteLine("çık ya çık");
            //else
            //    Console.WriteLine("çık iyi hava kısa kol giy");


            //int stok = 10;
            //int istenenMiktar = 3;
            //if (stok >= istenenMiktar)
            //    Console.WriteLine("stok yeterli");
            //else
            //    Console.WriteLine("stok yetersiz");


            //int stok = 10;
            //int.TryParse(Console.ReadLine(), out int miktar);
            //bool yeterli = miktar <= stok;
            //bool sıfır = miktar == 0;
            //bool pozitif=miktar > 0;
            //bool negatif = miktar < 0;
            //Console.WriteLine($"sıfır, {sıfır}");
            //Console.WriteLine($"yeterli stok,{yeterli}");
            //Console.WriteLine($"pozitif,{pozitif}");
            //Console.WriteLine($"negatif,{negatif}");



            //Stok 10, istenen miktar 3.Stok yeterliyse miktarı stoktan düşüp satışı onaylayın; değilse
            //yalnızca yetersiz stok mesajı verin. Son stoku her durumda gösterin.Şimdilik miktar pozitiftir



            //int stok = 10;
            //int.TryParse(Console.ReadLine(), out int istenenMiktar);
            //bool yetersiz = stok < istenenMiktar;
            //if (stok >= istenenMiktar)
            //    Console.WriteLine($"stok yeterli yeni stok:{stok - istenenMiktar}");
            //else
            //    Console.WriteLine($"yetersiz stok,{yetersiz}");


            //int stok = 10;
            //int miktar = 3;
            //if (miktar <= stok)
            //{
            //    stok = stok - miktar;
            //    Console.WriteLine("Satis onaylandi.");
            //}
            //else
            //{
            //    Console.WriteLine("Stok yetersiz.");
            //}
            //Console.WriteLine($"Kalan stok: {stok}");



            //Console.WriteLine("stok durumu giriniz");

            //int stok=int.Parse(Console.ReadLine());
            //if (stok < 5)
            //{
            //    Console.WriteLine("stok azaldı uyarı!!");
            //}
               
            //Console.WriteLine($"stok:{stok}");








































        }
    }
}
