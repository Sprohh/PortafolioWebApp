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
    
    public partial class PERMISO
    {
        public PERMISO()
        {
            this.USUARIO = new HashSet<USUARIO>();
        }
    
        public decimal ID { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<USUARIO> USUARIO { get; set; }
    }
}
