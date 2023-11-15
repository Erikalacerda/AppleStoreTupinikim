using System;
using System.ComponentModel.DataAnnotations;

namespace AppleStoreTupinikim
{
    public class Vendedores
{
    [Key]
    public int cnpj { get; set; }
    public string razaoSocial { get; set; }
    public string email { get; set; }
    public string site { get; set; }
    public int telefone { get; set; }


    }
}
