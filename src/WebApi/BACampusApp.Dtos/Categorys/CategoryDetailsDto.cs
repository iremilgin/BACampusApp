﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BACampusApp.Dtos.Categorys
{
    public class CategoryDetailsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid? TechnicalUnitId { get; set; }
        public Guid? ParentCategoryId { get; set; }

    }
}