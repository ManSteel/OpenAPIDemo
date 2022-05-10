using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Danh mục đối tượng (Nhà cung cấp, khách hàng, nhân viên)
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public class account_object : DictionaryObject
    {
        public int dictionary_type { get; set; } = 1;
        public string account_object_bank_account { get; set; }
        public string account_object_code { get; set; }
        public string account_object_group_code_list { get; set; } = null;
        public string account_object_group_id_list { get; set; } = null;
        public string account_object_group_misa_code_list { get; set; } = null;
        public string account_object_group_name_list { get; set; } = null;
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public string account_object_shipping_address { get; set; }
        /// <summary>
        /// 0 = là tổ chức; 1 = Là cá nhân
        /// </summary>
        public int? account_object_type { get; set; } = 0;
        public string address { get; set; }
        public decimal agreement_salary { get; set; } = 0;
        /// <summary>
        /// Tài khoản ngân hàng
        /// </summary>
        public string bank_account { get; set; }
        /// <summary>
        /// Chi nhánh tài khoản ngân hàng
        /// </summary>
        public string bank_branch_name { get; set; }
        /// <summary>
        /// Tên ngân hàng
        /// </summary>
        public string bank_name { get; set; }
        public Guid? branch_id { get; set; }
        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string company_tax_code { get; set; }
        /// <summary>
        /// Địa chỉ người liên hệ
        /// </summary>
        public string contact_address { get; set; }
        /// <summary>
        /// Email người liên hệ
        /// </summary>
        public string contact_email { get; set; }
        /// <summary>
        /// Điện thoại cố định người liên hệ
        /// </summary>
        public string contact_fixed_tel { get; set; }
        /// <summary>
        /// Số điện thoại di động của người liên hệ
        /// </summary>
        public string contact_mobile { get; set; }
        /// <summary>
        /// Tên người liên hệ
        /// </summary>
        public string contact_name { get; set; }
        /// <summary>
        /// Chức vụ người liên hệ (Nếu đối tượng là nhân viên thì đây chính là chức vụ mặc định của nhân viên đó)
        /// </summary>
        public string contact_title { get; set; }
        /// <summary>
        /// Quốc gia
        /// </summary>
        public string country { get; set; }
        public string crm_group_id { get; set; }
        public string crm_id { get; set; }
        /// <summary>
        /// công nợ khách hàng/nhà cung cấp
        /// </summary>
        public decimal debt_amount { get; set; }
        public string description { get; set; }
        /// <summary>
        /// Quận huyện
        /// </summary>
        public string district { get; set; }
        /// <summary>
        /// Hạn nợ ( Số ngày được nợ)
        /// </summary>
        public int? due_time { get; set; }
        /// <summary>
        /// Email người nhận hóa đơn điện tử
        /// </summary>
        public string einvoice_contact_email { get; set; }
        /// <summary>
        /// Mobile người nhận hóa đơn điện tử
        /// </summary>
        public string einvoice_contact_mobile { get; set; }
        /// <summary>
        /// Người nhận hóa đơn điện tử
        /// </summary>
        public string einvoice_contact_name { get; set; }
        /// <summary>
        /// Địa chỉ Email của tổ chức
        /// </summary>
        public string email_address { get; set; }
        public Guid? employee_id { get; set; }
        /// <summary>
        /// Fax
        /// </summary>
        public string fax { get; set; }
        public int? gender { get; set; } = 1;
        /// <summary>
        /// Số CMTND của người liên hệ
        /// </summary>
        public string identification_number { get; set; }
        public bool? inactive { get; set; }
        /// <summary>
        /// Lương đóng bảo hiểm
        /// </summary>
        public decimal insurance_salary { get; set; } = 0;
        public bool? is_convert { get; set; } = false;
        public bool? is_customer { get; set; } = false;
        public bool? is_employee { get; set; } = false;
        public bool? is_same_address { get; set; }
        public bool? is_vendor { get; set; } = false;
        public decimal maximize_debt_amount { get; set; } = 0;
        public string mobile { get; set; }
        public int? number_of_dependent { get; set; } = 0;
        public Guid? organization_unit_id { get; set; } = null;
        public string organization_unit_name { get; set; }
        public string other_contact_mobile { get; set; }
        public string pay_account { get; set; }
        public decimal receiptable_debt_amount { get; set; } = 0;
        public string receive_account { get; set; }
        public decimal salary_coefficient { get; set; } = 0;
    }
}
