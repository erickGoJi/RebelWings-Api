﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable enable
using System;
using System.Collections.Generic;

namespace biz.rebel_wings.Entities
{
    public partial class PhotoBanosMatutino
    {
        public int Id { get; set; }
        public int? BanosMatutinoId { get; set; }
        public string? Photo { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? UpdatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }

        public virtual BanosMatutino? BanosMatutino { get; set; }
    }
}