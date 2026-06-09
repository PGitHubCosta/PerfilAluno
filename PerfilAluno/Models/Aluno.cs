using System;
using System.ComponentModel.DataAnnotations;

namespace PerfilAluno.Models
{
    public class Aluno
    {
        [Required(ErrorMessage = "O nome é obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre {2} e {1} caracteres.")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; } = string.Empty;

        [Required(ErrorMessage = "O e-mail é obrigatório.")]
        [EmailAddress(ErrorMessage = "Digite um endereço de e-mail válido.")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "O R.A. é obrigatório.")]
        [StringLength(9, MinimumLength = 5, ErrorMessage = "O R.A. deve ter entre {2} e {1} números.")]
        [Display(Name = "Registro Acadêmico (R.A.)")]
        public string RA { get; set; } = string.Empty;

        [Required(ErrorMessage = "Selecione ou digite um curso.")]
        [Display(Name = "Curso")]
        public string Curso { get; set; } = string.Empty;

        [Required(ErrorMessage = "A data de nascimento é obrigatória.")]
        [DataType(DataType.Date)]
        [Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
    }
}
