﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.DTO
{
    public class Aluno : DTODefault
    {
        public Aluno()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long IdAluno { get; set;  }

        public long IdContaAluno { get; set; }

        [ForeignKey("IdContaAluno")]
        public virtual Conta ContaAluno { get; set; }

        public long IdEnderecoAluno { get; set;  }

        [ForeignKey("IdEnderecoAluno")]
        public virtual Endereco EnderecoAluno { get; set; }

        public virtual ICollection<Ficha> FichaAluno { get; set; }

        public virtual ICollection<Avaliacao> AvaliacaoAluno { get; set; }

        public int PermissaoAluno { get; set; }

        public string MatriculaAluno { get; set; }

        public string NomeAluno { get; set; }

        public long CpfAluno { get; set; }

        public DateTime DataNascimentoAluno { get; set; }

        public long TelefoneAluno { get; set; }

        public long CelularAluno { get; set; }

        public int SexoAluno { get; set; }

        public string ImagemAluno { get; set; }

        public override void Validate()
        {
            ClearValidateMensages();

            if (PermissaoAluno < 1)
            {
                AddError("O campo Permissão do Aluno não foi informado.");
            }

            if (MatriculaAluno.Length < 1)
            {
                AddError("O campo Matrícula do Aluno não foi informado.");
            }

            if (NomeAluno.Length < 1)
            {
                AddError("O campo Nome do Aluno não foi informado.");
            }

            if (CpfAluno.ToString().Length < 11)
            {
                AddError("O campo CPF do Aluno não foi informado.");
            }

            if (DataNascimentoAluno.ToString().Length < 1)
            {
                AddError("O campo Data de Nascimento do Aluno não foi informado.");
            }

            if (SexoAluno.ToString().Length < 1)
            {
                AddError("O campo Sexo do Aluno não foi informado.");
            }
        }
    }
}