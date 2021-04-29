﻿using System;
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
            dataGridView2.RowCount = dataGridView1.RowCount;
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

        /*Куча проверок закончена*/

        private void darkButton2_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++) //+0
            {
                for (int j = 0; j < dataGridView1.ColumnCount - 1; j++)
                {
                    U.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                    if (i < j)
                    {
                        L.Rows[i].Cells[j].Value = 0;
                    }
                }
            }
        }
    }
}
