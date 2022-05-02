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
    public class VoucherBussinessBase
    {
        /// <summary>
        /// Khởi tạo dữ liệu danh mục đẩy sang phần mềm kế toán
        /// Có thể Overide nếu maping dữ liệu đặc thù
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData"></param>
        public void InitDictionary(VoucherRequestParam dataVoucher, OriginData orgData)
        {
            List<IDictionary> lstDictionary = new List<IDictionary>();

            // 1. Đẩy thông tin danh mục đơn vị tính (Nếu có thông tin đơn vị tính)
            List<unit> lstUnit = new List<unit>();
            unit unit1 = new unit();
            unit1.unit_id = Guid.NewGuid();
            unit1.unit_name = "Chiếc";
            lstUnit.Add(unit1);

            unit unit2 = new unit();
            unit2.unit_id = Guid.NewGuid();
            unit2.unit_name = "Thùng";
            lstUnit.Add(unit2);

            lstDictionary.AddRange(lstUnit);

            // 2. Đẩy thông tin danh mục kho (Nếu có thông tin kho)
            List<stock> lstStock = new List<stock>();
            stock stock1 = new stock();
            stock1.stock_id = Guid.NewGuid();
            stock1.stock_code = "KHO1";
            stock1.stock_name = "Kho Hà Nội";
            lstStock.Add(stock1);

            stock stock2 = new stock();
            stock1.stock_id = Guid.NewGuid();
            stock1.stock_code = "KHO2";
            stock1.stock_name = "Kho Hải Phòng";
            lstStock.Add(stock1);


            // 3. Đẩy thông tin danh mục hàng hóa dịch vụ
            inventory_item item1 = new inventory_item();
            item1.inventory_item_name = "Quạt máy";
            item1.inventory_item_code = "QM";
            inventory_item item2 = new inventory_item();
            item1.inventory_item_name = "Dầu máy Castrol";
            item1.inventory_item_code = "DMCT";
            MappingInventoryItem(item1, orgData, lstStock, lstUnit);
            MappingInventoryItem(item1, orgData, lstStock, lstUnit);

            // 4. Đẩy thông tin khách hàng, nhà cung cấp, nhân viên
            account_object customer = new account_object(); //Khách hàng
            account_object employee = new account_object(); //Nhân viên
            lstDictionary.Add(item1);
            lstDictionary.Add(item2);
            lstDictionary.Add(customer);
            lstDictionary.Add(employee);


            dataVoucher.dictionary = lstDictionary;
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
        public void MappingInventoryItem(inventory_item product, OriginData orgData, List<stock> lstStock, List<unit> lstUnit)
        {
            //Xử lý mapping dữ liệu
            product.inventory_item_id = Guid.NewGuid();
            
        }




    }
}
