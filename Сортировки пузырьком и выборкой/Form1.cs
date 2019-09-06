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
    public partial class Form1 : Form
    {
        GraphView gv;
        List<Tuple<int, double, decimal[]>[]> dAlgorithms = new List<Tuple<int, double, decimal[]>[]>();
        public Form1()
        {
            InitializeComponent();
            /**
             *  Init table (REFINE! THINK UP ALGORITHM)
             */
            dataGridView1.RowCount = 36;
            //1 method
            dataGridView1[0, 0].Value = "Пузырьковая";
            dataGridView1[1, 0].Value = "Случайные";
            dataGridView1[1, 3].Value = "Послед. возраст.";
            dataGridView1[1, 6].Value = "Послед. убыв.";
            //2 method
            dataGridView1[0, 9].Value = "Выборкой";
            dataGridView1[1, 9].Value = "Случайные";
            dataGridView1[1, 12].Value = "Послед. возраст.";
            dataGridView1[1, 15].Value = "Послед. убыв.";
            //3 method
            dataGridView1[0, 18].Value = "Быстрая";
            dataGridView1[1, 18].Value = "Случайные";
            dataGridView1[1, 21].Value = "Послед. возраст.";
            dataGridView1[1, 24].Value = "Послед. убыв.";
            //4 method
            dataGridView1[0, 27].Value = "Выборкой";
            dataGridView1[1, 27].Value = "Случайные";
            dataGridView1[1, 30].Value = "Послед. возраст.";
            dataGridView1[1, 33].Value = "Послед. убыв.";

        }

        void ClearTable()
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[2, i].Value = string.Empty;
                dataGridView1[3, i].Value = string.Empty;
                dataGridView1[4, i].Value = string.Empty;
            }
        }

        public void RunAlgorithm(MethodsSort methodsSort, ref int iterator, Algorithms alg)
        {
            SomeSorts sort;
            //DateTime first, second;
            MethodsSequience ms = new MethodsSequience((int)startRange.Value, (int)endRange.Value,
                                                       (int)startPosition.Value, methodsSort);
            Tuple<int, double, decimal[]>[] tempAlg = new Tuple<int, double, decimal[]>[3];
            int[] rangeIteration = { 20, 1000, 5000 };
            for(int i = 0; i < rangeIteration.Length; i++)
            {
                sort = new SomeSorts(rangeIteration[i], ms);

                switch (alg)
                {
                    case Algorithms.Bubble:
                        tempAlg[i] = sort.SortBubble(); break;
                    case Algorithms.Choice:
                        tempAlg[i] = sort.SortChoice(); break;
                    case Algorithms.Quick:
                        tempAlg[i] = sort.QuickSort(); break;
                    case Algorithms.Merge:
                        tempAlg[i] = sort.MergeSort(); break;
                }
                    int crutch = iterator;

                dataGridView1.Invoke(new Action(() =>
                {
                    dataGridView1[2, crutch].Value = $"{rangeIteration[i]}: {tempAlg[i].Item2:0.###} ms";
                    dataGridView1[3, crutch].Value = tempAlg[i].Item3[0];
                    dataGridView1[4, crutch].Value = tempAlg[i].Item3[1];
                }));
                ++iterator;
            }
            dAlgorithms.Add(tempAlg);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            int tableCount = 0;
            button1.Enabled = false;
            button3.Enabled = false;
            ClearTable();
            await Task.Factory.StartNew(() => {
                foreach (Algorithms elAlg in Enum.GetValues(typeof(Algorithms)))
                    foreach (MethodsSort elMethodSort in Enum.GetValues(typeof(MethodsSort)))
                        RunAlgorithm(elMethodSort, ref tableCount, elAlg);
            });
            gv = new GraphView(dAlgorithms);
            button3.Enabled = true;
            button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            gv.Show();
        }
    }
}
