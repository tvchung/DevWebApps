using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DevWebApps.Models
{
    [MetadataType(typeof(CATEGORY.Metadata))]
    public partial class CATEGORY
    {
        sealed class Metadata
        {
            [Display(Name ="Mã")]
            public long ID { get; set; }

            [Display(Name = "Tên")]
            public string NAME { get; set; }

            [Display(Name = "Ghi chú")]
            public string NOTES { get; set; }
            [Display(Name = "Ảnh")]
            public string ICON { get; set; }
            [Display(Name = "Danh mục")]
            public Nullable<long> IDPARENT { get; set; }
            [Display(Name = "Slug")]
            public string SLUG { get; set; }
            [Display(Name = "Meta title")]
            public string META_TITLE { get; set; }
            [Display(Name = "Meta keyword")]
            public string META_KEYWORD { get; set; }
            [Display(Name = "Meta description")]
            public string META_DESCRIPTION { get; set; }
            [Display(Name = "Ngày tạo")]
            public Nullable<System.DateTime> CREATED_DATE { get; set; }
            [Display(Name = "Ngày sửa")]
            public Nullable<System.DateTime> UPDATED_DATE { get; set; }
            [Display(Name = "Ngưởi tạo")]
            public Nullable<long> CREATED_BY { get; set; }
            [Display(Name = "Người sửa")]
            public Nullable<long> UPDATED_BY { get; set; }
            [Display(Name = "Đã xóa")]
            public Nullable<byte> ISDELETE { get; set; }
            [Display(Name = "Trạng thái")]
            public Nullable<byte> ISACTIVE { get; set; }
        }
    }
}