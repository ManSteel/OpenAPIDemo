using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Nhóm khách hàng, nhà cung cấp
    /// </summary>
    public class account_object_group: DictionaryObject
    {
        public int dictionary_type { get; set; } = 2;
        public string account_object_group_code { get; set; }
        public Guid? account_object_group_id { get; set; }
        public string account_object_group_name { get; set; }
        public string crm_id { get; set; }
        public string description { get; set; }
        public int? grade { get; set; }
        public bool? inactive { get; set; } = false;
        public bool? is_parent { get; set; } = false;
        public bool? is_system { get; set; }
        public string misa_code_id { get; set; }
        public Guid? parent_id { get; set; }
        public int? sort_order { get; set; }
    }
}
