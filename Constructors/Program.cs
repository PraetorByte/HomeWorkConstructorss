/*Person person = new Person("construct", 11)
{
    age = 1,
    //name = "Initial",

};
person.Print();
person.Add(4, 2);
Console.WriteLine(person.ArithmeticMean(3, 5, 3, 7, 9, 9, 30, 30));
class Person
{
    public string name = "ByDefault";
    public byte age = 2;
    public Person(string name, byte age) : this(name)
    {
        
        this.age = age;
    }
    public Person() { }
    public Person(string name)
    {
        this.name = name;
    }
    public void Print()
    {
        Console.WriteLine(name + " " + age);
    }
    public int Add(int a = 2, int b = 2)
    {
        Console.WriteLine("add1");
        void LocalTest()
        {
            Console.WriteLine(a+b);
        }
        LocalTest();
        LocalTest();
        return a + b;
    }
    public void Add(int a, int b, int c)
    {
        Console.WriteLine("add2");

    }
    public double ArithmeticMean(params int[] nums)
    {
        int total = 0;
        foreach (int num in nums)
        {
            total += num;
        }
        return total / nums.Length;
    }
}*/

/*1
 
Model i model ne tozhe samoe
class Car
{
    public string Model;
    public int Year;

    public Car(string model)
    {
        model = model;
    }
}

2.
Tak prosto prisvaevaetsa Age 18 v tele constructa
class User
{
    public string Name;
    public int Age = 25;

    public User()
    {
        Age = 18;
    }
}

3.
Pered Salary v kotorij prisvoenie idet nado this.Salary
class Employee
{
    public string Name;
    public int Salary;

    public void UpdateSalary(int Salary)
    {
        Salary = Salary;
    }
}

4.
Netu v Book parametora
class Book
{
    public string Title = "Unknown";
    public int Pages;

    public Book()
    {
        this.Pages = pages;
    }
}

5. 
ne sovmestimostj tipov
class Person
{
    public string Name;
    public int Age;

    public Person(int name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}


*/



/*
 1.
dva metoda povtoryautsa s dvumya parametrami
class MathOperations
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(int a, int b)
    {
        return a + b;
    }
}

2.
2 parametra no ispolzuetsa 1
class Car
{
    public string Model;
    public int Year;

    public Car()
    {
        Model = "Неизвестно";
    }

    public Car(string model, int year)
    {
        this.Model = model;
    }
}

3. 
nuzhno napisatj params pered int[]
void PrintNumbers(int[] numbers)
{
    foreach (var number in numbers)
    {
        Console.WriteLine(number);
    }
}
PrintNumbers(1, 2, 3);

4.
net parametra prinimaushij tsifri
void Greet(string name, string message = "Привет")
{
    Console.WriteLine($"{message}, {name}!");
}

Greet("Анна", "Здравствуйте", 25);


*/



/*Animals animal = new Animals
{
    Age = 10
};*/
/*Person person = new Person
{
    Age = 10,
    Name = "Foo",
};*/
/*BankAccount bankAccount = new BankAccount(100, "joe")
{
    Balance = 0
};
bankAccount.Deposit(100);
bankAccount.Withdraw(111);*/
/*Homework o = new Homework();
o.SumArray(1, 2, 3);*/

/*
Order order = new Order();
Console.WriteLine("Write order price: ");
double price = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the discount in procent (0 if none): ");
int discount = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Write the additional discounts in procent with \",\" splitting them (0 if none): ");
string[] discountStrings = Console.ReadLine().Split(',');
double[] additionalDiscounts = Array.ConvertAll(discountStrings, double.Parse);
PrintPrices();

void PrintPrices()
{
    double currentPrice = price;
    Console.WriteLine("Original price: " + order.CalculateTotal(price));
    if (discount > 0)
    {
        currentPrice = order.CalculateTotal(price, discount);
        Console.WriteLine("Discounted price: "+ currentPrice);
    }
    if (additionalDiscounts[0] > 0)
    {
        Console.WriteLine("Additional discounts discounted price: " + order.ApplyDiscounts(currentPrice, additionalDiscounts));
    }
}
*/


class Homework
{
    public Homework()
    {

    }
    public int Multiply(int num)
    {
        return num * 2;
    }
    public int Multiply(int num1, int num2)
    {
        return num1 * num2;
    }
    
    public void SumArray(params int[] totalNums)
    {
        // NOTE: Где вызов локальной функции?
        int Local (params int[] totalNums)
        {
            int sum = 0;
            foreach (int i in totalNums)
            {
                sum += i;
            }
            Console.WriteLine("Sum: " + sum);
            return sum;
        };
    }
}

class Order
{
    public double CalculateTotal(double price)
    {
        return price;
    }

    public double CalculateTotal(double price, double discountPercent)
    {
        double discount = (discountPercent / 100) * price;
        return price - discount;
    }

    public double CalculateTotal(double price, double discountPercent, double fixedDiscount)
    {
        double discount = (discountPercent / 100) * price;
        return price - discount - fixedDiscount;
    }

    public double ApplyDiscounts(double price, params double[] discounts)
    {
        double finalPrice = price;
        foreach (double i in discounts)
        {
            double discount = (i / 100) * price;
            finalPrice -= discount;
        }
        return finalPrice;
    }
}

class MyProgram
{
    public static void PrintMessage(string userName, string message = "Hello")
    {
        Console.WriteLine($"{message}, {userName}!");
    }

    public static void PrintGrades(params int[] grades)
    {
        Console.WriteLine("Grades:");
        foreach (var grade in grades)
        {
            Console.WriteLine(grade);
        }
    }
}

class Animals
{
    public string Species;
    public string Name;
    public int Age;
    // NOTE: Где конструктор???
}

class Rectangle
{
    public double Width;
    public double Height;
    public int Color;
    public Rectangle()
    {
        this.Width = 0;
        this.Height = 0;
    }
    public Rectangle(double width, double height)
    {
        // NOTE: Где вызов одного конструктора из другого?
        this.Width = width;
        this.Height = height;
    }
    public Rectangle(double width, double height, int color)
    {
        // NOTE: Где вызов одного конструктора из другого?
        this.Width = width;
        this.Height = height;
        this.Color = color;
    }
}

class Student
{
    public string Name;
    public int Grade;
    public void UpdateGrade(int Grade)
    {
        this.Grade = Grade;
    }
}

class Person
{
    public int Age; 
    public string Name;
    public Person()
    {
        this.Age = 1;
    }
}

class Circle
{
    public double radius = 0;
    public Circle()
    {


    }
    public Circle(double radius)
    {
        this.radius = radius;

    }
}

class BankAccount
{
    public int AccountNumber;
    public double Balance;
    public string Owner;
    public BankAccount(int accNum, string owner)
    {
        this.AccountNumber = accNum;
        this.Owner = owner;
    }
    public void Deposit(double balance) // NOTE: Работа метода не соответствует ТЗ.
    {
        this.Balance = balance;
        Console.WriteLine($"Balance: {this.Balance}"); // NOTE: В ТЗ не сказано, что метод должен что-то выводить в консоль. Это мусорный код.
    }
    public void Withdraw(double amount)
    {
        this.Balance = this.Balance < amount ? this.Balance : this.Balance - amount;
        Console.WriteLine($"Balance: {this.Balance}"); // NOTE: В ТЗ не сказано, что метод должен что-то выводить в консоль. Это мусорный код.
    }


}
