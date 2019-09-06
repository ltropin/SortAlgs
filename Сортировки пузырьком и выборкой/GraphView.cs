using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Сортировки_пузырьком_и_выборкой
{
    public partial class GraphView : Form
    {
        private List<Tuple<int, double, decimal[]>[]> dAlgorithms = new List<Tuple<int, double, decimal[]>[]>();
        public GraphView()
        {
            InitializeComponent();
        }
        public GraphView(List<Tuple<int, double, decimal[]>[]> dAlgorithms)
        {
            InitializeComponent();
            this.dAlgorithms.Clear();
            this.dAlgorithms.AddRange(dAlgorithms.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tuple<int, double, decimal[]>[] tempAlgorithm = new Tuple<int, double, decimal[]>[3];
            if (rBubble.Checked)
            {
                if (rRandom.Checked) Array.Copy(dAlgorithms[0], tempAlgorithm, dAlgorithms[0].Length);
                else if (rIncrease.Checked) Array.Copy(dAlgorithms[1], tempAlgorithm, dAlgorithms[1].Length);
                else if (rDecrease.Checked) Array.Copy(dAlgorithms[2], tempAlgorithm, dAlgorithms[2].Length);
            }
            else if(rChoice.Checked)
            {
                if (rRandom.Checked) Array.Copy(dAlgorithms[3], tempAlgorithm, dAlgorithms[3].Length);
                else if (rIncrease.Checked) Array.Copy(dAlgorithms[4], tempAlgorithm, dAlgorithms[4].Length);
                else if (rDecrease.Checked) Array.Copy(dAlgorithms[5], tempAlgorithm, dAlgorithms[5].Length);
            }
            else if (rQuick.Checked)
            {
                if (rRandom.Checked) Array.Copy(dAlgorithms[6], tempAlgorithm, dAlgorithms[6].Length);
                else if (rIncrease.Checked) Array.Copy(dAlgorithms[7], tempAlgorithm, dAlgorithms[7].Length);
                else if (rDecrease.Checked) Array.Copy(dAlgorithms[8], tempAlgorithm, dAlgorithms[8].Length);
            }
            else if (rMerge.Checked)
            {
                if (rRandom.Checked) Array.Copy(dAlgorithms[9], tempAlgorithm, dAlgorithms[9].Length);
                else if (rIncrease.Checked) Array.Copy(dAlgorithms[10], tempAlgorithm, dAlgorithms[10].Length);
                else if (rDecrease.Checked) Array.Copy(dAlgorithms[11], tempAlgorithm, dAlgorithms[11].Length);
            }

            chart1.Series[0].Points.Clear();

            for (int i = 0; i < tempAlgorithm.Length; i++)
                chart1.Series[0].Points.AddXY(tempAlgorithm[i].Item1, tempAlgorithm[i].Item2);
        }

        private void GraphView_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}
