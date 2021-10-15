namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using GameLibrary.Web.ViewModels.Publishers;

    public interface IPublisherService
    {
        Task Create(CreatePublisherInputModel input);

        public IEnumerable<KeyValuePair<int,string>> GetAllAsKeyValuePair();
    }
}
