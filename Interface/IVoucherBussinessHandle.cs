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
        void InitDictionary(VoucherRequestParam dataVoucher, OriginData orgData);
    }
}
