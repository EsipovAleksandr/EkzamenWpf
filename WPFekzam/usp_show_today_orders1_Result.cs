//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WPFekzam
{
    using System;
    
    public partial class usp_show_today_orders1_Result
    {
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
    }
}