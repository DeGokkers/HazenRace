﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De_Gokkers
{
    public class CustomNumericUpDown : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            this.Text = "€" + this.Value.ToString();
        }
    }
}