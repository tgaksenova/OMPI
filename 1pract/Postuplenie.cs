//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _1pract
{
    using System;
    using System.Collections.Generic;
    
    public partial class Postuplenie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Postuplenie()
        {
            this.Material = new HashSet<Material>();
        }
    
        public Nullable<System.DateTime> Data_postupleniy { get; set; }
        public int C_documenta { get; set; }
        public string Svediniy_o_postavshike { get; set; }
        public Nullable<int> kolichestvo_material { get; set; }
        public Nullable<int> price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Material> Material { get; set; }
    }
}
