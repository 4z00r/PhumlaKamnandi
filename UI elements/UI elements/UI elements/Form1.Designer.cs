namespace UI_elements
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
            this.Welcome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ReservationButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.ReportButton = new System.Windows.Forms.Button();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Welcome.Font = new System.Drawing.Font("Monotype Corsiva", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Location = new System.Drawing.Point(80, 44);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(620, 79);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Phumla Kamnandi Hotels";
            this.Welcome.Click += new System.EventHandler(this.Welcome_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(306, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome To";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReservationButton
            // 
            this.ReservationButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ReservationButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReservationButton.Location = new System.Drawing.Point(166, 175);
            this.ReservationButton.Name = "ReservationButton";
            this.ReservationButton.Size = new System.Drawing.Size(169, 38);
            this.ReservationButton.TabIndex = 2;
            this.ReservationButton.Text = "Reservations";
            this.ReservationButton.UseVisualStyleBackColor = false;
            this.ReservationButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckInButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInButton.Location = new System.Drawing.Point(166, 292);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(169, 38);
            this.CheckInButton.TabIndex = 3;
            this.CheckInButton.Text = "Check-In";
            this.CheckInButton.UseVisualStyleBackColor = false;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // ReportButton
            // 
            this.ReportButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportButton.Location = new System.Drawing.Point(457, 175);
            this.ReportButton.Name = "ReportButton";
            this.ReportButton.Size = new System.Drawing.Size(169, 38);
            this.ReportButton.TabIndex = 4;
            this.ReportButton.Text = "View Reports";
            this.ReportButton.UseVisualStyleBackColor = true;
            this.ReportButton.Click += new System.EventHandler(this.ReportButton_Click);
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckOutButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutButton.Location = new System.Drawing.Point(457, 292);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(169, 38);
            this.CheckOutButton.TabIndex = 9;
            this.CheckOutButton.Text = "Check-Out";
            this.CheckOutButton.UseVisualStyleBackColor = false;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::UI_elements.Properties.Resources.manuel_moreno_DGa0LQ0yDPc_unsplash1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.ReportButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.ReservationButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Welcome);
            this.Name = "Form1";
            this.Text = "Main Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReservationButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button ReportButton;
        private System.Windows.Forms.Button CheckOutButton;
    }
}

