using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Team
    {
        public Guid Id { get; set; }


        public string name { get; set; }
        public DateTime created_at { get; set; }

        public DateTime updated_at { get; set; }


    }
}