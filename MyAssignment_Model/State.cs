﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAssignment_Model
{
    [Table("State")]
    public class State
    {
        [Key]
        public Int16 Id { get; set; }
        public string? Name { get; set; }
    }
}
