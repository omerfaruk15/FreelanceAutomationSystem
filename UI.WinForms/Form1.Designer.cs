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
            dgvProjects = new DataGridView();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtExpertise = new TextBox();
            btnEmployeeSave = new Button();
            dgvEmployees = new DataGridView();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnEmployeeUpdate = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tabPage2 = new TabPage();
            btnUpdateTask = new Button();
            btnDeleteTask = new Button();
            dgvTasks = new DataGridView();
            btnAssignTask = new Button();
            cmbTaskType = new ComboBox();
            txtWorkedHours = new TextBox();
            txtHourlyRate = new TextBox();
            txtTaskTitle = new TextBox();
            cmbEmployees = new ComboBox();
            cmbProjects = new ComboBox();
            btnEmployeeDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "Proje Adı:";
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(144, 6);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(250, 27);
            txtProjectName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 60);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Başlangıç Tarihi:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(144, 55);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(250, 27);
            dtpStartDate.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 110);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 4;
            label3.Text = "Bütçe:";
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(144, 103);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(250, 27);
            txtBudget.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 409);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Proje Kayıt";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgvProjects
            // 
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.Location = new Point(10, 147);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(323, 239);
            dgvProjects.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(557, 6);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(250, 27);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(557, 57);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(250, 27);
            txtLastName.TabIndex = 9;
            // 
            // txtExpertise
            // 
            txtExpertise.Location = new Point(557, 107);
            txtExpertise.Name = "txtExpertise";
            txtExpertise.Size = new Size(250, 27);
            txtExpertise.TabIndex = 10;
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.Location = new Point(485, 409);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(131, 37);
            btnEmployeeSave.TabIndex = 11;
            btnEmployeeSave.Text = "Personel Kayıt";
            btnEmployeeSave.UseVisualStyleBackColor = true;
            btnEmployeeSave.Click += btnEmployeeSave_Click;
            // 
            // dgvEmployees
            // 
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Location = new Point(485, 147);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(332, 239);
            dgvEmployees.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(485, 16);
            label4.Name = "label4";
            label4.Size = new Size(36, 20);
            label4.TabIndex = 13;
            label4.Text = "İsim";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(485, 62);
            label5.Name = "label5";
            label5.Size = new Size(60, 20);
            label5.TabIndex = 14;
            label5.Text = "Soyisim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(485, 114);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 15;
            label6.Text = "Uzmanlık";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1129, 588);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnEmployeeDelete);
            tabPage1.Controls.Add(btnEmployeeUpdate);
            tabPage1.Controls.Add(btnUpdate);
            tabPage1.Controls.Add(btnDelete);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(btnEmployeeSave);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(btnSave);
            tabPage1.Controls.Add(dgvProjects);
            tabPage1.Controls.Add(txtFirstName);
            tabPage1.Controls.Add(txtLastName);
            tabPage1.Controls.Add(txtBudget);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtExpertise);
            tabPage1.Controls.Add(dtpStartDate);
            tabPage1.Controls.Add(dgvEmployees);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(txtProjectName);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1121, 555);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.Location = new Point(644, 413);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(94, 29);
            btnEmployeeUpdate.TabIndex = 18;
            btnEmployeeUpdate.Text = "Güncelle";
            btnEmployeeUpdate.UseVisualStyleBackColor = true;
            btnEmployeeUpdate.Click += btnEmployeeUpdate_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(255, 410);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(144, 411);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnUpdateTask);
            tabPage2.Controls.Add(btnDeleteTask);
            tabPage2.Controls.Add(dgvTasks);
            tabPage2.Controls.Add(btnAssignTask);
            tabPage2.Controls.Add(cmbTaskType);
            tabPage2.Controls.Add(txtWorkedHours);
            tabPage2.Controls.Add(txtHourlyRate);
            tabPage2.Controls.Add(txtTaskTitle);
            tabPage2.Controls.Add(cmbEmployees);
            tabPage2.Controls.Add(cmbProjects);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1121, 555);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnUpdateTask
            // 
            btnUpdateTask.Location = new Point(484, 291);
            btnUpdateTask.Name = "btnUpdateTask";
            btnUpdateTask.Size = new Size(94, 29);
            btnUpdateTask.TabIndex = 15;
            btnUpdateTask.Text = "Güncelle";
            btnUpdateTask.UseVisualStyleBackColor = true;
            btnUpdateTask.Click += btnUpdateTask_Click;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.Location = new Point(362, 290);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(94, 29);
            btnDeleteTask.TabIndex = 14;
            btnDeleteTask.Text = "Sil";
            btnDeleteTask.UseVisualStyleBackColor = true;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // dgvTasks
            // 
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.Location = new Point(202, 65);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(510, 188);
            dgvTasks.TabIndex = 11;
            // 
            // btnAssignTask
            // 
            btnAssignTask.Location = new Point(232, 290);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(94, 29);
            btnAssignTask.TabIndex = 10;
            btnAssignTask.Text = "Görev Ata";
            btnAssignTask.UseVisualStyleBackColor = true;
            btnAssignTask.Click += btnAssignTask_Click;
            // 
            // cmbTaskType
            // 
            cmbTaskType.FormattingEnabled = true;
            cmbTaskType.Location = new Point(8, 291);
            cmbTaskType.Name = "cmbTaskType";
            cmbTaskType.Size = new Size(151, 28);
            cmbTaskType.TabIndex = 5;
            // 
            // txtWorkedHours
            // 
            txtWorkedHours.Location = new Point(32, 237);
            txtWorkedHours.Name = "txtWorkedHours";
            txtWorkedHours.Size = new Size(125, 27);
            txtWorkedHours.TabIndex = 4;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(34, 179);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(125, 27);
            txtHourlyRate.TabIndex = 3;
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(34, 120);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(125, 27);
            txtTaskTitle.TabIndex = 2;
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(8, 65);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(151, 28);
            cmbEmployees.TabIndex = 1;
            // 
            // cmbProjects
            // 
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(6, 21);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(151, 28);
            cmbProjects.TabIndex = 0;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.Location = new Point(765, 413);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(94, 29);
            btnEmployeeDelete.TabIndex = 19;
            btnEmployeeDelete.Text = "Sil";
            btnEmployeeDelete.UseVisualStyleBackColor = true;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1129, 588);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProjectName;
        private Label label2;
        private DateTimePicker dtpStartDate;
        private Label label3;
        private TextBox txtBudget;
        private Button btnSave;
        private DataGridView dgvProjects;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtExpertise;
        private Button btnEmployeeSave;
        private DataGridView dgvEmployees;
        private Label label4;
        private Label label5;
        private Label label6;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ComboBox cmbProjects;
        private ComboBox cmbTaskType;
        private TextBox txtWorkedHours;
        private TextBox txtHourlyRate;
        private TextBox txtTaskTitle;
        private ComboBox cmbEmployees;
        private Button btnAssignTask;
        private DataGridView dgvTasks;
        private Button btnDeleteTask;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnEmployeeUpdate;
        private Button btnUpdateTask;
        private Button btnEmployeeDelete;
    }
}
