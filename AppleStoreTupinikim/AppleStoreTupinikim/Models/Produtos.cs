using System;
using System.ComponentModel.DataAnnotations;

namespace AppleStoreTupinikim
{
    public class Clientes
{
    [Key]
    public int cpf { get; set; }
    public string nome { get; set; }
    public string email { get; set; }
    public string endereco { get; set; }
	
	}
}
