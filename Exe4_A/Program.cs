using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exe4_A
{
    class Stack
    {
        private int[] st;
        private int top;
        private int max;

        public Stack(int ukuran)
        {
            st = new int[ukuran];
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
                st[++top]=item;   
            } 

        }

    }
}
