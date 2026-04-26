using Core.Entities;  
using DataAccess;    

namespace UI.WinForms

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Project newProject = new Project();
            newProject.ProjectName = txtProjectName.Text;
            newProject.StartDate = dtpStartDate.Value;    
            newProject.Budget = decimal.Parse(txtBudget.Text); 

            ProjectDal projectDal = new ProjectDal();

            projectDal.Add(newProject);

            MessageBox.Show("Proje baþarýyla kaydedildi!");
        }
    }
}
