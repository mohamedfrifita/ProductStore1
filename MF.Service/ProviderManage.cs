using System;
using System.Collections.Generic;
using System.Text;
using MF.Domain;
using System.Linq;

namespace MF.Service
{
    public class ProviderManage
    {
        IList<Provider> providers;
        public ProviderManage(IList<Provider>providers)
        {
            this.providers = providers;
        }
       public IList<Provider>GetProvidersByName(string name)
        {
            var result = from p in providers
                         where p.UserName.Contains(name)
                         select p;
            return result.ToList();
        }
        public Provider GetFirstProvidersByName(string name)
        {
            var result = from p in providers
                         where p.UserName.StartsWith(name)
                         select p;
            return result.FirstOrDefault();
        }
        public Provider GetProvidersById(int id)
        {
            var result = from p in providers
                         where p.Id.Equals(id)
                         select p;
            return result.FirstOrDefault();
        }
    }
}
