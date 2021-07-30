using System.Collections.Generic;

namespace EF_EXAMPLE.Model.Context
{
    public class Jobs
    {
        public Jobs(){
            this.Peoples = new List<People>();
        }


        public int ID { get; set; }
        public string JobName { get; set; }


        public virtual ICollection<People> Peoples { get; set; }

        


    }
}
