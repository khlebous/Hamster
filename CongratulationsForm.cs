using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf1
{
    public partial class CongratulationsForm : Form
    {
        Form1 _parent;
        public CongratulationsForm(Form1 parent, int score)
        {
            _parent = parent;
            InitializeComponent();
            ScoreLabel.Text = score.ToString();
            this.KeyDown += CheckEnterKeyPress;
        }

        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {                
                MyOkButtton.PerformClick();
            }
        }

        private void MyOkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextCHangedEvent(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace( NameTextBox.Text))
            //if (NameTextBox.Text.Length > 0)
                MyOkButtton.Enabled = true;
            else
                MyOkButtton.Enabled = false;

        }

        private void MyOkButtton_Click(object sender, EventArgs e)
        {
            _parent.gamerName = NameTextBox.Text;
            this.Close();
        }
    }
}
