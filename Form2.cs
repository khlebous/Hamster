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
    public partial class Form2 : Form
    {
        Form1 _parent;

        public Form2(Form1 parent)
        {
            _parent = parent;
            InitializeComponent();

            boardSizeComboBox.Items.Add("4 x 4");
            boardSizeComboBox.Items.Add("6 x 6");
            boardSizeComboBox.Items.Add("8 x 8");

            ActiveButtinsNumericUpDown.Value = Convert.ToDecimal(_parent.activeButtons);
            ClicksToEndNumericUpDown.Value = Convert.ToDecimal(_parent.clicksToEnd);
            boardSizeComboBox.SelectedIndex = _parent.boardIndex;
            if (_parent.round)
                radioButtonRound.Checked=true;

            this.KeyDown += CheckEnterKeyPress;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            char s = boardSizeComboBox.Text[0];
            int v = int.Parse(s.ToString());
            _parent.boardSize = v;
            _parent.activeButtons = Convert.ToInt32(ActiveButtinsNumericUpDown.Value);
            _parent.clicksToEnd = Convert.ToInt32(ClicksToEndNumericUpDown.Value);
            _parent.boardIndex = boardSizeComboBox.SelectedIndex;
            DialogResult = DialogResult.OK;

            _parent.round = radioButtonRound.Checked;

            this.Close();
            //this.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
            //this.Hide();
        }
        private void CheckEnterKeyPress(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                MyCancelButton.PerformClick();
                //OkButton_Click(sender, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                MyOkButton.PerformClick();
                //OkButton_Click(sender, e);
            }
        }
    }
}
