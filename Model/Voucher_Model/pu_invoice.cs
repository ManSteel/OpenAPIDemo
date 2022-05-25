using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    public class pu_invoice
    {
        public int? voucher_type { get; set; } = 15;
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public Guid? account_object_id { get; set; }
        public string account_object_name { get; set; }
        public string account_object_tax_code { get; set; }
        public Guid? branch_id { get; set; }
        public string created_by { get; set; }
        public DateTime? created_date { get; set; } = DateTime.Now;
        public string currency_id { get; set; }
        public DateTime? due_date { get; set; }
        public Guid? employee_id { get; set; }
        public decimal exchange_rate { get; set; }
        public int? include_invoice { get; set; }
        public DateTime? inv_date { get; set; }
        public string inv_no { get; set; }
        public string inv_series { get; set; }
        public string inv_template_no { get; set; }
        public bool? is_import_purchase { get; set; }
        public bool? is_paid { get; set; }
        public bool? is_posted_finance { get; set; } = false;
        public bool? is_posted_management { get; set; } = false;

        public bool? is_summary_by_same_inventory_item { get; set; } = false;
        public string journal_memo { get; set; }
        public string modified_by { get; set; }
        public DateTime? modified_date { get; set; } = DateTime.Now;
        public DateTime? posted_date { get; set; }
        public DateTime? refdate { get; set; }
        public Guid? refid { get; set; }

        public string refno_finance { get; set; }
        public string refno_management { get; set; }
        public long? reforder { get; set; }
        public int? reftype { get; set; } = 3400;
        public string reftype_name { get; set; } = "Hóa đơn mua hàng";
        public string seller_tax_code { get; set; }
        public decimal total_turnover_amount { get; set; } = 0;
        public decimal total_turnover_amount_oc { get; set; } = 0;
        public decimal total_vat_amount { get; set; } = 0;
        public decimal total_vat_amount_oc { get; set; } = 0;
    }
}
