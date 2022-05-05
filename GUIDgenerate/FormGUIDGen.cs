using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace GUIDgenerate
{
    public partial class GUIDgenerate : Form
    {
        /// <summary>
        /// Generate Class constructor
        /// </summary>
        public GUIDgenerate()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Process Clear Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Clear_Click(object sender, EventArgs e)
        {
            textBox_GUID.Text = String.Empty;
            listBox_GUIDlist.Items.Clear();
        }

        /// <summary>
        /// Process Generate Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Generate_Click(object sender, EventArgs e)
        {
            int count = Convert.ToInt32(numericUpDown_Count.Value);
            while ( count-- > 0 )
            {
                if ( checkBox_UpperCase.Checked == true )
                {
                    textBox_GUID.Text = Guid.NewGuid().ToString().ToUpper();
                }
                else
                {
                    textBox_GUID.Text = Guid.NewGuid().ToString();
                }
                if (checkBox_ClipBoard.Checked == true)
                {
                    Clipboard.SetText(textBox_GUID.Text);
                }
                listBox_GUIDlist.Items.Add(textBox_GUID.Text);
                }
        }

        /// <summary>
        /// Process pick from list, place in text box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox_GUIDlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_GUID.Text = listBox_GUIDlist.SelectedItems[0].ToString();
            if (checkBox_ClipBoard.Checked == true)
            {
                Clipboard.SetText(textBox_GUID.Text);
            }
        }

        /// <summary>
        /// Process Right click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GUIDgenerate_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                AboutBoxGUID ab = new AboutBoxGUID();
                ab.ShowDialog();
            }

        }

    }
}
