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
    /// Thu tiên mặt
    /// </summary>
    public class ca_receipt: VoucherObject
    {
        public int voucher_type { get; set; } = 5;
        public int org_reftype { get; set; } = (int)EnumReftype.CaReceipt;
        public string org_reftype_name { get; set; } = "Phiếu thu tiền mặt";
        public int? reftype { get; set; } = (int)EnumReftype.CaReceipt;
        public string account_object_address { get; set; }
        public string account_object_code { get; set; }
        public string account_object_name { get; set; }
        public string account_object_contact_name { get; set; }
        public Guid? account_object_id { get; set; }
        public string currency_id { get; set; } = "VND";
        public Guid? branch_id { get; set; }
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
        public string employee_name { get; set; }
        public Guid? employee_id { get; set; }
        public decimal exchange_rate { get; set; }
        public string journal_memo { get; set; }
        public string modified_by { get; set; }
        public DateTime? modified_date { get; set; }

        public DateTime? posted_date { get; set; }
        public int? reason_type_id { get; set; }
        public string reason_type_name { get; set; }
        public DateTime? refdate { get; set; }
        public string refno_finance { get; set; }
        public long? reforder { get; set; }
        public decimal total_amount { get; set; }
        public decimal total_amount_oc { get; set; }
        public List<ca_receipt_detail> detail { get; set; }
    }
}
