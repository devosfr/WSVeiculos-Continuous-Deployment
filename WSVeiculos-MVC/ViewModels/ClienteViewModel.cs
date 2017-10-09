using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WSVeiculos_MVC.ViewModels
{
    public class ClienteViewModel
    {
        [Key]
        public int CodCliente { get; set; }

        [Required(ErrorMessage = "Preencha o Campor Nome")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Digite um nome de 5 a 20 caractéres")]
        public string Nome { get; set; }

        public IEnumerable<ProdutosViewModel> Produtos { get; set; }

    }
}