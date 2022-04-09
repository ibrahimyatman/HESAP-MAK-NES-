using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HESAP_MAKİNESİ
{
    internal class Program
    {
        static void Main()
        {
            int collectionResult, subractionResult,muptiplicationResult;
            double splitResult;
            bool control = true;
            while (control)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                Console.WriteLine("Toplama(+) işlermleri için 1 tuşuna basınız");
                Console.WriteLine("Çıkarma(-) işlemleri için 2 tuşuna basınız ");
                Console.WriteLine("Çarpma(*) işlemleri için 3 tuşuna basınız ");
                Console.WriteLine("Bölme(/) işlemleri için 4 tuşuna basınız ");
                Console.WriteLine("Çıkış yapmak için q tuşuna basınız  ");
               string chocie=Console.ReadLine();
                
                    switch (chocie)
                    {
                        case "1":
                            {
                                Console.WriteLine("Lütfen toplamak(+) istediğiniz 1.sayıyı giriniz");
                                int firstNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Lütfen toplamak(+) istediğiniz 2.sayıyı giriniz");
                                int secondNumber = Convert.ToInt32(Console.ReadLine());
                                collectionResult = firstNumber + secondNumber;
                                Console.WriteLine("İşlemin sonucu = " + " " + collectionResult);
                                break;
                            }
                        case "2":
                            {
                                Console.WriteLine("Lütfen çıkarmak (-) istediğiniz 1.sayıyı giriniz");
                                int firstNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Lütfen çıkarmak (-) istediğiniz 2.sayıyı giriniz");
                                int secondNumber = Convert.ToInt32(Console.ReadLine());
                                subractionResult = firstNumber - secondNumber;
                                Console.WriteLine("İşlemin sonucu = " + " " + subractionResult);
                                break;

                            }
                        case "3":
                            {
                                Console.WriteLine("Lütfen çarpmak (*) istediğiniz 1.sayıyı giriniz");
                                int firstNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Lütfen çarpmak(*) istediğiniz 2.sayıyı giriniz");
                                int secondNumber = Convert.ToInt32(Console.ReadLine());
                                muptiplicationResult = firstNumber * secondNumber;
                                Console.WriteLine("İşlemin sonucu = " + " " + muptiplicationResult);
                                break;
                            }
                        case "4":
                            {
                                Console.WriteLine("Lütfen bölmek(/) istediğiniz 1.sayıyı giriniz");
                                int firstNumber = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Lütfen bölmek(/) istediğiniz 2.sayıyı giriniz");
                                double secondNumber = Convert.ToDouble(Console.ReadLine());
                                splitResult = firstNumber / secondNumber;
                                Console.WriteLine("İşlemin sonucu = " + " " + splitResult);
                                break;

                            }
                        case "q":
                            {
                                Console.WriteLine("Hesap makinesinden çıkış yapılıyor");
                                control = false;
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("lütfen geçerli bir karakter giriniz");
                                break;
                            }

                           


                 
                    }

                Console.WriteLine("************************************");
            }

        }
    }
}
