int donenDeger = toplamaYap(6, 7);
Console.WriteLine("Toplam = " + donenDeger);

string donenisimsoyisim = isimsoyisimyazdir("Berk", "DURAN");
Console.WriteLine("Benim adım : " + donenisimsoyisim);
  }
  
  static int toplamaYap(int sayi1, int sayi2)
{
    int sonuc = sayi1 + sayi2;
    return sonuc;
}
static string isimsoyisimyazdir(string isim, string soyisim)
{
    return isim + " " + soyisim;
}