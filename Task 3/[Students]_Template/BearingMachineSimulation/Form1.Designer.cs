namespace BearingMachineSimulation
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
            this.readBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NhoursTxt = new System.Windows.Forms.TextBox();
            this.NbearTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bearCostTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dwnTimeCTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.repairCostTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.repairTimeBTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.repairTBrsTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bearingDist = new System.Windows.Forms.DataGridView();
            this.delayDist = new System.Windows.Forms.DataGridView();
            this.DelayTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DTProb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Probability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.simBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bearingDist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayDist)).BeginInit();
            this.SuspendLayout();
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readBtn.Location = new System.Drawing.Point(837, 13);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(202, 86);
            this.readBtn.TabIndex = 0;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "No of Hours";
            // 
            // NhoursTxt
            // 
            this.NhoursTxt.Location = new System.Drawing.Point(257, 23);
            this.NhoursTxt.Name = "NhoursTxt";
            this.NhoursTxt.ReadOnly = true;
            this.NhoursTxt.Size = new System.Drawing.Size(105, 20);
            this.NhoursTxt.TabIndex = 2;
            // 
            // NbearTxt
            // 
            this.NbearTxt.Location = new System.Drawing.Point(257, 79);
            this.NbearTxt.Name = "NbearTxt";
            this.NbearTxt.ReadOnly = true;
            this.NbearTxt.Size = new System.Drawing.Size(105, 20);
            this.NbearTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "No of Bearings";
            // 
            // bearCostTxt
            // 
            this.bearCostTxt.Location = new System.Drawing.Point(257, 126);
            this.bearCostTxt.Name = "bearCostTxt";
            this.bearCostTxt.ReadOnly = true;
            this.bearCostTxt.Size = new System.Drawing.Size(105, 20);
            this.bearCostTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bearing Cost";
            // 
            // dwnTimeCTxt
            // 
            this.dwnTimeCTxt.Location = new System.Drawing.Point(604, 23);
            this.dwnTimeCTxt.Name = "dwnTimeCTxt";
            this.dwnTimeCTxt.ReadOnly = true;
            this.dwnTimeCTxt.Size = new System.Drawing.Size(105, 20);
            this.dwnTimeCTxt.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(393, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "DownTime Cost";
            // 
            // repairCostTxt
            // 
            this.repairCostTxt.Location = new System.Drawing.Point(604, 100);
            this.repairCostTxt.Name = "repairCostTxt";
            this.repairCostTxt.ReadOnly = true;
            this.repairCostTxt.Size = new System.Drawing.Size(105, 20);
            this.repairCostTxt.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(378, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Repairperson Cost";
            // 
            // repairTimeBTxt
            // 
            this.repairTimeBTxt.Location = new System.Drawing.Point(604, 177);
            this.repairTimeBTxt.Name = "repairTimeBTxt";
            this.repairTimeBTxt.ReadOnly = true;
            this.repairTimeBTxt.Size = new System.Drawing.Size(105, 20);
            this.repairTimeBTxt.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(378, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "RepairTime/Bearing";
            // 
            // repairTBrsTxt
            // 
            this.repairTBrsTxt.Location = new System.Drawing.Point(257, 178);
            this.repairTBrsTxt.Name = "repairTBrsTxt";
            this.repairTBrsTxt.ReadOnly = true;
            this.repairTBrsTxt.Size = new System.Drawing.Size(105, 20);
            this.repairTBrsTxt.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "RepairTime/Bearings";
            // 
            // bearingDist
            // 
            this.bearingDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bearingDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Probability});
            this.bearingDist.Location = new System.Drawing.Point(17, 225);
            this.bearingDist.Name = "bearingDist";
            this.bearingDist.Size = new System.Drawing.Size(501, 400);
            this.bearingDist.TabIndex = 17;
            // 
            // delayDist
            // 
            this.delayDist.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.delayDist.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DelayTime,
            this.DTProb});
            this.delayDist.Location = new System.Drawing.Point(534, 225);
            this.delayDist.Name = "delayDist";
            this.delayDist.Size = new System.Drawing.Size(505, 400);
            this.delayDist.TabIndex = 18;
            // 
            // DelayTime
            // 
            this.DelayTime.HeaderText = "DelayTime";
            this.DelayTime.Name = "DelayTime";
            this.DelayTime.ReadOnly = true;
            // 
            // DTProb
            // 
            this.DTProb.HeaderText = "Probability";
            this.DTProb.Name = "DTProb";
            this.DTProb.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "BearingLife";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // Probability
            // 
            this.Probability.HeaderText = "Probability";
            this.Probability.Name = "Probability";
            this.Probability.ReadOnly = true;
            // 
            // simBtn
            // 
            this.simBtn.Font = new System.Drawing.Font("Century Gothic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simBtn.Location = new System.Drawing.Point(837, 121);
            this.simBtn.Name = "simBtn";
            this.simBtn.Size = new System.Drawing.Size(202, 86);
            this.simBtn.TabIndex = 19;
            this.simBtn.Text = "Simulate";
            this.simBtn.UseVisualStyleBackColor = true;
            this.simBtn.Click += new System.EventHandler(this.simBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1051, 642);
            this.Controls.Add(this.simBtn);
            this.Controls.Add(this.delayDist);
            this.Controls.Add(this.bearingDist);
            this.Controls.Add(this.repairTBrsTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.repairTimeBTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.repairCostTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dwnTimeCTxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bearCostTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NbearTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NhoursTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.readBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.bearingDist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delayDist)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NhoursTxt;
        private System.Windows.Forms.TextBox NbearTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bearCostTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dwnTimeCTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox repairCostTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox repairTimeBTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox repairTBrsTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView bearingDist;
        private System.Windows.Forms.DataGridView delayDist;
        private System.Windows.Forms.DataGridViewTextBoxColumn DelayTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn DTProb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Probability;
        private System.Windows.Forms.Button simBtn;
    }
}