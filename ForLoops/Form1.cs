using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ForLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            q1Output.Text = "";
            q2Output.Text = "";
            q3Output.Text = "";
            q4Output.Text = "";
            q5Output.Text = "";
            q6Output.Text = "";

            ///1.  Create a loop that displays all values inclusive between 1-5.

            for (int i = 1; i <= 5; i++)
            {
                q1Output.Text += $"{i} ";
            }


            ///2.  Create a loop that displays all values inclusive between 10-6.
            for (int i = 10; i >= 6; i--)
            {
                q2Output.Text += $"{i} ";
            }

            ///3.  Create a loop that displays even numbers inclusive between 2 and 10
            for (int i = 2; i <=10; i += 2)
            {
                q3Output.Text += $"{i} ";
            }

            ///4.  Create a loop that displays the sum of all numbers inclusive 
            ///between 1 and 10. The answers should be 55.
            int value = 0;
            for(int i = 1; i <= 10; i++)
            {
                value += i;
            }
            q4Output.Text = $"{value}";

            ///5. Create a loop that displays all leap years inclusive between 
            ///1990 and 2010. The output should be: 1992 1998 2000 2004 2008
            for(int year = 1990; year <= 2010; year++)
            {
                if(year%4 == 0)
                {
                    q5Output.Text += $"{year} ";
                }
            }

            ///6. Print the following patterns using a loop:
            ///
            /// *
            /// **
            /// ***
            /// ****
            /// *****
            /// 
            /// Hint: Start off with a string that has 1 "*" in it, then 
            /// in the loop you will add another "*" using +=

            string theOutput = "*";
            for (int i = 0;i < 5;i++)
            {
                q6Output.Text += theOutput + "\n";
                theOutput += "*";
            }
        }
    }
}
