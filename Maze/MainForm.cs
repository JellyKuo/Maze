using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Maze
{
    public partial class MainForm : Form
    {
        Button[] bt = new Button[100];
        Queue<int> q = new Queue<int>();
        Stack<int> s = new Stack<int>();
        Stack<int> p = new Stack<int>();
        int[] pre = new int[100];
        int step = 0;
        int goal = 100;

        public MainForm()
        {
            InitializeComponent();
            Reset();
        }

        #region 開始, 生成, 重設

        private void Start(int pos, string Algorithm)
        {
            switch (Algorithm)
            {
                case "BFS":
                    Console.WriteLine("BFS algorithm start with pos = " + pos.ToString());
                    q.Enqueue(pos);
                    p.Push(pos);
                    BFS.Enabled = true;
                    break;
                case "DFS":
                    Console.WriteLine("DFS algorithm start with pos = " + pos.ToString());
                    s.Push(pos);
                    p.Push(pos);
                    DFS.Enabled = true;
                    break;
                case "Astar":
                    Console.WriteLine("Astar algorithm start with pos = " + pos.ToString());
                    break;
                default:
                    throw new Exception("我不知道" + Algorithm + "是甚麼");
            }
        }

        private void GenerateGrid()
        {
            int pos_x = 0;
            int pos_y = 0;

            for (int a = 0; a < 100; a++)
            {
                bt[a] = new Button();
                bt[a].Name = a.ToString();
                bt[a].Location = new Point(pos_x, pos_y);
                bt[a].Size = new Size(30, 30);
                bt[a].BackColor = Color.AliceBlue;
                pos_x += 30;

                if (a % 10 == 9)
                {
                    pos_x = 0;
                    pos_y += 30;
                }
                bt[a].Click += new EventHandler(ButtonClick);
                gridPanel.Controls.Add(bt[a]);
            }
        }

        private void Reset()
        {
            BFS.Enabled = false;
            DFS.Enabled = false;
            Astar.Enabled = false;
            gridPanel.Controls.Clear();
            GenerateGrid();
            for (int a = 0; a < 100; a++)
                pre[a] = -1;
            BFSradioButton.Checked = true;
            endRadioButton.Checked = true;

        }

        private void ButtonClick(object sender, EventArgs e)
        {
            string Algorithm = "";
            Button button = (Button)sender;
            int pos = Convert.ToInt32(button.Name);
            bt[pos].Enabled = false;

            if (obsticleRadioButton.Checked)
                bt[pos].BackColor = Color.Black;
            if (BFSradioButton.Checked)
                Algorithm = "BFS";
            if (DFSradioButtion.Checked)
                Algorithm = "DFS";
            if (initRadioButton.Checked)
                Start(pos, Algorithm);

            if (endRadioButton.Checked)
            {
                for (int a = 0; a < 100; a++)
                {
                    if (bt[a].Text == "G")
                    {
                        bt[a].BackColor = Color.AliceBlue;
                        bt[a].Enabled = true;
                        bt[a].Text = "";
                    }
                }
                goal = pos;
                bt[pos].BackColor = Color.Yellow;
                bt[pos].Text = "G";
                bt[pos].Enabled = true;
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        #endregion

        #region Timer
        private void BFS_Tick(object sender, EventArgs e)
        {
            if (q.Count() > 0)
            {
                int p = q.Dequeue();
                bt[p].BackColor = Color.Cyan;
                bt[p].Enabled = false;

                int x = p % 10;
                int y = p / 10;

                if ((y - 1) >= 0 && bt[p - 10].Enabled && !q.Contains(p - 10))  //Right
                {
                    q.Enqueue(p - 10);
                    pre[p - 10] = p;
                }
                if ((y + 1) <= 9 && bt[p + 10].Enabled && !q.Contains(p + 10))  //Up
                {
                    q.Enqueue(p + 10);
                    pre[p + 10] = p;
                }
                if ((x - 1) >= 0 && bt[p - 1].Enabled && !q.Contains(p - 1))  //Left
                {
                    q.Enqueue(p - 1);
                    pre[p - 1] = p;
                }
                if ((x + 1) <= 9 && bt[p + 1].Enabled && !q.Contains(p + 1))  //Down
                {
                    q.Enqueue(p + 1);
                    pre[p + 1] = p;
                }

                if (!bt[goal].Enabled)
                {
                    BFS.Enabled = false;
                    MessageBox.Show("BFS在第" + step.ToString() + "步找到終點");
                    path(goal);
                }
                step++;
            }
        }

        private void DFS_Tick(object sender, EventArgs e)
        {
            if (s.Count() > 0)
            {
                int p = s.Pop();
                bt[p].BackColor = Color.Cyan;
                bt[p].Enabled = false;

                int x = p % 10;
                int y = p / 10;

                if ((x + 1) <= 9 && bt[p + 1].Enabled)  //Right
                {
                    s.Push(p + 1);
                    pre[p + 1] = p;
                }
                if ((y - 1) >= 0 && bt[p - 10].Enabled)  //Up
                {
                    s.Push(p - 10);
                    pre[p - 10] = p;
                }
                if ((x - 1) >= 0 && bt[p - 1].Enabled)  //Left
                {
                    s.Push(p - 1);
                    pre[p - 1] = p;
                }
                if ((y + 1) <= 9 && bt[p + 10].Enabled)  //Down
                {
                    s.Push(p + 10);
                    pre[p + 10] = p;
                }

                if (!bt[goal].Enabled)
                {
                    DFS.Enabled = false;
                    MessageBox.Show("DFS在第" + step.ToString() + "步找到終點");
                    path(goal);
                }
                step++;
            }
        }

        #endregion
        private void path(int p)
        {
            if (p != -1 && goal != 100)
            {
                bt[p].BackColor = Color.Pink;
                p = pre[p];
                path(p);
            }
        }

    }
}
