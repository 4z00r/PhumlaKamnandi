namespace PhumlaKamnandi
{
    partial class Form2
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
            this.ReserveButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.CheckOutDate = new System.Windows.Forms.DateTimePicker();
            this.CheckInDate = new System.Windows.Forms.DateTimePicker();
            this.Above5Box = new System.Windows.Forms.TextBox();
            this.Below5Box = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.DepositBox = new System.Windows.Forms.TextBox();
            this.CostBox = new System.Windows.Forms.TextBox();
            this.AdultBox = new System.Windows.Forms.TextBox();
            this.RoomBox = new System.Windows.Forms.TextBox();
            this.CreditBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(931, 511);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(90, 41);
            this.ExitButton.TabIndex = 61;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // ReserveButton
            // 
            this.ReserveButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReserveButton.Location = new System.Drawing.Point(686, 511);
            this.ReserveButton.Name = "ReserveButton";
            this.ReserveButton.Size = new System.Drawing.Size(106, 41);
            this.ReserveButton.TabIndex = 60;
            this.ReserveButton.Text = "Reserve";
            this.ReserveButton.UseVisualStyleBackColor = true;
            this.ReserveButton.Click += new System.EventHandler(this.ReserveButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.Location = new System.Drawing.Point(814, 511);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(90, 41);
            this.CancelButton.TabIndex = 59;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SeasonBox
            // 
            this.SeasonBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Items.AddRange(new object[] {
            "Low-Season",
            "Mid-Season",
            "High-Season"});
            this.SeasonBox.Location = new System.Drawing.Point(331, 378);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(121, 32);
            this.SeasonBox.TabIndex = 58;
            this.SeasonBox.SelectedIndexChanged += new System.EventHandler(this.SeasonBox_SelectedIndexChanged);
            // 
            // CheckOutDate
            // 
            this.CheckOutDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDate.Location = new System.Drawing.Point(284, 523);
            this.CheckOutDate.Name = "CheckOutDate";
            this.CheckOutDate.Size = new System.Drawing.Size(334, 31);
            this.CheckOutDate.TabIndex = 57;
            this.CheckOutDate.ValueChanged += new System.EventHandler(this.CheckOutDate_ValueChanged);
            // 
            // CheckInDate
            // 
            this.CheckInDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDate.Location = new System.Drawing.Point(284, 466);
            this.CheckInDate.Name = "CheckInDate";
            this.CheckInDate.Size = new System.Drawing.Size(334, 31);
            this.CheckInDate.TabIndex = 56;
            this.CheckInDate.ValueChanged += new System.EventHandler(this.CheckInDate_ValueChanged);
            // 
            // Above5Box
            // 
            this.Above5Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Above5Box.Location = new System.Drawing.Point(953, 56);
            this.Above5Box.Name = "Above5Box";
            this.Above5Box.Size = new System.Drawing.Size(64, 31);
            this.Above5Box.TabIndex = 55;
            this.Above5Box.TextChanged += new System.EventHandler(this.Above5Box_TextChanged);
            // 
            // Below5Box
            // 
            this.Below5Box.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Below5Box.Location = new System.Drawing.Point(953, 121);
            this.Below5Box.Name = "Below5Box";
            this.Below5Box.Size = new System.Drawing.Size(64, 31);
            this.Below5Box.TabIndex = 54;
            this.Below5Box.TextChanged += new System.EventHandler(this.Below5Box_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(346, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(257, 31);
            this.textBox1.TabIndex = 53;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(346, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(237, 31);
            this.textBox2.TabIndex = 52;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // DepositBox
            // 
            this.DepositBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepositBox.Location = new System.Drawing.Point(865, 326);
            this.DepositBox.Name = "DepositBox";
            this.DepositBox.Size = new System.Drawing.Size(156, 31);
            this.DepositBox.TabIndex = 51;
            this.DepositBox.TextChanged += new System.EventHandler(this.DepositBox_TextChanged);
            // 
            // CostBox
            // 
            this.CostBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostBox.Location = new System.Drawing.Point(865, 383);
            this.CostBox.Name = "CostBox";
            this.CostBox.Size = new System.Drawing.Size(156, 31);
            this.CostBox.TabIndex = 50;
            this.CostBox.TextChanged += new System.EventHandler(this.CostBox_TextChanged);
            // 
            // AdultBox
            // 
            this.AdultBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdultBox.Location = new System.Drawing.Point(953, 251);
            this.AdultBox.Name = "AdultBox";
            this.AdultBox.Size = new System.Drawing.Size(64, 31);
            this.AdultBox.TabIndex = 49;
            this.AdultBox.TextChanged += new System.EventHandler(this.AdultBox_TextChanged);
            // 
            // RoomBox
            // 
            this.RoomBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBox.Location = new System.Drawing.Point(953, 188);
            this.RoomBox.Name = "RoomBox";
            this.RoomBox.Size = new System.Drawing.Size(64, 31);
            this.RoomBox.TabIndex = 48;
            this.RoomBox.TextChanged += new System.EventHandler(this.RoomBox_TextChanged);
            // 
            // CreditBox
            // 
            this.CreditBox.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditBox.Location = new System.Drawing.Point(164, 323);
            this.CreditBox.Name = "CreditBox";
            this.CreditBox.Size = new System.Drawing.Size(288, 31);
            this.CreditBox.TabIndex = 47;
            this.CreditBox.TextChanged += new System.EventHandler(this.CreditBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 524);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 24);
            this.label13.TabIndex = 46;
            this.label13.Text = "Check-Out";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(182, 468);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 24);
            this.label12.TabIndex = 45;
            this.label12.Text = "Check-In";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(168, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 24);
            this.label11.TabIndex = 44;
            this.label11.Text = "Seasonal Rate";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(346, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(257, 31);
            this.textBox3.TabIndex = 43;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(695, 388);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 24);
            this.label10.TabIndex = 42;
            this.label10.Text = "Remaining Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(765, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 24);
            this.label9.TabIndex = 41;
            this.label9.Text = "No. Of Adults";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(695, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(244, 24);
            this.label8.TabIndex = 40;
            this.label8.Text = "No. Of Children Above 5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 39;
            this.label2.Text = "Guest Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(158, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Guest Telephone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(765, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "No. Of Rooms";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(652, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(287, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "No. Of Children 5 And Below";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(168, 283);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(200, 24);
            this.label14.TabIndex = 35;
            this.label14.Text = "Credit Card Number";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(721, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 24);
            this.label15.TabIndex = 34;
            this.label15.Text = "10% Deposit";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(203, 68);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(126, 24);
            this.label16.TabIndex = 33;
            this.label16.Text = "Guest Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 610);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ReserveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SeasonBox);
            this.Controls.Add(this.CheckOutDate);
            this.Controls.Add(this.CheckInDate);
            this.Controls.Add(this.Above5Box);
            this.Controls.Add(this.Below5Box);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.DepositBox);
            this.Controls.Add(this.CostBox);
            this.Controls.Add(this.AdultBox);
            this.Controls.Add(this.RoomBox);
            this.Controls.Add(this.CreditBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.Button ReserveButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ComboBox SeasonBox;
        private System.Windows.Forms.DateTimePicker CheckOutDate;
        private System.Windows.Forms.DateTimePicker CheckInDate;
        private System.Windows.Forms.TextBox Above5Box;
        private System.Windows.Forms.TextBox Below5Box;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox DepositBox;
        private System.Windows.Forms.TextBox CostBox;
        private System.Windows.Forms.TextBox AdultBox;
        private System.Windows.Forms.TextBox RoomBox;
        private System.Windows.Forms.TextBox CreditBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}