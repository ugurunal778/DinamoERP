using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class InterruptsDto
    {
        public int Id { get; set; }
        public int workNo { get; set; }
        public DateTime Start { get; set; }
        public DateTime Stop { get; set; }
        public string Stats { get; set; }
        public string Reason { get; set; }
    }
}