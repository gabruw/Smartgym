﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smartgym.Models
{
    public class Exercicio
    {
        public Exercicio()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdExercicio { get; set; }

        public long IdAparelhoExercicio { get; set; }

        [ForeignKey("IdAparelhoExercicio")]
        public virtual Aparelho AparelhoExercicio { get; set; }

        [MinLength(1)]
        [MaxLength(60)]
        [Required(ErrorMessage = "Necessário adicionar um Nome ao Exercício.")]
        public string NomeExercicio { get; set; }

        [MinLength(1)]
        [MaxLength(800)]
        [Required(ErrorMessage = "Necessário adicionar uma Observação ao Exercício.")]
        public string ObservacaoExercicio { get; set; }
    }
}
