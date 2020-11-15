namespace MultiQueueSimulation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stopNum = new System.Windows.Forms.TextBox();
            this.numOfServers = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.inputGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maxQueueLength = new System.Windows.Forms.Label();
            this.waitingProb = new System.Windows.Forms.Label();
            this.avgWaitTime = new System.Windows.Forms.Label();
            this.outputGridView2 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idleProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.avgServiceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.utiliz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.timeInQueue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stopNum
            // 
            this.stopNum.Location = new System.Drawing.Point(129, 60);
            this.stopNum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.stopNum.Name = "stopNum";
            this.stopNum.Size = new System.Drawing.Size(210, 24);
            this.stopNum.TabIndex = 0;
            this.stopNum.TextChanged += new System.EventHandler(this.stopNum_TextChanged);
            // 
            // numOfServers
            // 
            this.numOfServers.Location = new System.Drawing.Point(129, 15);
            this.numOfServers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numOfServers.Name = "numOfServers";
            this.numOfServers.Size = new System.Drawing.Size(210, 24);
            this.numOfServers.TabIndex = 0;
            this.numOfServers.TextChanged += new System.EventHandler(this.numOfServers_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Servers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Stopping Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Stopping Criteria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Selection Method";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox1.Location = new System.Drawing.Point(129, 107);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 24);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox2.Location = new System.Drawing.Point(129, 151);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(210, 24);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // inputGridView
            // 
            this.inputGridView.AllowUserToOrderColumns = true;
            this.inputGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inputGridView.Location = new System.Drawing.Point(17, 222);
            this.inputGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.inputGridView.Name = "inputGridView";
            this.inputGridView.RowHeadersWidth = 51;
            this.inputGridView.Size = new System.Drawing.Size(1689, 748);
            this.inputGridView.TabIndex = 3;
            this.inputGridView.Visible = false;
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
            this.button1.Location = new System.Drawing.Point(364, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(401, 166);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.maxQueueLength);
            this.panel1.Controls.Add(this.waitingProb);
            this.panel1.Controls.Add(this.avgWaitTime);
            this.panel1.Controls.Add(this.outputGridView2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.outputGridView);
            this.panel1.Location = new System.Drawing.Point(14, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1708, 955);
            this.panel1.TabIndex = 5;
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
            // outputGridView2
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.outputGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.outputGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.idleProb,
            this.avgServiceTime,
            this.utiliz});
            this.outputGridView2.Location = new System.Drawing.Point(3, 638);
            this.outputGridView2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputGridView2.Name = "outputGridView2";
            this.outputGridView2.RowHeadersWidth = 51;
            this.outputGridView2.Size = new System.Drawing.Size(846, 297);
            this.outputGridView2.TabIndex = 3;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // idleProb
            // 
            this.idleProb.HeaderText = "Idle Probability";
            this.idleProb.MinimumWidth = 6;
            this.idleProb.Name = "idleProb";
            this.idleProb.Width = 200;
            // 
            // avgServiceTime
            // 
            this.avgServiceTime.HeaderText = "Average Service Time";
            this.avgServiceTime.MinimumWidth = 6;
            this.avgServiceTime.Name = "avgServiceTime";
            this.avgServiceTime.Width = 250;
            // 
            // utiliz
            // 
            this.utiliz.HeaderText = "Utilization";
            this.utiliz.MinimumWidth = 6;
            this.utiliz.Name = "utiliz";
            this.utiliz.Width = 130;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(887, 832);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 28);
            this.label7.TabIndex = 2;
            this.label7.Text = "Waiting Probability: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(887, 759);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(246, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Max Queue Length: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(887, 686);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(282, 28);
            this.label5.TabIndex = 2;
            this.label5.Text = "Average Waiting Time: ";
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
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.outputGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            this.endTime,
            this.timeInQueue});
            this.outputGridView.Location = new System.Drawing.Point(0, 0);
            this.outputGridView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.outputGridView.Name = "outputGridView";
            this.outputGridView.RowHeadersWidth = 51;
            this.outputGridView.Size = new System.Drawing.Size(1440, 622);
            this.outputGridView.TabIndex = 0;
            this.outputGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.outputGridView_CellContentClick);
            // 
            // customerNo
            // 
            this.customerNo.HeaderText = "Customer Number";
            this.customerNo.MinimumWidth = 10;
            this.customerNo.Name = "customerNo";
            this.customerNo.Width = 120;
            // 
            // randomInterarrival
            // 
            this.randomInterarrival.HeaderText = "Random interarrival";
            this.randomInterarrival.MinimumWidth = 6;
            this.randomInterarrival.Name = "randomInterarrival";
            this.randomInterarrival.Width = 150;
            // 
            // interarrival
            // 
            this.interarrival.HeaderText = "Interarrival";
            this.interarrival.MinimumWidth = 6;
            this.interarrival.Name = "interarrival";
            this.interarrival.Width = 120;
            // 
            // arrival
            // 
            this.arrival.HeaderText = "Arrival";
            this.arrival.MinimumWidth = 6;
            this.arrival.Name = "arrival";
            this.arrival.Width = 125;
            // 
            // serverId
            // 
            this.serverId.HeaderText = "Server Id";
            this.serverId.MinimumWidth = 6;
            this.serverId.Name = "serverId";
            this.serverId.Width = 125;
            // 
            // timeBegin
            // 
            this.timeBegin.HeaderText = "Time Begin";
            this.timeBegin.MinimumWidth = 6;
            this.timeBegin.Name = "timeBegin";
            this.timeBegin.Width = 125;
            // 
            // randomService
            // 
            this.randomService.HeaderText = "Random Service";
            this.randomService.MinimumWidth = 6;
            this.randomService.Name = "randomService";
            this.randomService.Width = 150;
            // 
            // serviceTime
            // 
            this.serviceTime.HeaderText = "Service Time";
            this.serviceTime.MinimumWidth = 6;
            this.serviceTime.Name = "serviceTime";
            this.serviceTime.Width = 125;
            // 
            // endTime
            // 
            this.endTime.HeaderText = "End Time";
            this.endTime.MinimumWidth = 6;
            this.endTime.Name = "endTime";
            this.endTime.Width = 125;
            // 
            // timeInQueue
            // 
            this.timeInQueue.HeaderText = "Time In Queue";
            this.timeInQueue.MinimumWidth = 6;
            this.timeInQueue.Name = "timeInQueue";
            this.timeInQueue.Width = 150;
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
            this.button3.Location = new System.Drawing.Point(794, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(401, 166);
            this.button3.TabIndex = 6;
            this.button3.Text = "Import file";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(887, 884);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(285, 28);
            this.label8.TabIndex = 5;
            this.label8.Text = "Enter number of server: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1203, 888);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 24);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1446, 875);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(186, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Generate graph";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 985);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numOfServers);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.stopNum);
            this.Controls.Add(this.inputGridView);
            this.Controls.Add(this.button3);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox stopNum;
        private System.Windows.Forms.TextBox numOfServers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView inputGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn timeInQueue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView outputGridView2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label maxQueueLength;
        private System.Windows.Forms.Label waitingProb;
        private System.Windows.Forms.Label avgWaitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn idleProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn avgServiceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn utiliz;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label8;
    }
}

