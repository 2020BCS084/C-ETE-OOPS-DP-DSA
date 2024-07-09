using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace OOPS_Implementation
{
    public abstract class Device
    {
        public string color;                 //here data members & methods bind under same class therefore showing encapsulation
        private string device_ip;
        public int display_size;
        public string device_state;        //they can be consider for composition as have strong binding with device.

        public string charger;             //consider for aggregation

        protected Device(string color, string device_ip, int display_size, string device_state, string charger)
        {
            this.color = color;
            this.device_ip = device_ip;
            this.display_size = display_size;
            this.device_state = device_state;
            this.charger = charger;
        }

        public abstract int Start_Device();
        public abstract int Stop_Device();
    }

    public class Mobile : Device
    {
        public int front_camera_status = 0;
        public int back_camera_status = 0;
        public int call_status = 0;

        public Mobile(string color, string device_ip, int display_size, string device_state, string charger)
            : base(color, device_ip, display_size, device_state, charger)
        {
            Console.WriteLine("Mobile is created");
        }

        public override int Start_Device()                   //method overriding.
        {
            Console.WriteLine("Mobile started");
            device_state = "start";
            return 1;
        }

        public override int Stop_Device()                   //method overriding. 
        {
            Console.WriteLine("Mobile shutdown");
            device_state = "stop";
            return 0;
        }

        public int start_camera(string cam)
        {
            if (cam == "front")
            {
                front_camera_status = 1;
                back_camera_status = 0;
                return 1;
            }
            else
            {
                back_camera_status = 1;
                front_camera_status = 0;
                return 1;
            }
        }

        public int phone_call()
        {
            Console.WriteLine("Disconnecting the phone...");
            return call_status = 0;
        }

        public int phone_call(string no)                                  //method overloading.
        {
            Console.WriteLine($"Making phone call to {no} ...");
            return call_status = 1;
        }


    }

    public class Laptop : Device                                       //inheritance
    {
        public int open_status = 0;       //here data members & methods bind under same class therefore showing encapsulation

        public int cursor_status = 0;

        public Laptop(string color, string device_ip, int display_size, string device_state, string charger)
            : base(color, device_ip, display_size, device_state, charger)
        {
            Console.WriteLine("Laptop is created");
        }

        public override int Start_Device()
        {
            Console.WriteLine("Laptop started");
            device_state = "start";
            return 1;
        }

        public override int Stop_Device()
        {
            Console.WriteLine("Laptop shutdown");
            device_state = "stop";
            return 0;
        }

        public int openLaptop()
        {
            return open_status = 1;
        }

        public int closeLaptop()
        {
            return open_status = 0;
        }

        public int moveCursor()
        {
            cursor_status = 1;
            Console.WriteLine("Moving Cursor");
            return cursor_status = 1;
        }
    }

    public class Microwave : Device                                   //inheritance
    {
        public int temp;
        public int time_delay = 0;                 //here data members & methods bind under same class therefore showing encapsulation


        public Microwave(string color, string device_ip, int display_size, string device_state, string charger)
            : base(color, device_ip, display_size, device_state, charger)
        {
            Console.WriteLine("Microwave is created");
        }

        public override int Start_Device()
        {
            Console.WriteLine("Microwave started");
            return 1;
        }

        public override int Stop_Device()
        {
            Console.WriteLine("Microwave stopped");
            return 0;
        }

        public int setTimer(int time)
        {
            return time_delay = time;
        }

        public bool increaseTemp(int temp)
        {
            this.temp = this.temp + temp;
            return true;
        }

        public bool decreaseTemp(int temp)
        {
            this.temp = this.temp - temp;
            return true;
        }

        public int getTemp()
        {
            return this.temp;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Mobile redmi_note9Pro = new Mobile("red", "123.123.126.129", 400, "off", "yes");
            redmi_note9Pro.Start_Device();
            redmi_note9Pro.start_camera("front");
            redmi_note9Pro.phone_call("9876545678");
            redmi_note9Pro.phone_call();
            redmi_note9Pro.Stop_Device(); //there can be any number & type of mobiles which are considerd as mobiles this can also shows associatoin. 

            Laptop Dell_windows_10 = new Laptop("black", "211.220.129.198", 400, "off", "yes");
            Dell_windows_10.openLaptop();
            Dell_windows_10.moveCursor();
            Dell_windows_10.closeLaptop();

            Microwave first = new Microwave("white", "21.220.129.198", 200, "off", "yes");
            first.increaseTemp(50);
            first.decreaseTemp(20);
            first.setTimer(100);
            first.getTemp();
        }
    }
}











//Important OOPS Topics : 

//abstract classes : 
abstract class Animal
{
    // Abstract method (does not have a body)
    public abstract void animalSound();            //see we need to use abstract keyword here.
    // Regular method
    public void sleep()
    {
        Console.WriteLine("Zzz");
    }
}
// Derived class (inherit from Animal)
class Pig : Animal
{
    public override void animalSound()              //need to use the override keyword here.
    {
        // The body of animalSound() is provided here
        Console.WriteLine("The pig says: wee wee");
    }
}
class Program
{
    static void Main(string[] args)
    {   Pig myPig = new Pig(); // Create a Pig object
        myPig.animalSound();  // Call the abstract method
        myPig.sleep();  // Call the regular method
    }
}













//Interfaces: Interface methods do not have a body - the body is provided by the "implement" class  //no need to use the keyword implement actually.
//On implementation of an interface, you must override all of its methods                           //no need to use the keyword override actually.
//Interfaces can contain properties and methods, but not fields/variables
//Interface members are by default abstract and public
//An interface cannot contain a constructor (as it cannot be used to create objects)
//If we declare the methods in interface then we need to override all the methods in child else error will come.
//Classes are internal by default if no access specifier is given like => class Program {} so here access specifier is internal
//we can not create the objects of abstract classes and interfaces.

eg. interface IFirstInterface
{
    void myMethod(); // interface method
}

interface ISecondInterface
{
    void myOtherMethod(); // interface method
}

// Implement multiple interfaces
class DemoClass : IFirstInterface, ISecondInterface
{
    public void myMethod()
    {
        Console.WriteLine("Some text..");
    }
    public void myOtherMethod()
    {
        Console.WriteLine("Some other text...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        DemoClass myObj = new DemoClass();
        myObj.myMethod();
        myObj.myOtherMethod();
    }
}



//What is the difference between 