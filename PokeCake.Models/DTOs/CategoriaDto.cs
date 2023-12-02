using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokeCake.Models.DTOs;
internal class CategoriaDto
{
    public int Id { get; set; }
    public string? Nome { get; set; } 
    public string? Icone { get; set; } 
}
