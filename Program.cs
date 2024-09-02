using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Todo todo = new Todo();
            List<string> list = new List<string>();

            bool bl = true;
            int op =0 ;
            while (bl)
            {
                Console.WriteLine("options ,press num to manage the book ");
                Console.WriteLine("1 for add task");
                Console.WriteLine("2 for remove task");
                Console.WriteLine("3 for mark us done");
                Console.WriteLine("4 for view task and status");
                Console.WriteLine("5 for exit");
                try
                {
                     op = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception e) {
                    Console.WriteLine(e.Message);
                }
                if (op == 1)
                {
                    todo.addTask();
                }
                else if (op == 2)
                {
                    todo.removeTask();
                }
                else if (op == 3)
                {
                    todo.markusdone();
                }
                else if (op == 4)
                {
                    todo.viewList();
                }
                else if (op == 5)
                {
                  bl = false;
                }
                else
                {
                    Console.WriteLine("invalid input");
                }
                Console.WriteLine();
            }
            Console.WriteLine("press any to continue");
            Console.ReadKey();
        }
    }
}
