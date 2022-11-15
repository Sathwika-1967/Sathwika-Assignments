using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen3
{
    internal class StackException
    {
        public void Elements()
        {
            try
            {
                Stack st = new Stack(6);
                Console.WriteLine("---Stack Elements are---");
                st.Push(4);
                st.Push(5);
                st.Push(6);
                st.Push(7);
                st.Push(8);
                st.Push(9);
                st.Push(10);
                st.Display();
                Console.WriteLine("---Removed elements are-----");
                st.pop();
                st.pop();
                Console.WriteLine("-----After pop Method---");
                st.Display();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public static void Main()
        {
            StackException stackException = new StackException();
            stackException.Elements();
            Console.ReadLine();
        }

    }
}

