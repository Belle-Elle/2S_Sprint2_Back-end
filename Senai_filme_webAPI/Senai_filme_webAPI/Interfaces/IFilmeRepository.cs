using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_filme_webAPI.Interfaces
{
    interface IFilmeRepository
    {

        List<FilmeDomain> ListarTodos();
        FilmeDomain BuscarPorId();
        void Cadastrar(FilmeDomain novoFilme);
        void AtualizarIdCorpo(FilmeDomain filmeAtualizado);
        void Deletar(int IdFilme);

    }
}
