using Core.Entities;
using DataAccess;
using Microsoft.Data.SqlClient;

namespace UI.WinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            RefreshAllData();
        }

        private void RefreshAllData()
        {
            ListProjects();
            ListEmployees();
            ListTasks();
            FillComboBoxes();
        }

        #region Proje Ýþlemleri
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Project newProject = new Project { ProjectName = txtProjectName.Text, StartDate = dtpStartDate.Value };
                decimal.TryParse(txtBudget.Text, out decimal budget);
                newProject.Budget = budget;

                new ProjectDal().Add(newProject);
                MessageBox.Show("Proje kaydedildi!");
                RefreshAllData();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void ListProjects()
        {
            dgvProjects.DataSource = null;
            dgvProjects.DataSource = new ProjectDal().GetAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null) return;

            Project p = new Project();
            p.ProjectID = (int)dgvProjects.CurrentRow.Cells["ProjectID"].Value;
            p.ProjectName = txtProjectName.Text;
            p.StartDate = dtpStartDate.Value;
            decimal.TryParse(txtBudget.Text, out decimal b);
            p.Budget = b;

            new ProjectDal().Update(p);
            MessageBox.Show("Proje güncellendi!");
            RefreshAllData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvProjects.CurrentRow == null) return;
            int id = (int)dgvProjects.CurrentRow.Cells["ProjectID"].Value;

            if (MessageBox.Show("Projeyi ve tüm baðlý görevleri silmek istediðinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new ProjectDal().Delete(id);
                RefreshAllData();
            }
        }

        private void dgvProjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProjects.CurrentRow == null) return;
            txtProjectName.Text = dgvProjects.CurrentRow.Cells["ProjectName"].Value?.ToString();
            dtpStartDate.Value = (DateTime)dgvProjects.CurrentRow.Cells["StartDate"].Value;
            txtBudget.Text = dgvProjects.CurrentRow.Cells["Budget"].Value?.ToString();
        }
        #endregion

        #region Çalýþan Ýþlemleri
        private void btnEmployeeSave_Click(object sender, EventArgs e)
        {
            try
            {
                Calisan emp = new Calisan { FirstName = txtFirstName.Text, LastName = txtLastName.Text, Expertise = txtExpertise.Text };
                new EmployeeDal().Add(emp);
                MessageBox.Show("Çalýþan kaydedildi!");
                RefreshAllData();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void ListEmployees()
        {
            dgvEmployees.DataSource = null;
            dgvEmployees.DataSource = new EmployeeDal().GetAll();
        }

        private void btnEmployeeUpdate_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;

            Calisan emp = new Calisan();
            emp.EmployeeID = (int)dgvEmployees.CurrentRow.Cells["EmployeeID"].Value;
            emp.FirstName = txtFirstName.Text;
            emp.LastName = txtLastName.Text;
            emp.Expertise = txtExpertise.Text;

            new EmployeeDal().Update(emp);
            MessageBox.Show("Çalýþan güncellendi!");
            RefreshAllData();
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            int id = (int)dgvEmployees.CurrentRow.Cells["EmployeeID"].Value;

            if (MessageBox.Show("Çalýþaný ve tüm görevlerini silmek istediðinize emin misiniz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new EmployeeDal().Delete(id);
                RefreshAllData();
            }
        }

        private void dgvEmployees_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmployees.CurrentRow == null) return;
            txtFirstName.Text = dgvEmployees.CurrentRow.Cells["FirstName"].Value?.ToString();
            txtLastName.Text = dgvEmployees.CurrentRow.Cells["LastName"].Value?.ToString();
            txtExpertise.Text = dgvEmployees.CurrentRow.Cells["Expertise"].Value?.ToString();
        }
        #endregion

        #region Görev Ýþlemleri
        private void FillComboBoxes()
        {
            cmbProjects.DataSource = new ProjectDal().GetAll();
            cmbProjects.DisplayMember = "ProjectName";
            cmbProjects.ValueMember = "ProjectID";

            cmbEmployees.DataSource = new EmployeeDal().GetAll();
            cmbEmployees.DisplayMember = "FirstName";
            cmbEmployees.ValueMember = "EmployeeID";

            cmbTaskType.Items.Clear();
            cmbTaskType.Items.Add("Yazýlým");
            cmbTaskType.Items.Add("Tasarým");
        }

        private void btnAssignTask_Click(object sender, EventArgs e)
        {
            if (cmbTaskType.SelectedItem == null) return;

            string tip = cmbTaskType.SelectedItem.ToString();
            Gorev yeni = (tip == "Yazýlým") ? new YazilimGorevi() : new TasarimGorevi();

            yeni.ProjectID = (int)cmbProjects.SelectedValue;
            yeni.EmployeeID = (int)cmbEmployees.SelectedValue;
            yeni.TaskTitle = txtTaskTitle.Text;
            yeni.TaskType = tip;
            decimal.TryParse(txtHourlyRate.Text, out decimal r); yeni.HourlyRate = r;
            decimal.TryParse(txtWorkedHours.Text, out decimal h); yeni.WorkedHours = h;

            new TaskDal().Add(yeni);
            MessageBox.Show($"Görev Atandý! Hakediþ: {yeni.HakedisHesapla():C2}");
            RefreshAllData();
        }

        private void btnUpdateTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;

            string tip = dgvTasks.CurrentRow.Cells["TaskType"].Value.ToString();
            Gorev task = (tip == "Yazýlým") ? new YazilimGorevi() : new TasarimGorevi();

            task.TaskID = (int)dgvTasks.CurrentRow.Cells["TaskID"].Value;
            task.TaskTitle = txtTaskTitle.Text;
            decimal.TryParse(txtHourlyRate.Text, out decimal r); task.HourlyRate = r;
            decimal.TryParse(txtWorkedHours.Text, out decimal h); task.WorkedHours = h;

            new TaskDal().Update(task);
            MessageBox.Show($"Görev güncellendi! Yeni Hakediþ: {task.HakedisHesapla():C2}");
            RefreshAllData();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;
            int id = (int)dgvTasks.CurrentRow.Cells["TaskID"].Value;

            if (MessageBox.Show("Görevi silmek istiyor musunuz?", "Onay", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                new TaskDal().Delete(id);
                RefreshAllData();
            }
        }

        private void ListTasks()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = new TaskDal().GetAll();
        }

        private void dgvTasks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;
            txtTaskTitle.Text = dgvTasks.CurrentRow.Cells["TaskTitle"].Value?.ToString();
            txtHourlyRate.Text = dgvTasks.CurrentRow.Cells["HourlyRate"].Value?.ToString();
            txtWorkedHours.Text = dgvTasks.CurrentRow.Cells["WorkedHours"].Value?.ToString();
        }
        #endregion
    }
}