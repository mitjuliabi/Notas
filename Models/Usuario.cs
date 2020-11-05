using System;
using System.Collections.Generic;

namespace Notas.Models
{

    public class Usuario  
  {
    [Key]
    public string Mail {get;set;} 

    [Require]
    public String Nombre {get;set;}

    public List<Nota> Notas {get;set;}
  }
}