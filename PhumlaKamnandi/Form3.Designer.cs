namespace PhumlaKamnandi
{
    partial class Form3
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
            this.ExitButton = new System.Windows.Forms.Button();
            this.CheckInButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.CheckOutBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckInBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.RoomBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SignatureBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AuthorisationDropDown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(888, 460);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 41);
            this.ExitButton.TabIndex = 58;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // CheckInButton
            // 
            this.CheckInButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInButton.Location = new System.Drawing.Point(643, 460);
            this.CheckInButton.Name = "CheckInButton";
            this.CheckInButton.Size = new System.Drawing.Size(110, 41);
            this.CheckInButton.TabIndex = 57;
            this.CheckInButton.Text = "Check-In";
            this.CheckInButton.UseVisualStyleBackColor = true;
            this.CheckInButton.Click += new System.EventHandler(this.CheckInButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(772, 460);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 41);
            this.CancelButton.TabIndex = 56;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // CheckOutBox
            // 
            this.CheckOutBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutBox.Location = new System.Drawing.Point(438, 463);
            this.CheckOutBox.Name = "CheckOutBox";
            this.CheckOutBox.Size = new System.Drawing.Size(139, 31);
            this.CheckOutBox.TabIndex = 55;
            this.CheckOutBox.TextChanged += new System.EventHandler(this.CheckOutBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 466);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 24);
            this.label6.TabIndex = 54;
            this.label6.Text = "Booking Check-Out";
            // 
            // CheckInBox
            // 
            this.CheckInBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInBox.Location = new System.Drawing.Point(438, 406);
            this.CheckInBox.Name = "CheckInBox";
            this.CheckInBox.Size = new System.Drawing.Size(139, 31);
            this.CheckInBox.TabIndex = 53;
            this.CheckInBox.TextChanged += new System.EventHandler(this.CheckInBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(178, 409);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 24);
            this.label5.TabIndex = 52;
            this.label5.Text = "Booking Check-in";
            // 
            // RoomBox
            // 
            this.RoomBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBox.Location = new System.Drawing.Point(438, 347);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(139, 31);
            this.RoomBox.TabIndex = 51;
            this.RoomBox.TextChanged += new System.EventHandler(this.RoomBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Room Number/s";
            // 
            // SignatureBox
            // 
            this.SignatureBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignatureBox.Location = new System.Drawing.Point(438, 236);
            this.SignatureBox.Name = "SignatureBox";
            this.SignatureBox.Size = new System.Drawing.Size(139, 31);
            this.SignatureBox.TabIndex = 49;
            this.SignatureBox.TextChanged += new System.EventHandler(this.SignatureBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(247, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 24);
            this.label3.TabIndex = 48;
            this.label3.Text = "Signature";
            // 
            // AuthorisationDropDown
            // 
            this.AuthorisationDropDown.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthorisationDropDown.FormattingEnabled = true;
            this.AuthorisationDropDown.Items.AddRange(new object[] {
            "Approved",
            "Denied"});
            this.AuthorisationDropDown.Location = new System.Drawing.Point(438, 173);
            this.AuthorisationDropDown.Name = "AuthorisationDropDown";
            this.AuthorisationDropDown.Size = new System.Drawing.Size(162, 32);
            this.AuthorisationDropDown.TabIndex = 47;
            this.AuthorisationDropDown.SelectedIndexChanged += new System.EventHandler(this.AuthorisationDropDown_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(253, 24);
            this.label2.TabIndex = 46;
            this.label2.Text = "Credit Card Authorisation";
            // 
            // NameDropDown
            // 
            this.NameDropDown.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameDropDown.FormattingEnabled = true;
            this.NameDropDown.Location = new System.Drawing.Point(438, 107);
            this.NameDropDown.Name = "NameDropDown";
            this.NameDropDown.Size = new System.Drawing.Size(257, 32);
            this.NameDropDown.TabIndex = 45;
            this.NameDropDown.SelectedIndexChanged += new System.EventHandler(this.NameDropDown_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 24);
            this.label1.TabIndex = 44;
            this.label1.Text = "Guest Name";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 608);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.CheckInButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CheckOutBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckInBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SignatureBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AuthorisationDropDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameDropDown);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button CheckInButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox CheckOutBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox CheckInBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox RoomBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox SignatureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox AuthorisationDropDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NameDropDown;
        private System.Windows.Forms.Label label1;
    }
}