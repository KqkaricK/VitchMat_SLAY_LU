using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DarkUI.Forms;

namespace VitchMat_SLAY
{
    public partial class Form1 : DarkForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        void Razmer()
        {
            dataGridView1.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(t_raz.Text) + 1;
            dataGridView2.RowCount = Convert.ToInt32(t_raz.Text);
        }
        double Slay(int i, int j)
        {
            return Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
        }
        private void darkButton1_Click(object sender, EventArgs e)
        {
            Razmer();
        }
        private void darkButton2_Click(object sender, EventArgs e)
        {
            for (int k = 0; k < dataGridView1.RowCount; k++)  //Приводим к ступ. виду
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView1.ColumnCount; j++)
                    {
                        if ((i > k) && (j > k))
                        {
                            dataGridView1.Rows[i].Cells[j].Value = Slay(i, j) - (Slay(i, k) * Slay(k, j) / Slay(k, k));
                        }
                    }
                }
            }
            for (int j = 0; j < dataGridView1.RowCount; j++) //Добавляем 0
            {
                for (int i = 1 + j; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }
            dataGridView2.Rows[dataGridView2.RowCount - 1].Cells[0].Value = Slay(dataGridView1.RowCount - 1, dataGridView1.ColumnCount - 1) / Slay(dataGridView1.RowCount - 1, dataGridView1.ColumnCount - 2);
            
        }
    }
}
