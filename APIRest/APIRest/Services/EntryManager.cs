using APIRest.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace APIRest.Services
{
    public class EntryManager
    {
		IRestService restService;

		public EntryManager(IRestService service)
		{
			restService = service;
		}

		public Task<List<EntryModel>> GetTasksAsync()
		{
			return restService.GetDataAsync();
		}
	}
}
