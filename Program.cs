using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HESAP_MAKİNESİ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplama_sonuc, çıkarma_sonuc,çarpma_sonuc;
            double bölme_sonuc;
            bool kontrol = true;
            while (kontrol)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("Toplama(+) işlermleri için 1 tuşuna basınız");
                Console.WriteLine("Çıkarma(-) işlemleri için 2 tuşuna basınız ");
                Console.WriteLine("Çarpma(*) işlemleri için 3 tuşuna basınız ");
                Console.WriteLine("Bölme(/) işlemleri için 4 tuşuna basınız ");
                Console.WriteLine("Çıkış yapmak için q tuşuna basınız  ");
               string islem_secimi=Console.ReadLine();
                while (true)
                {
                    if (islem_secimi == "1")
                    {
                        Console.WriteLine("Lütfen toplamak(+) istediğiniz 1.sayıyı giriniz");
                        int sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen toplamak(+) istediğiniz 2.sayıyı giriniz");
                        int sayi2 = Convert.ToInt32(Console.ReadLine());
                        toplama_sonuc = sayi1 + sayi2;
                        Console.WriteLine("İşlemin sonucu = " + " " + toplama_sonuc);
                        break;


                    }
                    else if (islem_secimi == "2")
                    {
                        Console.WriteLine("Lütfen çıkarmak (-) istediğiniz 1.sayıyı giriniz");
                        int sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen çıkarmak (-) istediğiniz 2.sayıyı giriniz");
                        int sayi2 = Convert.ToInt32(Console.ReadLine());
                        çıkarma_sonuc = sayi1 - sayi2;
                        Console.WriteLine("İşlemin sonucu = " + " " + çıkarma_sonuc);
                        break;
                    }
                    else if (islem_secimi=="3")
                    {
                        Console.WriteLine("Lütfen çarpmak (*) istediğiniz 1.sayıyı giriniz");
                        int sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen çarpmak(*) istediğiniz 2.sayıyı giriniz");
                        int sayi2 = Convert.ToInt32(Console.ReadLine());
                        çarpma_sonuc = sayi1 * sayi2;
                        Console.WriteLine("İşlemin sonucu = " + " " + çarpma_sonuc);
                        break;
                    }
                    else if (islem_secimi=="4")
                    {
                        Console.WriteLine("Lütfen bölmek(/) istediğiniz 1.sayıyı giriniz");
                        int sayi1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Lütfen bölmek(/) istediğiniz 2.sayıyı giriniz");
                        double sayi2 = Convert.ToDouble(Console.ReadLine());
                        bölme_sonuc = sayi1 / sayi2;
                        Console.WriteLine("İşlemin sonucu = " + " " + bölme_sonuc);
                        break;
                    }
                    else if (islem_secimi=="q")
                    {
                        Console.WriteLine("Hesap makinesinden çıkış yapılıyor");
                        kontrol = false;
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Lütfwn geçerli bir karakter giriniz");
                        break;
                           
                    }
                }
                Console.WriteLine("************************************");

            }
            


        }
    }
}
