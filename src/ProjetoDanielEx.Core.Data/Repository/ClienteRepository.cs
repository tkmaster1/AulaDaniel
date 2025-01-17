﻿using Microsoft.EntityFrameworkCore;
using ProjetoDanielEx.Core.Domain.Entities;
using ProjetoDanielEx.Core.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoDanielEx.Core.Data.Repository
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    {
        #region Constructor

        public ClienteRepository(MeuContextoBDs context) : base(context) { }

        #endregion

        #region Methods

        public async Task<IEnumerable<Cliente>> ListarTodosClienteEndereco()
        {
            return await Db.Clientes.AsNoTracking()
                                    .Include(c => c.Endereco)
                                    .ToListAsync();
        }

        public async Task<Cliente> NomeExiste(string nomeDoCliente)
        {
            return await DbSet.Where(x => x.Nome.Trim().ToUpper().Equals(nomeDoCliente.Trim().ToUpper())).FirstOrDefaultAsync();
        }

        public async Task<Cliente> DocumentoExiste(string documento)
        {
            return await DbSet.Where(x => x.Documento.Trim().Equals(documento.Trim())).FirstOrDefaultAsync();
        }

        public async Task<Cliente> ObterClienteEndereco(int codigoCliente)
        {
            return await Db.Clientes.AsNoTracking()
                           .Include(c => c.Endereco)
                           .FirstOrDefaultAsync(c => c.Codigo == codigoCliente);
        }

        #endregion
    }
}
