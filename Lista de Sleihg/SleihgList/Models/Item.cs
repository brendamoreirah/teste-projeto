using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SleingList.Models;

namespace SleighList.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }
        public string? Nome { get; set; }
        public int Quantidade { get; set; }
        public int PrecoUnidade { get; set; }

        [ForeignKey("Usuario")]
        public int? UsuarioID { get; set; }
        public Usuario? Usuario { get; set; }

    }
}