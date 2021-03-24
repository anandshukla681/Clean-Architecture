using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Entities
{
    public class Defect
    {
        public int DefectId { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public int ClosedBy { get; set; }
        public DateTime ClosedOn { get; set; }
        public int AssignedTo { get; set; }
        public int AssignedBy { get; set; }
        public string Remarks { get; set; }
    }
}
