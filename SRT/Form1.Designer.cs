namespace SRT
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlClients = new System.Windows.Forms.Panel();
            this.dataGVClients = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnlServers = new System.Windows.Forms.Panel();
            this.dataGVServers = new System.Windows.Forms.DataGridView();
            this.pnlQueue = new System.Windows.Forms.Panel();
            this.dataGVQueue = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.pnlClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVClients)).BeginInit();
            this.panel2.SuspendLayout();
            this.pnlServers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVServers)).BeginInit();
            this.pnlQueue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnlClients);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 429);
            this.panel1.TabIndex = 0;
            // 
            // pnlClients
            // 
            this.pnlClients.Controls.Add(this.dataGVClients);
            this.pnlClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlClients.Location = new System.Drawing.Point(0, 182);
            this.pnlClients.Name = "pnlClients";
            this.pnlClients.Size = new System.Drawing.Size(643, 247);
            this.pnlClients.TabIndex = 5;
            // 
            // dataGVClients
            // 
            this.dataGVClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGVClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVClients.Location = new System.Drawing.Point(0, 0);
            this.dataGVClients.Name = "dataGVClients";
            this.dataGVClients.Size = new System.Drawing.Size(643, 247);
            this.dataGVClients.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pnlServers);
            this.panel2.Controls.Add(this.pnlQueue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(643, 182);
            this.panel2.TabIndex = 6;
            // 
            // pnlServers
            // 
            this.pnlServers.Controls.Add(this.dataGVServers);
            this.pnlServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlServers.Location = new System.Drawing.Point(0, 0);
            this.pnlServers.Name = "pnlServers";
            this.pnlServers.Size = new System.Drawing.Size(390, 182);
            this.pnlServers.TabIndex = 5;
            // 
            // dataGVServers
            // 
            this.dataGVServers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVServers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGVServers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVServers.Location = new System.Drawing.Point(0, 0);
            this.dataGVServers.Name = "dataGVServers";
            this.dataGVServers.Size = new System.Drawing.Size(390, 182);
            this.dataGVServers.TabIndex = 4;
            // 
            // pnlQueue
            // 
            this.pnlQueue.Controls.Add(this.dataGVQueue);
            this.pnlQueue.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlQueue.Location = new System.Drawing.Point(390, 0);
            this.pnlQueue.Name = "pnlQueue";
            this.pnlQueue.Size = new System.Drawing.Size(253, 182);
            this.pnlQueue.TabIndex = 6;
            // 
            // dataGVQueue
            // 
            this.dataGVQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVQueue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10});
            this.dataGVQueue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVQueue.Location = new System.Drawing.Point(0, 0);
            this.dataGVQueue.Name = "dataGVQueue";
            this.dataGVQueue.Size = new System.Drawing.Size(253, 182);
            this.dataGVQueue.TabIndex = 3;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Клиент";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Число";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 150;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Клиент0";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Клиент1";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Клиент2";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Клиент3";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 120;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Клиент4";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Сервер0";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 115;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Сервер1";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 115;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Сервер2";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 115;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 429);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(659, 468);
            this.Name = "Form1";
            this.Text = "Модель Клиент-Сервер";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.pnlClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVClients)).EndInit();
            this.panel2.ResumeLayout(false);
            this.pnlServers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVServers)).EndInit();
            this.pnlQueue.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVQueue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlClients;
        private System.Windows.Forms.DataGridView dataGVClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnlServers;
        private System.Windows.Forms.DataGridView dataGVServers;
        private System.Windows.Forms.Panel pnlQueue;
        private System.Windows.Forms.DataGridView dataGVQueue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}

