namespace ExamQ1
{
    partial class CustomerArrearsReport
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
            this.dgvCustArrearsReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustArrearsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustArrearsReport
            // 
            this.dgvCustArrearsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustArrearsReport.Location = new System.Drawing.Point(13, 13);
            this.dgvCustArrearsReport.Name = "dgvCustArrearsReport";
            this.dgvCustArrearsReport.Size = new System.Drawing.Size(466, 335);
            this.dgvCustArrearsReport.TabIndex = 0;
            // 
            // CustomerArrearsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 360);
            this.Controls.Add(this.dgvCustArrearsReport);
            this.Name = "CustomerArrearsReport";
            this.Text = "CustomerArrearsReport";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustArrearsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustArrearsReport;
    }
}