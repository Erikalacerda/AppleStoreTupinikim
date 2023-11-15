using System;
using System.ComponentModel.DataAnnotations;

namespace AppleStoreTupinikim
{
    public class Produto
{
    [Key]
    public int valor { get; set; }
    public string marca { get; set; }
    public string modelo { get; set; }
    public string usado { get; set; }
	
	}
}
