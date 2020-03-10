using System.Linq;
using System.Collections.Generic;
using MeusFilmes.Business.Entities;
using MeusFilmes.Business.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using System.Data.SQLite;
using Dapper;
using System;

namespace MeusFilmes.Data.Repositories
{
    public class FilmeRepository : RepositoryBase<Filme>, IFilmeRepository
    {
        public FilmeRepository(IConfiguration configuration) : base(configuration) { }

        public override void Alterar(Filme filme)
        {
            throw new System.NotImplementedException();
        }

        public override void Cadastrar(Filme filme)
        {
            try
            {
                conn.Open();
                var query = "INSERT INTO Filmes (Titulo,Duracao,Ano) VALUES(@Titulo,@Duracao,@Ano)";
                conn.Execute(query, filme);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public override Filme Consultar(int? id)
        {
            try
            {
                conn.Open();
                var query = "SELECT * FROM Filme";
                return conn.Query<Filme>(query).Where(f => f.Id == id).FirstOrDefault();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }

        }

        public override IEnumerable<Filme> Consultar()
        {
            try
            {
                conn.Open();
                var query = "SELECT * FROM Filmes";
                return conn.Query<Filme>(query).ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }


        }


        public override void Excluir(Filme filme)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose() { }

    }
}