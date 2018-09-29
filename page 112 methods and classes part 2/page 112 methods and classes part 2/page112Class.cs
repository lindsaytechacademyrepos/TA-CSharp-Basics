using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page_112_methods_and_classes_part_2
{
    class page112Class
    {
        public int method1(int num)
        {
            return num * 8;
        }

        public decimal method2(decimal num)
        {
            return num * 8;
        }

        public int method3(string string1)
        {
            int string2 = Convert.ToInt32(string1);
            return Convert.ToInt32(string2 * string2);
        }
    }
}
