using System;

namespace demomvc.Models
{
    public class Ventas
    {
       public string Id { get; set; }
       public string Name{ get; set; }

       public string Categoria{ get; set; }

       public decimal Precio{get; set;}

       public string Descuento{get; set; }

    }
}