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
            this.btnQuestionGet = new System.Windows.Forms.Button();
            this.txtQuestionIdGet = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnQuestionsPost = new System.Windows.Forms.Button();
            this.btnQuestionsPut = new System.Windows.Forms.Button();
            this.txtQuestionPost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Choice = new System.Windows.Forms.Label();
            this.txtChoicePost = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQuestionPut = new System.Windows.Forms.TextBox();
            this.txtVotes = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuestionIdPost = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDestinationEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtContentUrl = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnShare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(15, 34);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(109, 23);
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
            this.txtResult.Location = new System.Drawing.Point(12, 357);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(776, 201);
            this.txtResult.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "limit";
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(51, 92);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(100, 22);
            this.txtLimit.TabIndex = 6;
            // 
            // txtOffset
            // 
            this.txtOffset.Location = new System.Drawing.Point(212, 92);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(100, 22);
            this.txtOffset.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "offset";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(373, 92);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(416, 22);
            this.txtFilter.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "filter";
            // 
            // btnQuestionsGetQuery
            // 
            this.btnQuestionsGetQuery.Location = new System.Drawing.Point(15, 63);
            this.btnQuestionsGetQuery.Name = "btnQuestionsGetQuery";
            this.btnQuestionsGetQuery.Size = new System.Drawing.Size(361, 23);
            this.btnQuestionsGetQuery.TabIndex = 11;
            this.btnQuestionsGetQuery.Text = "/questions?limit={limit}&offset={offset}&filter={filter} (GET)";
            this.btnQuestionsGetQuery.UseVisualStyleBackColor = true;
            this.btnQuestionsGetQuery.Click += new System.EventHandler(this.btnQuestionsGetQuery_Click);
            // 
            // btnQuestionGet
            // 
            this.btnQuestionGet.Location = new System.Drawing.Point(16, 120);
            this.btnQuestionGet.Name = "btnQuestionGet";
            this.btnQuestionGet.Size = new System.Drawing.Size(212, 23);
            this.btnQuestionGet.TabIndex = 12;
            this.btnQuestionGet.Text = "/questions/{question_id} (GET)";
            this.btnQuestionGet.UseVisualStyleBackColor = true;
            this.btnQuestionGet.Click += new System.EventHandler(this.btnQuestionGet_Click);
            // 
            // txtQuestionIdGet
            // 
            this.txtQuestionIdGet.Location = new System.Drawing.Point(100, 149);
            this.txtQuestionIdGet.Name = "txtQuestionIdGet";
            this.txtQuestionIdGet.Size = new System.Drawing.Size(100, 22);
            this.txtQuestionIdGet.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "question_id";
            // 
            // btnQuestionsPost
            // 
            this.btnQuestionsPost.Location = new System.Drawing.Point(16, 177);
            this.btnQuestionsPost.Name = "btnQuestionsPost";
            this.btnQuestionsPost.Size = new System.Drawing.Size(405, 23);
            this.btnQuestionsPost.TabIndex = 15;
            this.btnQuestionsPost.Text = "/questions (POST) - It adds just one choice for demo purpose";
            this.btnQuestionsPost.UseVisualStyleBackColor = true;
            this.btnQuestionsPost.Click += new System.EventHandler(this.btnQuestionsPost_Click);
            // 
            // btnQuestionsPut
            // 
            this.btnQuestionsPut.Location = new System.Drawing.Point(16, 236);
            this.btnQuestionsPut.Name = "btnQuestionsPut";
            this.btnQuestionsPut.Size = new System.Drawing.Size(772, 23);
            this.btnQuestionsPut.TabIndex = 16;
            this.btnQuestionsPut.Text = "/questions (PUT) - It will just update the question and number of votes of the fi" +
    "rst choice of the list for demo purpose";
            this.btnQuestionsPut.UseVisualStyleBackColor = true;
            this.btnQuestionsPut.Click += new System.EventHandler(this.btnQuestionsPut_Click);
            // 
            // txtQuestionPost
            // 
            this.txtQuestionPost.Location = new System.Drawing.Point(84, 206);
            this.txtQuestionPost.Name = "txtQuestionPost";
            this.txtQuestionPost.Size = new System.Drawing.Size(349, 22);
            this.txtQuestionPost.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Question";
            // 
            // Choice
            // 
            this.Choice.AutoSize = true;
            this.Choice.Location = new System.Drawing.Point(439, 208);
            this.Choice.Name = "Choice";
            this.Choice.Size = new System.Drawing.Size(51, 17);
            this.Choice.TabIndex = 19;
            this.Choice.Text = "Choice";
            // 
            // txtChoicePost
            // 
            this.txtChoicePost.Location = new System.Drawing.Point(496, 205);
            this.txtChoicePost.Name = "txtChoicePost";
            this.txtChoicePost.Size = new System.Drawing.Size(292, 22);
            this.txtChoicePost.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(186, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Question";
            // 
            // txtQuestionPut
            // 
            this.txtQuestionPut.Location = new System.Drawing.Point(257, 266);
            this.txtQuestionPut.Name = "txtQuestionPut";
            this.txtQuestionPut.Size = new System.Drawing.Size(388, 22);
            this.txtQuestionPut.TabIndex = 21;
            // 
            // txtVotes
            // 
            this.txtVotes.Location = new System.Drawing.Point(723, 265);
            this.txtVotes.Name = "txtVotes";
            this.txtVotes.Size = new System.Drawing.Size(66, 22);
            this.txtVotes.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(651, 268);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "Votes (0)";
            // 
            // txtQuestionIdPost
            // 
            this.txtQuestionIdPost.Location = new System.Drawing.Point(100, 266);
            this.txtQuestionIdPost.Name = "txtQuestionIdPost";
            this.txtQuestionIdPost.Size = new System.Drawing.Size(80, 22);
            this.txtQuestionIdPost.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 269);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "question_id";
            // 
            // txtDestinationEmail
            // 
            this.txtDestinationEmail.Location = new System.Drawing.Point(137, 317);
            this.txtDestinationEmail.Name = "txtDestinationEmail";
            this.txtDestinationEmail.Size = new System.Drawing.Size(222, 22);
            this.txtDestinationEmail.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 30;
            this.label7.Text = "destination_email";
            // 
            // txtContentUrl
            // 
            this.txtContentUrl.Location = new System.Drawing.Point(456, 317);
            this.txtContentUrl.Name = "txtContentUrl";
            this.txtContentUrl.Size = new System.Drawing.Size(222, 22);
            this.txtContentUrl.TabIndex = 33;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(371, 320);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 32;
            this.label11.Text = "content_url";
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(16, 294);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(525, 23);
            this.btnShare.TabIndex = 34;
            this.btnShare.Text = "/share?destination_email={destination_email}&content_url={content_url} (POST)";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.txtContentUrl);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtDestinationEmail);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtQuestionIdPost);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtVotes);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuestionPut);
            this.Controls.Add(this.txtChoicePost);
            this.Controls.Add(this.Choice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuestionPost);
            this.Controls.Add(this.btnQuestionsPut);
            this.Controls.Add(this.btnQuestionsPost);
            this.Controls.Add(this.txtQuestionIdGet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnQuestionGet);
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
        private System.Windows.Forms.Button btnQuestionGet;
        private System.Windows.Forms.TextBox txtQuestionIdGet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnQuestionsPost;
        private System.Windows.Forms.Button btnQuestionsPut;
        private System.Windows.Forms.TextBox txtQuestionPost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Choice;
        private System.Windows.Forms.TextBox txtChoicePost;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQuestionPut;
        private System.Windows.Forms.TextBox txtVotes;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtQuestionIdPost;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDestinationEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtContentUrl;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnShare;
    }
}

