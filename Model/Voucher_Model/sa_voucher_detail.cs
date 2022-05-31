using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Chi tiết chứng từ mua hàng
    /// </summary>
    public class sa_voucher_detail: VoucherDetailObject
    {
        public string account_name { get; set; }
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public decimal amount { get; set; }
        public decimal amount_after_tax { get; set; }
        public decimal amount_oc { get; set; }
        public Guid? confronting_ref_detail_id { get; set; }
        public Guid? confronting_refid { get; set; }
        public string confronting_refno_finance { get; set; }
        public string cost_account { get; set; }
        public decimal cost_amount_finance { get; set; }
        public decimal cost_unit_price_finance { get; set; }
        public string credit_account { get; set; }
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
        public string debit_account { get; set; }
        public string description { get; set; }
        public string discount_account { get; set; }
        public decimal discount_amount { get; set; }
        public decimal discount_amount_oc { get; set; }
        public decimal discount_rate { get; set; }
        public string exchange_rate_operator { get; set; } = "*";
        public DateTime? expiry_date { get; set; }
        public string export_tax_account { get; set; }

        public decimal export_tax_amount { get; set; } = 0;

        public decimal export_tax_rate { get; set; } = 0;
        public decimal fob_amount { get; set; }
        public string guaranty_period { get; set; }
        public Guid? in_transfer_ref_detail_id { get; set; }
        public Guid? in_transfer_refid { get; set; }
        public string inventory_item_code { get; set; }
        public Guid? inventory_item_id { get; set; }
        public string inventory_item_name { get; set; }
        public int? inventory_resale_type_id { get; set; }
        public bool? is_description { get; set; }
        public bool? is_promotion { get; set; }
        public bool? is_un_update_outward_price { get; set; }
        public string lot_no { get; set; }
        public decimal main_convert_rate { get; set; }
        public decimal main_quantity { get; set; }
        public Guid? main_unit_id { get; set; }
        public string main_unit_name { get; set; }
        public decimal main_unit_price { get; set; }
        public bool? not_in_vat_declaration { get; set; }
        public Guid? outward_ref_detail_id { get; set; }
        public Guid? outward_refid { get; set; }
        public decimal panel_height_quantity { get; set; }
        public decimal panel_length_quantity { get; set; }
        public decimal panel_quantity { get; set; }
        public decimal panel_radius_quantity { get; set; }
        public decimal panel_width_quantity { get; set; }
        public Guid? pu_voucher_ref_detail_id { get; set; }
        public Guid? pu_voucher_refid { get; set; }
        public decimal quantity { get; set; }
        public Guid? sa_invoice_refid { get; set; }
        public Guid? sa_order_ref_detail_id { get; set; }
        public Guid? sa_quote_ref_detail_id { get; set; }
        public int? sort_order { get; set; }
        public string stock_account { get; set; }
        public string stock_code { get; set; }
        public Guid? stock_id { get; set; }
        public string stock_name { get; set; }
        public int? ta_career_group_id { get; set; }
        public Guid? unit_id { get; set; }
        public string unit_name { get; set; }
        public decimal unit_price { get; set; }
        public decimal unit_price_after_tax { get; set; }
        public bool? un_resonable_cost { get; set; }
        public string vat_account { get; set; }
        public decimal vat_amount { get; set; }
        public decimal vat_amount_oc { get; set; }
        public decimal vat_rate { get; set; }
        public string vat_description { get; set; }










    }
}
