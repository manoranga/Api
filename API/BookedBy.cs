//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API
{
    using System;
    using System.Collections.Generic;
    
    public partial class BookedBy
    {
        public int TouristId { get; set; }
        public int BookingId { get; set; }
    
        public virtual CabBooking CabBooking { get; set; }
        public virtual RoomBooking RoomBooking { get; set; }
        public virtual TourGuideBooking TourGuideBooking { get; set; }
        public virtual Tourist Tourist { get; set; }
    }
}
