using MyWorkProduct.DataAccess.Context;
using MyWorkProduct.DataAccess.Models;
using MyWorkProduct.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWorkProduct.Repository.Services
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MyWorkProductDbContext _dbContext;
        private IUserRepository _userRepository;
        private ITemplateTaskCategoryRepository _templateTaskCategoryRepository;
        private IReportTemplateRepository _reportTemplateRepository;

        public RepositoryWrapper(MyWorkProductDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IUserRepository UserRepository
        {
            get
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_dbContext);
                return _userRepository;
            }
        }

        public ITemplateTaskCategoryRepository TemplateTaskCategoryRepository
        {
            get
            {
                if (_templateTaskCategoryRepository == null)
                    _templateTaskCategoryRepository = new TemplateTaskCategoryRepository(_dbContext);
                return _templateTaskCategoryRepository;
            }
        }

        public IReportTemplateRepository ReportTemplateRepository
        {
            get
            {
                if (_reportTemplateRepository == null)
                    _reportTemplateRepository = new ReportTemplateRepository(_dbContext);
                return _reportTemplateRepository;
            }
        }
    }
}
