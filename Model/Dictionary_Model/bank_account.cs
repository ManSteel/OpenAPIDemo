using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Tài khoản ngân hàng
    /// </summary>
    public class bank_account: DictionaryObject
    {
        public int dictionary_type { get; set; } = 7;
        public Guid? bank_account_id { get; set; }
        public string bank_account_number { get; set; }
        public string account_holder { get; set; }
        public string address { get; set; }
        public string bank_branch_name { get; set; }
        public string province_or_city { get; set; }
        public string description { get; set; }
        public Guid? bank_id { get; set; }
        public string bank_name { get; set; }


    }
}
