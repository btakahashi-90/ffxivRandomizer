using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ffxivRando
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            // change select mode for loop
            cBox.SelectionMode = SelectionMode.MultiSimple;

            // loop to select all
            for (int i = 0; i < cBox.Items.Count; i++)
                cBox.SetSelected(i, true);

            // change selection mode back to multi-Ext
            cBox.SelectionMode = SelectionMode.MultiExtended;
        }

        private void clearClasses_Click(object sender, EventArgs e)
        {
            cBox.ClearSelected();
        }
    }
}
