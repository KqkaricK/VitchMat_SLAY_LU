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
            L.Rows.Clear();
            U.Rows.Clear();
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
            dataGridView2.RowCount = dataGridView1.RowCount;
            dataGridView3.RowCount = dataGridView1.RowCount;
            L.RowCount = dataGridView1.RowCount;
            L.ColumnCount = dataGridView1.RowCount;
            U.RowCount = dataGridView1.RowCount;
            U.ColumnCount = dataGridView1.RowCount;
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

        /*Ниже куча проверок*/

        bool Chek()
        {
            if (t_raz.Text == "")
            {
                return false;
            }
            else if(Convert.ToInt32(t_raz.Text) < 2 || Convert.ToInt32(t_raz.Text) > 10)
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

        /*Куча проверок закончена*/

        private void darkButton2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++) //+0
            {
                dataGridView2.Rows[i].Cells[0].Value = 0;
                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    if (i < j)
                    {
                        L.Rows[i].Cells[j].Value = 0;
                    }
                    else if (i >= j)
                    {
                        U.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++)  //Вычисление L и U
            {
                for (int k = i; k < dataGridView1.RowCount; k++)
                {
                    double S = 0;
                    for (int j = 0; j < i; j++)
                    {
                        S += (Convert.ToDouble(L.Rows[i].Cells[j].Value.ToString()) * Convert.ToDouble(U.Rows[j].Cells[k].Value.ToString()));
                    }
                    U.Rows[i].Cells[k].Value = Slay(i, k) - S;
                }
                for (int k = i; k < dataGridView1.RowCount; k++)
                {
                    if (i == k)
                    {
                        L.Rows[i].Cells[i].Value = 1;
                    }
                    else
                    {
                        double S = 0;
                        for (int j = 0; j < i; j++)
                        {
                            S += (Convert.ToDouble(L.Rows[k].Cells[j].Value.ToString()) * Convert.ToDouble(U.Rows[j].Cells[i].Value.ToString()));
                        }
                        L.Rows[k].Cells[i].Value = (Slay(k, i) - S) / Convert.ToDouble(U.Rows[i].Cells[i].Value.ToString());
                    }
                }
            }
            for (int i = 0; i < dataGridView1.RowCount; i++) // решение Ly = B
            {
                double S = 0;
                for (int k = 0; k < i; k++)
                {
                    S += Convert.ToDouble(L.Rows[i].Cells[k].Value.ToString()) * Convert.ToDouble(dataGridView3.Rows[k].Cells[0].Value.ToString());
                }
                dataGridView3.Rows[i].Cells[0].Value = Convert.ToDouble(dataGridView1.Rows[i].Cells[dataGridView1.ColumnCount - 1].Value.ToString()) - S;
            }
            for (int i = dataGridView1.RowCount - 1; i >= 0; i--) // решение Ux = y
            {
                double S = 0;
                for (int k = dataGridView1.RowCount - 1; k > 0; k--)
                {
                    S += Convert.ToDouble(U.Rows[i].Cells[k].Value.ToString()) * Convert.ToDouble(dataGridView2.Rows[k].Cells[0].Value.ToString());
                }
                dataGridView2.Rows[i].Cells[0].Value = (Convert.ToDouble(dataGridView3.Rows[i].Cells[0].Value.ToString()) - S) / Convert.ToDouble(U.Rows[i].Cells[i].Value.ToString());
            }
        }
    }
}
