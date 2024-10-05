namespace PhumlaKamnandi
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
            this.label1 = new System.Windows.Forms.Label();
            this.Welcome = new System.Windows.Forms.Label();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.makeBookingBtn = new System.Windows.Forms.Button();
            this.changeBookingBtn = new System.Windows.Forms.Button();
            this.cancelBookingBtn = new System.Windows.Forms.Button();
            this.enquireBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 42);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome To";
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(80, 64);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(756, 73);
            this.Welcome.TabIndex = 3;
            this.Welcome.Text = "Phumla Kamnandi Hotels";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationButton.Location = new System.Drawing.Point(31, 215);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(169, 38);
            this.ReservationButton.TabIndex = 4;
            this.ReservationButton.Text = "Reservations";
            this.ReservationButton.UseVisualStyleBackColor = false;
            this.ReservationButton.Click += new System.EventHandler(this.ReservationButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(263, 215);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(169, 38);
            this.ReportButton.TabIndex = 5;
            this.ReportButton.Text = "View Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInButton.Location = new System.Drawing.Point(488, 215);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(169, 38);
            this.CheckInButton.TabIndex = 6;
            this.CheckInButton.Text = "Check-In";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(719, 215);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(169, 38);
            this.CheckOutButton.TabIndex = 10;
            this.CheckOutButton.Text = "Check-Out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // makeBookingBtn
            // 
            this.makeBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeBookingBtn.Location = new System.Drawing.Point(488, 383);
            this.makeBookingBtn.Name = "makeBookingBtn";
            this.makeBookingBtn.Size = new System.Drawing.Size(143, 38);
            this.makeBookingBtn.TabIndex = 11;
            this.makeBookingBtn.Text = "Make Booking";
            this.makeBookingBtn.UseVisualStyleBackColor = true;
            this.makeBookingBtn.Click += new System.EventHandler(this.makeBookingBtn_Click);
            // 
            // changeBookingBtn
            // 
            this.changeBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBookingBtn.Location = new System.Drawing.Point(93, 384);
            this.changeBookingBtn.Name = "changeBookingBtn";
            this.changeBookingBtn.Size = new System.Drawing.Size(124, 37);
            this.changeBookingBtn.TabIndex = 12;
            this.changeBookingBtn.Text = "Change Booking";
            this.changeBookingBtn.UseVisualStyleBackColor = true;
            this.changeBookingBtn.Click += new System.EventHandler(this.changeBookingBtn_Click);
            // 
            // cancelBookingBtn
            // 
            this.cancelBookingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBookingBtn.Location = new System.Drawing.Point(284, 384);
            this.cancelBookingBtn.Name = "cancelBookingBtn";
            this.cancelBookingBtn.Size = new System.Drawing.Size(125, 37);
            this.cancelBookingBtn.TabIndex = 13;
            this.cancelBookingBtn.Text = "Cancel Booking";
            this.cancelBookingBtn.UseVisualStyleBackColor = true;
            this.cancelBookingBtn.Click += new System.EventHandler(this.cancelBookingBtn_Click);
            // 
            // enquireBtn
            // 
            this.enquireBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enquireBtn.Location = new System.Drawing.Point(691, 383);
            this.enquireBtn.Name = "enquireBtn";
            this.enquireBtn.Size = new System.Drawing.Size(130, 38);
            this.enquireBtn.TabIndex = 14;
            this.enquireBtn.Text = "Enquire Booking";
            this.enquireBtn.UseVisualStyleBackColor = true;
            this.enquireBtn.Click += new System.EventHandler(this.enquireBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhumlaKamnandi.Properties.Resources.manuel_moreno_DGa0LQ0yDPc_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(936, 479);
            this.Controls.Add(this.enquireBtn);
            this.Controls.Add(this.cancelBookingBtn);
            this.Controls.Add(this.changeBookingBtn);
            this.Controls.Add(this.makeBookingBtn);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Button makeBookingBtn;
        private System.Windows.Forms.Button changeBookingBtn;
        private System.Windows.Forms.Button cancelBookingBtn;
        private System.Windows.Forms.Button enquireBtn;
    }
}

