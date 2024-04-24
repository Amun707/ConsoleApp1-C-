namespace ConsoleApp1_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // однострочные
            /* многострочные
             */
            //арифметические операторы: +  -  */  %
            //операторы сравнения:  ==  >  <  <=  >=  ! =
            // логические операторы:  && ||  ! =
            //операторы присваивания:  =  +=  -=  *=  /=  &=  ^=  |=

            /*  int a;
              Console.WriteLine("Hello, World!");
              if (true)
              {

              }
              else if (true)
              {

              }
              else
              {

              }
              switch (a) { }
              a ? " " : bool;
            */

            /*  int a;
              a = Convert.ToInt32(Console.ReadLine());//запрашиваем у польз. число
              Console.WriteLine(a);
              if (a % 3 == 0)
              {
                  Console.Write("Fizz");
              }
              if (a % 5 == 0)
              {
                  Console.WriteLine("Buzz");
              }
              else
              {
                  Console.WriteLine(a);
                  int m, n;
                  n = Convert.ToInt32(Console.ReadLine());
                  m = Convert.ToInt32(Console.ReadLine());
                  int res;
                  res = n * m / 100;
                  Console.WriteLine(res);
              }*/

            //  int c, v, k, l;
            /*  c = Convert.ToInt32(Console.ReadLine());
              v = Convert.ToInt32(Console.ReadLine());
              k = Convert.ToInt32(Console.ReadLine());
              l = Convert.ToInt32(Console.ReadLine());
              Console.WriteLine(c * 100 + v * 100 + k * 10 + l);*/

            //  string a, b, s, d;
            //a = Console.ReadLine();
            //b = Console.ReadLine();
            //s = Console.ReadLine();
            //d = Console.ReadLine();
            //Console.WriteLine(Convert.ToInt32(a + b + s + d));

            //  var asd = 2.3f;//чтобы изменить тип данных с double на float добавляем в конце f
            //чтобы double l
            /*  int a, b;
              a = Convert.ToInt32(Console.ReadLine());
              b = Convert.ToInt32(Console.ReadLine());
              if (a < b)
              {
                  for (int i = a; i <= b; i++)
                  {
                      if (i % 2 == 0)
                          Console.WriteLine(i);
                  }
              }
              if (b < a)
              {
                  for (int i = b; i <= a; i++)
                      if(i%2==0)
                      Console.WriteLine(i);
              }
            */
            int a, b;
           a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
           int start = Math.Min(a, b);
            int end = Math.Max(a, b);

            (a, b) = (b, a);//можно swapать таким образом
        }
    }
}
