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
    public class unit: IDictionary
    {
        public int dictionary_type { get; set; } = 6;
        public string created_by { get; set; } = "Open API";
        public DateTime? created_date { get; set; } = DateTime.Now;
        public string modified_by { get; set; } = "Open API";
        public DateTime? modified_date { get; set; } = DateTime.Now;
        public Guid? unit_id { get; set; }
        public string unit_name { get; set; }
        public string description { get; set; }
        public bool? inactive { get; set; } = false;
    }
}
