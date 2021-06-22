using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                System.Console.WriteLine("Bir sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Girilen sayı: " + sayi);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally //hata alsın almasın çalışan yer burası
            {
                System.Console.WriteLine("İşlem Tamamlandı");
            }

            try
            {
                int a =int.Parse("test");
                int a=int.Parse("-21234567890");
            }
            catch (ArgumentNullException ex)
            {
            System.Console.WriteLine("boşdeğer girdiniz");
            System.Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                System.Console.WriteLine("veri tipi uygun değil...");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                System.Console.WriteLine("çok küçük ya da çok büyük değer girdiniz...");
                System.Console.WriteLine(ex);
            }
            finally{
                System.Console.WriteLine("işlem başarıyla tamamlandı...");
            }
        }
    }
}
