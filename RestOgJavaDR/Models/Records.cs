﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace RestOgJavaDR.Models
{
    [Keyless]
    public partial class Records
    {
        public int? Id { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string title { get; set; }
        [StringLength(255)]
        [Unicode(false)]
        public string artist { get; set; }
        public int? duration { get; set; }
        public int? publicationYear { get; set; }
    }
}