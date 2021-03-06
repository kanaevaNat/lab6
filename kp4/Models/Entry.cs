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

    public partial class Entry
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Пациент")]
        public Nullable<int> id_patient { get; set; }
        [Display(Name = "Врач")]
        public Nullable<int> id_doctor { get; set; }
        [Display(Name = "Расписание")]
        public Nullable<int> id_schedule { get; set; }
        [Display(Name = "Статус")]
        public Nullable<int> id_status { get; set; }
    
        public virtual Doctor Doctor { get; set; }
        public virtual Patient Patient { get; set; }
        public virtual Schedule Schedule { get; set; }
        public virtual StatusEntry StatusEntry { get; set; }
    }
}
