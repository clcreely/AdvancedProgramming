namespace ExamQ1
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
            this.dgvGasMeterRecords = new System.Windows.Forms.DataGridView();
            this.dgvAccountRecords = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoVolumeUsed = new System.Windows.Forms.RadioButton();
            this.rdoMeterId = new System.Windows.Forms.RadioButton();
            this.btnCustArrears = new System.Windows.Forms.Button();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasMeterRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountRecords)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvGasMeterRecords
            // 
            this.dgvGasMeterRecords.AllowUserToOrderColumns = true;
            this.dgvGasMeterRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGasMeterRecords.Location = new System.Drawing.Point(41, 38);
            this.dgvGasMeterRecords.Name = "dgvGasMeterRecords";
            this.dgvGasMeterRecords.Size = new System.Drawing.Size(465, 161);
            this.dgvGasMeterRecords.TabIndex = 0;
            this.dgvGasMeterRecords.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGasMeterRecords_RowEnter);
            // 
            // dgvAccountRecords
            // 
            this.dgvAccountRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccountRecords.Location = new System.Drawing.Point(41, 236);
            this.dgvAccountRecords.Name = "dgvAccountRecords";
            this.dgvAccountRecords.Size = new System.Drawing.Size(465, 116);
            this.dgvAccountRecords.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoVolumeUsed);
            this.groupBox1.Controls.Add(this.rdoMeterId);
            this.groupBox1.Location = new System.Drawing.Point(547, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(166, 161);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort Data";
            // 
            // rdoVolumeUsed
            // 
            this.rdoVolumeUsed.AutoSize = true;
            this.rdoVolumeUsed.Location = new System.Drawing.Point(22, 104);
            this.rdoVolumeUsed.Name = "rdoVolumeUsed";
            this.rdoVolumeUsed.Size = new System.Drawing.Size(88, 17);
            this.rdoVolumeUsed.TabIndex = 1;
            this.rdoVolumeUsed.TabStop = true;
            this.rdoVolumeUsed.Text = "Volume Used";
            this.rdoVolumeUsed.UseVisualStyleBackColor = true;
            this.rdoVolumeUsed.CheckedChanged += new System.EventHandler(this.rdoVolumeUsed_CheckedChanged);
            // 
            // rdoMeterId
            // 
            this.rdoMeterId.AutoSize = true;
            this.rdoMeterId.Location = new System.Drawing.Point(22, 52);
            this.rdoMeterId.Name = "rdoMeterId";
            this.rdoMeterId.Size = new System.Drawing.Size(66, 17);
            this.rdoMeterId.TabIndex = 0;
            this.rdoMeterId.TabStop = true;
            this.rdoMeterId.Text = "Meter ID";
            this.rdoMeterId.UseVisualStyleBackColor = true;
            this.rdoMeterId.CheckedChanged += new System.EventHandler(this.rdoMeterId_CheckedChanged);
            // 
            // btnCustArrears
            // 
            this.btnCustArrears.Location = new System.Drawing.Point(580, 236);
            this.btnCustArrears.Name = "btnCustArrears";
            this.btnCustArrears.Size = new System.Drawing.Size(98, 39);
            this.btnCustArrears.TabIndex = 3;
            this.btnCustArrears.Text = "Customer Arrears Report";
            this.btnCustArrears.UseVisualStyleBackColor = true;
            this.btnCustArrears.Click += new System.EventHandler(this.btnCustArrears_Click);
            // 
            // btnSummaryReport
            // 
            this.btnSummaryReport.Location = new System.Drawing.Point(580, 299);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(98, 39);
            this.btnSummaryReport.TabIndex = 4;
            this.btnSummaryReport.Text = "Summary Report";
            this.btnSummaryReport.UseVisualStyleBackColor = true;
            this.btnSummaryReport.Click += new System.EventHandler(this.btnSummaryReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Gas Meter Records";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Account Records";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 362);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSummaryReport);
            this.Controls.Add(this.btnCustArrears);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvAccountRecords);
            this.Controls.Add(this.dgvGasMeterRecords);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGasMeterRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccountRecords)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGasMeterRecords;
        private System.Windows.Forms.DataGridView dgvAccountRecords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoVolumeUsed;
        private System.Windows.Forms.RadioButton rdoMeterId;
        private System.Windows.Forms.Button btnCustArrears;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

