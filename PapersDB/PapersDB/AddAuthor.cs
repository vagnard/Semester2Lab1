﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace PapersDB
{
    public partial class AddAuthor : Form
    {
        public Scientist NewScientist;
        public AddAuthor()
        {
            NewScientist = new Scientist();
            InitializeComponent();
        }

        public AddAuthor(List<string> scientistNames)
        {
            NewScientist = new Scientist();
            InitializeComponent();
            authorNames_cmbx.DataSource = scientistNames;
        }

        private void addAuthor_btn_Click(object sender, EventArgs e)
        {
            if (authorNames_cmbx.Text.Trim() == "")
                MessageBox.Show("Name is empty");
            else
            {

                NewScientist.Name = authorNames_cmbx.Text.Trim();
              
                    DialogResult = DialogResult.OK;
                
            }
        }
    }
}
