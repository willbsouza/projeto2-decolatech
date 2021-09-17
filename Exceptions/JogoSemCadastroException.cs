using System;

namespace ApiJogos.Exceptions
{
    public class JogoSemCadastroException : Exception
    {
        public JogoSemCadastroException()
            : base("Jogo não cadastrado!")
        { }
    }
}
