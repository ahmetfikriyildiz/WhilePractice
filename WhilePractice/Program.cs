using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhilePractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bu pratik uygulama 5 aşamadan oluşuyor. Aşağıdaki alıştırmaları while kullanarak yapınız.
            //1->Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.
            //2-> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.
            //3-> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.
            //4-> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.
            //5-> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.
            //Toplu yorum satırını kaldırmak için toplu bir şekilde kaldirmak istediğiniz bölümün kodunu seçiniz ve ctrl + k + u 

            #region 1->
            //int i = 0;
            //while (i < 10)
            //{
            //    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
            //    i++;
            //}
            //Console.ReadLine();
            #endregion
            #region 2->
            //int i = 1;
            //while (i <= 20)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            //Console.ReadLine();
            #endregion
            #region 3->
            //int i = 1;
            //int toplam = 0;
            //while (i <= 20)
            //{
            //    if (i % 2 == 0)
            //    {
            //        toplam+=i;
            //    }
            //    i++; 
            //}
            //Console.WriteLine("1 ile 20 arasındaki sayıların toplamı: " + toplam);
            //Console.ReadLine();
            #endregion
            #region 4->
            //int i = 50;
            //int toplam = 0;
            //while (i <= 150)
            //{
            //    toplam += i;
            //    i++;
            //}
            //Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);
            //Console.ReadLine();
            #endregion
            #region 5->
            //int i = 1;
            //int tekToplam = 0;
            //int ciftToplam = 0;
            //while (i <= 120)
            //{
            //    if (i % 2 == 0)
            //    {
            //        ciftToplam += i;
            //    }
            //    else
            //    {
            //        tekToplam += i;
            //    }
            //    i++;
            //}
            //Console.WriteLine("Tek sayıların toplamı: " + tekToplam);
            //Console.WriteLine("Çift sayıların toplamı: " + ciftToplam);
            //Console.ReadLine();
            #endregion
        }
    }
}
