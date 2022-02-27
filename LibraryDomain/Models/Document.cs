﻿using System;

namespace LibraryDomain.Models
{
    public class Document
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime DatePublished { get; set; }
    }
}
