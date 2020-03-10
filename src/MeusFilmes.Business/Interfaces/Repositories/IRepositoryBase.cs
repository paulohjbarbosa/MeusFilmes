using System;
using System.Collections.Generic;


namespace MeusFilmes.Business.Interfaces.Repositories
{
    public interface IRepositoryBase<T> : IDisposable where T : class
    {
        void Cadastrar(T model);
        void Alterar(T model);
        T Consultar(int? id);        
        IEnumerable<T> Consultar();
        void Excluir(T model);

    }
}