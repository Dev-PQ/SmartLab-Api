﻿using LibreriaBSNet.InfoApp;
using SmartLabV3.DataObjects.Browses;
using SmartLabV3.DataObjects.Samples;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLabV3.Facade.Browses
{
    public partial class BrowsesFacade
    {
        private BrowsesDao browses;

        // --- Variables de control de errores 
        private string Error;

        private bool hayError;

        #region Constructores
        public BrowsesFacade()
        {
            switch (AplicacionBS.Gestor_BD)
            {
                default:
                    browses = new BrowsesDao();
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
        public virtual byte[] CheckSecurityOverride(String  userLogin)
        {
            return browses.CheckSecurityOverride(userLogin);
        }
        public virtual byte[] SqlGroupFilter(String userLogin)
        {
            return browses.SqlGroupFilter(userLogin);
        }
        #endregion
    }
}
