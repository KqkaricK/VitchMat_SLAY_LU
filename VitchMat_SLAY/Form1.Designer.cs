
namespace VitchMat_SLAY
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.t_raz = new DarkUI.Controls.DarkTextBox();
            this.darkLabel1 = new DarkUI.Controls.DarkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.darkButton1 = new DarkUI.Controls.DarkButton();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.darkLabel2 = new DarkUI.Controls.DarkLabel();
            this.darkButton2 = new DarkUI.Controls.DarkButton();
            this.L = new System.Windows.Forms.DataGridView();
            this.U = new System.Windows.Forms.DataGridView();
            this.darkLabel3 = new DarkUI.Controls.DarkLabel();
            this.darkLabel4 = new DarkUI.Controls.DarkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.U)).BeginInit();
            this.SuspendLayout();
            // 
            // t_raz
            // 
            this.t_raz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(73)))), ((int)(((byte)(74)))));
            this.t_raz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.t_raz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.t_raz.Location = new System.Drawing.Point(96, 16);
            this.t_raz.Name = "t_raz";
            this.t_raz.Size = new System.Drawing.Size(51, 20);
            this.t_raz.TabIndex = 0;
            this.t_raz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_raz_KeyPress);
            // 
            // darkLabel1
            // 
            this.darkLabel1.AutoSize = true;
            this.darkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel1.Location = new System.Drawing.Point(12, 18);
            this.darkLabel1.Name = "darkLabel1";
            this.darkLabel1.Size = new System.Drawing.Size(78, 13);
            this.darkLabel1.TabIndex = 1;
            this.darkLabel1.Text = "Размерность:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Location = new System.Drawing.Point(11, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(474, 203);
            this.dataGridView1.TabIndex = 49;
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            this.dataGridView1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView1_KeyPress);
            // 
            // darkButton1
            // 
            this.darkButton1.Location = new System.Drawing.Point(391, 13);
            this.darkButton1.Name = "darkButton1";
            this.darkButton1.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton1.Size = new System.Drawing.Size(94, 23);
            this.darkButton1.TabIndex = 50;
            this.darkButton1.Text = "Создать СЛАУ";
            this.darkButton1.Click += new System.EventHandler(this.darkButton1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.ColumnHeadersVisible = false;
            this.dataGridView2.Location = new System.Drawing.Point(503, 41);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(73, 203);
            this.dataGridView2.TabIndex = 51;
            // 
            // darkLabel2
            // 
            this.darkLabel2.AutoSize = true;
            this.darkLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel2.Location = new System.Drawing.Point(500, 18);
            this.darkLabel2.Name = "darkLabel2";
            this.darkLabel2.Size = new System.Drawing.Size(41, 13);
            this.darkLabel2.TabIndex = 54;
            this.darkLabel2.Text = "Корни:";
            // 
            // darkButton2
            // 
            this.darkButton2.Location = new System.Drawing.Point(503, 255);
            this.darkButton2.Name = "darkButton2";
            this.darkButton2.Padding = new System.Windows.Forms.Padding(5);
            this.darkButton2.Size = new System.Drawing.Size(73, 23);
            this.darkButton2.TabIndex = 55;
            this.darkButton2.Text = "Метод LU";
            this.darkButton2.Click += new System.EventHandler(this.darkButton2_Click_1);
            // 
            // L
            // 
            this.L.AllowUserToAddRows = false;
            this.L.AllowUserToDeleteRows = false;
            this.L.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.L.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.L.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.L.ColumnHeadersVisible = false;
            this.L.Location = new System.Drawing.Point(33, 255);
            this.L.Margin = new System.Windows.Forms.Padding(2);
            this.L.Name = "L";
            this.L.RowHeadersVisible = false;
            this.L.RowHeadersWidth = 51;
            this.L.RowTemplate.Height = 24;
            this.L.Size = new System.Drawing.Size(203, 203);
            this.L.TabIndex = 56;
            // 
            // U
            // 
            this.U.AllowUserToAddRows = false;
            this.U.AllowUserToDeleteRows = false;
            this.U.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.U.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.U.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.U.ColumnHeadersVisible = false;
            this.U.Location = new System.Drawing.Point(282, 255);
            this.U.Margin = new System.Windows.Forms.Padding(2);
            this.U.Name = "U";
            this.U.RowHeadersVisible = false;
            this.U.RowHeadersWidth = 51;
            this.U.RowTemplate.Height = 24;
            this.U.Size = new System.Drawing.Size(203, 203);
            this.U.TabIndex = 57;
            // 
            // darkLabel3
            // 
            this.darkLabel3.AutoSize = true;
            this.darkLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel3.Location = new System.Drawing.Point(12, 260);
            this.darkLabel3.Name = "darkLabel3";
            this.darkLabel3.Size = new System.Drawing.Size(16, 13);
            this.darkLabel3.TabIndex = 58;
            this.darkLabel3.Text = "L:";
            // 
            // darkLabel4
            // 
            this.darkLabel4.AutoSize = true;
            this.darkLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.darkLabel4.Location = new System.Drawing.Point(261, 260);
            this.darkLabel4.Name = "darkLabel4";
            this.darkLabel4.Size = new System.Drawing.Size(18, 13);
            this.darkLabel4.TabIndex = 59;
            this.darkLabel4.Text = "U:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 469);
            this.Controls.Add(this.darkLabel4);
            this.Controls.Add(this.darkLabel3);
            this.Controls.Add(this.U);
            this.Controls.Add(this.L);
            this.Controls.Add(this.darkButton2);
            this.Controls.Add(this.darkLabel2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.darkButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.darkLabel1);
            this.Controls.Add(this.t_raz);
            this.Name = "Form1";
            this.Text = "Решение СЛАУ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.L)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.U)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DarkUI.Controls.DarkTextBox t_raz;
        private DarkUI.Controls.DarkLabel darkLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DarkUI.Controls.DarkButton darkButton1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DarkUI.Controls.DarkLabel darkLabel2;
        private DarkUI.Controls.DarkButton darkButton2;
        private System.Windows.Forms.DataGridView L;
        private System.Windows.Forms.DataGridView U;
        private DarkUI.Controls.DarkLabel darkLabel3;
        private DarkUI.Controls.DarkLabel darkLabel4;
    }
}

