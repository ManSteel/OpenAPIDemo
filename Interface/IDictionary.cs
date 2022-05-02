using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Interface
{
    /// <summary>
    /// Danh mục đẩy kèm chứng từ (vật tư hàng hóa, khách hàng, nhà cung cấp, nhân viên, đơn vị tính, kho, ...)
    /// </summary>
    public interface IDictionary
    {
        /// <summary>
        /// 0: Chưa xác định
        /// 1: Đối tượng, xem định nghĩa cấu trúc input chi tiết tại: account_object
        /// 2: Nhóm đối tượng, xem định nghĩa cấu trúc input chi tiết tại: account_ object_ group
        /// 3: Vật tư, xem định nghĩa cấu trúc input chi tiết tại: inventory_item
        /// 4: Nhóm vật tư, xem định nghĩa cấu trúc input chi tiết tại: inventory_ item_ category
        /// 5: Kho, xem định nghĩa cấu trúc input chi tiết tại: stock
        /// 6: Đơn vị tính, xem định nghĩa cấu trúc input chi tiết tại: unit
        /// 7: Tài khoản ngân hàng, xem định nghĩa cấu trúc input chi tiết tại: bank_account
        /// 8: Ngân hàng, xem định nghĩa cấu trúc input chi tiết tại: bank
        /// 9: Khoản mục chi phí, xem định nghĩa cấu trúc input chi tiết tại: budget_item
        /// 10: Mục thu chi, xem định nghĩa cấu trúc input chi tiết tại: expense_item
        /// </summary>
        int dictionary_type { get; set; }
        string created_by { get; set; }
        DateTime? created_date { get; set; }
        string modified_by { get; set; }
        DateTime? modified_date { get; set; }
    }
}
