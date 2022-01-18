using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clientside
{
    class Locations
    {
        public int Id { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public int UserId { get; set; }
        
        public Locations(int Id,string lat,string lng,int UserId)
        {
            this.UserId = UserId;
            this.lat = lat;
            this.lng = lng;
            this.Id = Id;
        }
    }
}
