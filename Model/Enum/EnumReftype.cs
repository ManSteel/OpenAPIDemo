using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Enum
{
    /// <summary>
    /// Loại chứng từ trên amis kế toán
    /// </summary>
    public enum EnumReftype
    {
        /// <summary>
        /// Đơn đặt hàng
        /// </summary>
        SaOrder = 3520,
        /// <summary>
        /// Bán hàng hóa, dịch vụ trong nước chưa thu tiền
        /// </summary>
        SaVoucherUnpaid = 3530,
        /// <summary>
        /// Bán hàng hóa, dịch vụ trong nước - Tiền mặt
        /// </summary>
        SaVoucherPaidCash = 3531,
        /// <summary>
        /// Bán hàng xuất khẩu
        /// </summary>
        SaVoucherExport = 3532,
        /// <summary>
        /// Bán hàng đại lý bán đúng giá - Chưa thu tiền
        /// </summary>
        SaVoucher3534 = 3534,
        /// <summary>
        /// Bán hàng đại lý bán đúng giá - Tiền mặt
        /// </summary>
        SaVoucher3535 = 3535,

        /// <summary>
        /// Bán hàng nhận ủy thác xuất khẩu
        /// </summary>
        SaVoucher3536 = 3536,

        /// <summary>
        /// Bán hàng hóa, dịch vụ trong nước - Chuyển khoản
        /// </summary>
        SaVoucher3537 = 3537,

        /// <summary>
        /// Bán hàng đại lý bán đúng giá - Chuyển khoản
        /// </summary>
        SaVoucher3538 = 3538,

        /// <summary>
        /// Mua hàng trong nước nhập kho chưa thanh toán
        /// </summary>
        PuVoucher302 = 302,

        /// <summary>
        /// Mua hàng trong nước nhập kho - Tiền mặt
        /// </summary>
        PuVoucher307 = 307,

        /// <summary>
        /// Mua hàng trong nước nhập kho  - Ủy nhiệm chi
        /// </summary>
        PuVoucher308 = 308,

        /// <summary>
        /// Mua hàng trong nước nhập kho  - Chuyển khoản
        /// </summary>
        PuVoucher309 = 309,

        /// <summary>
        /// Mua hàng trong nước nhập kho  - Séc tiền mặt
        /// </summary>
        PuVoucher310 = 310,

        /// <summary>
        /// Mua hàng trong nước không qua kho chưa thanh toán
        /// </summary>
        PuVoucher312 = 312,

        /// <summary>
        /// Mua hàng trong nước không qua kho - Tiền mặt
        /// </summary>
        PuVoucher313 = 313,

        /// <summary>
        /// Mua hàng trong nước không qua kho - Ủy nhiệm chi
        /// </summary>
        PuVoucher314 = 314,

        /// <summary>
        /// Mua hàng trong nước không qua kho - Chuyển khoản
        /// </summary>
        PuVoucher315 = 315,
        /// <summary>
        /// Mua hàng trong nước không qua kho - Séc tiền mặt
        /// </summary>
        PuVoucher316 = 316,
        /// <summary>
        /// Mua hàng nhập khẩu nhập kho chưa thanh toán
        /// </summary>
        PuVoucher318 = 318,
        /// <summary>
        /// Mua hàng nhập khẩu nhập kho - Tiền mặt
        /// </summary>
        PuVoucher319 = 319,
        /// <summary>
        /// Mua hàng nhập khẩu nhập kho - Ủy nhiệm chi
        /// </summary>
        PuVoucher320 = 320,
        /// <summary>
        /// Mua hàng nhập khẩu nhập kho - Chuyển khoản
        /// </summary>
        PuVoucher321 = 321,
        /// <summary>
        /// Mua hàng nhập khẩu nhập kho - Séc tiền mặt
        /// </summary>
        PuVoucher322 = 322,
        /// <summary>
        /// Mua hàng nhập khẩu không qua kho chưa thanh toán
        /// </summary>
        PuVoucher324 = 324,
        /// <summary>
        /// Mua hàng nhập khẩu không qua kho - Tiền mặt
        /// </summary>
        PuVoucher325 = 325,
        /// <summary>
        /// Mua hàng nhập khẩu không qua kho - Ủy nhiệm chi
        /// </summary>
        PuVoucher326 = 326,
        /// <summary>
        /// Mua hàng nhập khẩu không qua kho - Chuyển khoản
        /// </summary>
        PuVoucher327 = 327,
        /// <summary>
        /// Mua hàng nhập khẩu không qua kho - Séc tiền mặt
        /// </summary>
        PuVoucher328 = 328,
        /// <summary>
        /// Phiếu thu tiền mặt khách hàng
        /// </summary>
        CaReceipt = 1010,
        /// <summary>
        /// Phiếu thu tiền gửi khách hàng
        /// </summary>
        BaDeposit = 1500

    }
}
