﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Exercicio : DTODefault
    {
        public Exercicio()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdExercicio { get; set; }

        public int IdAparelhoExercicio { get; set; }

        [ForeignKey("IdAparelhoExercicio")]
        public virtual Exercicio AparelhoExercicio { get; set; }

        public int IdSerieExercicio { get; set; }

        [ForeignKey("IdSerieExercicio")]
        public virtual Serie SerieExercicio { get; set; }

        public string NomeExercicio { get; set; }

        public string ObservacaoExercicio { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (NomeExercicio.Length < 1)
            {
                AddError("O campo Nome do Exercício não foi informado.");
            }
        }
    }
}