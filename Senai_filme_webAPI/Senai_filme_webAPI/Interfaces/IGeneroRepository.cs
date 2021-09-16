using Senai_filme_webAPI.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_filme_webAPI.Interfaces
{
    interface IGeneroRepository
    {

        List<GeneroDomain> ListarTodos();

        GeneroDomain BuscarPorId(int idGenero);

        void Cadastrar(GeneroDomain novoGenero);

        void AtualizarIdCorpo(GeneroDomain generoAtualizado);

        void AtualizarIdUrl(int idGenero, GeneroDomain generoAtualizado);

        void Deletar(int idGenero);

    }
}
