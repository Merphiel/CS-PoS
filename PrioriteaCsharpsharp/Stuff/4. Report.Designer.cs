namespace PrioriteaCsharpsharp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.saleslbl = new System.Windows.Forms.Label();
            this.reportbtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.incomingbtn = new System.Windows.Forms.Button();
            this.Orders = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Useless1 = new System.Windows.Forms.Label();
            this.frompicker = new System.Windows.Forms.DateTimePicker();
            this.topicker = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.exitbtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.Orders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Panel1.Controls.Add(this.PictureBox1);
            this.Panel1.Controls.Add(this.lblDate);
            this.Panel1.Controls.Add(this.lblTime);
            this.Panel1.Controls.Add(this.Label1);
            this.Panel1.Location = new System.Drawing.Point(1, -2);
            this.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(806, 83);
            this.Panel1.TabIndex = 51;
            // 
            // PictureBox1
            // 
            this.PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox1.Image = global::PrioriteaCsharpsharp.Properties.Resources._53d20278_70dd_4d21_95e8_647751d62c3b;
            this.PictureBox1.Location = new System.Drawing.Point(6, 3);
            this.PictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(83, 79);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureBox1.TabIndex = 2;
            this.PictureBox1.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.lblDate.ForeColor = System.Drawing.Color.White;
            this.lblDate.Location = new System.Drawing.Point(706, 23);
            this.lblDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(88, 17);
            this.lblDate.TabIndex = 4;
            this.lblDate.Text = "mm/dd/yyyy";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.BackColor = System.Drawing.Color.Transparent;
            this.lblTime.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.Color.White;
            this.lblTime.Location = new System.Drawing.Point(682, 2);
            this.lblTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(114, 24);
            this.lblTime.TabIndex = 3;
            this.lblTime.Text = "hh:mm:ss";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(105, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(400, 24);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Prioritea Point-Of-Sale System";
            // 
            // saleslbl
            // 
            this.saleslbl.AutoSize = true;
            this.saleslbl.BackColor = System.Drawing.Color.Transparent;
            this.saleslbl.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleslbl.ForeColor = System.Drawing.Color.Black;
            this.saleslbl.Location = new System.Drawing.Point(20, 58);
            this.saleslbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.saleslbl.Name = "saleslbl";
            this.saleslbl.Size = new System.Drawing.Size(49, 24);
            this.saleslbl.TabIndex = 5;
            this.saleslbl.Text = "PhP";
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportbtn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.Location = new System.Drawing.Point(1, 216);
            this.reportbtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(93, 45);
            this.reportbtn.TabIndex = 50;
            this.reportbtn.Text = "Reports";
            this.reportbtn.UseVisualStyleBackColor = false;
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.White;
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderbtn.Location = new System.Drawing.Point(1, 161);
            this.orderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(93, 45);
            this.orderbtn.TabIndex = 49;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = false;
            this.orderbtn.Click += new System.EventHandler(this.orderbtn_Click);
            // 
            // incomingbtn
            // 
            this.incomingbtn.BackColor = System.Drawing.Color.White;
            this.incomingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingbtn.Location = new System.Drawing.Point(1, 105);
            this.incomingbtn.Margin = new System.Windows.Forms.Padding(2);
            this.incomingbtn.Name = "incomingbtn";
            this.incomingbtn.Size = new System.Drawing.Size(93, 45);
            this.incomingbtn.TabIndex = 48;
            this.incomingbtn.Text = "Incoming Purchases";
            this.incomingbtn.UseVisualStyleBackColor = false;
            this.incomingbtn.Click += new System.EventHandler(this.incomingbtn_Click);
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.White;
            this.Orders.Controls.Add(this.label2);
            this.Orders.Controls.Add(this.Useless1);
            this.Orders.Controls.Add(this.frompicker);
            this.Orders.Controls.Add(this.topicker);
            this.Orders.Controls.Add(this.dataGridView1);
            this.Orders.Controls.Add(this.GroupBox1);
            this.Orders.Controls.Add(this.exitbtn);
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.Location = new System.Drawing.Point(102, 84);
            this.Orders.Margin = new System.Windows.Forms.Padding(2);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(2);
            this.Orders.Size = new System.Drawing.Size(695, 363);
            this.Orders.TabIndex = 47;
            this.Orders.TabStop = false;
            this.Orders.Text = "Order";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(28, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "To:";
            // 
            // Useless1
            // 
            this.Useless1.AutoSize = true;
            this.Useless1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Useless1.Location = new System.Drawing.Point(28, 21);
            this.Useless1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Useless1.Name = "Useless1";
            this.Useless1.Size = new System.Drawing.Size(33, 13);
            this.Useless1.TabIndex = 58;
            this.Useless1.Text = "From:";
            // 
            // frompicker
            // 
            this.frompicker.Location = new System.Drawing.Point(21, 30);
            this.frompicker.Name = "frompicker";
            this.frompicker.Size = new System.Drawing.Size(150, 23);
            this.frompicker.TabIndex = 57;
            this.frompicker.Value = new System.DateTime(2022, 8, 12, 0, 0, 0, 0);
            this.frompicker.ValueChanged += new System.EventHandler(this.frompicker_ValueChanged);
            // 
            // topicker
            // 
            this.topicker.Location = new System.Drawing.Point(21, 67);
            this.topicker.Name = "topicker";
            this.topicker.Size = new System.Drawing.Size(150, 23);
            this.topicker.TabIndex = 56;
            this.topicker.Value = new System.DateTime(2022, 8, 12, 0, 0, 0, 0);
            this.topicker.ValueChanged += new System.EventHandler(this.topicker_ValueChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(175, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(511, 326);
            this.dataGridView1.TabIndex = 55;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.saleslbl);
            this.GroupBox1.Location = new System.Drawing.Point(21, 95);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(149, 130);
            this.GroupBox1.TabIndex = 52;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Total Sales";
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitbtn.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(8, 300);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(162, 50);
            this.exitbtn.TabIndex = 44;
            this.exitbtn.Text = "BACK";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.reportbtn);
            this.Controls.Add(this.orderbtn);
            this.Controls.Add(this.incomingbtn);
            this.Controls.Add(this.Orders);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIORITEA --- Reports";
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.Orders.ResumeLayout(false);
            this.Orders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button reportbtn;
        internal System.Windows.Forms.Button orderbtn;
        internal System.Windows.Forms.Button incomingbtn;
        internal System.Windows.Forms.GroupBox Orders;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button exitbtn;
        internal System.Windows.Forms.Label saleslbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label Useless1;
        public System.Windows.Forms.DateTimePicker frompicker;
        public System.Windows.Forms.DateTimePicker topicker;
        private System.Windows.Forms.Timer timer1;
    }
}