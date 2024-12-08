using System.Text;

namespace Methods_5._12
{
    internal class Program
    {
        //Value türündeki bir parametre, metot içerisinde değişiklik yapılsa bile metottan çıktıktan sonra, yine eski değerini görürür. Buna  "call-by-value" denir.

        //Reference türündeki bir parametre, metot içerisinde değişiklik yaplırsa metottan çıktıktan sonra, yeni değerini görürür. Buna  "call-by-reference" denir.
        //string istisnadır. Reference tür olmasına rağmen, call-by-value gider.

        //Value türlerini referance türler gibi göndermek için ref veya out kelimelerini kullanırız. İkisi de call-by-ref yapar. 
        //AMA!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        //ref:Metod içerisinde değer atamaya GEREK YOK. AMA metodu çağırırken değer atamak ZORUNDAYIZ!!!!!!!!!!!!!!!!!!!

        //out:Metod içerisinde değer atamaya GEREK VAR. AMA metodu çağırırken değer atamaya GEREK YOK!!!!!!!!!!!!!!!!!!!

        //Aynı zamanda metodu çağırırken de parametre yerinde out ile değişken tanımlanabilir fakat ref ile tanımlamaz.
        //(out ile olan bu değişkeni isterseniz parametre kısmında değil de yine öncesinde de tanımlanabilir)



        static int F(int x)  //call-by-value
        {
            x++;
            return x;
        }
        static int F2(ref int x)  //call-by-value
        {
            x++;
            return x;
        }
        static int F3(out int x)  //call-by-value
        {
            x = 1;
            x++;
            return x;
        }
        static void F4(out string kelime)
        {
            kelime = "Sonuç";
        }
        static double Ornek1( double sayi,out int tam,out double ondalik)
        {
           
            tam = (int)sayi;
            ondalik = sayi - tam;
           
            return tam * tam - ondalik;
        }
        static void BasitCarpimTablosu(int sayi,out int birKati, out int ikiKati, out int ucKati, out int dortKati, out int besKati)
        {
            birKati = sayi * 1;
            ikiKati = sayi * 2;
            ucKati = sayi * 3;
            dortKati = sayi * 4;
            besKati = sayi * 5;
        }

        static void KDVliHesapla(ref float fiyat)
        {
            fiyat *= 1.2f;

        }
        static void Deneme(int y=100, int x = 9) //bu parametreli metodda x ve y'nin sıralarını ve nasıl eklenip nasıl sıralarının değiştirilebileceği anlatılıyor.
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }

        static void Main(string[] args)
        {
            #region Deneme methodunun döndüreceği değerler ve aradaki fark
            Deneme(13); //13,100
            Deneme(13, 44); //13,44
            #endregion

            #region KDV'li hesap metodu
            float price;
            Console.WriteLine("Please write the price of the product:");
            price = Convert.ToSingle(Console.ReadLine());
            KDVliHesapla(ref price);
            Console.WriteLine(price);
            #endregion

            #region Çarpım tablosu metodu
            int sayi;
            Console.WriteLine("Sayıyı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            BasitCarpimTablosu(sayi,out int birKati, out int ikiKati, out int ucKati, out int dortKati, out int besKati);
            #endregion

            #region Ondalıklı bir sayının tam ve ondalık kısmını veren metot
            double sayi2;
            Console.WriteLine("Sayıyı giriniz:");

            sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Önce Sayı: " + sayi2);

            var sonuc2 = Ornek1(sayi2, out int tam, out double ondalik);
            Console.WriteLine("Tam: " + tam + " Ondalik: " + ondalik);
            Console.WriteLine("Sonuc: " + sonuc2);
            Console.WriteLine("Sonra sayı: " + sayi2);
            #endregion

            #region F2 ve F4 metotları
            string s = "5";
            string word = "abc";
            Console.WriteLine("önce: " + word);
            F4(out word);
            Console.WriteLine("sonra: " + word);

            var durum = int.TryParse(s, out int sonuc);

            int deneme = 9;
            sonuc = F2(ref deneme);
            Console.WriteLine("Sonrası: " + sonuc);
            Console.WriteLine("Sonuç:  " + sonuc);
            #endregion

        }
    }
}
