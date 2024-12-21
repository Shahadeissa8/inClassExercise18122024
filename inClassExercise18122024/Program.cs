#region function1
using System.Xml.Linq;
using Microsoft.VisualBasic;

void PrintName()
{
    int x = 7;
    int y = 8;
    int sum = x + y; // it can be connected to database and used later
    Console.WriteLine("Shahad Eissa");
}

PrintName();
Console.WriteLine("===============");
#endregion

#region function2
int TotalSum()
{
    int n1 = 5;
    int n2 = 6;
    int n3 = 7;
    int sum = n1 + n2 + n3;
    // return sum = n1 + n2 + n3;;
    return sum;
}
Console.WriteLine(TotalSum()); // but why? because we didnt ask it to print it before now we are
Console.WriteLine("===============");
#endregion

#region function3
double EmployeeSalary()
{
    double salary, bonus, sum;
    salary = 1000;
    bonus = 500;
    sum = salary + bonus;
    return sum;
}
double totsales = 100;
double empsalary = EmployeeSalary();
Console.WriteLine(totsales + empsalary);
Console.WriteLine("sum " + (totsales + EmployeeSalary()));
Console.WriteLine("===============");
#endregion

#region function4
string FullName(string name)
{
    return name;
}
Console.WriteLine("write name");
string fname = Console.ReadLine();
Console.WriteLine("name is: " + fname);
#endregion

#region function4
int FindMax(int n1, int n2)
{
    if (n1 > n1)

        return n1;

    else
        return n2;
}

Console.WriteLine("enter first number");
int koko = Convert.ToInt32(Console.ReadLine()); // we can name it whatever it still will go to the function as n1
Console.WriteLine("enter second number");
int soso = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("max is " + FindMax(koko, soso));
#endregion

#region function5
//string FindMaxString = ""
//{
//    if (n1 > n1)

//    else if (n1>n2)

//        return "bigger"+n2;

//}
#endregion

#region function6
//name first last
//age
//gender
//is statement only 
//return first name last name , age > 18 write it and welcome, 18 if lower false 
string profile(string name, string gender, int age)
{
    if (age >= 18)
    {
        if (gender == "male")
        {
            return "mr " + name + "your age is " + age;
        }
        else
        {
            return "ms " + name + "your age is " + age;
        }
    }
    else
    {
        return "less than 18";
    }

}
Console.WriteLine("enter your name ");
string yourName = Console.ReadLine();
Console.WriteLine("enter gender ");
string gender = Console.ReadLine();
Console.WriteLine("enter age ");
int age = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(profile(yourName, gender, age));
#endregion

#region alternativeForFunctio6
void profile2(string theName, string theGender, int age)
{
    if (age >= 18)
    {
        if (gender == "female")
        {
            Console.WriteLine("welcomr mr " + theName);
        }
        else
        {
            Console.WriteLine("welcome ms" + theName);
        }
    }
    else
    {
        Console.WriteLine("you are too oung");
    }
}
Console.WriteLine("enter name ");
string thisIsName = Console.ReadLine();
Console.WriteLine("enter gender ");
string thisIsGender = Console.ReadLine();
Console.WriteLine("enter age ");
int thisIsAge = Convert.ToInt32(Console.ReadLine());
profile2(thisIsName, thisIsGender, thisIsAge);// we dont write it in console.writeline because it is a void

#endregion
