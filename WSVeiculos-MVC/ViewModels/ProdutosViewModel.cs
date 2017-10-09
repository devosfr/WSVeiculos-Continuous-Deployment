using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WSVeiculos_MVC.ViewModels
{
    public class ProdutosViewModel
    {

        [Key]
        public int CodProdutos { get; set; }

        [Required(ErrorMessage = "Preencha o Campor Nome")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Digite um Modelo de 5 a 20 caractéres")]
        public string Modelo { get; set; }

        [Required(ErrorMessage = "Preencha o Campor Nome")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Digite uma Marca de 5 a 20 caractéres")]
        public string Marca { get; set; }

        public int CodClient { get; set; }

        public virtual ClienteViewModel Cliente { get; set; }

        public double Preco { get; set; }


    }
}