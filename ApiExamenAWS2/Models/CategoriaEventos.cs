using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiExamenAWS2.Models
{
    [Table("categoriaevento")]
    public class CategoriaEventos
    {
        [Key]
        [Column("idcategoria")]
        public int IdEvento { get; set; }
        [Column("nombre")]
        public string Nombre { get; set; }
    }
}
