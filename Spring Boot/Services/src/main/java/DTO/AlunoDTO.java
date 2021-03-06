package DTO;

import java.util.Date;
import lombok.Data;

@Data
public class AlunoDTO {
    private int IdAluno;
    private int IdFicha;
    private int IdAvaliacao;
    private int Permissao;
    private String Email;
    private String Senha;
    private String Matricula;
    private String Nome; 
    private int Cpf;
    private Date DataNascimento;
    private int Telefone;
    private int Celular;
    private int Sexo;
    private String Rua;
    private String Bairro;
    private int Numero;
    private int Complemento;
    private String Imagem;
}