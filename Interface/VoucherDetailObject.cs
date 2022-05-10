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
    public abstract class VoucherDetailObject
    {
        public Guid? ref_detail_id { get; set; }
        public Guid? refid { get; set; }
    }
}
