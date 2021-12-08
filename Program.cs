using System;
using System.Collections.Generic;
using System.Linq;


namespace module1pr31s3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите кол-во программ");
            int countProg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во языков прог.");
            int countLangProg = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите кол-во правильных прог.");
            int workProgTrue = Convert.ToInt32(Console.ReadLine());

            WorkTrue workTrue = new WorkTrue(surname, countProg, countLangProg, workProgTrue);

            int q = workTrue.Q();
            workTrue.Qp(q);
            Console.WriteLine("Q = " + q);
        }
    }
}