using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_homework
{
    internal class MainPrintFile
    {
        public void Print(object file) 
        {
            if (file is Word)
            {
                Console.WriteLine("Word cap edildi");
            }
            if (file is Excel )
            {
                Console.WriteLine("Excel cap edildi");
            }
            if (file is PDF)
            {
                Console.WriteLine("PDF cap edildi");
            }
        }
    }
}
