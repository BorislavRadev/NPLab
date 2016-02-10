
using System;
using System.Collections.Generic;
namespace NPLab.Models
{
    public class Object
    {
        private ICollection<Sectors> sectors;

        public Object()
        {
            this.sectors = new HashSet<Sectors>();
        }

        public int Id { get; set; }

        public DateTime Time { get; set; }

        public string ObjectName { get; set; }

        public virtual ICollection<Sectors> ListOfSectors 
        {
            get { return this.sectors; }
            set {this.sectors = value; }
        }
    }
}
