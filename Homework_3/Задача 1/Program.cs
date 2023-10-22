        
        // Console.Clear();
        //     int number = 12321;
        // if (number >= 10000 && number < 100000)
        // {
        //     int n1 = number / 10000;
        //     int n2 = number % 10000 / 1000;
        //     int n3 = number % 1000 / 100;
        //     int n4 = number % 100 / 10;
        //     int n5 = number % 10;

        //     if (n1==n5 && n2==n4)
        //     {
        //         Console.Write("True");
        //     }
        //     else
        //     {
        //         Console.Write("False");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Число не пятизначное");
        //     Console.WriteLine("False");
        // }

        using System;

public class Answer
{
    static bool IsPalindrome(int number)
    {
              
        if (number >= 10000 && number < 100000)
        {
            int n1 = number / 10000;
            int n2 = number % 10000 / 1000;
            int n3 = number % 1000 / 100;
            int n4 = number % 100 / 10;
            int n5 = number % 10;

            if (n1==n5 && n2==n4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 64546;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}