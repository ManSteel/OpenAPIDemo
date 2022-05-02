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
    public interface IVoucher
    {
        int voucher_type { get; set; }
        string org_refid { get; set; }
        bool is_get_new_id { get; set; }
        bool is_allow_group { get; set; }
        string org_refno { get; set; }
        int org_reftype { get; set; }
        string org_reftype_name { get; set; }
        string refno_finance { get; set; }
        int act_voucher_type { get; set; }
        Guid refid { get; set; }
        int reftype { get; set; }
        string created_by { get; set; }
        DateTime? created_date { get; set; }
        bool auto_refno { get; set; }






    }
}
