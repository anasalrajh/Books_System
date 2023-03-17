namespace Books_System.Models
{
    using System;
    using System.Collections.Generic;

    public partial class tblCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCategory()
        {
            this.Books_Category = new HashSet<Books_Category>();
        }

        public int Id { get; set; }
        public string CategoryName { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Books_Category> Books_Category { get; set; }
        public List<tblSubCategory> SubCat { get; internal set; }
    }
}
