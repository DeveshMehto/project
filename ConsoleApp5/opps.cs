using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class opps
    {
        int model_no, car_price;
        string car_name;
        string car_color;
        void input1()


        {
            model_no = 101;
            car_name = " harrier";
            car_color = "black";
            car_price = 1500000;


        }
        void display1(string car1)
        {
            Console.WriteLine("model number" + model_no);
            Console.WriteLine("car name" + car_name);
            Console.WriteLine("car color" + car_color);
            Console.WriteLine("car price" + car_price);
        }
        void input2()
        {
            model_no = 102;
            car_name = " GTR";
            car_color = "blue";
            car_price = 15000000;
        }
        void display2(string car2)
        {
            Console.WriteLine("model number" + model_no);
            Console.WriteLine("car name" + car_name);
            Console.WriteLine("car color" + car_color);
            Console.WriteLine("car price" + car_price);
        }
        static void Main(string[] args)
        {
            opps c = new opps();
            Console.WriteLine("enter car name");
            string car1 = Console.ReadLine();
            c.input1();
            c.display1(car1);
            Console.WriteLine("enter second car name");
            string car2 = Console.ReadLine();
            c.input1();
            c.display1(car2);

        }
    }

    class methodoverloading
    {
        int calculate(int a, int b)
        {
            return a + b;
        }
        float calculate(int x, float y)
        {
            return x * y;
        }
        int calculate(int a, int b, int c)
        {
            return a - b - c;
        }
        float calculate(float a, float b)
        {
            float c = a / b;
            return c;

        }
        static void Main(string[] args)
        {
            methodoverloading mo = new methodoverloading();
            Console.WriteLine("addition" + mo.calculate(10, 5));
            Console.WriteLine("substraction" + mo.calculate(20, 10, 5));
            Console.WriteLine("multiplication" + mo.calculate(5, 10f));
            Console.WriteLine("dividion" + mo.calculate(50f, 10f));
        }
    }
    class Areaoverloading
    {
        void Area(int r)
        {
            float pi = 3.14f;
            float area = pi * (r * r);
            Console.WriteLine("area of circle" + area);
        }
        void Area(int l, int b)
        {
            float area = l * b;
            Console.WriteLine("area of rectangle" + area);
        }
        void Area(float h, float b)
        {
            float area = (h * b) / 2;
            Console.WriteLine("area of triangle" + area);
        }
        void area(float s)
        {
            float area = s * s;
            Console.WriteLine("area of square" + area);
        }
        static void Main(string[] args)
        {
            Areaoverloading AO = new Areaoverloading();
            AO.Area(6);
            AO.Area(3, 5);
            AO.Area(4f, 5f);
            AO.Area(6);

        }

    }
    class Bank
    {
        int Acc_no;
        string Acc_type;
        double balance;
        string cust_name;

        void acc_details()
        {
            Console.WriteLine("enter details of account holder");
            Console.WriteLine("enter account number");
            Acc_no = int.Parse(Console.ReadLine());
            Console.WriteLine("enter account type");
            Acc_type = Console.ReadLine();
            Console.WriteLine("enter customer name");
            string cust_name = Console.ReadLine();
            Console.WriteLine("enter balance");
            balance = double.Parse(Console.ReadLine());

        }

        void show_details()
        {
            Console.WriteLine("details of account holder");
            Console.WriteLine("account number" + Acc_no);
            Console.WriteLine("account type" + Acc_type);
            Console.WriteLine("customer name" + cust_name);
            Console.WriteLine("account  balance" + balance);

        }
        void deposite()
        {
            Console.WriteLine("enter amount to deposite");
            double depo = double.Parse(Console.ReadLine());
            balance = balance + depo;
            show_details();
        }
        void withdraw()
        {
            Console.WriteLine("enter amount to be withdraw");
            double with = double.Parse(Console.ReadLine());
            balance = balance - with;
            show_details();

        }
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.acc_details();
            bank.show_details();

            Console.WriteLine("select");
            Console.WriteLine("1:deposite \n2:withdraw");
            int ch = int.Parse(Console.ReadLine());
            if (ch == 1)
            {
                bank.deposite();
            }
            else if (ch == 2)
            {
                bank.withdraw();
            }
            else
            {
                Console.WriteLine("wrong choice");
            }
        }
    }
    class student
    {
        int Roll_No;
        string Name;
        float per;
        void accept_Details()
        {
            Console.WriteLine("enter student name");
            Name = Console.ReadLine();
            Console.WriteLine("enter roll number");
            Roll_No = int.Parse(Console.ReadLine());
        }
        float percentage()
        {
            Console.WriteLine("enter marks of subject");
            int sub1 = int.Parse(Console.ReadLine());
            int sub2 = int.Parse(Console.ReadLine());
            int sub3 = int.Parse(Console.ReadLine());
            int total = int.Parse(Console.ReadLine());
            per = (total * 100) / 300;
            return per;


        }
        void display()
        {
            Console.WriteLine("\n\n\n Details of subject");
            Console.WriteLine("Name" + Name);
            Console.WriteLine("roll number" + Roll_No);
            Console.WriteLine("percentage" + per);
        }
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.accept_Details();
            s1.percentage();
            s1.display();
        }
    }
    class constoverload
    {
        public constoverload()
        {
            Console.WriteLine("constructor without parameter");
        }
        public constoverload(int modelno)
        {
            Console.WriteLine("first overload constructor with single parameter");
            Console.WriteLine("car model number is" + modelno);
        }
        public constoverload(int modelno, string brand)
        {
            Console.WriteLine("first overload constructor with second parameter");
            Console.WriteLine("car model no" + modelno + "\ncar brand" + brand);
        }
        static void Main(string[] args)
        {
            constoverload co = new constoverload();
            constoverload co1 = new constoverload(101);
            constoverload co2 = new constoverload(102, "tata");


        }
    }
    class StaticOverLoad
    {
        static int a;
        int b;
        public void Addition(int x, int y)
        {
            a = x;
            b = y;
            Console.WriteLine("Addition" + (a + b));
        }
        public void Division(int x, int y)
        {
            StaticOverLoad s = new StaticOverLoad();
            a = x;
            s.b = y;
            int c = a / s.b;
            Console.WriteLine("Division+" + c);
        }


    }
    internal class staticover
    {
        static void Main(string[] args)
        {

            StaticOverLoad so = new StaticOverLoad();
            so.Addition(10, 5);
            so.Division(10, 5);
        }
    }
    class car
    {
        private int model;
        private string name;
        private string color;
        private int price;

        public int Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Name
        { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Price
        { get { return price; } set { price = value; } }



    }
    class carinfo
    {
        static void Main(string[] args)
        {
            car c = new car();
            c.Model = 101;
            c.Name = "Mustang";
            c.Color = "black";
            c.Price = 10000000;
            Console.WriteLine(c.Model + " " + " " + c.Name + " " + c.Color + " " + c.Price);
        }
    }

    class studentt
    {
        private int id;
        private string name;
        private double percentage;
        private bool isstudent;

        public int Id
        { get { return id; } set { id = value; } }
        public string Name
        { get { return name; } set { name = value; } }
        public double Percentage
        { get { return percentage; } set { percentage = value; } }
        public bool Isstudent
        { get { return isstudent; } set { isstudent = value; } }


    }
    class studentinfo
    {
        static void Main(string[] args)
        {
            studentt s = new studentt();
            s.Id = 0111;
            s.Name = "devesh";
            s.Percentage = 8.04;
            s.Isstudent = true;
            Console.WriteLine(s.Id + " " + " " + s.Name + " " + s.Percentage + " " + s.Isstudent);
        }
    }

    class Department
    {
        private int did;
        private string dname;


        public int Did
        { get { return did; } set { did = value; } }

        public string Dname
        { get { return Dname; } set { Dname = value; } }




    }
    class emp
    {

        private int id;
        private string name;
        private Department dept;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        { get { return name; } set { name = value; } }
        public Department Dept
        {
            get { return dept; }
            set { dept = value; }



        }
        static void Main(string[] args)
        {
            emp e = new emp();
            e.Id = 12;
            e.Name = "sanjay";
            e.Dept = new Department();
            Department d = e.Dept;
            d.Did = 24;
            d.Dname = "HR";

            Console.WriteLine(e.Id + " " + e.Name + " " + d.Did + " " + d.Dname);




        }
    }
    class Subengine
    {
        string cleanupDate;

        public Subengine(string cleanupDate)
        {
            this.cleanupDate = cleanupDate;
        }
        public void DisplaySubengine()
        {
            Console.WriteLine(cleanupDate);
        }


    }
    class Engine
    {
        string type;
        Subengine sub;
        public Engine(string type, Subengine sub)
        {
            this.type = type;
            this.sub = sub;
        }
        public void DisplayEngine()
        {

            Console.WriteLine(type + " ");
            sub.DisplaySubengine();


        }

    }

    
    class Car
    {
        int modelno;
        string name;
        Engine e;
        Car(int modelno,string name,Engine e)
        {
           this. modelno = modelno;
            this.name = name;
            this.e = e;
        }
        void show()
        {
            Console.WriteLine(modelno+" "+name+" ");
            e.DisplayEngine();
        }
        static void Main(string[] args)
        {
            Car c = new Car(2344,"supra", new Engine("Petrol", new Subengine("6 -jun-2022")));
            c.show();
        }
    }
    class Mydate
    {
        private int dd;
        private int mm;
        private int yy;

        public int DD
        { get { return dd; } set { dd = value; } }
        public int MM { get { return mm; } set { mm = value; } }
        public int YY
        { get { return yy; } set { yy = value; } }
    }

    class Order
    { 
        private int o_id;
        private string cust_name;
        private int price;
        private string city;

        public int O_id
        { get { return o_id; } set { o_id = value; } }
        public string Cust_name
        { get { return cust_name; } set { cust_name = value; } }
        public int Price
        { get { return price; } set { price = value; } }
        public string City
            { get { return city; } set { city = value; } }
    }
    class Shipment
    {
        public int id;
        public  Order od;
        public Mydate md;

       static void Main(string[] args)
       {
        Shipment sm = new Shipment();
        sm.id = 11;
        sm.od = new Order();
        sm.od.O_id = 111;
        sm.od.Cust_name = "devesh";
        sm.od.Price = 2000;
        sm.od.City = "Bhopal";
        sm.md = new Mydate();
        sm.md.DD = 06;
        sm.md.MM = 06;
        sm.md.YY = 2022;
        Console.WriteLine("shipment Id" + sm.id + "Order Id" + sm.od.O_id + "Customer name" + sm.od.Cust_name + "Price" + sm.od.Price + "City" + sm.od.City + "DD" + sm.md.DD + "MM" + sm.md.DD + "YY" + sm.md.YY);
  
       }
    }
    class Nib
    {
        private string materialType;
        public Nib(string materialType)
        {
            this.materialType = materialType;   
        }
        public void showNib()
        {
            Console.WriteLine("Material Type"+materialType);
        }
    }
    class Pen
    {
        private int length;
        private string Color;
        private int price;
        private Nib nb;

        public Pen(int length,string Color,int price,Nib nb)
        {
            this.length = length;   
            this.Color = Color;
            this.price = price;
            this.nb = nb;
        }
        public void showpen()
        {
            Console.WriteLine("length"+length+"color"+Color+"price");
            nb.showNib();
        }
    }
    class Bag
    {
        private string brand_name;
        private string color;
        private Pen p;

        public Bag(string brand_name,string color,Pen p)
        {
            this.brand_name = brand_name;
            this.color = color;
            this.p = p;
        }
        public void showBag()
        {
            Console.WriteLine("Brand Name"+brand_name+"Color"+color);
            p.showpen();

        }
        static void Main(string[] args)
        {
            Bag bg = new Bag("Skybag", "olivegreen", new Pen(10, "blue", 20, new Nib("crome")));
            bg.showBag();
        }

    }

    class Mobile
    {
        protected string memory = "128";

    }
    class Apple:Mobile
    {
         string camera="12mp";
        void show()
        { 
            Console.WriteLine("memory" + memory + "camera" + camera); 
        }
        static void Main(string[] args)
        {
            Apple a = new Apple();
            a.show();
        }
    }

    class Shape
    {
        protected string area = "8";

    }
    class Triangle : Shape
    {
        string triangle = "right angle";
        void show()
        {
            Console.WriteLine("    area  " +area +   " triangle  "   + triangle);
        }
        static void Main(string[] args)
        {
            Triangle a = new Triangle();
            a.show();
        }
    }

    class Bike
    {
        protected string Model = "Bullet";

    }
    class RoyalEnfield : Bike
    {
        string CC = "350";
        string Color = "Black";
        void show()
        {
            Console.WriteLine("    Model  " + Model + " CC  " + CC + " Color  " + Color);
        }
        static void Main(string[] args)
        {
            RoyalEnfield a = new RoyalEnfield();
            a.show();
        }
    }

    class Clothes
    {
        protected string Type = "T-shirt";
        protected int Price = 1500;

    }
    class GAP : Clothes
    {
        string size = "Medium";
        string Color = "Black";
        void show()
        {
            Console.WriteLine("    Type " + Type + " Price  " + Price + " Size  " +size+ "color "+Color  );
        }
        static void Main(string[] args)
        {
            GAP a = new GAP();
            a.show();
        }
    }
    class College
    {
        public string name = "TIT";
        public string type = "All Courses";

    }
    class Course:College
    {
        public string course1 = "Engineering";
        public string course2 = "B.Com";
        public string course3 = "MBA";
    }
    class Branch:Course
    {
        public string engineering = "ME,IT,CS & EC";
        public string bcom = "Economics & Texation";
        public string mba = "Marketing & Finance";

        void show()
        {
            Console.WriteLine(" College Name " +name +"  Type "  + type  + "  Course1  "+  course1  + "  Course2  " +  course2 + "  Course3 "  +  course3  +  "  Engineering  "  + engineering +  "  BCom  " +  bcom  + " MBA " +  mba);
        }
        static void Main(string[] args)
        {
            Branch a = new Branch();
            a.show();
        }
    }
    class Laptop
    {
        protected int price = 50000;

    }
    class Dell:Laptop
    {
        public void show()
        {
            price = 60000;
            Console.WriteLine(" Dell " +price);
        }
    }
    class HP : Laptop
    {
        public void display()

        {
            price = 55000;
            Console.WriteLine( " HP " +price);
        }
    }
    class Accer:Laptop
    {
        public void output()
        {
            price = 70000;
            Console.WriteLine(" Accer " +price);
        }
    }
    class MyLaptop
    {
        static void Main(string[] args)
        {
            Dell d = new Dell();
            d.show();
            HP h = new HP();
            h.display();
            Accer a = new Accer();
            a.output();
        }
    }
    class Animal
    {
        protected int legs = 2;


        public Animal()
        {
            Console.WriteLine("Animal");
        }
        public Animal(int x)
        {
            Console.WriteLine("x="+x);
        }
        public void foo()
        {
            Console.WriteLine("Parent");
        }

    }
    class Dog:Animal
    {
        int legs = 4;
        public Dog():base()
        {
            Console.WriteLine("Dog");
        }
        public Dog(int x) : base(x)
        {
            Console.WriteLine("My x child "+" "+x);
        }
        void show()
        {
            Console.WriteLine(legs+ " "+base.legs);
            base.foo();
        }
        public void foo()
        {
            Console.WriteLine("child");
        }
        static void Main(string[] args)
        {
            Dog d = new Dog();
            d.show();
            d.foo();
            Dog d2 = new Dog(123);

        }
    }
    class Vehical
    {
        public virtual void run()
        {
            Console.WriteLine("vehical is running....");
        }
    }
    class Carr:Vehical
    {
        public override void run()
        {
            Console.WriteLine("car is running......");
        }
    }
    class Truc:Vehical
    {
        public override void run()
        {
            Console.WriteLine("truck kis running.......");
        }
    }
    class Overriding
    {
        static void Main(string[] args)
        {
            Vehical d = new Carr();
            d.run();
        }
    }


}



