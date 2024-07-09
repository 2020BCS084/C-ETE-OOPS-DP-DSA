using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desing Patterns : 
            /*Design patterns are defined as reusable solutions to the common problems that arise during software design and development. They are general templates or best practices that guide developers in creating 
             *well-structured, maintainable and efficient code.

            creational design patterns are used to create the objects.
            two main ideas behind these patterns encapsulation and hiding how these objects are created & combined.
            They help make a system independent of how its objects are created, composed, and represented.
            Creational patterns give a lot of flexibility in what gets created, who creates it, how it gets created, and, when.




            Creational Design Patterns are as follows : 
            -abstract factory - let's us create object without specifying their type.  
            -Builder - facilitates the creation of complex objects.
            -Factory Method - creates objects without specifying the exact classes to create.
            -Prototype - Prototype pattern creates a new object from an object that already exists.
            -Singleton - it ensure that only one instance of the object is created and exists in app at any one time.*/

-Factory Method Design Pattern : 
-Factory Method or Factory Design Patterns also known as virtual constructor, it define an interface for creating an object, but let subclasses decide which class to instantiate.

-When to Use the Factory Method : 
-A class can’t anticipate the class of objects it must create.
-A class wants its subclass to specify the objects it creates.
-Classes delegate responsibility to one of several helper subclasses, and you want to localize the knowledge of which helper subclass is the delegate.

//5 things we need to create for the abstract factory : 
-abstract factory, concrete factory, the abstract product ,the concrete product and the client.  //In essence, abstract factory focuses on interface definition and family creation, while concrete factory implements specific object creation logic based on that interface.
-In abstract Design_Patterns each class should follows single responsibility principle means it should do only one thing. Due to seperate class for adding more functionality we dont need to change the clients class.




//Builder Method : 

Builder pattern aims to “Separate the construction of a complex object from its representation so that the same construction process can create different representations.” It is used to construct a complex 
object step by step, the final step will return the object. The process of constructing an object should be generic so that it can be used to create different representations of the same object.

-We used builder design pattern when we want to get the rid of telescopic constructor i.e constructors with n-optional different parameters for creating n-different types of objects.
-We need 4 things to create builder design pattern : 
-Builder interface, Concrete Builder class, a product class and a directive class. the main advantage of builder design pattern is we can use the same constructor code for designing different objects.
It ensures the single responsibility principle.



//Abstract Factory Design Pattern :
In simpler terms the Abstract Factory Pattern is a way of organizing how you create groups of things that are related to each other.
Abstract Factory pattern is almost similar to Factory Pattern and is considered as another layer of abstraction over factory pattern.
Abstract Factory patterns work around a super-factory which creates other factories.
So at runtime, the abstract factory is coupled with any desired concrete factory which can create objects of the desired type.
eg: 
Given the scenario where you have different categories of cars (luxury cars and ordinary cars), and each category includes specific types of cars(like Audi and BMW for luxury, and Tata and Toyota for 
ordinary), the Abstract Factory pattern would be the most suitable design pattern to use.

//First we will have the Super Factory which creates the instances of other factories like luxary factory or ordinary factory and these subfactories will create the instance of the actual cars i.e if ordinary
//then tata or toyota and if luxury then BMW or Audi.


        }
    }
}