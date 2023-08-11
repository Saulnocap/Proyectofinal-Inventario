using System;
using System.Collections.Generic;

namespace prueba.Models;

public partial class Inventario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? ProdCode { get; set; }

    public int? Cantidad { get; set; }

    public int? Precio { get; set; }

    public DateTime? Fecha { get; set; }

    public string? MovType { get; set; }

    public int? ProvCode { get; set; }
}
