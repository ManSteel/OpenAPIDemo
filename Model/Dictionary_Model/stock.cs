using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    public class stock: DictionaryObject
    {
        public int dictionary_type { get; set; } = 5;
        public Guid? branch_id { get; set; }
        /// <summary>
        /// Id kho
        /// </summary>
        public Guid? stock_id { get; set; }
        /// <summary>
        /// Mã kho
        /// </summary>
        public string stock_code { get; set; }
        /// <summary>
        /// Tên kho
        /// </summary>
        public string stock_name { get; set; }
        /// <summary>
        /// Diễn giải
        /// </summary>
        public string description { get; set; }
        public bool inactive { get; set; }
        public string inventory_account { get; set; }
    }
}
