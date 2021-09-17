using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace ApiJogos.InputModel
{
    public class JogoInputModel
    {
        [Required]
        [StringLength(60, MinimumLength = 3, ErrorMessage = "O nome do jogo deve ter de 3 a 60 caracteres")]
        public string Nome { get; set; }
        [Required]
        [StringLength(60, MinimumLength = 1, ErrorMessage = "O nome da produtora deve ter entre 3 a 60 caracteres")]
        public string Produtora { get; set; }
        [Required]
        [Range(1, 500, ErrorMessage = "Preço mínimo 1 real e máximo 500 reais")]
        public double Preco { get; set; }
    }
}
