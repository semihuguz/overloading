Console.WriteLine("*********Alt Parametreler ****************");

string  sayi = "999";
int outSayi;
bool sonuc = int.TryParse(sayi, outSayi);

if (sonuc)
{
    Console.WriteLine("Basarili");
    Console.WriteLine(outSayi);
}
else
{
    Console.WriteLine("Basarisiz");
}
Metotlar instance = new Metotlar();
instance.Topla(4,5, out int toplamSonuc);
Console.WriteLine(toplamSonuc);

int ifade = 999;
instance.EkranaYazdir(Convert.Tostring(ifade));
instance.EkranaYazdir(ifade);


class Metotlar 
{
    public int Topla(int a, int b, out int toplam)
    {
        toplam = a+b;
    }
}

//Birden fazla ayni metodu tanimlamamiza izin verir.  Bu şekilde birden fazla aynı metodun yazılmasına overloading, aşırı yükleme adı verilir.
class overloading
{
    public void EkranaYazdir(string veri)
    {

    } 
    public void EkranaYazdir(int veri)
    {
        
    } 
    public void EkranaYazdir(string veri1, string veri2)
    {
        Console.WriteLine(veri1 + veri2);
    } 
}


