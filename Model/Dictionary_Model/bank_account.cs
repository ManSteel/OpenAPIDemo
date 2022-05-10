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

    }
}
