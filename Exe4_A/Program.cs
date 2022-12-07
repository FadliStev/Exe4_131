using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_A
{
    class Stack
    {
        private int[] fad;
        private int top;
        private int max;

        public Stack(int ukuran)
        {
            fad = new int[ukuran];
            top = -1;
            max = ukuran;

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
                Console.WriteLine("Popped Element is: " +fad[top]);
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
            }
        }
    }
    class Program
    {
        static void Main()
        {
            Stack st = new Stack(5);

            st.push(49);

            Console.WriteLine("Items Are : ");
            st.display();

            st.pop();


        }
    }
}
