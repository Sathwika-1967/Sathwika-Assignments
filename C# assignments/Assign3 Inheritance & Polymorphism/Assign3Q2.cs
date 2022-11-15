using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3
{
    internal class Stack
    {
        int[] Mystack;
        int top;
        int max;
        public Stack(int size)
        {
            Mystack = new int[size];
            top = -1;
            max = size;
        }
        public void Push(int size)
        {
            try
            {
                if (top == 5)
                {
                    Console.WriteLine("The Stack is full");
                }
                else
                {
                    top++;
                    Mystack[top] = size;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void pop()
        {
            int Element;
            if (top == -1)
            {
                Console.WriteLine("The stack is underflow");
            }
            else
            {
                Element = Mystack[top];
                top--;
                Console.WriteLine(" The poped elements =" + Element);
            }
        }
        public void Display()
        {
            int i;
            for (i = top; i >= 0; i--)
            {
                Console.WriteLine(Mystack[i]);
                Console.ReadLine();
            }
        }
    }
}
    

