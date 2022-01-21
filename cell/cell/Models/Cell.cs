using System.ComponentModel.DataAnnotations.Schema;

namespace cell.Models
{
    [Table("phones")]
    public class Cell
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("marca")]
        public string Marca { get; set; }
        [Column("modelo")]
        public string Modelo { get; set; }
        [Column("cor")]
        public string Cor { get; set; }
        [Column("tela")]
        public string Tela { get; set; }
        [Column("camera")]
        public string Camera { get; set; }
        [Column("memoria")]
        public string Memoria { get; set; }
        [Column("bateria")]
        public string Bateria { get; set; }

    }
}
