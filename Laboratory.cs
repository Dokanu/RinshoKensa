using System;
using System.Collections.Generic;
using System.Text;

namespace LaboratoryChecker
{
    public class Laboratory
    {
        public int id { get; set; }

        public int number { get; set; }

        public string subject { get; set; } = string.Empty;

        public bool isCompleted { get; set; }

        public bool inWork { get; set; }

        public bool inWait { get; set; }
    }
}
