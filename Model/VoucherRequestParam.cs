using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Tham số để đẩy chứng từ
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public class VoucherRequestParam
    {
        /// <summary>
        /// Mã công ty kết nối (Nhập tùy ý). Recommend nên để mã số thuế công ty kết nối với Amis Kế toán
        /// </summary>
        public string org_company_code { get; set; } = "01012431250";
        /// <summary>
        /// AMIS kế toán sẽ cung cấp cho đối tác một mã ứng dụng (app_id), mã ứng dụng này dùng để nhận diện ứng dụng khi kết nối với AMIS kế toán. 
        /// Đối tác vui lòng liên hệ với MISA để được cung cấp mã ứng dụng này.
        /// </summary>
        public string app_id { get; set; }
        /// <summary>
        /// Danh sách các chứng từ đẩy lên
        /// </summary>
        public List<VoucherObject> voucher { get; set; }
        /// <summary>
        /// Danh sách danh mục đẩy kèm chứng từ
        /// </summary>
        public List<DictionaryObject> dictionary { get; set; }

    }
}
