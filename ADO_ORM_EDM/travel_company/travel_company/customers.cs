//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace travel_company
{
    using System;
    using System.Collections.Generic;
    
    public partial class customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public customers()
        {
            this.Creat_table_baseClient = new HashSet<Creat_table_baseClient>();
        }
    
        public int Id { get; set; }
        public string name { get; set; }
        public string last_name { get; set; }
        public int client_baseId { get; set; }
    
        public virtual trip trip { get; set; }
        public virtual client_base client_base { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Creat_table_baseClient> Creat_table_baseClient { get; set; }
    }
}
