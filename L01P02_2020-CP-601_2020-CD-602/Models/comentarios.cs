using System.ComponentModel.DataAnnotations;

namespace L01P02_2020_CP_601_2020_CD_602.Models
{
    public class comentarios
    {
        [Key]
        public int cometarioId { get; set; }
        public int? publicacionId { get; set; }
        public string? comentario { get; set; }
        public int? usuarioId { get; set; }
    }
}
