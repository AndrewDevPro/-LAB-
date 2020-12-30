using System;

namespace LAB_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int King = 0;

            Console.Write("На какой из координат находиться король (1-8) : ");
            King = Convert.ToInt32(Console.ReadLine());

            do
            {
                if (King < 0 || King > 8)
                {
                    Console.WriteLine("Такой координаты не на шахматной доске, введите от 1 до 8 : ");
                    King = Convert.ToInt32(Console.ReadLine());
                }
            } while (King<0 || King >8);
           

            if (King == 3)
            {
                Console.WriteLine("True - король может перейти на вторую половину доски за 1 шаг ");
            }
            else if(King>3)
            {
                Console.WriteLine("True - король находится на второй половине доски ");
            }
            else
            {
                Console.WriteLine("False - король не сможет перейти на вторую половину доски за 1 шаг ");
            }
        }
    }
}
