﻿using System.ComponentModel.DataAnnotations;

namespace SisMed.ViewModels.Paciente
{
    public class AdicionarPacienteViewModel
    {
        public string CPF { get; set; } = String.Empty;

        public string Nome { get; set; } = String.Empty;

        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }
    }
}
