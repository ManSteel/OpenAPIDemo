using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Hóa đơn bán hàng
    /// </summary>
    /// Created by: LDLONG 30.05.2022
    public class sa_invoice
    {
        public string account_object_address { get; set; }
        public string account_object_bank_account { get; set; }
        public string account_object_bank_name { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public string account_object_tax_code { get; set; }
        public DateTime? adjust_inv_date { get; set; }
        public string adjust_inv_no { get; set; }
        public string adjust_inv_series { get; set; }
        public string adjust_inv_template_no { get; set; }
        public string adjust_journal_memo { get; set; }
        public Guid? adjust_purchase_purpose_id { get; set; }
        public Guid? adjust_refid { get; set; }
        public int? adjust_reftype { get; set; }
        public int? adjust_t_acareer_group_id { get; set; }
        public decimal adjust_vat_rate { get; set; }
        public string bill_of_lading_no { get; set; }
        public Guid? branch_id { get; set; }
        public string buyer { get; set; }
        public string common_inventory_name { get; set; }
        public string container_no { get; set; }
        public string contract_code { get; set; }
        public DateTime? contract_date { get; set; }
        public string created_by { get; set; }
        public DateTime? created_date { get; set; } = DateTime.Now;
        public string currency_id { get; set; } = "VND";
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
        public decimal discount_rate_voucher { get; set; }
        public int? discount_type { get; set; }
        public int? display_on_book { get; set; }
        public string employee_code { get; set; }
        public Guid? employee_id { get; set; }
        public string employee_name { get; set; }
        public decimal exchange_rate { get; set; }
        public int? include_invoice { get; set; }
        public DateTime? inv_date { get; set; }
        public string inv_no { get; set; }
        public string inv_series { get; set; }
        public string inv_template_no { get; set; }
        public int? inv_type_id { get; set; }

        public bool? is_attach_list { get; set; }
        public bool? is_branch_issued { get; set; }
        public bool? is_invoice_replace { get; set; }
        public bool? is_paid { get; set; }
        public bool? is_posted { get; set; }
        public bool? is_posted_last_year { get; set; }
        public DateTime? list_date { get; set; }
        public string list_no { get; set; }
        public string modified_by { get; set; }
        public DateTime? modified_date { get; set; }
        public string payment_method { get; set; }
        public string place_of_delivery { get; set; }
        public string place_of_receipt { get; set; }
        public Guid? refid { get; set; }
        public int? reftype { get; set; }
        public string reftype_name { get; set; }
        public Guid? sa_invoice_request_refid { get; set; }
        public decimal total_amount { get; set; }
        public decimal total_amount_oc { get; set; }
        public decimal total_discount_amount { get; set; }
        public decimal total_discount_amount_oc { get; set; }
        public decimal total_sale_amount { get; set; }
        public decimal total_sale_amount_oc { get; set; }
        public decimal total_vat_amount { get; set; }
        public decimal total_vat_amount_oc { get; set; }
        public string transport_name { get; set; }

    }
}
