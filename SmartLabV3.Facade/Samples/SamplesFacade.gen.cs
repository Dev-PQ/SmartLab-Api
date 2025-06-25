using SmartLabV3.DataObjects.Samples;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaBSNet.InfoApp;
using System.Data;
using System.Text.RegularExpressions;

namespace SmartLabV3.Facade.Samples
{
    [DataObject(true)]
    public partial class SamplesFacade
    {
        private SamplesDao samples;

        // --- Variables de control de errores 
        private string Error;

        private bool hayError;

        #region Constructores
        public SamplesFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    samples = new SamplesDao();
                    break;
            }
        }
        #endregion

        #region Metodos de Control de Errores
        public virtual string getError()
        {
            return Error;
        }

        public virtual bool HayError()
        {
            return hayError;
        }
        #endregion

        #region Metodos Secundarios
        public virtual byte[] Client_Factura(String whereJobHeader)
        {
            return samples.Client_Factura(whereJobHeader);
        }
        public virtual byte[] GetFlotas_Seguro(String whereGroups, String whereJobHeader)
        {
            return samples.GetFlotas_Seguro(whereGroups, whereJobHeader);
        }

        public virtual byte[] Equipo(String whereGroups) 
        {
            return samples.Equipo(whereGroups);
        }

        public virtual byte[] ComponentesPorEquipo(String Group, String Equipos)
        {
            return samples.ComponentesPorEquipo(Group,Equipos);
        }
        public virtual byte[] NivelServicio(String whereCustomer)
        {
            return samples.NivelServicio(whereCustomer);
        }

        public virtual byte[] AceiteLubricante()
        {
            return samples.AceiteLubricante();
        }
        #endregion
    }
}
