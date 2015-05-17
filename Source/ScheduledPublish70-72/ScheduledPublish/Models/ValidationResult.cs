﻿using System.Collections.Generic;

namespace ScheduledPublish.Models
{
    public class ValidationResult
    {
        public bool IsValid { get; set; }
        public List<string> ValidationErrors { get; set; }

        public ValidationResult()
        {
            ValidationErrors = new List<string>();
        }
    }
}