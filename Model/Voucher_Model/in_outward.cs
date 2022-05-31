using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Chứng từ xuất kho
    /// </summary>
    /// Created by LDLONG 30.05.2022
    public class in_outward
    {
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public string account_object_tax_code { get; set; }
        public Guid? assembly_refid { get; set; }
        public Guid? branch_id { get; set; }
        public string contact_name { get; set; }
        public string contract_code { get; set; }
        public string created_by { get; set; }
        public DateTime? created_date { get; set; }
        public string custom_field1 { get; set; }
        public string custom_field2 { get; set; }
        public string custom_field3 { get; set; }
        public string custom_field4 { get; set; }
        public string custom_field5 { get; set; }
        public string custom_field6 { get; set; }
        public string custom_field7 { get; set; }
        public string custom_field8 { get; set; }
        public string custom_field9 { get; set; }
        public string custom_field10 { get; set; }
        public string employee_code { get; set; }
        public Guid? employee_id { get; set; }
        public string employee_name { get; set; }
        public Guid? from_stock_id { get; set; }
        public DateTime? in_reforder { get; set; }
        public DateTime? inventory_posted_date { get; set; }
        public string inv_no { get; set; }
        public string inv_series { get; set; }
        public string inv_template_no { get; set; }
        /// <summary>
        /// Loại hóa đơn:
        /// 0 : nhập tay
        /// 1.Hóa đơn giá trị gia tăng; 
        /// 2.Hóa đơn bán hàng; 
        /// 3.Phiếu xuất kho kiêm vận chuyển hàng hóa nội bộ; 
        /// 4.Phiếu xuất kho gửi bán hàng đại lý; 
        /// 5.Hóa đơn xuất khấu; 
        /// 6.Hóa đơn bán hàng(dành cho tổ chức, cá nhân trong khu phi thuế quan)
        /// </summary>
        public int? inv_type_id { get; set; }
        public bool? is_branch_issued { get; set; }
        public bool? is_invoice_replace { get; set; }
        public bool? is_sale_with_outward { get; set; }
        public string journal_memo { get; set; }
        public string modified_by { get; set; }
        public DateTime? modified_date { get; set; }
        public DateTime? order_date { get; set; }
        public string order_no { get; set; }
        public string organization_code { get; set; }
        public Guid? organization_id { get; set; }
        public string organization_name { get; set; }
        public DateTime? posted_date { get; set; }
        public DateTime? refdate { get; set; }
        public Guid? refid { get; set; }
        public string refno_finance { get; set; }
        public string refno_management { get; set; }
        public long? reforder { get; set; }
        public int? reftype { get; set; }
        public string reftype_name { get; set; }
        public int? revenue_status { get; set; }
        public string shipping_address { get; set; }
        public Guid? to_stock_id { get; set; }
        public decimal total_amount_finance { get; set; }
        public decimal total_amount_management { get; set; }
        public string transport { get; set; }
        public Guid? transporter_id { get; set; }
        public string transporter_name { get; set; }

    }
}
