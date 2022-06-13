using System;
using System.Collections.Generic;

#nullable disable

namespace MyWorkProduct.DataAccess.Models
{
    public partial class Client
    {
        public Client()
        {
            ClientConfigurations = new HashSet<ClientConfiguration>();
            ClientProviders = new HashSet<ClientProvider>();
            ClientTitles = new HashSet<ClientTitle>();
            ClientUserRoles = new HashSet<ClientUserRole>();
            Departments = new HashSet<Department>();
            NotificationGlobalSubscriptions = new HashSet<NotificationGlobalSubscription>();
            OrganizationHierarchies = new HashSet<OrganizationHierarchy>();
            Teams = new HashSet<Team>();
            TemplateTaskCategories = new HashSet<TemplateTaskCategory>();
            UserStorageAccountTypes = new HashSet<UserStorageAccountType>();
            UserTitles = new HashSet<UserTitle>();
            Users = new HashSet<User>();
        }

        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public int? StateId { get; set; }
        public string ZipCode { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ClientTitle { get; set; }
        public string ClientBranding { get; set; }
        public DateTime? EndDate { get; set; }
        public int? TotalLicenses { get; set; }
        public bool? IsActive { get; set; }
        public string LogoPath { get; set; }

        public virtual ICollection<ClientConfiguration> ClientConfigurations { get; set; }
        public virtual ICollection<ClientProvider> ClientProviders { get; set; }
        public virtual ICollection<ClientTitle> ClientTitles { get; set; }
        public virtual ICollection<ClientUserRole> ClientUserRoles { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<NotificationGlobalSubscription> NotificationGlobalSubscriptions { get; set; }
        public virtual ICollection<OrganizationHierarchy> OrganizationHierarchies { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<TemplateTaskCategory> TemplateTaskCategories { get; set; }
        public virtual ICollection<UserStorageAccountType> UserStorageAccountTypes { get; set; }
        public virtual ICollection<UserTitle> UserTitles { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
