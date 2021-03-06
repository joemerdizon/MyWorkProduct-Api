using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Repository.Interface
{
    public interface IRepositoryWrapper
    {
        IUserRepository UserRepository { get; }
        ITemplateTaskCategoryRepository TemplateTaskCategoryRepository { get; }
        IReportTemplateRepository ReportTemplateRepository { get;  }
    }
}

