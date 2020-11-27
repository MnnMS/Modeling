namespace NewspaperSellerSimulation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PoorDayDis = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.FairDayDis = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.GoodDayDis = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SellingPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ScrapPrice = new System.Windows.Forms.TextBox();
            this.PurchasePrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NumOfNewspapers = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.NumOfRecords = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxQueueLength = new System.Windows.Forms.Label();
            this.waitingProb = new System.Windows.Forms.Label();
            this.avgWaitTime = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.outputGridView = new System.Windows.Forms.DataGridView();
            this.customerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomInterarrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.interarrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serverId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeBegin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.randomService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PoorDayDis
            // 
            this.PoorDayDis.Location = new System.Drawing.Point(193, 243);
            this.PoorDayDis.Name = "PoorDayDis";
            this.PoorDayDis.Size = new System.Drawing.Size(210, 24);
            this.PoorDayDis.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(30, 243);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(145, 17);
            this.label12.TabIndex = 33;
            this.label12.Text = "Poor Day Distributions";
            // 
            // FairDayDis
            // 
            this.FairDayDis.Location = new System.Drawing.Point(193, 210);
            this.FairDayDis.Name = "FairDayDis";
            this.FairDayDis.Size = new System.Drawing.Size(210, 24);
            this.FairDayDis.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 17);
            this.label11.TabIndex = 31;
            this.label11.Text = "Fair Day Distributions";
            // 
            // GoodDayDis
            // 
            this.GoodDayDis.Location = new System.Drawing.Point(193, 180);
            this.GoodDayDis.Name = "GoodDayDis";
            this.GoodDayDis.Size = new System.Drawing.Size(210, 24);
            this.GoodDayDis.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 180);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(149, 17);
            this.label10.TabIndex = 29;
            this.label10.Text = "Good Day Distributions";
            // 
            // SellingPrice
            // 
            this.SellingPrice.Location = new System.Drawing.Point(193, 150);
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.Size = new System.Drawing.Size(210, 24);
            this.SellingPrice.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 27;
            this.label9.Text = "Selling Price";
            // 
            // ScrapPrice
            // 
            this.ScrapPrice.Location = new System.Drawing.Point(193, 117);
            this.ScrapPrice.Name = "ScrapPrice";
            this.ScrapPrice.Size = new System.Drawing.Size(210, 24);
            this.ScrapPrice.TabIndex = 26;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.Location = new System.Drawing.Point(193, 87);
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.Size = new System.Drawing.Size(210, 24);
            this.PurchasePrice.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "Scrap Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "Purchase Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Number Of Records";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Number Of Newspapers";
            // 
            // NumOfNewspapers
            // 
            this.NumOfNewspapers.Location = new System.Drawing.Point(193, 22);
            this.NumOfNewspapers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumOfNewspapers.Name = "NumOfNewspapers";
            this.NumOfNewspapers.Size = new System.Drawing.Size(210, 24);
            this.NumOfNewspapers.TabIndex = 17;
            this.NumOfNewspapers.Validated += new System.EventHandler(this.NumOfNewspapers_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(495, 26);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 166);
            this.button1.TabIndex = 23;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NumOfRecords
            // 
            this.NumOfRecords.Location = new System.Drawing.Point(193, 54);
            this.NumOfRecords.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NumOfRecords.Name = "NumOfRecords";
            this.NumOfRecords.Size = new System.Drawing.Size(210, 24);
            this.NumOfRecords.TabIndex = 18;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Silver;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(922, 26);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(401, 166);
            this.button3.TabIndex = 24;
            this.button3.Text = "Import file";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // inputGridView
            // 
            this.inputGridView.AllowUserToOrderColumns = true;
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputGridView.Location = new System.Drawing.Point(12, 313);
            this.inputGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.RowHeadersWidth = 51;
            this.inputGridView.Size = new System.Drawing.Size(1694, 659);
            this.inputGridView.TabIndex = 35;
            this.inputGridView.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maxQueueLength);
            this.panel1.Controls.Add(this.waitingProb);
            this.panel1.Controls.Add(this.avgWaitTime);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.outputGridView);
            this.panel1.Location = new System.Drawing.Point(12, 13);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1697, 959);
            this.panel1.TabIndex = 36;
            this.panel1.Visible = false;
            // 
            // maxQueueLength
            // 
            this.maxQueueLength.AutoSize = true;
            this.maxQueueLength.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maxQueueLength.Location = new System.Drawing.Point(1182, 762);
            this.maxQueueLength.Name = "maxQueueLength";
            this.maxQueueLength.Size = new System.Drawing.Size(0, 23);
            this.maxQueueLength.TabIndex = 4;
            // 
            // waitingProb
            // 
            this.waitingProb.AutoSize = true;
            this.waitingProb.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.waitingProb.Location = new System.Drawing.Point(1182, 834);
            this.waitingProb.Name = "waitingProb";
            this.waitingProb.Size = new System.Drawing.Size(0, 23);
            this.waitingProb.TabIndex = 4;
            // 
            // avgWaitTime
            // 
            this.avgWaitTime.AutoSize = true;
            this.avgWaitTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avgWaitTime.Location = new System.Drawing.Point(1182, 688);
            this.avgWaitTime.Name = "avgWaitTime";
            this.avgWaitTime.Size = new System.Drawing.Size(0, 23);
            this.avgWaitTime.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1472, 34);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(191, 148);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // outputGridView
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.outputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerNo,
            this.randomInterarrival,
            this.interarrival,
            this.arrival,
            this.serverId,
            this.timeBegin,
            this.randomService,
            this.serviceTime,
            this.endTime});
            this.outputGridView.Location = new System.Drawing.Point(43, 57);
            this.outputGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputGridView.Name = "outputGridView";
            this.outputGridView.RowHeadersWidth = 51;
            this.outputGridView.Size = new System.Drawing.Size(1223, 544);
            this.outputGridView.TabIndex = 0;
            // 
            // customerNo
            // 
            this.customerNo.HeaderText = "Day";
            this.customerNo.MinimumWidth = 10;
            this.customerNo.Name = "customerNo";
            this.customerNo.Width = 120;
            // 
            // randomInterarrival
            // 
            this.randomInterarrival.HeaderText = "Random Type of Newsday";
            this.randomInterarrival.MinimumWidth = 6;
            this.randomInterarrival.Name = "randomInterarrival";
            this.randomInterarrival.Width = 150;
            // 
            // interarrival
            // 
            this.interarrival.HeaderText = "Type of Newsday";
            this.interarrival.MinimumWidth = 6;
            this.interarrival.Name = "interarrival";
            this.interarrival.Width = 120;
            // 
            // arrival
            // 
            this.arrival.HeaderText = "Random Demand";
            this.arrival.MinimumWidth = 6;
            this.arrival.Name = "arrival";
            this.arrival.Width = 125;
            // 
            // serverId
            // 
            this.serverId.HeaderText = "Demand";
            this.serverId.MinimumWidth = 6;
            this.serverId.Name = "serverId";
            this.serverId.Width = 125;
            // 
            // timeBegin
            // 
            this.timeBegin.HeaderText = "Revenue From sales";
            this.timeBegin.MinimumWidth = 6;
            this.timeBegin.Name = "timeBegin";
            this.timeBegin.Width = 125;
            // 
            // randomService
            // 
            this.randomService.HeaderText = "Lost Profit";
            this.randomService.MinimumWidth = 6;
            this.randomService.Name = "randomService";
            this.randomService.Width = 150;
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "Salvage From Sales Of Scrap";
            this.serviceTime.MinimumWidth = 6;
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.Width = 125;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "Daily Profit";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputGridView);
            this.Controls.Add(this.PoorDayDis);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.FairDayDis);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.GoodDayDis);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.SellingPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ScrapPrice);
            this.Controls.Add(this.PurchasePrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NumOfNewspapers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NumOfRecords);
            this.Controls.Add(this.button3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoorDayDis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox FairDayDis;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox GoodDayDis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox SellingPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ScrapPrice;
        private System.Windows.Forms.TextBox PurchasePrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NumOfNewspapers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox NumOfRecords;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label maxQueueLength;
        private System.Windows.Forms.Label waitingProb;
        private System.Windows.Forms.Label avgWaitTime;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView outputGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomInterarrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn interarrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrival;
        private System.Windows.Forms.DataGridViewTextBoxColumn serverId;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeBegin;
        private System.Windows.Forms.DataGridViewTextBoxColumn randomService;
        private System.Windows.Forms.DataGridViewTextBoxColumn serviceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTime;
    }
}