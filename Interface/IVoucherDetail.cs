using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    /// <summary>
    /// Thông tin chi tiết của chứng từ (detail voucher)
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public interface IVoucherDetail
    {
        Guid? ref_detail_id { get; set; }
        Guid? refid { get; set; }
    }
}
