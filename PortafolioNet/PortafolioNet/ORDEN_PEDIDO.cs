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
    
    public partial class ORDEN_PEDIDO
    {
        public decimal ID { get; set; }
        public System.DateTime FECHA_VENC { get; set; }
        public decimal CANTIDAD { get; set; }
        public decimal ID_PRODUCTO { get; set; }
        public decimal ID_FUNCIONARIO { get; set; }
        public decimal ID_ESTADO_PEDIDO { get; set; }
    
        public virtual FUNCIONARIO FUNCIONARIO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
        public virtual TIPO_ESTADO_PEDIDO TIPO_ESTADO_PEDIDO { get; set; }
    }
}
