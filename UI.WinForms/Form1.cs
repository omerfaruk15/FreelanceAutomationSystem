using Core.Entities;
using DataAccess;
using Microsoft.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veritabanına bağlanırken bir sorun oluştu: " + ex.Message, "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshAllData()
        {
            try
            {
                ListProjects();
                ListEmployees();
                ListTasks();
                FillComboBoxes();
                UpdateAnalysis();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #region Proje İşlemleri
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    MessageBox.Show("Lütfen proje adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Project newProject = new Project { ProjectName = txtProjectName.Text.Trim(), StartDate = dtpStartDate.Value };
                decimal.TryParse(txtBudget.Text, out decimal budget);
                newProject.Budget = budget;

                new ProjectDal().Add(newProject);
                MessageBox.Show("Proje başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListProjects()
        {
            dgvProjects.DataSource = null;
            dgvProjects.DataSource = new ProjectDal().GetAll();

            if (dgvProjects.Columns.Count > 0)
            {
                if (dgvProjects.Columns["ProjectID"] != null) dgvProjects.Columns["ProjectID"].Visible = false;
                if (dgvProjects.Columns["Gorevler"] != null) dgvProjects.Columns["Gorevler"].Visible = false;
                if (dgvProjects.Columns["IsCompleted"] != null) dgvProjects.Columns["IsCompleted"].Visible = false; 
                if (dgvProjects.Columns["Expenses"] != null) dgvProjects.Columns["Expenses"].Visible = false;      

                if (dgvProjects.Columns["ProjectName"] != null) dgvProjects.Columns["ProjectName"].HeaderText = "Proje Adı";
                if (dgvProjects.Columns["StartDate"] != null) dgvProjects.Columns["StartDate"].HeaderText = "Başlangıç Tarihi";
                if (dgvProjects.Columns["Budget"] != null) dgvProjects.Columns["Budget"].HeaderText = "Bütçe";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjects.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellenecek projeyi tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtProjectName.Text))
                {
                    MessageBox.Show("Güncelleme yapmak için proje adını boş bırakamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Project p = new Project();
                p.ProjectID = Convert.ToInt32(dgvProjects.CurrentRow.Cells["ProjectID"].Value);
                p.ProjectName = txtProjectName.Text.Trim();
                p.StartDate = dtpStartDate.Value;

                decimal.TryParse(txtBudget.Text, out decimal b);
                p.Budget = b;

                new ProjectDal().Update(p);
                MessageBox.Show("Proje başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProjects.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek projeyi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvProjects.CurrentRow.Cells["ProjectID"].Value);

                if (MessageBox.Show("Projeyi ve tüm bağlı görevleri silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new ProjectDal().Delete(id);
                    MessageBox.Show("Proje başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAllData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Proje silinirken hata oluştu (Bağlı kayıtlar olabilir): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvProjects.CurrentRow != null)
                {
                    txtProjectName.Text = dgvProjects.CurrentRow.Cells["ProjectName"].Value?.ToString();

                    if (dgvProjects.CurrentRow.Cells["StartDate"].Value != null)
                    {
                        dtpStartDate.Value = Convert.ToDateTime(dgvProjects.CurrentRow.Cells["StartDate"].Value);
                    }

                    txtBudget.Text = dgvProjects.CurrentRow.Cells["Budget"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Çalışan İşlemleri
        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Lütfen çalışan adı ve soyadını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Calisan emp = new Calisan
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Expertise = txtExpertise.Text.Trim()
                };
                new EmployeeDal().Add(emp);
                MessageBox.Show("Çalışan başarıyla kaydedildi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışan kaydedilirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListEmployees()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = new EmployeeDal().GetAll();

            if (dgvEmployees.Columns.Count > 0)
            {
                if (dgvEmployees.Columns["EmployeeID"] != null) dgvEmployees.Columns["EmployeeID"].Visible = false;

                if (dgvEmployees.Columns["FirstName"] != null) dgvEmployees.Columns["FirstName"].HeaderText = "Personel Adı";
                if (dgvEmployees.Columns["LastName"] != null) dgvEmployees.Columns["LastName"].HeaderText = "Personel Soyadı";
                if (dgvEmployees.Columns["Expertise"] != null) dgvEmployees.Columns["Expertise"].HeaderText = "Uzmanlık Alanı";
            }
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen güncellenecek çalışanı tablodan seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtLastName.Text))
                {
                    MessageBox.Show("Güncelleme yapmak için Ad ve Soyad kısımlarını boş bırakamazsınız!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Calisan emp = new Calisan();
                emp.EmployeeID = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);
                emp.FirstName = txtFirstName.Text.Trim();
                emp.LastName = txtLastName.Text.Trim();
                emp.Expertise = txtExpertise.Text.Trim();

                new EmployeeDal().Update(emp);
                MessageBox.Show("Çalışan başarıyla güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışan güncellenirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEmployees.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek çalışanı seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvEmployees.CurrentRow.Cells["EmployeeID"].Value);

                if (MessageBox.Show("Çalışanı ve tüm görevlerini silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new EmployeeDal().Delete(id);
                    MessageBox.Show("Çalışan başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAllData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Çalışan silinirken hata oluştu (Bağlı kayıtlar olabilir): " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvEmployees.CurrentRow != null)
                {
                    txtFirstName.Text = dgvEmployees.CurrentRow.Cells["FirstName"].Value?.ToString();
                    txtLastName.Text = dgvEmployees.CurrentRow.Cells["LastName"].Value?.ToString();
                    txtExpertise.Text = dgvEmployees.CurrentRow.Cells["Expertise"].Value?.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Görev İşlemleri
        private void FillComboBoxes()
        {
            try
            {
                cmbProjects.DataSource = new ProjectDal().GetAll();
                cmbProjects.DisplayMember = "ProjectName";
                cmbProjects.ValueMember = "ProjectID";

                cmbEmployees.DataSource = new EmployeeDal().GetAll();
                cmbEmployees.DisplayMember = "FirstName";
                cmbEmployees.ValueMember = "EmployeeID";

                cmbTaskType.Items.Clear();
                cmbTaskType.Items.Add("Yazılım");
                cmbTaskType.Items.Add("Tasarım");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Açılır listeler doldurulurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTaskType.SelectedItem == null || cmbProjects.SelectedValue == null || cmbEmployees.SelectedValue == null)
                {
                    MessageBox.Show("Lütfen Proje, Çalışan ve Görev Tipi seçimlerini eksiksiz yapınız.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtTaskTitle.Text))
                {
                    MessageBox.Show("Lütfen bir görev tanımı giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string tip = cmbTaskType.SelectedItem.ToString();
                Gorev yeni = (tip == "Yazılım") ? new YazilimGorevi() : new TasarimGorevi();

                yeni.ProjectID = Convert.ToInt32(cmbProjects.SelectedValue);
                yeni.EmployeeID = Convert.ToInt32(cmbEmployees.SelectedValue);

                yeni.TaskTitle = txtTaskTitle.Text.Trim();
                yeni.TaskType = tip;

                decimal.TryParse(txtHourlyRate.Text, out decimal r);
                yeni.HourlyRate = r;

                decimal.TryParse(txtWorkedHours.Text, out decimal h);
                yeni.WorkedHours = h;

                new TaskDal().Add(yeni);
                MessageBox.Show($"Görev başarıyla atandı!\nHesaplanan Hakediş: {yeni.HakedisHesapla():C2}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev atanırken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvTasks.CurrentRow == null)
                {
                    MessageBox.Show("Lütfen silinecek görevi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgvTasks.CurrentRow.Cells["TaskID"].Value);

                if (MessageBox.Show("Bu görevi silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    new TaskDal().Delete(id);
                    MessageBox.Show("Görev başarıyla silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshAllData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Görev silinirken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ListTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = new TaskDal().GetAll();

            if (dgvTasks.Columns.Count > 0)
            {
                if (dgvTasks.Columns["Calisan"] != null) dgvTasks.Columns["Calisan"].Visible = false;
                if (dgvTasks.Columns["TaskID"] != null) dgvTasks.Columns["TaskID"].Visible = false;
                if (dgvTasks.Columns["ProjectID"] != null) dgvTasks.Columns["ProjectID"].Visible = false;
                if (dgvTasks.Columns["EmployeeID"] != null) dgvTasks.Columns["EmployeeID"].Visible = false;
                if (dgvTasks.Columns["Project"] != null) dgvTasks.Columns["Project"].Visible = false;

                if (dgvTasks.Columns["CalisanAdSoyad"] != null)
                    dgvTasks.Columns["CalisanAdSoyad"].HeaderText = "Çalışan Adı";
                dgvTasks.Columns["CalisanAdSoyad"].DisplayIndex = 0; 

                if (dgvTasks.Columns["TaskTitle"] != null) dgvTasks.Columns["TaskTitle"].HeaderText = "Görev Tanımı";
                if (dgvTasks.Columns["HourlyRate"] != null) dgvTasks.Columns["HourlyRate"].HeaderText = "Saatlik Ücret";
                if (dgvTasks.Columns["WorkedHours"] != null) dgvTasks.Columns["WorkedHours"].HeaderText = "Çalışılan Saat";
                if (dgvTasks.Columns["TaskType"] != null) dgvTasks.Columns["TaskType"].HeaderText = "Görev Tipi";
            }
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && dgvTasks.CurrentRow != null)
                {
                    txtTaskTitle.Text = dgvTasks.CurrentRow.Cells["TaskTitle"].Value?.ToString();
                    txtHourlyRate.Text = dgvTasks.CurrentRow.Cells["HourlyRate"].Value?.ToString();
                    txtWorkedHours.Text = dgvTasks.CurrentRow.Cells["WorkedHours"].Value?.ToString();

                    if (dgvTasks.CurrentRow.Cells["ProjectID"].Value != null)
                    {
                        cmbProjects.SelectedValue = Convert.ToInt32(dgvTasks.CurrentRow.Cells["ProjectID"].Value);
                    }

                    if (dgvTasks.CurrentRow.Cells["EmployeeID"].Value != null)
                    {
                        cmbEmployees.SelectedValue = Convert.ToInt32(dgvTasks.CurrentRow.Cells["EmployeeID"].Value);
                    }

                    if (dgvTasks.CurrentRow.Cells["TaskType"].Value != null)
                    {
                        cmbTaskType.SelectedItem = dgvTasks.CurrentRow.Cells["TaskType"].Value.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veri okunurken hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion


        private void UpdateAnalysis()
        {
            try
            {
                using (var context = new DataAccess.AppDbContext())
                {
                    int projeSayisi = context.Projects.Count();

                    decimal toplamButce = context.Projects.Sum(p => (decimal?)p.Budget) ?? 0;

                    int yazilimGoreviSayisi = context.Tasks.Count(t => t.TaskType == "Yazılım");

                    int tasarimGoreviSayisi = context.Tasks.Count(t => t.TaskType == "Tasarım");

                    decimal toplamGorevMaliyeti = context.Tasks.Sum(t => (decimal?)(t.WorkedHours * t.HourlyRate)) ?? 0;

                    lblAnalizProje.Text = $"Sistemdeki Toplam Proje: {projeSayisi}";
                    lblAnalizButce.Text = $"Toplam Proje Bütçesi: {toplamButce:C2}";
                    lblAnalizYazilim.Text = $"Yazılım Odaklı Görevler: {yazilimGoreviSayisi}";
                    lblAnalizTasarim.Text = $"Tasarım Odaklı Görevler: {tasarimGoreviSayisi}";
                    lblAnalizMaliyet.Text = $"Görevlerin Toplam Maliyeti: {toplamGorevMaliyeti:C2}";
                }
            }
            catch (Exception ex)
            {
                lblAnalizProje.Text = "Analiz yüklenemedi.";
            }
        }

       
    }
}