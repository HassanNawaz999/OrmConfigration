using System;
using System.Collections.Generic;

namespace OrmConfigrationDemo.Models
{
    public partial class TblPlayerInfo
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Interest { get; set; }
    }
}
