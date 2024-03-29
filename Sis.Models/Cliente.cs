﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Sis.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }
        [Required]
        /*        [MaxLength(2)]
                [Range(0, 100)]*/
        public string? Name { get; set; }

        [DisplayName("Valor da conta")]
        public double? Value { get; set; }
    }
}
