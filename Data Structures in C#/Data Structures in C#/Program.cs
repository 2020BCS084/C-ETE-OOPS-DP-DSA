/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

dwdd
namespace Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack st = new Stack();                    //stack :
            st.Push(3);
            st.Push(5);
            Console.WriteLine(st.Push(8));
            Console.WriteLine(st.Peek());
            Console.ReadLine();

                                                      //Queue :   
        }
    }
    class Stack
    {
        public int top;
        public const int Max = 10;
        public object[] obj = new object[Max];     //creating array of object   //in it we can store any type of data ig.
        public Stack()
        {
            top = -1;
        }
        public object Push(object val)
        {
            if (top < Max)
            {
                obj[++top] = val;
                return val;
            }
            return -1;
        }
        public object Pop()
        {
            if (top > 0)
            {
                object popped_element = obj[top];
                top--;
                return popped_element;
            }
            else
            {
                Console.WriteLine("stack underflow");
            }
            return -1;     
        }
        public object Peek()
        {
            if (top > 0) { 
            return obj[top];
            }
            return null;
        }
    }
}*/






//Linked List : 

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Program
{

   public class Node<T>
    {
       public T Data;
       public Node<T> Next;
       public Node(T Data)           //if dont use public for constructor then we wont be able to create the instance of this class.
        {
            this.Data = Data;
            Next = null;
        }

    }
    public class LinkedListN<T>{
       public Node<T> Head;
        public LinkedListN()
        {
            Head = null;
        }

      public  void Add(T Data)
        {
            Node<T> NewNode = new Node<T>(Data);
            
            if (Head == null)
            {
                Head = NewNode;
            }
            else
            {
                Node<T> curr;
                curr = Head;
                while (curr.Next != null)
                {
                    curr = curr.Next;
                }
                curr.Next = NewNode;
            }
        }

       public void PrintLinkedList()
        {
            if (Head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                Node<T> curr=Head;
                while (curr != null)
                {
                    Console.Write(curr.Data+" ");
                    curr = curr.Next;
                }
            }
        }

    }

    public class Program2
    {
        public static void Main(string[] args)
        {
            LinkedListN<int> lst = new LinkedListN<int>();
            lst.Add(1);
            lst.Add(2);
            lst.Add(3);
            lst.Add(4);
            lst.Add(5);
            lst.Add(6);
            lst.PrintLinkedList();
            Console.ReadLine();

        }
        
    }
}






//Tree in C# : 



class Tree
{






}