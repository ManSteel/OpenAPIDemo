using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;
using WindowsFormsApp1.Model.Enum;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Chứng từ bán hàng/ bán dịch vụ
    /// </summary>
    public class sa_voucher: VoucherObject
    {
        public int voucher_type { get; set; } = 13;
        public int org_reftype { get; set; } = (int)EnumReftype.SaVoucherUnpaid;
        public string org_reftype_name { get; set; } = "Chứng từ bán hàng";
        public int reftype { get; set; } = (int)EnumReftype.SaVoucherUnpaid;
        /// <summary>
        /// thông tin phiếu xuất kho (sử dụng khi là chứng từ bán hàng kiêm phiếu xuất)
        /// </summary>
        public in_outward in_outward { get; set; }
        /// <summary>
        /// thông tin hóa đơn (sử dụng khi là chứng từ bán hàng kèm hóa đơn)
        /// </summary>
        public sa_invoice sa_invoice { get; set; }
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public string account_object_tax_code { get; set; }
        public Guid? bank_account_id { get; set; }
        public string bank_account_number { get; set; }
        public string bank_name { get; set; }
        public Guid? branch_id { get; set; } = Guid.Empty;
        public decimal caba_amount { get; set; }
        public decimal caba_amount_oc { get; set; }
        public DateTime? cash_book_posted_date { get; set; }
        public string currency_id { get; set; }
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
        public int? debt_status { get; set; }
        public decimal discount_rate_voucher { get; set; }
        public int? discount_type { get; set; }
        public int? display_on_book { get; set; } = 0;
        public DateTime? due_date { get; set; }
        public int? due_day { get; set; }
        public string employee_code { get; set; }
        public Guid? employee_id { get; set; }
        public string employee_name { get; set; }
        public decimal exchange_rate { get; set; } = 1;
        /// <summary>
        /// có lập kèm hóa đơn không
        /// 0 không lập kèm, 1 : có lập kèm hóa đơn
        /// </summary>
        public int? include_invoice { get; set; }
        public DateTime? in_reforder { get; set; }
        public DateTime? inv_date { get; set; }
        public string inv_no { get; set; }
        public string inv_series { get; set; }
        public bool? is_invoice_exported { get; set; }
        public bool? is_invoice_exported_last_year { get; set; }
        public bool? is_paid { get; set; }
        public bool? is_remind_debt { get; set; } = false;
        public bool? is_sale_with_outward { get; set; } = false;
        public string journal_memo { get; set; }
        public string modified_by { get; set; }
        public DateTime? modified_date { get; set; }
        public string other_term { get; set; }
        /// <summary>
        /// Đã xuất hàng (0: Chưa xuất, 1: Đã xuất, 2: Để trắng <đối với hóa đơn bán hàng mà tất cả  mặt hàng đều có tính chất dịchvụ>), 3 là xuất một phần
        /// </summary>
        public int? outward_exported_status { get; set; }
        public Guid? outward_refid { get; set; }
        /// <summary>
        /// hết tiền thì cập nhật = 1 chi tiết: 0: chưa thanh toán, 1: thanh toán hết, 2: thanh toán một phần
        /// </summary>
        public int? paid_type { get; set; }
        /// <summary>
        /// Người nộp (Bán hàng thu tiền ngay) / Người liên hệ (Bán hàng chưa thu tiền)
        /// </summary>
        public string payer { get; set; }
        public string payment_term_code { get; set; }
        public Guid? payment_term_id { get; set; }
        public string payment_term_name { get; set; }
        public DateTime? posted_date { get; set; }
        public Guid? pu_voucher_refid { get; set; }
        public DateTime? refdate { get; set; }
        public long? reforder { get; set; }
        public Guid? sa_invoice_refid { get; set; }
        public string shipping_address { get; set; }
        public string supplier_code { get; set; }

        public Guid? supplier_id { get; set; }
        public string supplier_name { get; set; }

        public decimal total_amount { get; set; }
        public decimal total_amount_oc { get; set; }
        public decimal total_discount_amount { get; set; }
        public decimal total_discount_amount_oc { get; set; }
        public decimal total_export_tax_amount { get; set; }
        public decimal total_export_tax_amount_oc { get; set; }
        public decimal total_sale_amount { get; set; }
        public decimal total_sale_amount_oc { get; set; }
        public decimal total_vat_amount { get; set; }
        public decimal total_vat_amount_oc { get; set; }
        public List<sa_voucher_detail> detail { get; set; }

    }
}
