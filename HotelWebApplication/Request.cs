//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelWebApplication
{
    using System;
    using System.Collections.Generic;
    
    public partial class Request
    {
        public int req_ID { get; set; }
        public int type { get; set; }
        public string comment { get; set; }
        public int status { get; set; }
        public int room_nr { get; set; }
    
        public virtual Room Room { get; set; }
    }
}