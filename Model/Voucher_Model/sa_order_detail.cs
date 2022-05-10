using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Thông tin các dòng chi tiết đơn hàng
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public class sa_order_detail : VoucherDetailObject
    {
        public decimal amount { get; set; }
        public decimal amount_oc { get; set; }
        public string crm_id { get; set; }
        public string description { get; set; }
        public decimal discount_amount { get; set; }
        public decimal discount_amount_oc { get; set; }
        public decimal discount_rate { get; set; }
        public string exchange_rate_operator { get; set; } = "*";
        public DateTime? expiry_date { get; set; }
        public bool? is_description { get; set; }
        public string inventory_item_code { get; set; }
        public Guid? inventory_item_id { get; set; }
        public string inventory_item_name { get; set; }
        public bool? is_promotion { get; set; } = false;
        public decimal last_year_delivered_amount { get; set; }
        public decimal last_year_delivered_amount_oc { get; set; }
        public decimal last_year_delivered_before_tax_amount { get; set; }
        public decimal last_year_delivered_before_tax_amount_oc { get; set; }
        public string lot_no { get; set; }
        public decimal main_convert_rate { get; set; }
        public decimal main_quantity { get; set; }
        public decimal main_quantity_delivered_in { get; set; }
        public decimal main_quantity_delivered_in_last_year { get; set; }
        public decimal main_quantity_delivered_sa { get; set; }
        public decimal main_quantity_delivered_sa_last_year { get; set; }
        public Guid? main_unit_id { get; set; }
        public string main_unit_name { get; set; }
        public decimal main_unit_price { get; set; }
        public decimal panel_height_quantity { get; set; }
        public decimal panel_length_quantity { get; set; }
        public decimal panel_quantity { get; set; }
        public decimal panel_radius_quantity { get; set; }
        public decimal panel_width_quantity { get; set; }
        public decimal quantity { get; set; }
        public decimal quantity_delivered_in { get; set; }
        public decimal quantity_delivered_in_last_year { get; set; }
        public decimal quantity_delivered_sa { get; set; }
        public decimal quantity_delivered_sa_last_year { get; set; }
        public int? sort_order { get; set; }
        public string stock_code { get; set; }
        public Guid? stock_id { get; set; }
        public string stock_name { get; set; }
        public Guid? unit_id { get; set; }
        public string unit_name { get; set; }
        public decimal unit_price { get; set; }
        public decimal unit_price_after_tax { get; set; }
        public decimal vat_amount { get; set; }
        public decimal vat_amount_oc { get; set; }
        public decimal vat_rate { get; set; }


    }
}
