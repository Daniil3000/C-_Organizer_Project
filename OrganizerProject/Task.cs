//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OrganizerProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> Finish { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public Nullable<bool> IsFinished { get; set; }
    }
}
