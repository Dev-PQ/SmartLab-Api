using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SmartLabV3.Facade.Samples;
using LibreriaBSNetCore.Exceptions;

namespace SmartLabV3.WebApi.Controllers.Samples
{
    [Route("api/Samples")]
    [ApiController()]
    public class SamplesController : ControllerBase
    {

        [Route("Client_Factura/{whereJobHeader}")]
        [HttpGet()]
        public virtual byte[] Client_Factura(String whereJobHeader)
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.Client_Factura(whereJobHeader);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("GetFlotas_Seguro/{whereGroups}/{whereJobHeader}")]
        [HttpGet()]
        public virtual byte[] GetFlotas_Seguro(String whereGroups, String whereJobHeader)
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.GetFlotas_Seguro(whereGroups,whereJobHeader);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("Equipo/{whereGroups}")]
        [HttpGet()]
        public virtual byte[] Equipo(String whereGroups)
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.Equipo(whereGroups);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("ComponentesPorEquipo/{Group}/{Equipos}")]
        [HttpGet()]
        public virtual byte[] ComponentesPorEquipo(String Group, String Equipos)
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.ComponentesPorEquipo(Group, Equipos);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
        [Route("NivelServicio/{whereCustomer}")]
        [HttpGet()]
        public virtual byte[] NivelServicio(String whereCustomer)
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.NivelServicio(whereCustomer);
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }

        [Route("AceiteLubricante")]
        [HttpGet()]
        public virtual byte[] AceiteLubricante()
        {
            try
            {
                SamplesFacade faSamplesFacade = new SamplesFacade();
                return faSamplesFacade.AceiteLubricante();
            }
            catch (System.Exception e)
            {
                Logger.Fatal(e);
                throw;
            }
        }
    }
}