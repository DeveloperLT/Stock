//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

namespace Stock.Models
{
    
    
    public partial class inventario_estoque
    {
        public int id { get; set; }
        public System.DateTime data { get; set; }
        public int id_produto { get; set; }
        public int quant_estoque { get; set; }
        public int quant_inventario { get; set; }
        public string motivo { get; set; }
    
        public virtual produto produto { get; set; }
    }
}