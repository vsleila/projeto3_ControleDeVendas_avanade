using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoControleVendas.Models;
using MiniMundo.Models;

namespace ProjetoControleVendas.Data
{
    public class ProjetoControleVendasContext : DbContext
    {
        public ProjetoControleVendasContext (DbContextOptions<ProjetoControleVendasContext> options)
            : base(options)
        {
        }

        public DbSet<ProjetoControleVendas.Models.Produtos> Produtos { get; set; } = default!;
        public DbSet<ProjetoControleVendas.Models.Funcionarios> Funcionarios { get; set; } = default!;
        public DbSet<ProjetoControleVendas.Models.Vendas> Vendas { get; set; } = default!;
        public DbSet<MiniMundo.Models.Clientes> Clientes { get; set; } = default!;
        public DbSet<MiniMundo.Models.NivelDeAcesso> NivelDeAcesso { get; set; } = default!;
    }
}
