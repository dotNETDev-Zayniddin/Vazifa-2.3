using System;
namespace Vazifa{
    class Program{
        static void Main(string[] args){
            Console.Write("Patriet tekshiruvi o'tkazmoqchi bo'lgan sonni kiriting: ");
            int input = Convert.ToInt32(Console.ReadLine());    

            bool isEven = input % 2 == 0;
            bool isOdd = input % 2 == 1;
            int intisEven = Convert.ToInt32(isEven);
            int intisOdd = Convert.ToInt32(isOdd);
             
            string result;
            result = $"{(char)(84*intisOdd)}{(char)(111*intisOdd)}{(char)(113*intisOdd)}{(char)(74*intisEven)}{((char)(117*intisEven))}{(char)(102*intisEven)}{(char)(116*intisEven)}";
            
            //ASCII Jadvalidan foydalanib chiqishi kerak bo'lgan natijaning har bir harfi topib chiqildi. Misol: (char) (84) = 'T'
            // Va (char) (84) * intisEven toq yoki juft ekanligini tekshiradi. Agar juft bo'lsa intisEven = 0 va 'T' = 0, 'o' = 0 'q'=0 hosil bo'lib natijada Juft ko'rinadi 

            Console.Write($"Natija: {result}");
        }
    }
}