using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string era = "BC";
            
            string result = "";
            for (int i = -5; i <= 5; i++)
            {
                if(era == "BC" && i < -1)
                {
                    i *= -1;
                    result += "Century " + i + " " + era + " " + (i - 1) * 100 + "-" + (i * 100 - 1) +"\n";
                    i *= -1;
                }else if(era == "BC" && i == 1)
                {
                    result += "Century " + i + " " + era + " " + i + "-" + (i * 100 - 1) + "\n";
                    era = "AD";
                    i -= 1;
                }else if(era == "AD" && i == 1)
                {
                    result += "Century " + i + " " + era + " " + i + "-" + (i * 100 - 1) + "\n";
                    
                }else if(era == "AD" && i < 6)
                {
                    result += "Century " + i + " " + era + " " + (i - 1) * 100 + "-" + (i * 100 - 1) + "\n";
                }
                
            }
            MessageBox.Show(result);
        }
    }
}
