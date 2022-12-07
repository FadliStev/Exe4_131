using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_A
{
    class Stack
    {
        private int []fad = new int [49];
        private int top;
        private int max;

        public Stack(int ukuran)
        {
            fad = new int[ukuran];
            top = -1;
            max = 49;

        }
        public void push(int item)
        {
            if(top == max - 1)
            {
                Console.WriteLine("Stack Ofervlow");
                return; 
            }
            else
            {
                fad[++top]=item;  
                Console.WriteLine("Element " + item + " pushed");
            } 

        }
        public int pop()
        {
            if(top == -1)
            {
                Console.WriteLine("Stack Underflow");
                return -1;  
            }
            else
            {
                Console.WriteLine("Popped Element is: " + fad[top]);
                return fad[top--];
            }
        }
        public void display()
        {
            
            if(top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return ;
            }
            else
            {
                for(int i = 0; i < top; i++)
                {
                    Console.WriteLine("Item ["+ (i +1) + "]: "+ fad[i]);
                }
                Console.WriteLine();
            }

        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Stack st = new Stack(49);

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n**************Stack Menu*************\n");
                Console.WriteLine("1.Push");
                Console.WriteLine("2.Pop");
                Console.WriteLine("3.Display");
                Console.WriteLine("4.Exit");
                Console.WriteLine("\nEnter your choice");
                string sInput = Console.ReadLine();
                char ch = Convert.ToChar(sInput == "" ? "0" : sInput);
                switch (ch)
                {
                    case '1':
                        Console.WriteLine("Enter a Number : ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        st.push(num);
                        break;
                    case '2':
                        st.pop();
                        break;
                    case '3':
                        Console.WriteLine("Display Element");
                        st.display();
                        break;
                    case '4':
                        return;
                    case '5':
                        Console.WriteLine("Invalid Chooice");
                        break;
                }
            }


        }
    }
}
