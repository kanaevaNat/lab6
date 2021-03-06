//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace kp4.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    public partial class Patient
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Patient()
        {
            this.Entry = new HashSet<Entry>();
            this.Visit = new HashSet<Visit>();
        }
        [Key]
        public int id { get; set; }
        [Display(Name = "Фамилия")]
        public string last_name { get; set; }
        [Display(Name = "Имя")]
        public string name { get; set; }
        [Display(Name = "Отчество")]
        public string patronymic { get; set; }
        [Display(Name = "Адрес")]
        public string adress { get; set; }
        [Display(Name = "Дата рождения")]
        public Nullable<System.DateTime> date { get; set; }
        [Display(Name = "Врач")]
        public Nullable<int> id_doctor { get; set; }
        [Display(Name = "Логин")]
        public string login { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entry> Entry { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Visit> Visit { get; set; }
    }
}
