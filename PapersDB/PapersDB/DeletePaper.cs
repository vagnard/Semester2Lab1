﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PapersDB
{
    public partial class DeletePaper : Form
    {
        public int ID;
        public DeletePaper()
        {
            ID = -1;
            InitializeComponent();
        }

        private void delPaper_btn_Click(object sender, EventArgs e)
        {
            if (paperID_txbx.Text.Trim() == "")
                MessageBox.Show("ID is empty");
            else
            {
                try
                {
                    ID = Convert.ToInt32(paperID_txbx.Text.Trim());
                }
                catch (FormatException)
                {
                    MessageBox.Show("Input string is not a sequence of digits.");
                }
                DialogResult = DialogResult.OK;
            }
        }
        
    }
}
