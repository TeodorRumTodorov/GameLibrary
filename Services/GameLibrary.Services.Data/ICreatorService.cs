namespace GameLibrary.Services.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;
    using GameLibrary.Web.ViewModels.Creators;

    public interface ICreatorService
    {
        public Task Create(CreateCreatorInputModel input);

        public IEnumerable<KeyValuePair<int,string>> GetAllAsKeyValuePair();
    }
}
