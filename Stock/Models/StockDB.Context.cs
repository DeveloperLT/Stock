﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Stock.Models
{
    
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<cidade> cidades { get; set; }
        public virtual DbSet<entrada_produto> entrada_produto { get; set; }
        public virtual DbSet<estado> estadoes { get; set; }
        public virtual DbSet<fornecedor> fornecedors { get; set; }
        public virtual DbSet<grupo_produto> grupo_produto { get; set; }
        public virtual DbSet<inventario_estoque> inventario_estoque { get; set; }
        public virtual DbSet<local_armazenamento> local_armazenamento { get; set; }
        public virtual DbSet<marca_produto> marca_produto { get; set; }
        public virtual DbSet<pai> pais { get; set; }
        public virtual DbSet<perfil> perfils { get; set; }
        public virtual DbSet<produto> produtoes { get; set; }
        public virtual DbSet<saida_produto> saida_produto { get; set; }
        public virtual DbSet<unidade_medida> unidade_medida { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
    }
}
