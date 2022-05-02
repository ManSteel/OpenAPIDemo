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
    public class bank_account: IDictionary
    {
        public int dictionary_type { get; set; } = 7;
        public string created_by { get; set; } = "Open API";
        public DateTime? created_date { get; set; } = DateTime.Now;
        public string modified_by { get; set; } = "Open API";
        public DateTime? modified_date { get; set; } = DateTime.Now;

    }
}
