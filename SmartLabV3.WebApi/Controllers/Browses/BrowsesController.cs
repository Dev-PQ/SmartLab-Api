using Microsoft.AspNetCore.Mvc;
using SmartLabV3.Facade.Browses;
using LibreriaBSNetCore.Exceptions;

namespace SmartLabV3.WebApi.Controllers.Browses
{
    [Route("api/Browses")]
    [ApiController()]
    public class BrowsesController:ControllerBase
    {
        [Route("CheckSecurityOverride/{userLogin}")]
        [HttpGet()]
        public virtual byte[] CheckSecurityOverride(String userLogin)
        {
            try
            {
                BrowsesFacade faBrowsesFacade = new BrowsesFacade();
                return faBrowsesFacade.CheckSecurityOverride(userLogin);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("SqlGroupFilter/{userLogin}")]
        [HttpGet()]
        public virtual byte[] SqlGroupFilter(String userLogin)
        {
            try
            {
                BrowsesFacade faBrowsesFacade = new BrowsesFacade();
                return faBrowsesFacade.SqlGroupFilter(userLogin);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}
