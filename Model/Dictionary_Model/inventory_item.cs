using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Hàng hóa dịch vụ
    /// </summary>
    /// Created by: LDLONG 30.04.2022
    public class inventory_item: IDictionary
    {
        public int dictionary_type { get; set; } = 3;
        public string created_by { get; set; } = "Open API";
        public DateTime? created_date { get; set; } = DateTime.Now;
        public string modified_by { get; set; } = "Open API";
        public DateTime? modified_date { get; set; } = DateTime.Now;
        public string allocation_account { get; set; } = "5111";
        public int? allocation_time { get; set; } = 0;
        /// <summary>
        /// Loại kỳ phân bổ:
        /// 0:  Số kỳ phân bổ cố định
        /// 1: Số kỳ phân bổ trên một đơn vị số lượng
        /// </summary>
        public int? allocation_type { get; set; } = 0;
        public int? base_on_formula { get; set; } = 0;
        public Guid? branch_id { get; set; } = Guid.Empty;
        public string cogs_account { get; set; } = "632";
        public int? cost_method { get; set; } = 0;
        public string crm_id { get; set; }
        public Guid? default_stock_id { get; set; }
        public string description { get; set; }
        public string discount_account { get; set; }
        public int? discount_type { get; set; }
        public decimal export_tax_rate { get; set; } = 0;
        public decimal fixed_sale_price { get; set; } = 0;
        public decimal fixed_unit_price { get; set; } = 0;
        public decimal import_tax_rate { get; set; } = 0;
        public bool inactive { get; set; }
        public string inventory_account { get; set; }
        public string inventory_item_category_code_list { get; set; }
        public string inventory_item_category_id_list { get; set; }
        public string inventory_item_category_misa_code_list { get; set; }
        public string inventory_item_category_name_list { get; set; }
        public string inventory_item_code { get; set; }
        public Guid? inventory_item_id { get; set; }
        public string inventory_item_name { get; set; }
        /// <summary>
        /// Tính chất:0 Là Vật tư hàng hóa; 1: Là thành phẩm; 2 Là dịch vụ;3 là Nguyên vật liệu
        /// </summary>
        public int? inventory_item_type { get; set; } = 0;
        public bool is_allow_duplicate_serial_number { get; set; } = true;
        public bool is_follow_serial_number { get; set; }
        public bool is_system { get; set; } = false;
        public bool is_unit_price_after_tax { get; set; } = false;
        public decimal minimum_stock { get; set; } = 0;
        public string purchase_description { get; set; }
        public decimal purchase_discount_rate { get; set; } = 0;
        public string return_account { get; set; }
        public string sale_account { get; set; }
        public string sale_description { get; set; }
        public string sale_off_account { get; set; }
        /// <summary>
        /// Đơn giá bán 1
        /// </summary>
        public decimal sale_price1 { get; set; } = 0;
        /// <summary>
        /// Đơn giá bán 2
        /// </summary>
        public decimal sale_price2 { get; set; } = 0;
        /// <summary>
        /// Đơn giá bán 3
        /// </summary>
        public decimal sale_price3 { get; set; } = 0;
        /// <summary>
        /// huế suất GTGT: 0=0%;5=5%;10=10%;-1=KCT
        /// </summary>
        public decimal tax_rate { get; set; } = -1;
        public Guid? unit_id { get; set; }
        public string unit_list { get; set; }
        /// <summary>
        /// Đơn giá
        /// </summary>
        public decimal unit_price { get; set; }


    }
}
