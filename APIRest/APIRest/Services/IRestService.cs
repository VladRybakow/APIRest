using APIRest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Services
{
    public interface IRestService
    {
        Task<List<EntryModel>> GetDataAsync();
    }
}
