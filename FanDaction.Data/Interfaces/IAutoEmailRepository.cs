using FanDaction.Core.Models;
using FanDaction.Core.ViewModels;
using System.Linq;

namespace FanDaction.Data.Interfaces
{
    public interface IAutoEmailRepository : IBaseRepository<EmailTemplate>
    {
        IQueryable<EmailTemplateVM> GetEmails(int? number = null);
        EmailTemplateVM GetEmailById(int? id = null);
    }
}
