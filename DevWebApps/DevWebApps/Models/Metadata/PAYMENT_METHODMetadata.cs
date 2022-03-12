using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevWebApps.Models
{
    [MetadataType(typeof(PAYMENT_METHOD.Metadata))]
    public partial class PAYMENT_METHOD
    {
        sealed class Metadata
        {
            [Display(Name ="Mã")]
            public long ID { get; set; }
            [Display(Name = "Tên")]
            public string NAME { get; set; }
            [Display(Name = "Ghi chú")]
            public string NOTES { get; set; }
            [Display(Name = "Ngày tạo")]
            public Nullable<System.DateTime> CREATED_DATE { get; set; }
            [Display(Name = "Ngày sửa")]
            public Nullable<System.DateTime> UPDATED_DATE { get; set; }
            [Display(Name = "Đã xóa")]
            public Nullable<byte> ISDELETE { get; set; }
            [Display(Name = "Trạng thái")]
            public Nullable<byte> ISACTIVE { get; set; }
        }
    }
}