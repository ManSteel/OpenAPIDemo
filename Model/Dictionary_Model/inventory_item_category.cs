using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Nhóm VTHH
    /// </summary>
    public class inventory_item_category: DictionaryObject
    {
        public int dictionary_type { get; set; } = 4;
        public string inventory_category_code { get; set; }
        public Guid? inventory_category_id { get; set; }
        public string inventory_category_name { get; set; }
        public bool? is_parent { get; set; } = false;
        public bool? is_system { get; set; } = false;
        public string misa_code_id { get; set; }
        public Guid? parent_id { get; set; }

    }
}
