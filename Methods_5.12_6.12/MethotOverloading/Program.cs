namespace MethodOverloading_6._12
{
    internal class Program
    {
        /*  
         * Method Overloading (Metot Aşırı yükleme) : AYNI İSİMDE fakat farklı imzada olan metodlar oluşturmaktır.
         */
        static int Mutlak(int sayi) //sayi integer ise
        {
            if (sayi < 0)
            {
                return -1 * sayi;
            }
            return sayi;
        }
        static double Mutlak(double sayi) //sayi double ise
        {
            if (sayi < 0)
            {  
                return -1 * sayi;
            }
            return sayi;
        }

        static double BizimMetot(double sayi, int derece) //aşağıdaki verilen (-8, 3)'ün bu metotta nasıl çalıştığı
        {
            while (derece < 1) //derece şu anda 3 verildiği için while döngüsüne girmez, eğer 0 veya -li bir sayı girilseydi while döngüsüne giricek ve yeni bir derece isteyecekti
            {
                Console.WriteLine("Dereceyi tam pozitif ve 1 den büyük giriniz");
                derece = Convert.ToInt32(Console.ReadLine());
            }

            if (sayi < 0) //sayı -8 olduğu için if'e girer ama...
            {
                while (derece % 2 == 0) //derece 3 olduğu ve 3%2!==0 olduğu için bu while'a girmez ve aşağıdaki if'ten devam eder.
                {
                    Console.WriteLine("Sayı negatif ise derece çift olamaz! Ayrıca derece her zaman pozitif olmalıdır");
                    derece = Convert.ToInt32(Console.ReadLine());
                }
            }

            if (sayi < 0) //(-8, 3) burda işlem görücek.
            {
                sayi = Math.Abs(sayi);//Sayının mutlak değerini döndüren fonksiyon. -8'i 8 yapıcak
                return Math.Pow(sayi, 1 / derece) * -1; //8'in 1/3 denilen şey 8'in '∛8' halidir yani 2 döndürüp -1 ile çarpıcak ve bunu return edicek. 
            }
            return Math.Pow(1,0/ derece);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(64)); //64'ün kökünü döndüren fonksiyon
            Console.WriteLine(Math.Pow(2, -6)); //2'nin -6'ncı üssünü döndüren fonksiyon
            Console.WriteLine(Math.Ceiling(2.16)); //sayıyı en yakın üst tamsayıya yuvarlıyor. Yani bu durumda 3
            Console.WriteLine(Math.Floor(2.96)); //sayıyı en yakın alt tamsayıya yuvarlıyor. Yani bu durumda 2
            Console.WriteLine(Math.Max(13, 6)); //iki sayı arasındaki max değer
            Console.WriteLine(Math.Min(13, 6)); //iki sayı arasındaki min değer
            Console.WriteLine(Math.PI); //Pi sayısı
            Console.WriteLine(Math.E); //e sayısı
            Console.WriteLine(Math.Sin(30 * Math.PI / 180)); //Sinüs fonksiyonu 30*3,14/180
            Console.WriteLine(BizimMetot(-8, 3));
            Console.WriteLine(Mutlak(-14));//aynı isimde ama int döndüren mutlak
            Console.WriteLine(Mutlak(-28.93));//aynı isimde ama double döndüren mutlak method overloading'in en basit olarak yaptığı şey budur.
                                              //İsim aynı ama farklı değeri olan, farklı parametre alan veya farklı sonuç döndüren methodlara denir.
        }
    }
}
