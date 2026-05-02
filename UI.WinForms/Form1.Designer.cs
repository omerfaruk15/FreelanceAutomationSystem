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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            groupBox4 = new GroupBox();
            lblAnalizMaliyet = new Label();
            lblAnalizYazilim = new Label();
            lblAnalizButce = new Label();
            lblAnalizProje = new Label();
            groupBox3 = new GroupBox();
            dgvTasks = new DataGridView();
            btnDeleteTask = new Button();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            btnAssignTask = new Button();
            cmbProjects = new ComboBox();
            cmbEmployees = new ComboBox();
            cmbTaskType = new ComboBox();
            label12 = new Label();
            txtTaskTitle = new TextBox();
            txtWorkedHours = new TextBox();
            txtHourlyRate = new TextBox();
            groupBox2 = new GroupBox();
            label21 = new Label();
            dgvEmployees = new DataGridView();
            label10 = new Label();
            label11 = new Label();
            txtExpertise = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnEmployeeDelete = new Button();
            btnEmployeeSave = new Button();
            btnEmployeeUpdate = new Button();
            groupBox1 = new GroupBox();
            label19 = new Label();
            label18 = new Label();
            label7 = new Label();
            dgvProjects = new DataGridView();
            txtBudget = new TextBox();
            dtpStartDate = new DateTimePicker();
            txtProjectName = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnSave = new Button();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            lblAnalizTasarim = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1455, 1041);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox4);
            tabPage1.Controls.Add(groupBox3);
            tabPage1.Controls.Add(groupBox2);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1447, 1005);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Yönetim Paneli";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            groupBox4.BackColor = Color.Azure;
            groupBox4.Controls.Add(lblAnalizTasarim);
            groupBox4.Controls.Add(lblAnalizMaliyet);
            groupBox4.Controls.Add(lblAnalizYazilim);
            groupBox4.Controls.Add(lblAnalizButce);
            groupBox4.Controls.Add(lblAnalizProje);
            groupBox4.Location = new Point(1053, 10);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(385, 498);
            groupBox4.TabIndex = 35;
            groupBox4.TabStop = false;
            groupBox4.Text = "Analiz Bölümü";
            // 
            // lblAnalizMaliyet
            // 
            lblAnalizMaliyet.AutoSize = true;
            lblAnalizMaliyet.Location = new Point(25, 370);
            lblAnalizMaliyet.Name = "lblAnalizMaliyet";
            lblAnalizMaliyet.Size = new Size(22, 23);
            lblAnalizMaliyet.TabIndex = 3;
            lblAnalizMaliyet.Text = "...";
            // 
            // lblAnalizYazilim
            // 
            lblAnalizYazilim.AutoSize = true;
            lblAnalizYazilim.Location = new Point(25, 281);
            lblAnalizYazilim.Name = "lblAnalizYazilim";
            lblAnalizYazilim.Size = new Size(22, 23);
            lblAnalizYazilim.TabIndex = 2;
            lblAnalizYazilim.Text = "...";
            // 
            // lblAnalizButce
            // 
            lblAnalizButce.AutoSize = true;
            lblAnalizButce.Location = new Point(25, 167);
            lblAnalizButce.Name = "lblAnalizButce";
            lblAnalizButce.Size = new Size(22, 23);
            lblAnalizButce.TabIndex = 1;
            lblAnalizButce.Text = "...";
            // 
            // lblAnalizProje
            // 
            lblAnalizProje.AutoSize = true;
            lblAnalizProje.Location = new Point(25, 61);
            lblAnalizProje.Name = "lblAnalizProje";
            lblAnalizProje.Size = new Size(22, 23);
            lblAnalizProje.TabIndex = 0;
            lblAnalizProje.Text = "...";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Azure;
            groupBox3.Controls.Add(dgvTasks);
            groupBox3.Controls.Add(btnDeleteTask);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(btnAssignTask);
            groupBox3.Controls.Add(cmbProjects);
            groupBox3.Controls.Add(cmbEmployees);
            groupBox3.Controls.Add(cmbTaskType);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(txtTaskTitle);
            groupBox3.Controls.Add(txtWorkedHours);
            groupBox3.Controls.Add(txtHourlyRate);
            groupBox3.Location = new Point(6, 564);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1437, 384);
            groupBox3.TabIndex = 34;
            groupBox3.TabStop = false;
            groupBox3.Text = "Görev Atama";
            // 
            // dgvTasks
            // 
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.BackgroundColor = Color.White;
            dgvTasks.BorderStyle = BorderStyle.None;
            dgvTasks.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.MidnightBlue;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTasks.EnableHeadersVisualStyles = false;
            dgvTasks.Location = new Point(492, 30);
            dgvTasks.Name = "dgvTasks";
            dgvTasks.RowHeadersVisible = false;
            dgvTasks.RowHeadersWidth = 51;
            dgvTasks.Size = new Size(943, 273);
            dgvTasks.TabIndex = 27;
            dgvTasks.CellClick += dgvTasks_CellClick;
            // 
            // btnDeleteTask
            // 
            btnDeleteTask.BackColor = Color.IndianRed;
            btnDeleteTask.FlatStyle = FlatStyle.Flat;
            btnDeleteTask.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDeleteTask.ForeColor = Color.White;
            btnDeleteTask.Location = new Point(798, 317);
            btnDeleteTask.Name = "btnDeleteTask";
            btnDeleteTask.Size = new Size(115, 43);
            btnDeleteTask.TabIndex = 28;
            btnDeleteTask.Text = "Sil";
            btnDeleteTask.UseVisualStyleBackColor = false;
            btnDeleteTask.Click += btnDeleteTask_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(18, 331);
            label13.Name = "label13";
            label13.Size = new Size(99, 23);
            label13.TabIndex = 24;
            label13.Text = "Görev Türü:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(18, 279);
            label14.Name = "label14";
            label14.Size = new Size(114, 23);
            label14.TabIndex = 25;
            label14.Text = "Çalışılan Saat:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 212);
            label15.Name = "label15";
            label15.Size = new Size(109, 23);
            label15.TabIndex = 26;
            label15.Text = "Saatlik Ücret:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(18, 152);
            label16.Name = "label16";
            label16.Size = new Size(108, 23);
            label16.TabIndex = 27;
            label16.Text = "Görev Başlığı";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(18, 84);
            label17.Name = "label17";
            label17.Size = new Size(108, 23);
            label17.TabIndex = 28;
            label17.Text = "Personel Adı:";
            // 
            // btnAssignTask
            // 
            btnAssignTask.BackColor = Color.MediumSeaGreen;
            btnAssignTask.FlatStyle = FlatStyle.Flat;
            btnAssignTask.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnAssignTask.ForeColor = Color.White;
            btnAssignTask.Location = new Point(610, 317);
            btnAssignTask.Name = "btnAssignTask";
            btnAssignTask.Size = new Size(133, 43);
            btnAssignTask.TabIndex = 26;
            btnAssignTask.Text = "Görev Ata";
            btnAssignTask.UseVisualStyleBackColor = false;
            btnAssignTask.Click += btnAssignTask_Click;
            // 
            // cmbProjects
            // 
            cmbProjects.FormattingEnabled = true;
            cmbProjects.Location = new Point(196, 30);
            cmbProjects.Name = "cmbProjects";
            cmbProjects.Size = new Size(169, 31);
            cmbProjects.TabIndex = 20;
            // 
            // cmbEmployees
            // 
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(196, 80);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(172, 31);
            cmbEmployees.TabIndex = 21;
            // 
            // cmbTaskType
            // 
            cmbTaskType.FormattingEnabled = true;
            cmbTaskType.Location = new Point(194, 327);
            cmbTaskType.Name = "cmbTaskType";
            cmbTaskType.Size = new Size(172, 31);
            cmbTaskType.TabIndex = 25;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(18, 33);
            label12.Name = "label12";
            label12.Size = new Size(83, 23);
            label12.TabIndex = 23;
            label12.Text = "Proje Adı:";
            // 
            // txtTaskTitle
            // 
            txtTaskTitle.Location = new Point(196, 144);
            txtTaskTitle.Name = "txtTaskTitle";
            txtTaskTitle.Size = new Size(172, 30);
            txtTaskTitle.TabIndex = 22;
            // 
            // txtWorkedHours
            // 
            txtWorkedHours.Location = new Point(196, 278);
            txtWorkedHours.Name = "txtWorkedHours";
            txtWorkedHours.Size = new Size(169, 30);
            txtWorkedHours.TabIndex = 24;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(196, 212);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(172, 30);
            txtHourlyRate.TabIndex = 23;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Azure;
            groupBox2.Controls.Add(label21);
            groupBox2.Controls.Add(dgvEmployees);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(txtExpertise);
            groupBox2.Controls.Add(txtLastName);
            groupBox2.Controls.Add(txtFirstName);
            groupBox2.Controls.Add(btnEmployeeDelete);
            groupBox2.Controls.Add(btnEmployeeSave);
            groupBox2.Controls.Add(btnEmployeeUpdate);
            groupBox2.Location = new Point(525, 10);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(521, 506);
            groupBox2.TabIndex = 33;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Yönetimi";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(18, 30);
            label21.Name = "label21";
            label21.Size = new Size(108, 23);
            label21.TabIndex = 31;
            label21.Text = "Personel Adı:";
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployees.BackgroundColor = Color.White;
            dgvEmployees.BorderStyle = BorderStyle.None;
            dgvEmployees.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.EnableHeadersVisualStyles = false;
            dgvEmployees.Location = new Point(18, 140);
            dgvEmployees.Name = "dgvEmployees";
            dgvEmployees.RowHeadersVisible = false;
            dgvEmployees.RowHeadersWidth = 51;
            dgvEmployees.Size = new Size(480, 275);
            dgvEmployees.TabIndex = 12;
            dgvEmployees.CellClick += dgvEmployees_CellClick;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(18, 87);
            label10.Name = "label10";
            label10.Size = new Size(127, 23);
            label10.TabIndex = 21;
            label10.Text = "Uzmanlık Alanı:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(18, 55);
            label11.Name = "label11";
            label11.Size = new Size(133, 23);
            label11.TabIndex = 22;
            label11.Text = "Personel Soyadı:";
            // 
            // txtExpertise
            // 
            txtExpertise.Location = new Point(179, 87);
            txtExpertise.Name = "txtExpertise";
            txtExpertise.Size = new Size(281, 30);
            txtExpertise.TabIndex = 10;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(179, 52);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(281, 30);
            txtLastName.TabIndex = 9;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(179, 12);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(281, 30);
            txtFirstName.TabIndex = 8;
            // 
            // btnEmployeeDelete
            // 
            btnEmployeeDelete.BackColor = Color.IndianRed;
            btnEmployeeDelete.FlatStyle = FlatStyle.Flat;
            btnEmployeeDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEmployeeDelete.ForeColor = Color.White;
            btnEmployeeDelete.Location = new Point(363, 428);
            btnEmployeeDelete.Name = "btnEmployeeDelete";
            btnEmployeeDelete.Size = new Size(115, 43);
            btnEmployeeDelete.TabIndex = 19;
            btnEmployeeDelete.Text = "Sil";
            btnEmployeeDelete.UseVisualStyleBackColor = false;
            btnEmployeeDelete.Click += btnEmployeeDelete_Click;
            // 
            // btnEmployeeSave
            // 
            btnEmployeeSave.BackColor = Color.MediumSeaGreen;
            btnEmployeeSave.FlatStyle = FlatStyle.Flat;
            btnEmployeeSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEmployeeSave.ForeColor = Color.White;
            btnEmployeeSave.Location = new Point(35, 428);
            btnEmployeeSave.Name = "btnEmployeeSave";
            btnEmployeeSave.Size = new Size(170, 43);
            btnEmployeeSave.TabIndex = 11;
            btnEmployeeSave.Text = "Personel Kayıt";
            btnEmployeeSave.UseVisualStyleBackColor = false;
            btnEmployeeSave.Click += btnEmployeeSave_Click;
            // 
            // btnEmployeeUpdate
            // 
            btnEmployeeUpdate.BackColor = Color.Goldenrod;
            btnEmployeeUpdate.FlatStyle = FlatStyle.Flat;
            btnEmployeeUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEmployeeUpdate.ForeColor = Color.White;
            btnEmployeeUpdate.Location = new Point(227, 428);
            btnEmployeeUpdate.Name = "btnEmployeeUpdate";
            btnEmployeeUpdate.Size = new Size(115, 43);
            btnEmployeeUpdate.TabIndex = 18;
            btnEmployeeUpdate.Text = "Güncelle";
            btnEmployeeUpdate.UseVisualStyleBackColor = false;
            btnEmployeeUpdate.Click += btnEmployeeUpdate_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Azure;
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dgvProjects);
            groupBox1.Controls.Add(txtBudget);
            groupBox1.Controls.Add(dtpStartDate);
            groupBox1.Controls.Add(txtProjectName);
            groupBox1.Controls.Add(btnUpdate);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnSave);
            groupBox1.ForeColor = SystemColors.ActiveCaptionText;
            groupBox1.Location = new Point(3, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(515, 506);
            groupBox1.TabIndex = 32;
            groupBox1.TabStop = false;
            groupBox1.Tag = "";
            groupBox1.Text = "Proje Yönetimi";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(9, 83);
            label19.Name = "label19";
            label19.Size = new Size(174, 23);
            label19.TabIndex = 30;
            label19.Text = "Proje Başlangıç Tarihi:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(9, 118);
            label18.Name = "label18";
            label18.Size = new Size(57, 23);
            label18.TabIndex = 29;
            label18.Text = "Bütçe:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 39);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 18;
            label7.Text = "Proje Adı:";
            // 
            // dgvProjects
            // 
            dgvProjects.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProjects.BackgroundColor = Color.White;
            dgvProjects.BorderStyle = BorderStyle.None;
            dgvProjects.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProjects.EnableHeadersVisualStyles = false;
            dgvProjects.Location = new Point(12, 153);
            dgvProjects.Name = "dgvProjects";
            dgvProjects.RowHeadersVisible = false;
            dgvProjects.RowHeadersWidth = 51;
            dgvProjects.Size = new Size(480, 275);
            dgvProjects.TabIndex = 7;
            dgvProjects.CellClick += dgvProjects_CellClick;
            // 
            // txtBudget
            // 
            txtBudget.Location = new Point(178, 115);
            txtBudget.Name = "txtBudget";
            txtBudget.Size = new Size(281, 30);
            txtBudget.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(178, 77);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(281, 30);
            dtpStartDate.TabIndex = 3;
            // 
            // txtProjectName
            // 
            txtProjectName.Location = new Point(178, 30);
            txtProjectName.Name = "txtProjectName";
            txtProjectName.Size = new Size(281, 30);
            txtProjectName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Goldenrod;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnUpdate.ForeColor = Color.White;
            btnUpdate.Location = new Point(228, 435);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(115, 43);
            btnUpdate.TabIndex = 17;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(369, 435);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 43);
            btnDelete.TabIndex = 16;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(56, 435);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(135, 43);
            btnSave.TabIndex = 6;
            btnSave.Text = "Proje Kayıt";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(546, 71);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(546, 131);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(546, 18);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 126);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 69);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 10);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // lblAnalizTasarim
            // 
            lblAnalizTasarim.AutoSize = true;
            lblAnalizTasarim.Location = new Point(25, 446);
            lblAnalizTasarim.Name = "lblAnalizTasarim";
            lblAnalizTasarim.Size = new Size(22, 23);
            lblAnalizTasarim.TabIndex = 4;
            lblAnalizTasarim.Text = "...";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1455, 1041);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProjects).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button btnDeleteTask;
        private DataGridView dgvTasks;
        private Button btnAssignTask;
        private ComboBox cmbTaskType;
        private TextBox txtWorkedHours;
        private TextBox txtHourlyRate;
        private TextBox txtTaskTitle;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtBudget;
        private TextBox txtExpertise;
        private TextBox txtProjectName;
        private ComboBox cmbEmployees;
        private ComboBox cmbProjects;
        private Button btnEmployeeDelete;
        private Button btnEmployeeUpdate;
        private Button btnUpdate;
        private Button btnDelete;
        private Label label5;
        private Button btnEmployeeSave;
        private Label label6;
        private Button btnSave;
        private DataGridView dgvProjects;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpStartDate;
        private DataGridView dgvEmployees;
        private Label label2;
        private Label label1;
        private Button button1;
        private GroupBox groupBox3;
        private GroupBox groupBox2;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private Label label17;
        private Label label12;
        private Label label19;
        private Label label18;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label11;
        private Label label10;
        private Label label7;
        private Label label21;
        private Label lblAnalizMaliyet;
        private Label lblAnalizYazilim;
        private Label lblAnalizButce;
        private Label lblAnalizProje;
        private Label lblAnalizTasarim;
    }
}
