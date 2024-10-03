namespace PhumlaKamnandi
{
    partial class Form6
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.Generate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ReportTable = new System.Windows.Forms.ListBox();
            this.Date2 = new System.Windows.Forms.DateTimePicker();
            this.Date1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SeasonBox = new System.Windows.Forms.ComboBox();
            this.Generate1 = new System.Windows.Forms.Button();
            this.ReportTable1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 438);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::PhumlaKamnandi.Properties.Resources.marten_bjork_n_IKQDCyrG0_unsplash;
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.Generate);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ReportTable);
            this.tabPage1.Controls.Add(this.Date2);
            this.tabPage1.Controls.Add(this.Date1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(220, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date specific occupency report";
            // 
            // Generate
            // 
            this.Generate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate.Location = new System.Drawing.Point(495, 65);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(88, 35);
            this.Generate.TabIndex = 4;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(179, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // ReportTable
            // 
            this.ReportTable.FormattingEnabled = true;
            this.ReportTable.Location = new System.Drawing.Point(160, 127);
            this.ReportTable.Name = "ReportTable";
            this.ReportTable.Size = new System.Drawing.Size(444, 277);
            this.ReportTable.TabIndex = 5;
            // 
            // Date2
            // 
            this.Date2.Location = new System.Drawing.Point(268, 92);
            this.Date2.Name = "Date2";
            this.Date2.Size = new System.Drawing.Size(200, 20);
            this.Date2.TabIndex = 2;
            // 
            // Date1
            // 
            this.Date1.Location = new System.Drawing.Point(268, 54);
            this.Date1.Name = "Date1";
            this.Date1.Size = new System.Drawing.Size(200, 20);
            this.Date1.TabIndex = 0;
            this.Date1.ValueChanged += new System.EventHandler(this.Date1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(179, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Start Date";
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::PhumlaKamnandi.Properties.Resources.marten_bjork_n_IKQDCyrG0_unsplash;
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.SeasonBox);
            this.tabPage2.Controls.Add(this.Generate1);
            this.tabPage2.Controls.Add(this.ReportTable1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(172, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Season";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(224, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seasonal occupency report";
            // 
            // SeasonBox
            // 
            this.SeasonBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeasonBox.FormattingEnabled = true;
            this.SeasonBox.Location = new System.Drawing.Point(251, 58);
            this.SeasonBox.Name = "SeasonBox";
            this.SeasonBox.Size = new System.Drawing.Size(212, 28);
            this.SeasonBox.TabIndex = 8;
            // 
            // Generate1
            // 
            this.Generate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate1.Location = new System.Drawing.Point(502, 54);
            this.Generate1.Name = "Generate1";
            this.Generate1.Size = new System.Drawing.Size(88, 35);
            this.Generate1.TabIndex = 6;
            this.Generate1.Text = "Generate";
            this.Generate1.UseVisualStyleBackColor = true;
            this.Generate1.Click += new System.EventHandler(this.Generate1_Click);
            // 
            // ReportTable1
            // 
            this.ReportTable1.FormattingEnabled = true;
            this.ReportTable1.Location = new System.Drawing.Point(146, 102);
            this.ReportTable1.Name = "ReportTable1";
            this.ReportTable1.Size = new System.Drawing.Size(444, 277);
            this.ReportTable1.TabIndex = 7;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PhumlaKamnandi.Properties.Resources.marten_bjork_n_IKQDCyrG0_unsplash;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ReportTable;
        private System.Windows.Forms.DateTimePicker Date2;
        private System.Windows.Forms.DateTimePicker Date1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox SeasonBox;
        private System.Windows.Forms.Button Generate1;
        private System.Windows.Forms.ListBox ReportTable1;
    }
}