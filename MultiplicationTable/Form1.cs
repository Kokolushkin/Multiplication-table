using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiplicationTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const int N = 11;

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 101; i++)
            {
                if(i > 9)
                    selectNumberRows.Items.Add(i);
                selectSpecificNumber.Items.Add(i);
                selectCountMultiplier.Items.Add(i);
            }
            selectNumberRows.SelectedIndex = 0;
            selectSpecificNumber.SelectedIndex = 4;
            selectCountMultiplier.SelectedIndex = 9;
            string[] options = { "full", "even", "odd" };
            selectOptions.Items.AddRange(options);
            selectOptions.SelectedIndex = 0;
            SetMatrix(N);
        }

        private void PrintMatrix(int Row, int[,] matr, int opt)
        {
            resultWindow.Clear();
            int startCycle = 0;
            int stepCycle = 0;
            switch (opt)
            {
                case 0:
                    startCycle = 1;
                    stepCycle = 1;
                    break;
                case 1:
                    startCycle = 2;
                    stepCycle = 2;
                    break;
                case 2:
                    startCycle = 1;
                    stepCycle = 2;
                    break;
            }

            String mes = "";

            mes += " \t";
            for (int i = 1; i < N; i++)
                mes += Convert.ToString(matr[i, 0]) + "\t";
            mes += "\n";

            for (int i = startCycle; i < Row; i+=stepCycle)
             {
                for (int j = 0; j < N; j++)
                {
                    mes += Convert.ToString(matr[i, j]) + "\t";
                }
                mes += "\n";
             }

                resultWindow.Text = mes;
        }

        private void SetMatrix(int Row)
        {
            int[,] matr = new int[Row, N];

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == 0)
                    {
                        matr[i, j] = j;
                    }
                    if (j == 0)
                    {
                        matr[i, j] = i;
                    }
                    if (i != 0 && j != 0)
                    {
                        matr[i, j] = i * j;
                    }
                }
            }

            PrintMatrix(Row, matr, selectOptions.SelectedIndex);
        }

        private void SingleTable(int number, int mult)
        {
            string mes = "";
           for(int i = 1; i <= mult; i++)
            {
                int res = number * i;
                mes += number + "\t*\t" + i + "\t=\t" + res + "\n";
            }
            resultWindow.Clear();
            resultWindow.Text = mes;
        }

        private void ControlEnabled()
        {
            switch (fullTable.Checked)
            {
                case true:
                    selectSpecificNumber.Enabled = false;
                    selectCountMultiplier.Enabled = false;
                    selectNumberRows.Enabled = true;
                    selectOptions.Enabled = true;
                    break;
                case false:
                    selectNumberRows.Enabled = false;
                    selectOptions.Enabled = false;
                    selectSpecificNumber.Enabled = true;
                    selectCountMultiplier.Enabled = true;
                    break;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            switch (fullTable.Checked)
            {
                case true:
                    int Row = Convert.ToInt32(selectNumberRows.SelectedItem) + 1;
                    SetMatrix(Row);
                    break;
                case false:
                    int number = Convert.ToInt32(selectSpecificNumber.SelectedItem);
                    int mult = Convert.ToInt32(selectCountMultiplier.SelectedItem);
                    SingleTable(number, mult);
                    break;
            }
        }

        private void FullTable_CheckedChanged(object sender, EventArgs e)
        {
            ControlEnabled();
        }

        private void SingleTable_CheckedChanged(object sender, EventArgs e)
        {
            ControlEnabled();
        }
    }
}
