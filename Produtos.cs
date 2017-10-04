using System;

public class Produtos
{

    public int CodProdutos { get; set; }

    public string Modelo { get; set; }

    public string Marca{ get; set; }

    public int CodClient { get; set; }

    public virtual Cliente Cliente { get; set; }

}
