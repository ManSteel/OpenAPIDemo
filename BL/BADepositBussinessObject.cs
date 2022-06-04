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
    public class BADepositBussinessObject: VoucherBussinessBase
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
            // *Note* Demo nên fix cứng dữ liệu - thực tế dựa vào orgData để sinh ra các dữ liệu mục 1

            // 4. Đẩy thông tin đối tượng
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

            bank_account bankAccount = new bank_account();
            bankAccount.bank_account_id = Guid.NewGuid();
            bankAccount.bank_account_number = "5917117";

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
            ba_deposit baDepositVoucher = new ba_deposit();
            InitVoucherMaster(baDepositVoucher, orgData);
            InitVoucherDetail(baDepositVoucher, orgData);
            lstVoucher.Add(baDepositVoucher);
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
            var voucherData = (ba_deposit)voucher;
            voucherData.org_refid = Guid.NewGuid().ToString();
            voucherData.org_refno = "NTTK00003_test"; //Số đơn hàng gốc trên ứng dụng thứ 3 (mỗi lần test đổi lại số đơn hàng khác)
            voucherData.refno_finance = "NTTK00003_test";
            voucherData.refid = Guid.NewGuid();
            voucherData.refdate = DateTime.Now; // gắn lại theo ngày đơn hàng bên ứng dụng thứ 3, code demo gán = DateTime.Now
            voucherData.posted_date = DateTime.Now;
            voucherData.journal_memo = "Thu tiền khách hàng Lê Đình Long";

            voucherData.account_object_id = Guid.Empty;
            voucherData.account_object_code = "KH00001";
            voucherData.account_object_name = "Lê Đình Long";

            // Nộp vào tài khoản nào
            voucherData.bank_account_id = Guid.Empty;
            voucherData.bank_account_number = "5917117";
            voucherData.bank_name = "Ngân hàng TMCP Á Châu";


            voucherData.account_object_address = "Hà Đông - HN"; //Địa chỉ

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
            var voucherData = (ba_deposit)voucher;
            List<ba_deposit_detail> lstDetail = new List<ba_deposit_detail>();

            // *Note* Demo nên fix cứng dữ liệu - thực tế dựa vào orgData để sinh ra dữ liệu
            ba_deposit_detail detailItem1 = new ba_deposit_detail();
            detailItem1.refid = voucherData.refid;
            detailItem1.ref_detail_id = Guid.NewGuid();
            detailItem1.description = "Thu tiền khám bệnh";
            detailItem1.credit_account = "131";
            detailItem1.debit_account = "1121";
            detailItem1.amount_oc = 1500000;
            detailItem1.amount = 1500000;
            detailItem1.account_object_id = Guid.Empty;
            detailItem1.account_object_code = "KH00001";
            detailItem1.account_object_name = "Lê Đình Long";

            ba_deposit_detail detailItem2 = new ba_deposit_detail();
            detailItem2.refid = voucherData.refid;
            detailItem2.ref_detail_id = Guid.NewGuid();
            detailItem2.description = "Phụ thu 1 cốc cà phê code demo";
            detailItem2.credit_account = "131";
            detailItem2.debit_account = "1121";
            detailItem2.amount_oc = 100000;
            detailItem2.amount = 100000;
            detailItem2.account_object_id = Guid.Empty;
            detailItem2.account_object_code = "KH00001";
            detailItem2.account_object_name = "Lê Đình Long";

            lstDetail.Add(detailItem1);
            lstDetail.Add(detailItem2);
            CaculateAmountDetail(lstDetail);
            voucherData.detail = lstDetail;
        }

        /// <summary>
        /// Tính toán lại tiền ở từng dòng nếu cần
        /// </summary>
        /// Created by: LDLONG 22.05.2022
        public void CaculateAmountDetail(List<ba_deposit_detail> lstDetail)
        {
            if (lstDetail?.Count > 0)
            {
                foreach (ba_deposit_detail item in lstDetail)
                {
                    //TODO tính toán các thứ các thứ ở đây
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
            if (dataVouchers.voucher?.Count > 0)
            {
                List<account_object> lstAccountObject = new List<account_object>(); // Danh sách đối tượng
                List<bank_account> lstBankAccount = new List<bank_account>();
                if (dataVouchers.dictionary?.Count > 0)
                {
                    lstAccountObject = dataVouchers.dictionary.Where(x => x is account_object)?.Cast<account_object>().ToList();
                    lstBankAccount = dataVouchers.dictionary.Where(x => x is bank_account)?.Cast<bank_account>().ToList();
                }
                foreach (ba_deposit pVoucher in dataVouchers.voucher)
                {
                    // Mapping phần thông tin chung bao gồm khách hàng, nhân viên, nhà cung cấp bằng mã đối tượng
                    // 1.Đối tượng thu tiền
                    if (pVoucher.account_object_code != null)
                    {
                        var objMapping1 = lstAccountObject.FirstOrDefault(x => x.account_object_code == pVoucher.account_object_code);
                        if (objMapping1 != null)
                        {
                            pVoucher.account_object_id = objMapping1.account_object_id;
                        }

                    }
                    // 2.Nhân viên trên chứng từ
                    if (pVoucher.employee_code != null)
                    {
                        var objMapping2 = lstAccountObject.FirstOrDefault(x => x.account_object_code == pVoucher.employee_code);
                        if (objMapping2 != null)
                        {
                            pVoucher.employee_id = objMapping2.account_object_id;
                            pVoucher.employee_name = objMapping2.account_object_name;
                        }
                    }
                    // 3.Tài khoản nộp tiền trên máy thu
                    if (pVoucher.bank_account_number != null)
                    {
                        var bankAccount = lstBankAccount.FirstOrDefault(x => x.bank_account_number == pVoucher.bank_account_number);
                        if (bankAccount != null)
                        {
                            pVoucher.bank_account_id = bankAccount.bank_account_id;
                        }
                    }

                    //Mapping thông tin id chi tiết chứng từ
                    if (pVoucher.detail?.Count > 0)
                    {
                        foreach (ba_deposit_detail item in pVoucher.detail)
                        {
                            if (item.account_object_code != null)
                            {
                                var objDetailMapping = lstAccountObject.FirstOrDefault(x => x.account_object_code == item.account_object_code);
                                if (objDetailMapping != null)
                                {
                                    item.account_object_id = objDetailMapping.account_object_id;
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
