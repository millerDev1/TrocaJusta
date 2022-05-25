using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrocaJusta.Models;

    public class TrocaJustaContext : DbContext
    {
        public TrocaJustaContext (DbContextOptions<TrocaJustaContext> options)
            : base(options)
        {
        }

        public DbSet<TrocaJusta.Models.Endereco> Endereco { get; set; }

        public DbSet<TrocaJusta.Models.Profissao> Profissao { get; set; }

        public DbSet<TrocaJusta.Models.Reclamacao> Reclamacao { get; set; }

        public DbSet<TrocaJusta.Models.Usuario> Usuario { get; set; }

        public DbSet<TrocaJusta.Models.Troca> Troca { get; set; }

        public DbSet<TrocaJusta.Models.Servico> Servico { get; set; }

        public DbSet<TrocaJusta.Models.Genero> Genero { get; set; }

        public DbSet<TrocaJusta.Models.Login> Login { get; set; }
    }
