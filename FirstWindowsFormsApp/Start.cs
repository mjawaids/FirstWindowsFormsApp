using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp
{
    class Start
    {
        public static void Main()
        {
            MyForm form = new MyForm();
            Application.Run(form);
        }
    }
}
