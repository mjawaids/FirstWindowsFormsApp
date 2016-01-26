using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstWindowsFormsApp
{
    public class MyForm : Form
    {
        private TextBox textBox;
        private Button button;
        private Label label;

        public MyForm()
        {
            Text = "My Window";

            textBox = new TextBox();
            textBox.Left = 25;
            textBox.Top = 25;
            textBox.Width = 200;
            Controls.Add(textBox);

            button = new Button();
            button.Left = 25;
            button.Top = 75;
            button.Width = 200;
            button.Text = "Click Me";
            Controls.Add(button);

            label = new Label();
            label.Left = 25;
            label.Top = 125;
            label.Width = 200;
            label.Text = "Label";
            Controls.Add(label);
        }   
    }
}
