using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphabetLooping
{
    public partial class frmAlphabetLooping : Form
    {
        public frmAlphabetLooping()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            // variables
            int firstNumber;
            int secondNumber;
            // clear listbox
            this.lstBox.Items.Clear();

            for (firstNumber = 65; firstNumber <= 90; firstNumber++)
            {

                for (secondNumber = 97; secondNumber <= 122; secondNumber++)
                {

                    this.lstBox.Items.Add(Char.ConvertFromUtf32(firstNumber) + " -> " + Char.ConvertFromUtf32(secondNumber));
                }
            }
        }
    }
}
