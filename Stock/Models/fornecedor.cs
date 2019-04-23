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
   
    
    public partial class fornecedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public fornecedor()
        {
            this.produtoes = new HashSet<produto>();
        }
    
        public int id { get; set; }
        public string nome { get; set; }
        public string razao_social { get; set; }
        public string num_documento { get; set; }
        public int tipo { get; set; }
        public string telefone { get; set; }
        public string contato { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }
        public string cep { get; set; }
        public int id_pais { get; set; }
        public int id_estado { get; set; }
        public int id_cidade { get; set; }
        public bool ativo { get; set; }
    
        public virtual cidade cidade { get; set; }
        public virtual estado estado { get; set; }
        public virtual pai pai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<produto> produtoes { get; set; }
    }
}
