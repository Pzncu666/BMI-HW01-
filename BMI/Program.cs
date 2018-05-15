using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI
{
    class Program
    {
        static void Main(string[] args)
        {   
            // 更換文字顏色
            Console.ForegroundColor = ConsoleColor.Cyan;

            // 輸入變數
            Console.Write("請輸入身高(公分):");
            string height = Console.ReadLine();
            double h = double.Parse(height) / 100;
            Console.Write("請輸入體重(公斤):");
            string weight = Console.ReadLine();
            double w = double.Parse(weight);
            
            // 更換文字顏色
            Console.ForegroundColor = ConsoleColor.Green;
            
            // 計算BMI
            double bmi = w / (Math.Pow(h, 2));
            Console.WriteLine("BMI數值為:" + bmi);
            Console.WriteLine();
            
            // 判斷BMI結果
            if (bmi < 18.5)
            {
                Console.WriteLine("過輕咯");
            }
            else if (18.5 <= bmi && bmi < 24)
            {
                Console.WriteLine("恭喜~正常體質");
            }
            else
                Console.WriteLine("過重不優ㄜ");
            
            // 判斷兵役
            if (bmi < 16.5)
            {
                Console.WriteLine("免役desu");
            }
            else if (18.5 <= bmi && bmi < 24)
            {
                Console.WriteLine("呀齁~國軍弟兄");
            }
            else
                Console.WriteLine("免役desu");
            
            // 停住畫面
            Console.ReadLine();




        }
    }
}
