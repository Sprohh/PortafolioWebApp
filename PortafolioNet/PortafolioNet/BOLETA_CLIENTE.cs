//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PruebaConexionNET
{
    using System;
    using System.Collections.Generic;
    
    public partial class BOLETA_CLIENTE
    {
        public BOLETA_CLIENTE()
        {
            this.SERVICIO = new HashSet<SERVICIO>();
        }
    
        public decimal ID { get; set; }
        public System.DateTime FECHA { get; set; }
        public decimal RUT_CLIENTE { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual ICollection<SERVICIO> SERVICIO { get; set; }
    }
}
