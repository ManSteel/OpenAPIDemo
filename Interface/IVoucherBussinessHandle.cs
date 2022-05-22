using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1.Interface
{
    public interface IVoucherBussinessHandle
    {
        /// <summary>
        /// Khởi tạo thông tin danh mục đẩy kèm chứng từ
        /// </summary>
        /// <param name="dataVoucher">Request chứng từ đẩy vào API</param>
        /// <param name="orgData">Dữ liệu gốc bên phần mềm thứ 3</param>
        void InitDictionary(VoucherRequestParam dataVoucher, OriginData orgData);

        /// <summary>
        /// Khởi tạo thông tin chứng từ đẩy lên API
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData"></param>
        void InitVoucherData(VoucherRequestParam dataVoucher, OriginData orgData);

        /// <summary>
        /// Maping id trong danh mục với các thông tin trong chứng từ dựa vào mã của object
        /// </summary>
        /// <param name="dataVoucher"></param>
        void MappingIdObjectVoucher(VoucherRequestParam dataVoucher);


    }
}
