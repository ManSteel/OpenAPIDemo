using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Interface;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Model.Dictionary_Model;
using WindowsFormsApp1.Model.Voucher_Model;

namespace WindowsFormsApp1.BL
{
    /// <summary>
    /// Class xử lý build reuqest param đơn đặt hàng đẩy vào API Amis Kế toán
    /// </summary>
    /// Created by: LDLONG 10.05.2022
    public class SaOrderBussinesObject: VoucherBussinessBase
    {
        /// <summary>
        /// Khởi tạo dữ liệu danh mục đẩy sang phần mềm kế toán
        /// Có thể Overide nếu maping dữ liệu đặc thù
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData">Dữ liệu gốc bên app thứ 3 dùng để đẩy dữ liệu sang Amis Kế toán</param>
        public override void InitDictionary(VoucherRequestParam dataVoucher, OriginData orgData)
        {
            List<DictionaryObject> lstDictionary = new List<DictionaryObject>();
            // *Note* Demo nên fix cứng dữ liệu - thực tế dựa vào orgData để sinh ra các dữ liệu mục 1,2,3,4
            // 1. Đẩy thông tin danh mục đơn vị tính (Nếu có thông tin đơn vị tính)
            List<unit> lstUnit = new List<unit>();
            unit unit1 = new unit();
            unit1.unit_id = Guid.NewGuid();
            unit1.unit_name = "Chiếc";
            lstDictionary.Add(unit1);

            unit unit2 = new unit();
            unit2.unit_id = Guid.NewGuid();
            unit2.unit_name = "Thùng";
            lstDictionary.Add(unit2);

            // 2. Đẩy thông tin danh mục kho (Nếu có thông tin kho)
            List<stock> lstStock = new List<stock>();
            stock stock1 = new stock();
            stock1.stock_id = Guid.NewGuid();
            stock1.stock_code = "KHO1";
            stock1.stock_name = "Kho Hà Nội";
            lstDictionary.Add(stock1);

            stock stock2 = new stock();
            stock2.stock_id = Guid.NewGuid();
            stock2.stock_code = "KHO2";
            stock2.stock_name = "Kho Hải Phòng";
            lstDictionary.Add(stock2);


            // 3. Đẩy thông tin danh mục hàng hóa dịch vụ
            inventory_item item1 = new inventory_item();
            item1.inventory_item_id = Guid.NewGuid();
            item1.inventory_item_name = "Quạt máy";
            item1.inventory_item_code = "QM"; // Nếu đã đẩy hàng hóa dịch vụ 1 lần, các lần sau có thể không cần đẩy lại chương trình tự động map theo inventory_item_code
            lstDictionary.Add(item1);

            inventory_item item2 = new inventory_item();
            item2.inventory_item_id = Guid.NewGuid();
            item2.inventory_item_name = "Dầu máy Castrol";
            item2.inventory_item_code = "DMCT";
            lstDictionary.Add(item2);

            var lstItem = lstDictionary.Where(x => x is inventory_item);
            foreach (inventory_item item in lstItem)
            {
                MappingInventoryItem(item, orgData, lstUnit);
            }

            // 4. Đẩy thông tin khách hàng, nhà cung cấp, nhân viên
            account_object obj1 = new account_object(); //Khách hàng
            obj1.account_object_id = Guid.NewGuid();
            obj1.account_object_code = "KH00001";
            obj1.account_object_name = "Lê Đình Long";
            obj1.is_customer = true;

            account_object obj2 = new account_object(); //Nhân viên
            obj2.account_object_id = Guid.NewGuid();
            obj2.account_object_code = "NV00001";
            obj2.account_object_name = "Bùi Trung Tú";
            obj2.is_employee = true;

            account_object obj3 = new account_object(); //Nhà cung cấp
            obj3.account_object_id = Guid.NewGuid();
            obj3.account_object_code = "NCC00001";
            obj3.account_object_name = "Nguyễn Văn Toàn";
            obj3.is_vendor = true;

            lstDictionary.Add(obj1);
            lstDictionary.Add(obj2);
            lstDictionary.Add(obj3);


            dataVoucher.dictionary = lstDictionary;
        }

        /// <summary>
        /// Khởi tạo dữ liệu chứng từ đẩy sang phần mềm kế toán
        /// Overide để maping dữ liệu đặc thù theo từng loại chứng từ
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// <param name="orgData"></param>
        /// Created by: LDLONG 10.05.2022
        public override void InitVoucherData(VoucherRequestParam dataVoucher, OriginData orgData)
        {
            List<VoucherObject> lstVoucher = new List<VoucherObject>(); //Có thể đẩy nhiều 1 hoặc nhiều đơn đặt hàng (demo đẩy 1 đơn hàng)
            sa_order saOrder = new sa_order();
            InitVoucherMaster(saOrder, orgData);
            InitVoucherDetail(saOrder, orgData);
            lstVoucher.Add(saOrder);
            dataVoucher.voucher = lstVoucher;
        }

        /// <summary>
        /// Build phần thông tin chung chứng từ
        /// </summary>
        /// <param name="voucher"></param>
        /// <param name="orgData"></param>
        /// Created by: LDLONG 10.05.2022
        public override void InitVoucherMaster(VoucherObject voucher, OriginData orgData)
        {
            // *Note* Demo nên fix cứng dữ liệu - thực tế dựa vào orgData để sinh ra dữ liệu
            var voucherData = (sa_order)voucher;
            voucherData.org_refid = Guid.NewGuid().ToString();
            voucherData.org_refno = "DH00000181"; //Số đơn hàng gốc trên ứng dụng thứ 3 (mỗi lần test đổi lại số đơn hàng khác)
            voucherData.refno = "DH00000181";
            voucherData.refid = Guid.NewGuid();
            voucherData.refdate = DateTime.Now; // gắn lại theo ngày đơn hàng bên ứng dụng thứ 3, code demo gán = DateTime.Now
            voucherData.account_object_id = Guid.Empty;
            voucherData.account_object_code = "KH00001";
            voucherData.account_object_name = "Lê Đình Long"; // thông tin khách hàng

            voucherData.employee_code = "NV00001";
            voucherData.employee_name = "Bùi Trung Tú";
            voucherData.employee_id = Guid.Empty;
        }

        /// <summary>
        /// Build phần thông tin chi tiết chứng từ
        /// </summary>
        /// <param name="voucher"></param>
        /// <param name="orgData"></param>
        /// Created by: LDLONG 10.05.2022
        public override void InitVoucherDetail(VoucherObject voucher, OriginData orgData)
        {
            var voucherData = (sa_order)voucher;
            List<sa_order_detail> lstDetail = new List<sa_order_detail>();

            // *Note* Demo nên fix cứng dữ liệu - thực tế dựa vào orgData để sinh ra dữ liệu
            sa_order_detail detailItem1 = new sa_order_detail();
            detailItem1.refid = voucherData.refid;
            detailItem1.ref_detail_id = Guid.NewGuid();
            detailItem1.inventory_item_id = Guid.Empty;
            detailItem1.inventory_item_name = "Quạt máy";
            detailItem1.description = "Quạt máy";
            detailItem1.inventory_item_code = "QM";
            detailItem1.unit_id = Guid.Empty;
            detailItem1.unit_name = "Chiếc";
            detailItem1.stock_id = Guid.Empty;
            detailItem1.stock_code = "KHO1";
            detailItem1.stock_name = "Kho Hà Nội";
            detailItem1.quantity = 5;
            detailItem1.unit_price = 300000;
            detailItem1.vat_rate = 10;
            detailItem1.vat_amount = 150000;
            detailItem1.vat_amount_oc = 150000;
            detailItem1.amount_oc = detailItem1.quantity * detailItem1.unit_price;
            detailItem1.amount = detailItem1.amount_oc;

            sa_order_detail detailItem2 = new sa_order_detail();
            detailItem2.refid = voucherData.refid;
            detailItem2.ref_detail_id = Guid.NewGuid();
            detailItem2.inventory_item_id = Guid.Empty;
            detailItem2.inventory_item_name = "Dầu máy Castrol";
            detailItem1.description = "Dầu máy Castrol";
            detailItem2.inventory_item_code = "DMCT";
            detailItem2.unit_id = Guid.Empty;
            detailItem2.unit_name = "Thùng";
            detailItem2.stock_id = Guid.Empty;
            detailItem2.stock_code = "KHO2";
            detailItem2.stock_name = "Kho Hải Phòng";
            detailItem2.quantity = 4;
            detailItem2.unit_price = 400000;
            detailItem2.vat_rate = 10;
            detailItem2.vat_amount = 160000;
            detailItem2.vat_amount_oc = 160000;
            detailItem2.amount_oc = detailItem2.quantity * detailItem2.unit_price;
            detailItem2.amount = detailItem2.amount_oc;

            lstDetail.Add(detailItem1);
            lstDetail.Add(detailItem2);
            CaculateAmountDetail(lstDetail);
            voucherData.detail = lstDetail;
        }

        /// <summary>
        /// Tính toán lại tiền ở từng dòng nếu cần
        /// </summary>
        /// Created by: LDLONG 22.05.2022
        public void CaculateAmountDetail(List<sa_order_detail> lstDetail)
        {
            if(lstDetail?.Count > 0)
            {
                foreach (sa_order_detail item in lstDetail)
                {
                    item.amount_oc = item.quantity * item.unit_price;
                    // Tiền VND thì thành tiền quy đổi bằng thành tiền nguyên tệ. Ngoại tệ thì phải tính toán lại theo tỷ giá
                    item.amount = item.amount_oc; 
                }
            }
        }

        /// <summary>
        /// Mapping Id các object của danh mục với chứng từ
        /// </summary>
        /// <param name="dataVoucher"></param>
        /// Created by: LDLONG 22.05.2022
        public override void MappingIdObjectVoucher(VoucherRequestParam dataVouchers)
        {
            if(dataVouchers.voucher?.Count > 0)
            {
                List<account_object> lstAccountObject = new List<account_object>(); // Danh sách đối tượng
                List<inventory_item> lstInventoryItem = new List<inventory_item>();
                List<unit> lstUnit = new List<unit>();
                List<stock> lstStock = new List<stock>();
                if(dataVouchers.dictionary?.Count > 0)
                {
                    lstAccountObject = dataVouchers.dictionary.Where(x => x is account_object)?.Cast<account_object>().ToList();
                    lstInventoryItem = dataVouchers.dictionary.Where(x => x is inventory_item)?.Cast<inventory_item>().ToList();
                    lstUnit = dataVouchers.dictionary.Where(x => x is unit)?.Cast<unit>().ToList();
                    lstStock = dataVouchers.dictionary.Where(x => x is stock)?.Cast<stock>().ToList();
                }
                foreach (sa_order order in dataVouchers.voucher)
                {
                    // Mapping phần thông tin chung bao gồm khách hàng, nhân viên, nhà cung cấp bằng mã đối tượng
                    // 1.Khách hàng hoặc nhà cung cấp trên chứng từ
                    if(order.account_object_code != null)
                    {
                        var objMapping1 = lstAccountObject.FirstOrDefault(x => x.account_object_code == order.account_object_code);
                        if (objMapping1 != null)
                        {
                            order.account_object_id = objMapping1.account_object_id;
                            order.account_object_name = objMapping1.account_object_name;
                        }

                    }
                    // 2.Nhân viên trên chứng từ
                    if (order.employee_code != null)
                    {
                        var objMapping2 = lstAccountObject.FirstOrDefault(x => x.account_object_code == order.employee_code);
                        if (objMapping2 != null)
                        {
                            order.employee_id = objMapping2.account_object_id;
                            order.employee_name = objMapping2.account_object_name;
                        }
                    }

                    //Mapping thông tin id chi tiết chứng từ
                    if(order.detail?.Count > 0)
                    {
                        foreach (sa_order_detail item in order.detail)
                        {
                            // 3.Mapping id hàng hóa
                            if(!String.IsNullOrEmpty(item.inventory_item_code))
                            {
                                var inventoryMapping = lstInventoryItem.FirstOrDefault(x => x.inventory_item_code == item.inventory_item_code);
                                if(inventoryMapping != null)
                                {
                                    item.inventory_item_id = inventoryMapping.inventory_item_id;
                                    item.inventory_item_name = inventoryMapping.inventory_item_name;
                                    item.description = inventoryMapping.inventory_item_name;
                                }
                            }
                            // 4.Mapping id đơn vị tính (Nếu có)
                            if (!String.IsNullOrEmpty(item.unit_name))
                            {
                                var unitMapping = lstUnit.FirstOrDefault(x => x.unit_name == item.unit_name);
                                if (unitMapping != null)
                                {
                                    item.unit_id = unitMapping.unit_id;
                                }
                            }
                            // 5.Mapping id kho (Nếu có)
                            if (!String.IsNullOrEmpty(item.stock_code))
                            {
                                var stockMapping = lstStock.FirstOrDefault(x => x.stock_code == item.stock_code);
                                if (stockMapping != null)
                                {
                                    item.stock_id = stockMapping.stock_id;
                                    item.stock_name = stockMapping.stock_name;
                                }
                            }
                        }
                    }


                }
            }
        }
    }
}
