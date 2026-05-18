namespace NeedBridge
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelSummary = new System.Windows.Forms.Panel();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.lblOrderTotal = new System.Windows.Forms.Label();
            this.lblTotalValue = new System.Windows.Forms.Label();
            this.lblDeliveryTitle = new System.Windows.Forms.Label();
            this.txtDeliveryAddress = new System.Windows.Forms.TextBox();
            this.lblPaymentTitle = new System.Windows.Forms.Label();
            this.panelMethods = new System.Windows.Forms.Panel();
            this.rbBkash = new System.Windows.Forms.RadioButton();
            this.rbNagad = new System.Windows.Forms.RadioButton();
            this.rbRocket = new System.Windows.Forms.RadioButton();
            this.rbCard = new System.Windows.Forms.RadioButton();
            this.rbCOD = new System.Windows.Forms.RadioButton();
            this.panelPaymentDetails = new System.Windows.Forms.Panel();
            this.lblPaymentInstruction = new System.Windows.Forms.Label();
            this.txtPaymentRef = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panelTop.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.panelSummary.SuspendLayout();
            this.panelMethods.SuspendLayout();
            this.panelPaymentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.panelTop.Controls.Add(this.lblTitle);
            this.panelTop.Controls.Add(this.lblSubtitle);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(560, 93);
            this.panelTop.TabIndex = 1;
            this.panelTop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTop_Paint);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(20, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 51);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Complete Your Payment";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(26, 61);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(500, 20);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Choose your payment method and confirm";
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelSummary);
            this.panelContent.Controls.Add(this.lblDeliveryTitle);
            this.panelContent.Controls.Add(this.txtDeliveryAddress);
            this.panelContent.Controls.Add(this.lblPaymentTitle);
            this.panelContent.Controls.Add(this.panelMethods);
            this.panelContent.Controls.Add(this.panelPaymentDetails);
            this.panelContent.Controls.Add(this.lblError);
            this.panelContent.Controls.Add(this.btnConfirm);
            this.panelContent.Controls.Add(this.btnCancel);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 93);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(560, 470);
            this.panelContent.TabIndex = 0;
            // 
            // panelSummary
            // 
            this.panelSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.panelSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelSummary.Controls.Add(this.lblSummaryTitle);
            this.panelSummary.Controls.Add(this.lblOrderTotal);
            this.panelSummary.Controls.Add(this.lblTotalValue);
            this.panelSummary.Location = new System.Drawing.Point(30, 15);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(490, 80);
            this.panelSummary.TabIndex = 0;
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(95)))), ((int)(((byte)(165)))));
            this.lblSummaryTitle.Location = new System.Drawing.Point(12, 10);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(300, 20);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Order Summary";
            // 
            // lblOrderTotal
            // 
            this.lblOrderTotal.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblOrderTotal.Location = new System.Drawing.Point(12, 40);
            this.lblOrderTotal.Name = "lblOrderTotal";
            this.lblOrderTotal.Size = new System.Drawing.Size(150, 20);
            this.lblOrderTotal.TabIndex = 1;
            this.lblOrderTotal.Text = "Total Amount:";
            // 
            // lblTotalValue
            // 
            this.lblTotalValue.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblTotalValue.Location = new System.Drawing.Point(174, 30);
            this.lblTotalValue.Name = "lblTotalValue";
            this.lblTotalValue.Size = new System.Drawing.Size(200, 48);
            this.lblTotalValue.TabIndex = 2;
            this.lblTotalValue.Text = "৳0";
            this.lblTotalValue.Click += new System.EventHandler(this.lblTotalValue_Click);
            // 
            // lblDeliveryTitle
            // 
            this.lblDeliveryTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDeliveryTitle.Location = new System.Drawing.Point(30, 110);
            this.lblDeliveryTitle.Name = "lblDeliveryTitle";
            this.lblDeliveryTitle.Size = new System.Drawing.Size(300, 20);
            this.lblDeliveryTitle.TabIndex = 1;
            this.lblDeliveryTitle.Text = "Delivery Address *";
            // 
            // txtDeliveryAddress
            // 
            this.txtDeliveryAddress.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtDeliveryAddress.Location = new System.Drawing.Point(30, 135);
            this.txtDeliveryAddress.Name = "txtDeliveryAddress";
            this.txtDeliveryAddress.Size = new System.Drawing.Size(490, 30);
            this.txtDeliveryAddress.TabIndex = 2;
            // 
            // lblPaymentTitle
            // 
            this.lblPaymentTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPaymentTitle.Location = new System.Drawing.Point(30, 180);
            this.lblPaymentTitle.Name = "lblPaymentTitle";
            this.lblPaymentTitle.Size = new System.Drawing.Size(300, 20);
            this.lblPaymentTitle.TabIndex = 3;
            this.lblPaymentTitle.Text = "Select Payment Method *";
            // 
            // panelMethods
            // 
            this.panelMethods.Controls.Add(this.rbBkash);
            this.panelMethods.Controls.Add(this.rbNagad);
            this.panelMethods.Controls.Add(this.rbRocket);
            this.panelMethods.Controls.Add(this.rbCard);
            this.panelMethods.Controls.Add(this.rbCOD);
            this.panelMethods.Location = new System.Drawing.Point(30, 205);
            this.panelMethods.Name = "panelMethods";
            this.panelMethods.Size = new System.Drawing.Size(490, 55);
            this.panelMethods.TabIndex = 4;
            // 
            // rbBkash
            // 
            this.rbBkash.Checked = true;
            this.rbBkash.Location = new System.Drawing.Point(0, 10);
            this.rbBkash.Name = "rbBkash";
            this.rbBkash.Size = new System.Drawing.Size(90, 30);
            this.rbBkash.TabIndex = 0;
            this.rbBkash.TabStop = true;
            this.rbBkash.Text = "bKash";
            this.rbBkash.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // rbNagad
            // 
            this.rbNagad.Location = new System.Drawing.Point(95, 10);
            this.rbNagad.Name = "rbNagad";
            this.rbNagad.Size = new System.Drawing.Size(90, 30);
            this.rbNagad.TabIndex = 1;
            this.rbNagad.Text = "Nagad";
            this.rbNagad.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // rbRocket
            // 
            this.rbRocket.Location = new System.Drawing.Point(190, 10);
            this.rbRocket.Name = "rbRocket";
            this.rbRocket.Size = new System.Drawing.Size(90, 30);
            this.rbRocket.TabIndex = 2;
            this.rbRocket.Text = "Rocket";
            this.rbRocket.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // rbCard
            // 
            this.rbCard.Location = new System.Drawing.Point(285, 10);
            this.rbCard.Name = "rbCard";
            this.rbCard.Size = new System.Drawing.Size(90, 30);
            this.rbCard.TabIndex = 3;
            this.rbCard.Text = "Card";
            this.rbCard.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // rbCOD
            // 
            this.rbCOD.Location = new System.Drawing.Point(380, 10);
            this.rbCOD.Name = "rbCOD";
            this.rbCOD.Size = new System.Drawing.Size(90, 30);
            this.rbCOD.TabIndex = 4;
            this.rbCOD.Text = "COD";
            this.rbCOD.CheckedChanged += new System.EventHandler(this.PaymentMethod_Changed);
            // 
            // panelPaymentDetails
            // 
            this.panelPaymentDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPaymentDetails.Controls.Add(this.lblPaymentInstruction);
            this.panelPaymentDetails.Controls.Add(this.txtPaymentRef);
            this.panelPaymentDetails.Location = new System.Drawing.Point(30, 275);
            this.panelPaymentDetails.Name = "panelPaymentDetails";
            this.panelPaymentDetails.Size = new System.Drawing.Size(490, 80);
            this.panelPaymentDetails.TabIndex = 5;
            // 
            // lblPaymentInstruction
            // 
            this.lblPaymentInstruction.Location = new System.Drawing.Point(10, 10);
            this.lblPaymentInstruction.Name = "lblPaymentInstruction";
            this.lblPaymentInstruction.Size = new System.Drawing.Size(450, 20);
            this.lblPaymentInstruction.TabIndex = 0;
            this.lblPaymentInstruction.Text = "Enter payment reference";
            // 
            // txtPaymentRef
            // 
            this.txtPaymentRef.Location = new System.Drawing.Point(10, 35);
            this.txtPaymentRef.Name = "txtPaymentRef";
            this.txtPaymentRef.Size = new System.Drawing.Size(460, 22);
            this.txtPaymentRef.TabIndex = 1;
            // 
            // lblError
            // 
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(30, 360);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(400, 20);
            this.lblError.TabIndex = 6;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(30, 390);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(220, 45);
            this.btnConfirm.TabIndex = 7;
            this.btnConfirm.Text = "Confirm Order";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(270, 390);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // PaymentForm
            // 
            this.ClientSize = new System.Drawing.Size(560, 563);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.panelTop);
            this.Name = "PaymentForm";
            this.Text = "Payment";
            this.panelTop.ResumeLayout(false);
            this.panelContent.ResumeLayout(false);
            this.panelContent.PerformLayout();
            this.panelSummary.ResumeLayout(false);
            this.panelMethods.ResumeLayout(false);
            this.panelPaymentDetails.ResumeLayout(false);
            this.panelPaymentDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;

        private System.Windows.Forms.Panel panelContent;

        private System.Windows.Forms.Panel panelSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Label lblOrderTotal;
        private System.Windows.Forms.Label lblTotalValue;

        private System.Windows.Forms.Label lblDeliveryTitle;
        private System.Windows.Forms.TextBox txtDeliveryAddress;

        private System.Windows.Forms.Label lblPaymentTitle;

        private System.Windows.Forms.Panel panelMethods;

        private System.Windows.Forms.RadioButton rbBkash;
        private System.Windows.Forms.RadioButton rbNagad;
        private System.Windows.Forms.RadioButton rbRocket;
        private System.Windows.Forms.RadioButton rbCard;
        private System.Windows.Forms.RadioButton rbCOD;

        private System.Windows.Forms.Panel panelPaymentDetails;
        private System.Windows.Forms.Label lblPaymentInstruction;
        private System.Windows.Forms.TextBox txtPaymentRef;

        private System.Windows.Forms.Label lblError;

        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Button btnCancel;
    }
}