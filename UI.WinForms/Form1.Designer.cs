namespace UI.WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtProjectName = new TextBox();
            label2 = new Label();
            dtpStartDate = new DateTimePicker();
            label3 = new Label();
            txtBudget = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(140, 95);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Proje Adı:";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(269, 96);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(125, 27);
            txtProjectName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(154, 152);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(366, 169);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(167, 233);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Bütçe:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(364, 222);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(125, 27);
            txtBudget.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(277, 293);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 6;
            btnSave.Text = "Proje Kayıt";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtBudget);
            Controls.Add(label3);
            Controls.Add(dtpStartDate);
            Controls.Add(label2);
            Controls.Add(txtProjectName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private Label label3;
        private TextBox txtBudget;
        private Button btnSave;
    }
}
