using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using FanDaction.Core.ValueTypes;
using FanDaction.Data.Repositories;
using FanDaction.Data.Interfaces;

namespace FanDaction.Data.Repositories
{
    public class AutoEmailRepository : BaseRepository<EmailTemplate>, IAutoEmailRepository
    {
        public AutoEmailRepository() { }

        public AutoEmailRepository(FandDbContext dbContext, IFandDataAccess dataAccess)
            : base(dbContext, dataAccess)
        { }

        public IQueryable<EmailTemplateVM> GetEmails(int? number = null)
        {
            var emails = Context.Set<EmailTemplate>().AsQueryable();

            if (number != null) emails = emails.Where(e => e.Id == number);

            var q = from e in emails
                    orderby e.Subject
                    select new EmailTemplateVM
                    {
                        Id = e.Id,
                        Body = e.Body,
                        Enabled = e.Enabled,
                        Reserved = e.Reserved,
                        Subject = e.Subject,
                        Token = e.Token,
                    };
            return q;
        }

        public EmailTemplateVM GetEmailById(int? id = null)
        {
            return null;
        }
    }
}
