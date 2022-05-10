using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    /// <summary>
    /// Phần thông tin chung của chứng từ (master voucher)
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public abstract class VoucherObject
    {
        public string org_refid { get; set; }
        public bool is_get_new_id { get; set; } = true;
        public bool is_allow_group { get; set; } = false;
        public string org_refno { get; set; }
        public string refno_finance { get; set; }
        public int act_voucher_type { get; set; } = 0;
        public Guid refid { get; set; }
        /// <summary>
        /// Được tạo bởi ai (Trường này để amis accounting quản lý ai tạo không cần đẩy dữ liệu để mặc định Open API)
        /// </summary>
        public string created_by { get; set; } = "Open API";
        /// <summary>
        /// Ngày tạo (Trường này để amis accounting quản lý ai tạo không cần đẩy dữ liệu để mặc định Open API)
        /// </summary>
        public DateTime? created_date { get; set; } = DateTime.Now;
        public bool auto_refno { get; set; } = false;
    }
}
