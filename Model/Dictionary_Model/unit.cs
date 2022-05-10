using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;

namespace WindowsFormsApp1.Model.Dictionary_Model
{
    /// <summary>
    /// Đơn vị tính
    /// </summary>
    public class unit: DictionaryObject
    {
        public int dictionary_type { get; set; } = 6;
        public Guid? unit_id { get; set; }
        public string unit_name { get; set; }
        public string description { get; set; }
        public bool? inactive { get; set; } = false;
    }
}
