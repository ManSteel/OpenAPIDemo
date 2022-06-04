using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Voucher_Model
{
    /// <summary>
    /// Thu tiền mặt thông tin dòng chi tiết
    /// </summary>
    /// Created by: LDLONG 04.06.2022
    public class ca_receipt_detail: VoucherDetailObject
    {
        public string account_name { get; set; }
        public string account_object_code { get; set; }
        public string account_object_name { get; set; }
        public Guid? account_object_id { get; set; }
        public decimal amount { get; set; }
        public decimal amount_oc { get; set; }
        public Guid? bank_account_id { get; set; }
        public string bank_account_number { get; set; }
        public string bank_name { get; set; }

        public string credit_account { get; set; }
        public string debit_account { get; set; }
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
        public string description { get; set; }
        public int? sort_order { get; set; }
        public bool un_resonable_cost { get; set; }
    }
}
