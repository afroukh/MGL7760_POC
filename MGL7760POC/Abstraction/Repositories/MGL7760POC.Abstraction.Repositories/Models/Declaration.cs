using System;
using System.Collections.Generic;
using System.Text;

namespace MGL7760POC.Abstraction.Repositories.Models
{
    public class Declaration
    {
        public int Id { get; set; }
        public string DateCreation { get; set; }
        public string FullName { get; set; }
        public string NAS { get; set; }


        public Declaration()
        {
        }
    }
}
