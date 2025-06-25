using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using SmartLabV3.DataObjects.Utils;

namespace SmartLabV3.DataObjects.Samples
{
    public partial class SamplesDao : DataAccessBase
    {
        public virtual byte[] GetFlotas_Seguro(String whereGroups, String whereJobHeader)
        {
            if (whereGroups == "*")
            {
                whereGroups = null; 
            }
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_FLOTA_AREA_Q1", whereGroups, whereJobHeader).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }

        public virtual byte[] Client_Factura(String whereJobHeader)
        {
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_JOB_HEADER_Q1", whereJobHeader).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }

        public virtual byte[] Equipo(String whereGroups)
        {
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_Equipo_Q1", whereGroups).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }

        public virtual byte[] ComponentesPorEquipo(String Group,String Equipos)
        {
            if (Group == "*")
            {
                Group = null;
            }
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_COMPONENTE_Q1", Group, Equipos).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }
        public virtual byte[] NivelServicio(String whereCustomer)
        {
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_NivelServicio_Q1", whereCustomer).Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }
        public virtual byte[] AceiteLubricante()
        {
            UtilsLib util = new UtilsLib();
            DataTable dtDatos = Db.ExecuteDataSet("SP_ACEITE_LUBRICANTE_Q1").Tables[0];
            if (dtDatos.Rows.Count > 0)
            {
                return util.CompressDataTable(dtDatos);
            }
            else
            {
                return util.CompressDataTable(new DataTable());
            }
        }
    }
}
