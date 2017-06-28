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
    public partial class Form1 : Form
    {
        public int boardSize { get; set; } = 4;
        public int boardIndex { get; set; } = 0;
        public int activeButtons { get; set; } = 5;
        public int clicksToEnd { get; set; } = 5;
        public string gamerName { get; set; }
        public bool round { get; set; } = false;
        private bool isStart = false;
        int actualClicks = 0;
        int score = 0;

        MyBottons[] buttons;
        Timer timer = new Timer();
        Form2 modal;
        CongratulationsForm congForm;

        public Form1()
        {
            InitializeComponent();
            ReadFromTXT();
            InitialNewGame();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            trackBar1.ValueChanged += TrackBar1_ValueChanged;
        }

        private void ReadFromTXT()
        {
            if (!System.IO.File.Exists("score.txt"))
                return;
            using (System.IO.TextReader tw = new System.IO.StreamReader("score.txt"))
            {
                string line1;
                while ((line1 = tw.ReadLine()) != null)
                {
                    string line2 = tw.ReadLine();
                    ListViewItem lvi = new ListViewItem(new[] { line1, line2 });
                    ScorelistView.Items.Add(lvi);
                }
            }
        }

        public void MyBottons_Click(object sender, EventArgs e)
        {
            if (!isStart)
                return;
            MyBottons mb = (MyBottons)sender;
            if (mb.BackColor == Color.Blue)
            {
                score += 50;
                mb.BackColor = Color.AliceBlue;
                MyBottons.PushedButtons.Remove(mb.number);
                MyBottons.NotUsedButtoms.Add(mb.number);
                ScoreStatusLabel.BackColor = default(Color);
            }
            else
            {
                score -= 100;
                ScoreStatusLabel.BackColor = Color.Red;
            }
            ScoreStatusLabel.Text = "Score: " + score.ToString();
            if (++actualClicks >= clicksToEnd)
                EndOfGame();
        }

        private void InitialNewGame()
        {
            timer.Stop();
            isStart = false;
            score = 0;
            ScoreStatusLabel.Text = "Score: " + score.ToString();
            ScoreStatusLabel.BackColor = default(Color);
            actualClicks = 0;
            MyBottons.PushedButtons = new List<int>();
            MyBottons.NotUsedButtoms = new List<int>();


            buttons = new MyBottons[boardSize * boardSize];
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnCount = boardSize;
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();
            for (int i = 0; i < boardSize; i++)
            {
                for (int j = 0; j < boardSize; j++)
                {
                    buttons[i * boardSize + j] = new MyBottons(i * boardSize + j, round);
                    tableLayoutPanel1.Controls.Add(buttons[i * boardSize + j], i, j);
                    buttons[i * boardSize + j].Click += MyBottons_Click;
                    //MyBottons.NotUsedButtoms.Add(i * boardSize + j);              
                }
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1));
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1));
            }
            buttonStart.Text = "Start";
        }

        private void TrackBar1_ValueChanged(object sender, EventArgs e)
        {
            timer.Interval = trackBar1.Value;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (MyBottons.PushedButtons.Count > 0)
                buttons[MyBottons.PushedButtons[0]].HideButton();

            Random r = new Random();
            MyBottons.NotUsedButtoms = MyBottons.NotUsedButtoms.OrderBy(x => r.Next()).Select(x => x).ToList();

            while (MyBottons.PushedButtons.Count < activeButtons)
            {
                buttons[MyBottons.NotUsedButtoms[0]].ShowButton();
            }
            timer.Start();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                isStart = true;
                StartGame();// boardSize, activeButtons, clicksToEnd);
                buttonStart.Text = "Pause";
            }
            else
            {
                isStart = false;
                PauseGame();
                buttonStart.Text = "Start";
            }
        }

        private void StartGame()
        {
            Random r = new Random();
            MyBottons.NotUsedButtoms = MyBottons.NotUsedButtoms.OrderBy(x => r.Next()).Select(x => x).ToList();
            while (MyBottons.PushedButtons.Count < activeButtons)
            {
                buttons[MyBottons.NotUsedButtoms[0]].ShowButton();
            }
            timer.Start();
        }

        private void PauseGame()
        {
            timer.Stop();
        }

        private void EndOfGame()
        {
            congForm = new CongratulationsForm(this, score);
            congForm.ShowDialog(this);
            ListViewItem lvi = new ListViewItem(new[] { score.ToString(), gamerName });
            ScorelistView.Items.Add(lvi);
            // this.ScorelistView.ListViewItemSorter = new ListViewItemComparer(ScorelistView.Column);
            InitialNewGame();
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            modal = new Form2(this);
            modal.ShowDialog(this);
            if (modal.DialogResult == DialogResult.OK)
            {
                timer.Stop();
                InitialNewGame();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (System.IO.TextWriter tw = new System.IO.StreamWriter("score.txt"))
            {
                foreach (ListViewItem item in ScorelistView.Items)
                {
                    for (int a = 0; a < 2; a++) //the 3 = number of subitems in a listview 
                    {
                        tw.WriteLine(item.SubItems[a].Text);
                    }
                    //tw.WriteLine();
                }
            }
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ScorelistView.Items.Clear(); 
        }
    }
}
