﻿using System.Collections.Generic;

namespace EntityFramework.CodeFirst.Advanced.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IList<Course> Courses { get; set; }  
    }
}