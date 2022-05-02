using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    /// <summary>
    /// Thông tin token kết nối
    /// </summary>
    /// Created by: LDLONG 20.03.2022
    public class TokenInfo
    {
        /// <summary>
        /// Token để sử dụng các hàm xử lý nghiệp vụ. Token này chỉ có thời hạn truy cập là 12h. 
        /// Khi sử dụng token hết hạn truy cập, tất cả các lời gọi đến api đều không thực hiện được
        /// </summary>
        public string access_token { get; set; }

        /// <summary>
        /// Hạn sử dụng của access_token.
        /// </summary>
        public DateTime? expired_time { get; set; }

        /// <summary>
        /// Hạn sử dụng của access_token (tính bằng ticks) = (expired_time).ticks. 
        /// Để đảm bảo độ chính xác cao, nhà phát triển nên dùng thông tin này để kiểm tra hiệu lực của token.
        /// </summary>
        public long expired_time_ticks { get; set; }

        

    }
}
