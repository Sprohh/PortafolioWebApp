using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortafolioNet.Business
{
    internal class Connection
    {
        #region Campos
        private static LindaSonrisaEntities _lindaSonrisaDB; //Conexión con la DataBase
        #endregion

        #region Properties
        public static LindaSonrisaEntities LindaSonrisaDB
        {
            get
            {
                if (_lindaSonrisaDB == null)
                    _lindaSonrisaDB = new LindaSonrisaEntities();
                return _lindaSonrisaDB;
            }
            set
            {
                _lindaSonrisaDB = value;
            }
        }
        #endregion
    }
}
