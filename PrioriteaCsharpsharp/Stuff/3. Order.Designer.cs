namespace PrioriteaCsharpsharp.Stuff
{
    partial class Order
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
            this.Orders = new System.Windows.Forms.GroupBox();
            this.Button10 = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.totaltxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.reportbtn = new System.Windows.Forms.Button();
            this.orderbtn = new System.Windows.Forms.Button();
            this.incomingbtn = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Orders.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Orders
            // 
            this.Orders.BackColor = System.Drawing.Color.White;
            this.Orders.Controls.Add(this.Button10);
            this.Orders.Controls.Add(this.exitbtn);
            this.Orders.Controls.Add(this.Button6);
            this.Orders.Controls.Add(this.Button5);
            this.Orders.Controls.Add(this.GroupBox1);
            this.Orders.Controls.Add(this.dataGridView1);
            this.Orders.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Orders.Location = new System.Drawing.Point(102, 84);
            this.Orders.Margin = new System.Windows.Forms.Padding(2);
            this.Orders.Name = "Orders";
            this.Orders.Padding = new System.Windows.Forms.Padding(2);
            this.Orders.Size = new System.Drawing.Size(695, 363);
            this.Orders.TabIndex = 31;
            this.Orders.TabStop = false;
            this.Orders.Text = "Order";
            // 
            // Button10
            // 
            this.Button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button10.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.Button10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button10.Location = new System.Drawing.Point(374, 300);
            this.Button10.Margin = new System.Windows.Forms.Padding(2);
            this.Button10.Name = "Button10";
            this.Button10.Size = new System.Drawing.Size(158, 50);
            this.Button10.TabIndex = 8;
            this.Button10.Text = "Print Receipt \r\nand Save";
            this.Button10.UseVisualStyleBackColor = false;
            this.Button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.exitbtn.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Location = new System.Drawing.Point(31, 300);
            this.exitbtn.Margin = new System.Windows.Forms.Padding(2);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(175, 50);
            this.exitbtn.TabIndex = 44;
            this.exitbtn.Text = "BACK";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // Button6
            // 
            this.Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.Button6.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.Button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button6.Location = new System.Drawing.Point(574, 305);
            this.Button6.Margin = new System.Windows.Forms.Padding(2);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(93, 50);
            this.Button6.TabIndex = 4;
            this.Button6.Text = "Clear";
            this.Button6.UseVisualStyleBackColor = false;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Button5.Font = new System.Drawing.Font("Courier New", 10.2F);
            this.Button5.Location = new System.Drawing.Point(31, 238);
            this.Button5.Margin = new System.Windows.Forms.Padding(2);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(175, 50);
            this.Button5.TabIndex = 3;
            this.Button5.Text = "Delete Latest";
            this.Button5.UseVisualStyleBackColor = false;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.totaltxt);
            this.GroupBox1.Location = new System.Drawing.Point(215, 246);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.GroupBox1.Size = new System.Drawing.Size(152, 104);
            this.GroupBox1.TabIndex = 2;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Total";
            // 
            // totaltxt
            // 
            this.totaltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltxt.Location = new System.Drawing.Point(16, 38);
            this.totaltxt.Margin = new System.Windows.Forms.Padding(2);
            this.totaltxt.Name = "totaltxt";
            this.totaltxt.Size = new System.Drawing.Size(123, 37);
            this.totaltxt.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 21);
            this.dataGridView1.MaximumSize = new System.Drawing.Size(686, 212);
            this.dataGridView1.MinimumSize = new System.Drawing.Size(686, 212);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(686, 212);
            this.dataGridView1.TabIndex = 9;
            // 
            // reportbtn
            // 
            this.reportbtn.BackColor = System.Drawing.Color.White;
            this.reportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportbtn.Location = new System.Drawing.Point(1, 216);
            this.reportbtn.Margin = new System.Windows.Forms.Padding(2);
            this.reportbtn.Name = "reportbtn";
            this.reportbtn.Size = new System.Drawing.Size(93, 45);
            this.reportbtn.TabIndex = 45;
            this.reportbtn.Text = "Reports";
            this.reportbtn.UseVisualStyleBackColor = false;
            this.reportbtn.Click += new System.EventHandler(this.reportbtn_Click);
            // 
            // orderbtn
            // 
            this.orderbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.orderbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderbtn.Location = new System.Drawing.Point(1, 161);
            this.orderbtn.Margin = new System.Windows.Forms.Padding(2);
            this.orderbtn.Name = "orderbtn";
            this.orderbtn.Size = new System.Drawing.Size(93, 45);
            this.orderbtn.TabIndex = 44;
            this.orderbtn.Text = "Order";
            this.orderbtn.UseVisualStyleBackColor = false;
            // 
            // incomingbtn
            // 
            this.incomingbtn.BackColor = System.Drawing.Color.White;
            this.incomingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incomingbtn.Location = new System.Drawing.Point(1, 105);
            this.incomingbtn.Margin = new System.Windows.Forms.Padding(2);
            this.incomingbtn.Name = "incomingbtn";
            this.incomingbtn.Size = new System.Drawing.Size(93, 45);
            this.incomingbtn.TabIndex = 43;
            this.incomingbtn.Text = "Incoming Purchases";
            this.incomingbtn.UseVisualStyleBackColor = false;
            this.incomingbtn.Click += new System.EventHandler(this.incomingbtn_Click);
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
            this.Panel1.TabIndex = 46;
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
            this.lblTime.Click += new System.EventHandler(this.lblTime_Click);
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
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Order
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
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Order";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PRIORITEA -- Order";
            this.Load += new System.EventHandler(this.Order_Load);
            this.Orders.ResumeLayout(false);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox Orders;
        internal System.Windows.Forms.Button Button6;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox totaltxt;
        internal System.Windows.Forms.Button reportbtn;
        internal System.Windows.Forms.Button orderbtn;
        internal System.Windows.Forms.Button incomingbtn;
        internal System.Windows.Forms.Panel Panel1;
        internal System.Windows.Forms.Label lblDate;
        internal System.Windows.Forms.Label lblTime;
        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button exitbtn;
        internal System.Windows.Forms.Button Button10;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}