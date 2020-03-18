using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PMIDE.Models.Task
{
    public class TaskPageModel
    {
        public TaskPageModel(string pageTitle)
        {
            PageTitle = pageTitle;
        }

        public string PageTitle { get; set; }
    }
}
