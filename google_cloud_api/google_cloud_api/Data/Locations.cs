using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace google_cloud_api.Data
{
    public class Locations
    {
        public int Id { get; set; }
        public string lat { get; set; }
        public string lng { get; set; }
        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual Person Person { get; set; }
    }
}
