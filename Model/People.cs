using System.Collections.Generic;

namespace EF_EXAMPLE.Model.Context
{
    public class People
    {
        public People(){
            
        }

        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int JobsID { get; set; }
        
        public virtual Jobs Jobs{ get; set; }
    }
}
