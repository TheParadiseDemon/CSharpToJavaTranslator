using System;
namespace Program
{
    class main
     {

public static int sum(int a, int b){
 return a+b;
}
public static int mul(int a, int b){
 return a*b;
}

              public  static  void main(String[] args)
        {
          int a = 2;
          int b = 5;
          Console.WriteLine(sum(a,b));
           Console.WriteLine(mul(a,b));
            Console.WriteLine(mul(a,b)+sum(a,b));
           }

}
}s