namespace NeedBridge
{
    partial class WriteReview
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelForm = new System.Windows.Forms.Panel();
            this.lblProductInfo = new System.Windows.Forms.Label();
            this.lblRatingTitle = new System.Windows.Forms.Label();
            this.panelStars = new System.Windows.Forms.Panel();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb4 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.lblRatingDesc = new System.Windows.Forms.Label();
            this.lblCommentTitle = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelForm.SuspendLayout();
            this.panelStars.SuspendLayout();
            this.SuspendLayout();

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Size = new System.Drawing.Size(500, 70);

            this.lblTitle.AutoSize = false;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Size = new System.Drawing.Size(460, 32);
            this.lblTitle.Text = "Write a Review";

            this.lblSubtitle.AutoSize = false;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.FromArgb(180, 220, 255);
            this.lblSubtitle.Location = new System.Drawing.Point(20, 44);
            this.lblSubtitle.Size = new System.Drawing.Size(460, 20);
            this.lblSubtitle.Text = "Share your experience with this product";

            // panelForm
            this.panelForm.AutoScroll = true;
            this.panelForm.BackColor = System.Drawing.Color.White;
            this.panelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForm.Padding = new System.Windows.Forms.Padding(30, 20, 30, 20);
            this.panelForm.Controls.Add(this.lblProductInfo);
            this.panelForm.Controls.Add(this.lblRatingTitle);
            this.panelForm.Controls.Add(this.panelStars);
            this.panelForm.Controls.Add(this.lblRatingDesc);
            this.panelForm.Controls.Add(this.lblCommentTitle);
            this.panelForm.Controls.Add(this.txtComment);
            this.panelForm.Controls.Add(this.lblError);
            this.panelForm.Controls.Add(this.btnSubmit);
            this.panelForm.Controls.Add(this.btnCancel);

            // Product info
            this.lblProductInfo.AutoSize = false;
            this.lblProductInfo.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblProductInfo.ForeColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.lblProductInfo.Location = new System.Drawing.Point(30, 20);
            this.lblProductInfo.Size = new System.Drawing.Size(430, 28);
            this.lblProductInfo.Text = "Loading product...";
            this.lblProductInfo.Name = "lblProductInfo";

            // Rating title
            this.lblRatingTitle.AutoSize = false;
            this.lblRatingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblRatingTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblRatingTitle.Location = new System.Drawing.Point(30, 65);
            this.lblRatingTitle.Size = new System.Drawing.Size(430, 22);
            this.lblRatingTitle.Text = "Your Rating *";

            // panelStars
            this.panelStars.Location = new System.Drawing.Point(30, 93);
            this.panelStars.Size = new System.Drawing.Size(430, 50);
            this.panelStars.Controls.Add(this.rb1);
            this.panelStars.Controls.Add(this.rb2);
            this.panelStars.Controls.Add(this.rb3);
            this.panelStars.Controls.Add(this.rb4);
            this.panelStars.Controls.Add(this.rb5);

            this.rb1.AutoSize = false;
            this.rb1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rb1.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.rb1.Location = new System.Drawing.Point(0, 8);
            this.rb1.Size = new System.Drawing.Size(84, 30);
            this.rb1.Text = "1 Star";
            this.rb1.Name = "rb1";
            this.rb1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb1.CheckedChanged += new System.EventHandler(this.Star_Changed);

            this.rb2.AutoSize = false;
            this.rb2.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rb2.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.rb2.Location = new System.Drawing.Point(86, 8);
            this.rb2.Size = new System.Drawing.Size(84, 30);
            this.rb2.Text = "2 Stars";
            this.rb2.Name = "rb2";
            this.rb2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb2.CheckedChanged += new System.EventHandler(this.Star_Changed);

            this.rb3.AutoSize = false;
            this.rb3.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rb3.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.rb3.Location = new System.Drawing.Point(172, 8);
            this.rb3.Size = new System.Drawing.Size(84, 30);
            this.rb3.Text = "3 Stars";
            this.rb3.Name = "rb3";
            this.rb3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb3.CheckedChanged += new System.EventHandler(this.Star_Changed);

            this.rb4.AutoSize = false;
            this.rb4.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rb4.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.rb4.Location = new System.Drawing.Point(258, 8);
            this.rb4.Size = new System.Drawing.Size(84, 30);
            this.rb4.Text = "4 Stars";
            this.rb4.Name = "rb4";
            this.rb4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb4.CheckedChanged += new System.EventHandler(this.Star_Changed);

            this.rb5.AutoSize = false;
            this.rb5.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.rb5.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.rb5.Location = new System.Drawing.Point(344, 8);
            this.rb5.Size = new System.Drawing.Size(84, 30);
            this.rb5.Text = "5 Stars";
            this.rb5.Name = "rb5";
            this.rb5.Checked = true;
            this.rb5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rb5.CheckedChanged += new System.EventHandler(this.Star_Changed);

            // Rating desc
            this.lblRatingDesc.AutoSize = false;
            this.lblRatingDesc.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            this.lblRatingDesc.ForeColor = System.Drawing.Color.FromArgb(200, 140, 0);
            this.lblRatingDesc.Location = new System.Drawing.Point(30, 153);
            this.lblRatingDesc.Size = new System.Drawing.Size(430, 22);
            this.lblRatingDesc.Text = "Excellent!";
            this.lblRatingDesc.Name = "lblRatingDesc";

            // Comment
            this.lblCommentTitle.AutoSize = false;
            this.lblCommentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblCommentTitle.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblCommentTitle.Location = new System.Drawing.Point(30, 188);
            this.lblCommentTitle.Size = new System.Drawing.Size(430, 22);
            this.lblCommentTitle.Text = "Your Comment";

            this.txtComment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtComment.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtComment.Location = new System.Drawing.Point(30, 216);
            this.txtComment.Multiline = true;
            this.txtComment.Size = new System.Drawing.Size(430, 100);
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Error
            this.lblError.AutoSize = false;
            this.lblError.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 325);
            this.lblError.Size = new System.Drawing.Size(430, 20);
            this.lblError.Name = "lblError";
            this.lblError.Text = "";

            // Buttons
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(24, 95, 165);
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(30, 353);
            this.btnSubmit.Size = new System.Drawing.Size(200, 40);
            this.btnSubmit.Text = "Submit Review";
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);

            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(245, 353);
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);

            // WriteReview Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 520);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WriteReview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Write Review - NeedBridge";
            this.Load += new System.EventHandler(this.WriteReview_Load);
            this.panelTop.ResumeLayout(false);
            this.panelForm.ResumeLayout(false);
            this.panelForm.PerformLayout();
            this.panelStars.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Label lblProductInfo;
        private System.Windows.Forms.Label lblRatingTitle;
        private System.Windows.Forms.Panel panelStars;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb4;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.Label lblRatingDesc;
        private System.Windows.Forms.Label lblCommentTitle;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
    }
}