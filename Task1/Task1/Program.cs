using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

// Написать консольное приложение,
// вычисляющие квадратный корень из введённого пользователем числа.
// Если пользователь ввел не число а текст, выводить сообщение "Ошибка: {введённый текст} не является числом".
// Если пользователь ввёл отрицательное число - выводить сообщение "Ошибка:  корень отрицательного числа вычислить невозможно".
namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        int i;

        try { 
        Console.WriteLine("Введите число для вычисления корня:");
        string input = Console.ReadLine(); 

        if (double.TryParse(input, out double number)){
            i = Convert.ToInt32(Math.Sqrt(number));
            Console.WriteLine(i);}
        else    { Console.WriteLine("Ошибка: " + input + " не является числом"); }    }
        
        catch { Console.WriteLine("Ошибка:  корень отрицательного числа вычислить невозможно"); }
        }
    }   
}
