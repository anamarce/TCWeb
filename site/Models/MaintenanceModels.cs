using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;

namespace site.Models
{
    public class Question {
    [Required]
    [Display(Name = "Tema")]
    public string Topic { get; set; }

    [Required]
    [Display (Name = "Pregunta")]
    public string QuestionText { get; set; }

    [Required]
    [Display (Name = "Respuesta Correcta")]
    public string Answer1 { get; set; }

    [Required]
    [Display (Name = "Segunda Opcion")]
    public string Answer2 { get; set; }

    [Required]
    [Display(Name = "Tercera Opcion")]
    public string Answer3 { get; set; }

    [Required]
    [Display(Name = "Cuarta Opcion")]
    public string Answer4 { get; set; }
    }
}
