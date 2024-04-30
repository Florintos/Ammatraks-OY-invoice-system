using AmmatraksOY_InvoiceApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmmatraksOY_InvoiceApplication.ViewModel
{
    public class ProjectManager
    {
        private List<Project> projects;

        public ProjectManager()
        {
            projects = new List<Project>();
        }

        public void AddProject(Project project)
        {
            projects.Add(project);
        }
    }
}
