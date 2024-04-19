using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateTask.Models
{
    internal class Group
    {
        private int Id { get; set; }
        private string Name { get; set; }

        public Group(string name)
        {
            Name = name;
            Id++;
        }
    }
}
