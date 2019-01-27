namespace BlissRecruitmentAPICaller
{
    partial class MainForm
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
            this.btnStatus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBaseAddress = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnQuestionsGetQuery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(15, 34);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(126, 23);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "/health (GET)";
            this.btnStatus.UseVisualStyleBackColor = true;
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Base address";
            // 
            // txtBaseAddress
            // 
            this.txtBaseAddress.Location = new System.Drawing.Point(113, 6);
            this.txtBaseAddress.Name = "txtBaseAddress";
            this.txtBaseAddress.Size = new System.Drawing.Size(675, 22);
            this.txtBaseAddress.TabIndex = 2;
            this.txtBaseAddress.Text = "http://localhost:64068";
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 237);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 201);
            this.txtResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(50, 86);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 22);
            this.txtLimit.TabIndex = 6;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(211, 86);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(100, 22);
            this.txtOffset.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "offset";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(372, 86);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(416, 22);
            this.txtFilter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "filter";
            // 
            // btnQuestionsGetQuery
            // 
            this.btnQuestionsGetQuery.Location = new System.Drawing.Point(15, 63);
            this.btnQuestionsGetQuery.Name = "btnQuestionsGetQuery";
            this.btnQuestionsGetQuery.Size = new System.Drawing.Size(315, 23);
            this.btnQuestionsGetQuery.TabIndex = 11;
            this.btnQuestionsGetQuery.Text = "/questions?limit={limit}&offset={offset}&filter={filter}";
            this.btnQuestionsGetQuery.UseVisualStyleBackColor = true;
            this.btnQuestionsGetQuery.Click += new System.EventHandler(this.btnQuestionsGetQuery_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnQuestionsGetQuery);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtBaseAddress);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnStatus);
            this.Name = "MainForm";
            this.Text = "Caller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBaseAddress;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnQuestionsGetQuery;
    }
}

