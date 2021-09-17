using System;

namespace ApiJogos.Exceptions
{
    public class JogoCadastradoException : Exception
    {
        public JogoCadastradoException()
            : base("Jogo já cadastrado anteriormente!")
        { }
    }
}
