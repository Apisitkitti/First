using System;
public class Program1
{
    public static void Main()
    {
        string NumInput1 = InputNUM1();
        string NumInput2 = InputNUM2();
        string NumInput3 = InputNUM3();
        int Changnum_1 = StringtoInt(NumInput1);
        int Changnum_2 = StringtoInt(NumInput2);
        int Changnum_3 = StringtoInt(NumInput3);
        int All_plus = Sum(Changnum_1,Changnum_2,Changnum_3);
        AllOutput(All_plus);


    }
    public static string InputNUM1()
    {
            Console.Write("Pls Input your number 1 : ");
            return Console.ReadLine(); 
    }
     public static string InputNUM2()
    {
            Console.Write("Pls Input your number 2 : ");
            return Console.ReadLine(); 
    } 
    public static string InputNUM3()
    {
            Console.Write("Pls Input your number 3 : ");
            return Console.ReadLine(); 
    }
    public static int StringtoInt(string Value)
    {
        if(int.TryParse(Value,out int num ))
        {
          return num;  
        }
        throw new Exception("Pls input again");
    }
    public static int Sum(int First,int Sec,int Third)
    {
        return First+Sec+Third;
    }
    public static void AllOutput(int Sum)
    {
        Console.WriteLine("*********************************************");
        Console.WriteLine("Sum: {0}",Sum);
        Console.WriteLine("*********************************************");

    }

}
