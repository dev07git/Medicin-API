using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IMedicinService
    {
        Task<List<Medicin>> GetMedicinsAsync();
    }
}