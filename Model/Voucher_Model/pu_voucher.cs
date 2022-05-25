using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    public class pu_voucher: VoucherObject
    {
        public int voucher_type { get; set; } = 18;
        public int? org_reftype { get; set; } = 302;
        public string org_reftype_name { get; set; } = "Mua hàng chưa thanh toán";
        public int? reftype { get; set; } = 302;

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string account_object_address { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string account_object_address_other { get; set; }
        /// <summary>
        /// Tài khoản đơn vị nhận tiền
        /// </summary>
        public string account_object_bank_account { get; set; }
        /// <summary>
        /// Tên ngân hàng đơn vị nhận tiền
        /// </summary>
        public string account_object_bank_name { get; set; }
        /// <summary>
        /// Mã đối tượng
        /// </summary>
        public string account_object_code { get; set; }
        /// <summary>
        /// Người giao hàng (Phiếu nhập)
        /// </summary>
        public string account_object_contact_name { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_identification_number_other { get; set; }
        /// <summary>
        /// Tên nhà cung cấp/khách hàng/cán bộ
        /// </summary>
        public string account_object_name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string attachment_id_list { get; set; }
        public Guid? bank_account_id { get; set; }
        public string bank_account_number { get; set; }
        public string bank_name { get; set; }
        public Guid? branch_id { get; set; }
        public decimal caba_amount { get; set; }
        public decimal caba_amount_oc { get; set; }
        /// <summary>
        /// Lý do chi/Nội dung thanh toán
        /// </summary>
        public string caba_journal_memo { get; set; }
        /// <summary>
        /// Ngày hạch toán (Phiếu chi)
        /// </summary>
        public DateTime? caba_posted_date { get; set; }
        /// <summary>
        /// Ngày chứng từ (Phiếu chi)
        /// </summary>
        public DateTime? caba_refdate { get; set; }
        /// <summary>
        /// Số chứng từ sổ tài chính (Phiếu chi)
        /// </summary>
        public string caba_refno_finance { get; set; }
        public DateTime? cash_book_posted_date { get; set; }
        /// <summary>
        /// Loại tiền
        /// </summary>
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
        public decimal discount_by_invoice_rate { get; set; }
        /// <summary>
        /// Loại chiết khấu 
        /// 0: Không chiết khấu 
        /// 1: Chiết khấu theo mặt hàng 
        /// 2: Chiết khấu theo % Hóa đơn 
        /// 3: Chiết khấu theo số tiền trên tổng hóa đơn
        /// </summary>
        public int? discount_type { get; set; }
        public int? display_on_book { get; set; } = 0;
        /// <summary>
        /// Ngày thanh toán
        /// </summary>
        public DateTime? due_date { get; set; }
        /// <summary>
        /// Hạn thanh toán (bao nhiêu ngày)
        /// </summary>
        public int? due_time { get; set; }
        /// <summary>
        /// ID nhân viên
        /// </summary>

        public Guid? employee_id { get; set; }
        /// <summary>
        /// Tên nhân viên
        /// </summary>
        public string employee_name { get; set; }
        /// <summary>
        /// Tỷ giá hối đoái
        /// </summary>
        public decimal exchange_rate { get; set; }
        /// <summary>
        /// Có lập kèm hóa đơn không
        /// 0: Không kèm hóa đơn
        /// 1: Nhận kèm hóa đơn
        /// 2: Không có hóa đơn
        /// </summary>
        public int? include_invoice { get; set; }
        /// <summary>
        /// Ngày hạch toán tab phiếu nhập chứng từ mua hàng
        /// </summary>
        public DateTime? in_reforder { get; set; }
        public bool? is_pu_lot_voucher { get; set; }
        /// <summary>
        /// Lý do chi/Nội dung thanh toán
        /// </summary>
        public string journal_memo { get; set; }
        public int? paid_status { get; set; }
        public Guid? payment_term_id { get; set; }
        /// <summary>
        /// Ngày hạch toán (Phiếu nhập/Chứng từ ghi nợ)
        /// </summary>
        public DateTime? posted_date { get; set; }
        /// <summary>
        /// RefID của hóa đơn mua hàng
        /// </summary>
        public Guid? pu_invoice_refid { get; set; }
        /// <summary>
        /// Người nhận (Phiếu chi)/Người lĩnh tiền (Séc tiền mặt)
        /// </summary>
        public string receiver { get; set; }
        /// <summary>
        /// Ngày chứng từ (Phiếu nhập/Chứng từ ghi nợ)
        /// </summary>
        public DateTime? refdate { get; set; }
        /// <summary>
        /// Primary key
        /// </summary>
        public Guid? refid { get; set; }
        /// <summary>
        /// Số chứng từ (Phiếu nhập/Chứng từ ghi nợ)
        /// </summary>
        public string refno_finance { get; set; }
        /// <summary>
        /// Loại chứng từ (lấy từ bảng RefType trong docs)
        /// </summary>
        public string reftype_name { get; set; }
        public decimal total_amount { get; set; } = 0;
        public decimal total_amount_oc { get; set; } = 0;
        public decimal total_custom_before_amount { get; set; } = 0;
        public decimal total_discount_amount { get; set; } = 0;
        public decimal total_discount_amount_oc { get; set; } = 0;
        public decimal total_freight_amount { get; set; } = 0;
        public decimal total_import_tax_amount { get; set; } = 0;
        public decimal total_import_tax_amount_oc { get; set; } = 0;
        public decimal total_inward_amount { get; set; } = 0;
        public decimal total_special_consume_tax_amount { get; set; }= 0;
        public decimal total_special_consume_tax_amount_oc { get; set; }= 0;
        public decimal total_vat_amount { get; set; }= 0;
        public decimal total_vat_amount_oc { get; set; } = 0;
        public string employee_code { get; set; }
        public pu_invoice pu_invoice { get; set; } = null;
        public List<pu_voucher_detail> detail { get; set; }


    }
}
