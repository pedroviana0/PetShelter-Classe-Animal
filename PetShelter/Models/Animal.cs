using System.ComponentModel.DataAnnotations;

namespace PetShelter.Models
{
    public class Animal
    {
        [Key]
        public int AnimalID { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Especie { get; set; } 

        [StringLength(50)]
        public string Raca { get; set; }

        [Range(0, 50)]
        public int? Idade { get; set; } 

        [StringLength(1)]
        public string Sexo { get; set; } 

        [StringLength(20)]
        public string Porte { get; set; } 

        [StringLength(50)]
        public string Cor { get; set; }

        [Required]
        [StringLength(30)]
        public string Status { get; set; } 

        [DataType(DataType.Date)]
        public DateTime DataEntrada { get; set; }

        [DataType(DataType.MultilineText)]
        public string HistoricoSaude { get; set; }
    }
}
