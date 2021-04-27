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
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView1.RowCount = Convert.ToInt32(t_raz.Text);
            dataGridView1.ColumnCount = Convert.ToInt32(t_raz.Text) + 1;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Style.BackColor = Color.LightGreen;
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = 0;
                }
            }
            dataGridView2.RowCount = Convert.ToInt32(t_raz.Text);
        }
        double Slay(int i, int j)
        {
            return Convert.ToDouble(dataGridView1.Rows[i].Cells[j].Value.ToString());
        }
        private void darkButton1_Click(object sender, EventArgs e)
        {
            if (Chek() == false)
            {
                MessageBox.Show("Размерность должна быть больше 1 и меньше 11");
            }
            else
            {
                Razmer();
            }
        }
        private void darkButton2_Click(object sender, EventArgs e) //гаусса
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
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--) //Обратный ход
            {
                double s = 0;
                for (int j = i + 1; j < dataGridView1.RowCount; j++)
                {
                    s += Convert.ToDouble(dataGridView2.Rows[j].Cells[0].Value.ToString()) * Slay(i, j);
                }
                dataGridView2.Rows[i].Cells[0].Value = (Slay(i, dataGridView1.ColumnCount - 1) - s) / Slay(i, i);
            }
        }

        /*Ниже куча проверок*/

        bool Chek()
        {
            if (t_raz.Text == "0" || t_raz.Text == "1" || Convert.ToInt32(t_raz.Text) > 10)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void t_raz_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && e.KeyChar != '-' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox tb = (TextBox)e.Control;
            tb.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
        }

        private void darkButton3_Click(object sender, EventArgs e)  //жордана-гаусса
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
            for (int k = dataGridView1.RowCount - 1; k >= 0; k--) 
            {
                for (int i = dataGridView1.RowCount - 2; i >= 0; i--)
                {
                    if (i < k)
                    {
                        dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value = Slay(i, dataGridView1.ColumnCount - 1) - (Slay(i, k) * Slay(k, dataGridView1.ColumnCount - 1) / Slay(k, k));
                    }
                }
            }
            for (int j = 0; j < dataGridView1.RowCount; j++) //Добавляем 0
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                { 
                    if (i != j)
                    {
                        dataGridView1.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--) //Обратный ход
            {
                double s = 0;
                for (int j = i + 1; j < dataGridView1.RowCount; j++)
                {
                    s += Convert.ToDouble(dataGridView2.Rows[j].Cells[0].Value.ToString()) * Slay(i, j);
                }
                dataGridView2.Rows[i].Cells[0].Value = (Slay(i, dataGridView1.ColumnCount - 1) - s) / Slay(i, i);
            }
        }
    }
}
