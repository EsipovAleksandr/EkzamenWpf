//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoShop.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.OrdersDetail = new HashSet<OrdersDetail>();
        }
    
        public int Id { get; set; }
        public string Order_details { get; set; }
        public string Order_status { get; set; }
        public string Waybill_num { get; set; }
        public decimal Sum_final { get; set; }
        public decimal Sum_payed { get; set; }
        public System.DateTime Order_date { get; set; }
        public System.DateTime Date_send { get; set; }
        public Nullable<System.DateTime> Date_arrive { get; set; }
        public string Delivery { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrdersDetail> OrdersDetail { get; set; }
    }
}