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
    
    public partial class TIPO_FUNCIONARIO
    {
        public TIPO_FUNCIONARIO()
        {
            this.FUNCIONARIO = new HashSet<FUNCIONARIO>();
        }
    
        public decimal ID { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<FUNCIONARIO> FUNCIONARIO { get; set; }
    }
}
