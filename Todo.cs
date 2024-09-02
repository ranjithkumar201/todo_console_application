using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    internal class Todo
    {
       
        List<object> todoList=new List<object>();
        List<string> status=new List<string>();
        //string status = "\tstatus  :  incomplete";
        public void addTask()
        {
            Console.WriteLine("Enter todo in a list:");
            object todo=Console.ReadLine();
            todoList.Add(todo.ToString());
            status.Add("\t(status : incomplete)");
            Console.WriteLine("Successfully added");
        }
        public void removeTask()
        {
            int c = 1;
            if (todoList.Count > 0)
            {
                int n = 0;
                foreach (string todo in todoList)
                {
                    Console.WriteLine($"{c++} - {todo}");
                }
                Console.Write("Enter num to remove task :");
                try
                {
                     n = Convert.ToInt32(Console.ReadLine());
                }catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                if (n >= 1 && n <= todoList.Count)
                {
                    todoList.Remove(todoList[n - 1]);
                    status.Remove(status[n - 1]);
                    Console.WriteLine("SUCCESSFULLY REMOVED");
                }
                else
                {
                    Console.WriteLine("invalid option");
                }
            }
            else
            {
                Console.WriteLine("EMPTY TODO");
            }
        }
        public void viewList()
        {
            Console.WriteLine("\t\t\t\tTODO LIST---------");
            int c = 1;
            if (todoList.Count > 0)
            {
                //var newlist=todoList.Concat(status);
                //foreach (object todo in newlist)
                //{
                //    Console.WriteLine($"\t\t\t\t{c++} - {todo} ");
                //}
                for(int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($"\t\t{c++} - {todoList[i]}{status[i]}");
                }
            }
            else
            {
                Console.WriteLine("\t\t\t\tEMPTY TODO");
            }
        }
        public void markusdone()
        {
            int c = 1;
            foreach (string todo in todoList)
            {
                Console.WriteLine($"{c++} - {todo}");
            }
            Console.Write("Enter num to mark us done :");
            int n= Convert.ToInt32(Console.ReadLine());
            if (n>=0&&n<=todoList.Count) {
                status[n - 1] = "\t(status : done)";
               // todoList[n - 1] = todoList[n - 1]+status;
                Console.WriteLine("STATUS UPDATED");
            }
            else
            {
                Console.WriteLine("INVALID OPTIONS");
            }
        }
    }
}
