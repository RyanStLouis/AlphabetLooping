/*
 * Created by: Ryan St. Louis
 * Created on: 20-10-2015
 * Created for: ICS3U
 * Daily Assignment – Unit#3-13
 * This program displays looping letters of the alphabet.
*/

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
