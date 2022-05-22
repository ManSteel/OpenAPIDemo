using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Dictionary_Model;

namespace WindowsFormsApp1.BL
{
    public class VoucherBussinessBase: IVoucherBussinessHandle
    {

        /// <summary>
        /// Khởi tạo dữ liệu danh mục đẩy sang phần mềm kế toán
        /// Overide để maping dữ liệu đặc thù theo từng loại chứng từ
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData"></param>
        /// Created by: LDLONG 10.05.2022
        public virtual void InitDictionary(VoucherRequestParam dataVoucher, OriginData orgData)
        {
            
        }


        /// <summary>
        /// Khởi tạo dữ liệu chứng từ đẩy sang phần mềm kế toán
        /// Overide để maping dữ liệu đặc thù theo từng loại chứng từ
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData"></param>
        /// Created by: LDLONG 10.05.2022
        public virtual void InitVoucherData(VoucherRequestParam dataVoucher, OriginData orgData)
        {
            
        }

        /// <summary>
        /// Khởi tạo phần thông tin chung chứng từ
        /// Overide để maping dữ liệu đặc thù theo từng loại chứng từ
        /// </summary>
        /// <param name="voucher"></param>
        /// <param name="orgData"></param>
        public virtual void InitVoucherMaster(VoucherObject voucher, OriginData orgData)
        {
            
        }

        /// <summary>
        /// Khởi tạo phần thông tin chi tiết chứng từ
        /// Overide để maping dữ liệu đặc thù theo từng loại chứng từ
        /// </summary>
        /// <param name="voucher"></param>
        /// <param name="orgData"></param>
        public virtual void InitVoucherDetail(VoucherObject voucher, OriginData orgData)
        {

        }


        /// <summary>
        /// Maping dữ liệu khách hàng, nhà cung cấp, nhân viên bên thứ phần mềm 3 với đối tượng kế toán
        /// Có thể Overide nếu maping dữ liệu đặc thù
        /// </summary>
        /// Created by: LDLONG 30.04.2022
        public void MappingAccountObject(account_object accountObj, OriginData orgData)
        {
            //Xử lý mapping dữ liệu
            accountObj.account_object_id = Guid.NewGuid();
        }

        /// <summary>
        /// Maping thông tin hàng hóa
        /// Có thể Overide nếu maping dữ liệu đặc thù
        /// </summary>
        public void MappingInventoryItem(inventory_item product, OriginData orgData, List<unit> lstUnit)
        {
            //Xử lý mapping dữ liệu
            product.inventory_item_id = Guid.NewGuid();
            
        }

        public virtual void MappingIdObjectVoucher(VoucherRequestParam dataVoucher)
        {
            
        }
    }
}
