using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Kết quả connect Amis MAKT
    /// </summary>
    /// Created by: LDLONG 20.03.2022
    public class ConnectResult
    {
        /// <summary>
        /// true - thành công, false - thất bại 
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// Thông tin lỗi chi tiết.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Thông tin token sử dụng call API
        /// </summary>
        public string Data { get; set; }


    }
}
