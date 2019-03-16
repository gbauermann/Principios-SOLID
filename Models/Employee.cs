﻿using System;

namespace Models
{
    public class Employee : IEmployee
    {
        public string FirtName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }    
        public bool IsManager { get; set; } = false;
        public bool IsExecutive { get; set; } = false;
    }
}
