using System;
using System.Collections.Generic;
using System.Text;

namespace NotesApp
{
    public class InformationDetails
    {
        public string Name { get; set; }
        
        public string Details { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
