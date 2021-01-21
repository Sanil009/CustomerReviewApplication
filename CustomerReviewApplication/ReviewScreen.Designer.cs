
namespace CustomerReviewApplication
{
    partial class ReviewScreen
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
            this.pnReview = new System.Windows.Forms.Panel();
            this.btnReviewBack = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbFeedback = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnServiceRatings = new System.Windows.Forms.Panel();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnDetails = new System.Windows.Forms.Panel();
            this.cbAge = new System.Windows.Forms.ComboBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnReviewHeading = new System.Windows.Forms.Panel();
            this.lblReviewPanel = new System.Windows.Forms.Label();
            this.pnReview.SuspendLayout();
            this.pnDetails.SuspendLayout();
            this.pnReviewHeading.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnReview
            // 
            this.pnReview.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pnReview.Controls.Add(this.pnReviewHeading);
            this.pnReview.Controls.Add(this.btnClear);
            this.pnReview.Controls.Add(this.tbFeedback);
            this.pnReview.Controls.Add(this.label1);
            this.pnReview.Controls.Add(this.pnServiceRatings);
            this.pnReview.Controls.Add(this.btnSubmit);
            this.pnReview.Controls.Add(this.pnDetails);
            this.pnReview.Location = new System.Drawing.Point(6, 6);
            this.pnReview.Margin = new System.Windows.Forms.Padding(2);
            this.pnReview.Name = "pnReview";
            this.pnReview.Size = new System.Drawing.Size(940, 524);
            this.pnReview.TabIndex = 0;
            // 
            // btnReviewBack
            // 
            this.btnReviewBack.BackColor = System.Drawing.Color.DarkRed;
            this.btnReviewBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReviewBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReviewBack.Location = new System.Drawing.Point(897, 3);
            this.btnReviewBack.Name = "btnReviewBack";
            this.btnReviewBack.Size = new System.Drawing.Size(43, 37);
            this.btnReviewBack.TabIndex = 10;
            this.btnReviewBack.Text = "X";
            this.btnReviewBack.UseVisualStyleBackColor = false;
            this.btnReviewBack.Click += new System.EventHandler(this.btnReviewBack_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.IndianRed;
            this.btnClear.Location = new System.Drawing.Point(829, 477);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 40);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbFeedback
            // 
            this.tbFeedback.Location = new System.Drawing.Point(681, 252);
            this.tbFeedback.Margin = new System.Windows.Forms.Padding(2);
            this.tbFeedback.Multiline = true;
            this.tbFeedback.Name = "tbFeedback";
            this.tbFeedback.Size = new System.Drawing.Size(248, 206);
            this.tbFeedback.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(580, 252);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Feedback:";
            // 
            // pnServiceRatings
            // 
            this.pnServiceRatings.AutoScroll = true;
            this.pnServiceRatings.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnServiceRatings.Location = new System.Drawing.Point(5, 252);
            this.pnServiceRatings.Margin = new System.Windows.Forms.Padding(2);
            this.pnServiceRatings.Name = "pnServiceRatings";
            this.pnServiceRatings.Size = new System.Drawing.Size(562, 265);
            this.pnServiceRatings.TabIndex = 8;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.YellowGreen;
            this.btnSubmit.Location = new System.Drawing.Point(681, 477);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(104, 40);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnDetails
            // 
            this.pnDetails.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnDetails.Controls.Add(this.cbAge);
            this.pnDetails.Controls.Add(this.lblAge);
            this.pnDetails.Controls.Add(this.tbEmail);
            this.pnDetails.Controls.Add(this.lblEmail);
            this.pnDetails.Controls.Add(this.tbPhone);
            this.pnDetails.Controls.Add(this.lblPhone);
            this.pnDetails.Controls.Add(this.tbName);
            this.pnDetails.Controls.Add(this.lblName);
            this.pnDetails.Location = new System.Drawing.Point(121, 103);
            this.pnDetails.Margin = new System.Windows.Forms.Padding(2);
            this.pnDetails.Name = "pnDetails";
            this.pnDetails.Size = new System.Drawing.Size(690, 127);
            this.pnDetails.TabIndex = 1;
            this.pnDetails.Paint += new System.Windows.Forms.PaintEventHandler(this.pnDetails_Paint);
            // 
            // cbAge
            // 
            this.cbAge.FormattingEnabled = true;
            this.cbAge.Items.AddRange(new object[] {
            "18-25",
            "26-40",
            "41-55",
            "55+"});
            this.cbAge.Location = new System.Drawing.Point(494, 81);
            this.cbAge.Margin = new System.Windows.Forms.Padding(2);
            this.cbAge.Name = "cbAge";
            this.cbAge.Size = new System.Drawing.Size(168, 24);
            this.cbAge.TabIndex = 7;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAge.Location = new System.Drawing.Point(400, 82);
            this.lblAge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(43, 20);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Age:";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(494, 18);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(168, 22);
            this.tbEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(400, 17);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(56, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email:";
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(132, 83);
            this.tbPhone.Margin = new System.Windows.Forms.Padding(2);
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(160, 22);
            this.tbPhone.TabIndex = 3;
            this.tbPhone.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(12, 82);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(91, 20);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone No.:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(132, 18);
            this.tbName.Margin = new System.Windows.Forms.Padding(2);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(160, 22);
            this.tbName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 17);
            this.lblName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // pnReviewHeading
            // 
            this.pnReviewHeading.BackColor = System.Drawing.Color.CadetBlue;
            this.pnReviewHeading.Controls.Add(this.lblReviewPanel);
            this.pnReviewHeading.Controls.Add(this.btnReviewBack);
            this.pnReviewHeading.Location = new System.Drawing.Point(0, 0);
            this.pnReviewHeading.Name = "pnReviewHeading";
            this.pnReviewHeading.Size = new System.Drawing.Size(940, 89);
            this.pnReviewHeading.TabIndex = 11;
            // 
            // lblReviewPanel
            // 
            this.lblReviewPanel.AutoSize = true;
            this.lblReviewPanel.BackColor = System.Drawing.Color.CadetBlue;
            this.lblReviewPanel.Font = new System.Drawing.Font("Miriam Libre", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewPanel.Location = new System.Drawing.Point(345, 17);
            this.lblReviewPanel.Name = "lblReviewPanel";
            this.lblReviewPanel.Size = new System.Drawing.Size(287, 53);
            this.lblReviewPanel.TabIndex = 13;
            this.lblReviewPanel.Text = "Review Panel";
            // 
            // ReviewScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 534);
            this.Controls.Add(this.pnReview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReviewScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReviewScreen";
            this.Load += new System.EventHandler(this.ReviewScreen_Load);
            this.pnReview.ResumeLayout(false);
            this.pnReview.PerformLayout();
            this.pnDetails.ResumeLayout(false);
            this.pnDetails.PerformLayout();
            this.pnReviewHeading.ResumeLayout(false);
            this.pnReviewHeading.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnReview;
        private System.Windows.Forms.Panel pnDetails;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Panel pnServiceRatings;
        private System.Windows.Forms.ComboBox cbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbFeedback;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnReviewBack;
        private System.Windows.Forms.Panel pnReviewHeading;
        private System.Windows.Forms.Label lblReviewPanel;
    }
}