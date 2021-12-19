using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreinamentoAspNetMvcUdemy.Models
{
    public class Usuario
    {
        /// <summary>
        /// Validações utilizando o DataAnnotations
        /// </summary>
        [Required(ErrorMessage="Nome é obrigatório")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5, ErrorMessage ="Insira uma informação de 5 a 50 caracteres")]
        public string Observacoes { get; set; }

        [Range(18,70,ErrorMessage ="Idade tem que estar entre 18 e 70 anos")]
        public int Idade { get; set; }

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="Digite um email válido")]
        public string Email { get; set; }

        [RegularExpression(@"[a-zA-Z]{5,15}",ErrorMessage ="Somente letras e de 5 a 15 caracteres")]
        [Required(ErrorMessage = "Login é obrigatório")]
        [Remote("LoginUnico","Usuario",ErrorMessage = "Este login já existe")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Senha { get; set; }

        [System.ComponentModel.DataAnnotations.Compare("Senha",ErrorMessage ="As senhas não são iguais")]
        public string ConfirmarSenha { get; set; } 

        
    }
}