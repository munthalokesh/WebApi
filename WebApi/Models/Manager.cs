//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Manager
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Manager()
        {
            this.HangerDetails = new HashSet<HangerDetail>();
        }
    
        public string ManagerId { get; set; }
        public string ManagerName { get; set; }
        public string SSNo { get; set; }
        public System.DateTime Dob { get; set; }
        public string Gender { get; set; }
        public string MobileNo { get; set; }
        public string Email { get; set; }
        public string AddressId { get; set; }
        public Nullable<int> Id { get; set; }
    
        public virtual Address Address { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HangerDetail> HangerDetails { get; set; }
    }
}
