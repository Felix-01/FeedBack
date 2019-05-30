﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedBack.Models.ViewModels
{
    public class FeedbackViewModel
    {
        public string Comment { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public int? Select { get; set; }
        public List<Answer> Answers { get; set; }
    }
}