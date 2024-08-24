using System;

namespace student
{
    public class studentmarks
    {
        public static void Main(string[] args)
        {
            float m=0, h=0, e=0, s=0, sst=0, total, percent;
            Console.WriteLine("Enter marks obtained in subjects : ");
            m = Convert.ToSingle(Console.ReadLine());
            h = Convert.ToSingle(Console.ReadLine());
            e = Convert.ToSingle(Console.ReadLine());
            s = Convert.ToSingle(Console.ReadLine());
            sst = Convert.ToSingle(Console.ReadLine());
            total=m+h+e+s+sst;
            percent=total/500*100;
            Console.WriteLine("Total : "+total);
            Console.WriteLine("Percent : "+percent);
            if(percent>90 && percent<=100)
            {
                Console.WriteLine("A Grade");
            }
            else if (percent > 70)
            {
                Console.WriteLine("B Grade");
            }
            else if (percent > 50)
            {
                Console.WriteLine("C Grade");
            }
            else
            {
                Console.WriteLine("Fail");
            }
            //Console.ReadLine();
        }
    }
}