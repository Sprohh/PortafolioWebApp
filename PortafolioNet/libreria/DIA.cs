//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libreria
{
    using System;
    using System.Collections.Generic;
    
    public partial class DIA
    {
        public System.DateTime DIA1 { get; set; }
        public System.DateTime HORA_INICIO { get; set; }
        public System.DateTime HORA_TERMINO { get; set; }
        public decimal RUT_FUNCIONARIO { get; set; }
    
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
    }
}
