using ApiJogos.InputModel;
using ApiJogos.ViewModel;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApiJogos.Services
{
    public interface IJogoServices : IDisposable
    {
        Task<List<JogoViewModel>> Obter(int pagina, int quantidade);
        Task<JogoViewModel> Obter(Guid id);
        Task<JogoViewModel> Inserir(JogoInputModel jogo);
        Task Atualizar(Guid id, JogoInputModel jogo);
        Task Atualizar(Guid id, double preco);
        Task Remover(Guid id);
    }
}
