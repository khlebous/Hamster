using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace wf1
{
    class MyBottons : Button
    {
        //Button _button = new Button();
        //public static int cos = 0;
        public static List<int> NotUsedButtoms = new List<int>();
        public static List<int> PushedButtons = new List<int>();
        private bool _isRound;
        //public static int score { get; set; } = 0;
        public int number { get; set; }
        public MyBottons(int i, bool round)
        {
            this.BackColor = Color.AliceBlue;
            _isRound = round;
            number = i;
            NotUsedButtoms.Add(i);
            this.Dock = DockStyle.Fill;

        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            if (_isRound)
            {
                GraphicsPath grPath = new GraphicsPath();
                grPath.AddEllipse(this.Width*0.15F, this.Height*0.15F, this.Width*0.70F,this.Height*0.70F);
                this.Region = new System.Drawing.Region(grPath);
            }
            base.OnPaint(e);
        }

        //private void MyBottons_Click(object sender, EventArgs e)
        //{
        //    if (this.BackColor == Color.Blue)
        //    {
        //        score += 50;
        //        HideButton();
        //    }
        //    else
        //    {
        //        score -= 100;
        //    }
        //}

        public void ShowButton()
        {
            this.BackColor = Color.Blue;
            PushedButtons.Add(number);
            NotUsedButtoms.Remove(number);
        }
        public void HideButton()
        {
            this.BackColor = Color.AliceBlue;
            PushedButtons.Remove(number);
            NotUsedButtoms.Add(number);
            //ButtonsInQueue.Deq
        }


    }
}
