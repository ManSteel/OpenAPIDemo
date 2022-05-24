using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    public class pu_voucher_detail: VoucherDetailObject
    {
        public string account_name { get; set; }
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public decimal allocation_rate { get; set; } = 0;
        public decimal allocation_rate_import { get; set; } = 0;
        public decimal allocation_rate_import_origin_currency { get; set; } = 0;
        public decimal amount { get; set; }
        public decimal amount_oc { get; set; }
        /// <summary>
        /// TK có
        /// </summary>
        public string credit_account { get; set; }
        /// <summary>
        /// Tk nợ
        /// </summary>
        public string debit_account { get; set; }
        /// <summary>
        /// TK đối ứng thuế GTGT
        /// </summary>
        public string deduction_debit_account { get; set; }
        /// <summary>
        /// Tên hàng
        /// </summary>
        public string description { get; set; }
        /// <summary>
        /// Tiền chiết khấu quy đổi
        /// </summary>
        public decimal discount_amount { get; set; }
        /// <summary>
        ///  Tiền chiêt khấu nguyên tệ
        /// </summary>
        public decimal discount_amount_oc { get; set; }
        /// <summary>
        /// Tỉ lệ chiết khấu
        /// </summary>
        public decimal discount_rate { get; set; }
        public string environmental_tax_account { get; set; }
        public decimal environmental_tax_amount { get; set; } = 0;
        public decimal environmental_tax_amount_oc { get; set; } = 0;
        public string exchange_rate_operator { get; set; } = "*";
        /// <summary>
        /// Hạn dùng
        /// </summary>
        public DateTime? expiry_date { get; set; }
        /// <summary>
        /// Giá FOB
        /// </summary>
        public decimal fob_amount { get; set; } = 0;
        /// <summary>
        /// Giá FOB ngoại tệ
        /// </summary>
        public decimal fob_amount_oc { get; set; } = 0;
        /// <summary>
        /// Chi phí mua hàng/Phí hàng về kho
        /// </summary>
        public decimal freight_amount { get; set; } = 0;
        /// <summary>
        /// Phí trước hải quan
        /// </summary>
        public decimal import_charge_amount { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public decimal import_charge_before_custom_amount_allocated { get; set; } = 0;
        /// <summary>
        /// Phí trước hải quan bằng đồng tiền hạch toán
        /// </summary>
        public decimal import_charge_before_custom_amount_main_currency { get; set; } = 0;
        /// <summary>
        /// Phí trước hải quan bằng ngoại tệ
        /// </summary>
        public decimal import_charge_before_custom_amount_oc { get; set; } = 0;
        /// <summary>
        /// 
        /// </summary>
        public decimal import_charge_exchange_rate { get; set; } = 0;
        /// <summary>
        /// Tài khoản thuế nhập khẩu
        /// </summary>
        public string import_tax_account { get; set; }
        /// <summary>
        /// Tiền thuế  nhập khẩu quy đổi
        /// </summary>
        public decimal import_tax_amount { get; set; } = 0;
        /// <summary>
        /// Tiền thuế nhập khẩu
        /// </summary>
        public decimal import_tax_amount_oc { get; set; } = 0;
        /// <summary>
        /// % Thuế nhập khẩu
        /// </summary>
        public decimal import_tax_rate { get; set; } = 0;
        /// <summary>
        /// Giá tính thuế NK = Giá FOB + Phí trước hải quan
        /// </summary>
        public decimal import_tax_rate_price { get; set; } = 0;
        public DateTime? inv_date { get; set; }
        /// <summary>
        /// Là dòng diễn giải
        /// </summary>
        public bool? is_description { get; set; } = false;
        public string inventory_item_code { get; set; }
        public Guid? inventory_item_id { get; set; }
        public string inventory_item_name { get; set; }
        /// <summary>
        /// 1: Hàng hóa giữ hộ, gia công 
        /// 2: Hàng hóa bán hộ, ký gửi
        /// </summary>
        public int? inventory_resale_type_id { get; set; } = null;
        public string inv_no { get; set; } //Mua hàng nhiều hóa đơn mới dùng trường này
        public string inv_series { get; set; } //Mua hàng nhiều hóa đơn mới dùng trường này
        public string inv_template_no { get; set; } //Mua hàng nhiều hóa đơn mới dùng trường này
        /// <summary>
        /// Giá trị nhập kho/Tổng giá trị HHDV (Mua hàng ko qua kho) QĐ
        /// </summary>
        public decimal inward_amount { get; set; }
        /// <summary>
        /// Số lô
        /// </summary>
        public string lot_no { get; set; }
        /// <summary>
        /// Tỷ lệ chuyển đổi ra đơn vị chính
        /// </summary>
        public decimal main_convert_rate { get; set; }
        /// <summary>
        /// Số lượng theo đơn vị chính
        /// </summary>
        public decimal main_quantity { get; set; }
        /// <summary>
        /// Đơn vị tính chính
        /// </summary>
        public Guid? main_unit_id { get; set; }
        public string main_unit_name { get; set; }
        public decimal main_unit_price { get; set; } = 0;
        /// <summary>
        /// Chiều cao
        /// </summary>
        public decimal panel_height_quantity { get; set; } = 0;
        /// <summary>
        /// Chiều dài
        /// </summary>
        public decimal panel_length_quantity { get; set; } = 0;
        /// <summary>
        /// Lượng
        /// </summary>
        public decimal panel_quantity { get; set; } = 0;
        /// <summary>
        /// Bán kính
        /// </summary>
        public decimal panel_radius_quantity { get; set; } = 0;
        /// <summary>
        /// Chiều rộng
        /// </summary>
        public decimal panel_width_quantity { get; set; } = 0;
        public string purchase_purpose_code { get; set; }
        public Guid? purchase_purpose_id { get; set; }
        /// <summary>
        /// Số lượng
        /// </summary>
        public decimal quantity { get; set; }
        /// <summary>
        /// Thứ tự sắp xếp các dòng chi tiết
        /// </summary>
        public int? sort_order { get; set; }
        /// <summary>
        /// Tài khoản thuế tiêu thụ đặc biệt
        /// </summary>
        public string special_consume_tax_account { get; set; }
        /// <summary>
        /// Thuế tiêu thụ đặc biệt quy đổi
        /// </summary>
        public decimal special_consume_tax_amount { get; set; } = 0;
        /// <summary>
        /// Thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal special_consume_tax_amount_oc { get; set; } = 0;
        /// <summary>
        /// %Thuế tiêu thụ đặc biệt
        /// </summary>
        public decimal special_consume_tax_rate { get; set; } = 0;
        /// <summary>
        /// Mã kho
        /// </summary>
        public string stock_code { get; set; }
        /// <summary>
        /// Id kho
        /// </summary>
        public Guid? stock_id { get; set; }
        public string tax_account_object_address { get; set; }
        public string tax_account_object_code { get; set; }
        public Guid? tax_account_object_id { get; set; }
        public string tax_account_object_name { get; set; }
        public string tax_account_object_tax_code { get; set; }
        public Guid? unit_id { get; set; }
        public string unit_name { get; set; }
        public decimal unit_price { get; set; } = 0;
        public decimal unit_price_after_tax { get; set; } = 0;
        public bool? un_resonable_cost { get; set; } = null;
        /// <summary>
        /// TK thuế GTGT
        /// </summary>
        public string vat_account { get; set; }
        /// <summary>
        /// Tiền thuế GTGT quy đổi
        /// </summary>
        public decimal vat_amount { get; set; }
        /// <summary>
        /// Tiền thuế GTGT
        /// </summary>
        public decimal vat_amount_oc { get; set; }
        /// <summary>
        /// Diễn giải thuế
        /// </summary>
        public string vat_description { get; set; }
        /// <summary>
        /// Tỷ lệ thuế suất GTGT
        /// </summary>
        public decimal vat_rate { get; set; }

    }
}
