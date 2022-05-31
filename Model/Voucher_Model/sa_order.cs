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
    /// Đơn đặt hàng
    /// </summary>
    /// Created by: LDLONG 30.4.2022
    public class sa_order: VoucherObject
    {
        public int voucher_type { get; set; } = 20;
        public int org_reftype { get; set; } = (int)EnumReftype.SaOrder;
        public string org_reftype_name { get; set; } = "Đơn đặt hàng";
        public int reftype { get; set; } = (int)EnumReftype.SaOrder;

        /// <summary>
        /// Địa chỉ giao hàng
        /// </summary>
        public string account_object_address { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string account_object_code { get; set; }
        /// <summary>
        /// ID khách hàng là tổ chức hoặc cá nhân
        /// </summary>
        public Guid? account_object_id { get; set; }
        /// <summary>
        /// Tên khách hàng là tổ chức hoặc cá nhân
        /// </summary>
        public string account_object_name { get; set; }
        /// <summary>
        /// Mã số thuế khách hàng
        /// </summary>
        public string account_object_tax_code { get; set; }
        /// <summary>
        /// Lưu list id tệp đính kèm
        /// </summary>
        public string attachment_id_list { get; set; }
        /// <summary>
        /// Chi nhánh
        /// </summary>
        public Guid? branch_id { get; set; } = Guid.Empty;
        /// <summary>
        /// ID đơn hàng bên CRM (Để giá trị default)
        /// </summary>
        public string crm_id { get; set; } = String.Empty;
        /// <summary>
        /// Loại tiền
        /// </summary>
        public string currency_id { get; set; } = "VND";
        /// <summary>
        /// Tình trạng giao hàng 0 chưa giao, 1 đang giao, 2 đã giao đủ 
        /// (Mặc định khi lập chứng từ là chưa giao hàng do đơn hàng vừa lập chưa có phiếu xuất kho, phiếu bán hàng)
        /// </summary>
        public int delivered_status { get; set; } = 0;
        /// <summary>
        /// Ngày giao hàng
        /// </summary>
        public DateTime? delivery_date { get; set; }
        /// <summary>
        /// Tỷ lệ/tiền chiết khấu theo mặt hàng/tổng chứng từ
        /// </summary>
        public decimal discount_rate_voucher { get; set; }
        /// <summary>
        /// Loại chiết khấu:  0: Không chiết khấu 1: Theo mặt hàng 2: theo % hóa đơn 3: số tiền trên tổng số hóa đơn
        /// </summary>
        public int? discount_type { get; set; }
        /// <summary>
        /// Số ngày được nợ
        /// </summary>
        public int? due_day { get; set; }
        /// <summary>
        /// Mã nhân viên bán hàng
        /// </summary>
        public string employee_code { get; set; }
        /// <summary>
        /// Id nhân viên bán hàng
        /// </summary>
        public Guid? employee_id { get; set; }
        /// <summary>
        /// Tên nhân viên bán hàng
        /// </summary>
        public string employee_name { get; set; }
        /// <summary>
        /// Tỉ giá hối đối
        /// </summary>
        public decimal exchange_rate { get; set; } = 1;
        /// <summary>
        /// Check tính giá thành
        /// </summary>
        public bool is_calculated_cost { get; set; } = false;
        /// <summary>
        /// Trạng thái đã xuất hóa đơn
        /// </summary>
        public bool is_invoiced { get; set; } = false;
        /// <summary>
        /// Ghi chú
        /// </summary>
        public string journal_memo { get; set; }
        /// <summary>
        /// Giá trị đã xuất hóa đơn năm trước
        /// </summary>
        public decimal last_year_invoice_amount { get; set; } = 0;
        /// <summary>
        /// Giá trị đã xuất hóa đơn năm trước nguyên tệ
        /// </summary>
        public decimal last_year_invoice_amount_oc { get; set; } = 0;
        /// <summary>
        /// Được sửa bởi ai
        /// </summary>
        public string modified_by { get; set; } = String.Empty;
        public DateTime? modified_date { get; set; } = DateTime.Now;
        /// <summary>
        /// Điều khoản khác
        /// </summary>
        public string other_term { get; set; }
        public string payment_term_code { get; set; }
        public Guid? payment_term_id { get; set; }
        public string payment_term_name { get; set; }
        public Guid? quote_refid { get; set; }
        public string receiver { get; set; }
        public DateTime? refdate { get; set; } = DateTime.Now;
        public string refno { get; set; }
        /// <summary>
        ///  Tình trạng ghi nhận doanh số. 0=Chưa ghi doanh số: 1=Đã ghi doanh số
        /// </summary>
        public int revenue_status { get; set; } = 1;
        /// <summary>
        /// Địa chỉ giao hàng
        /// </summary>
        public string shipping_address { get; set; }
        /// <summary>
        /// Tình trạng đơn hàng, 0: Chưa thực hiện; 1: Đang thực hiện; 2: Hoàn thành; 3: Đã hủy bỏ 
        /// (Mặc định khi lập chứng từ là chưa thực hiện do đơn hàng vừa lập chưa có phiếu xuất kho, phiếu bán hàng)
        /// </summary>
        public int? status { get; set; }
        /// <summary>
        /// Tổng tiền thanh toán quy đổi
        /// </summary>
        public decimal total_amount { get; set; }
        /// <summary>
        /// Tổng tiền đã thực hiên quy đổi
        /// </summary>
        public decimal total_amount_made { get; set; }
        /// <summary>
        /// Tổng số tiền đã thực hiện nguyên tệ
        /// </summary>
        public decimal total_amount_made_oc { get; set; }
        /// <summary>
        /// Tổng tiền thanh toán
        /// </summary>
        public decimal total_amount_oc { get; set; }
        /// <summary>
        /// Tổng tiền chiết khấu quy đổi
        /// </summary>
        public decimal total_discount_amount { get; set; }
        /// <summary>
        /// Tổng tiền chiết khấu
        /// </summary>
        public decimal total_discount_amount_oc { get; set; }
        /// <summary>
        /// Giá trị đã xuất hóa đơn quy đổi
        /// </summary>
        public decimal total_invoice_amount { get; set; }
        /// <summary>
        /// Giá trị đã xuất hóa đơn nguyên tệ
        /// </summary>
        public decimal total_invoice_amount_oc { get; set; }
        /// <summary>
        /// Thực thu quy đổi(hiển thị trên danh sách)
        /// </summary>
        public decimal total_receipted_amount { get; set; }
        /// <summary>
        /// Thực thu nguyên tệ(hiển thị trên danh sách)
        /// </summary>
        public decimal total_receipted_amount_oc { get; set; }
        /// <summary>
        /// Tổng tiền hàng quy đổi
        /// </summary>
        public decimal total_sale_amount { get; set; }
        /// <summary>
        /// Tổng tiền hàng
        /// </summary>
        public decimal total_sale_amount_oc { get; set; }
        /// <summary>
        /// Tổng tiền thuế quy đổi
        /// </summary>
        public decimal total_vat_amount { get; set; }
        /// <summary>
        /// Tổng tiền thuế
        /// </summary>
        public decimal total_vat_amount_oc { get; set; }
        /// <summary>
        /// Thông tin chi tiết đơn hàng
        /// </summary>
        public List<sa_order_detail> detail { get; set; }

    }
}
