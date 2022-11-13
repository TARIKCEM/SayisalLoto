﻿using System;

namespace SayisalLoto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayisal =new int[6];
            

            int[] tahminler = new int[6];

            int tahmin = 0;
            for (int i = 0; i < tahminler.Length;)
            {
                Console.Write("{0}.Tahmin:", i + 1);
                tahmin = Int32.Parse(Console.ReadLine());
                if (tahmin<1 || tahmin>49)
                {
                    Console.WriteLine("Lütfen 1 ila 49 arasında bir sayı giriniz");
                    continue;
                }
                else
                {
                    tahminler[i++] = tahmin;
                   
                }
            }

            //for (int i = 0; i < tahminler.Length; i++)
            //{
            //    Console.Write("{0} ", tahminler[i]);

            //}

            
            SayisalLotoCek(sayisal);
            int tahminSayisi = TahminEt(sayisal, tahminler);
            Console.WriteLine(" Doğru bilme Sayiniz: " + tahminSayisi);

        }

        static void SayisalLotoCek(int[] sayisal)
        {
            Random rnd = new Random();
            int value;
            for (int i = 0; i < sayisal.Length;)
            {
                value = rnd.Next(1, 50);
                if (Array.IndexOf(sayisal,value) == -1)
                {
                    sayisal[i] = value;
                    i++;
                }
            }
            Console.WriteLine("Sayisal Loto Çekiliyor.");

            for (int i = 0; i < sayisal.Length; i++)
            {
                Console.Write(sayisal[i] + " ");
            }
        }
            
        static int TahminEt(int[] sayilar, int[] tahminler)
        {
            int tahminSayisi = 0;
            //Console.Write("Doğru tahmin edilin sayılar: ");
            for (int i = 0; i < tahminler.Length; i++)
            {
                if (Array.IndexOf(sayilar,tahminler[i]) != -1) //13 sayilar array i içerisinde yoksa IndexOf -1 döner,varsa içindeki index numarasını döner
                {
                    tahminSayisi++;
                    //Console.Write("{0} ", tahminler[i]);
                }
            }
            return tahminSayisi;
        }
    }
}
