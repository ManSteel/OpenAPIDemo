﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.BL;
using WindowsFormsApp1.Interface;
using WindowsFormsApp1.Model;

namespace WindowsFormsApp1
{
    public partial class AppConnectMisaAmis : Form
    {
        private HttpClient _client;
        private string _baseUrl;
        public AppConnectMisaAmis()
        {
            InitializeComponent();
            _client = new HttpClient();
            _baseUrl = "https://actapp.misa.vn"; // Môi trường chính thức
            //_baseUrl = "https://testactapp.misa.vn"; // Môi trường test

        }

        /// <summary>
        /// Tải project về set lại đúng _urlStorage trên máy của mình
        /// </summary>
        private string _urlStorage = @"C:\Users\Admin\source\repos\WindowsFormsApp1\Data";

        #region Event handle
        /// <summary>
        /// Kết nối Amis Kế toán lấy access_token
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Created by: LDLONG 20.03.2022
        private async void connect_app(object sender, EventArgs e)
        {
            try
            {
                //ConnectParam param = new ConnectParam();
                //param.app_id = "0e0a14cf-9e4b-4af9-875b-c490f34a581b";
                //param.access_code = "YXmnj0/VIKq773xjxH0EzbjWOGoGKBs6P/v9BazCqYsZxyuGjPSkp2FZqwAEEuWACJ0eW002315ddR0jjR2GoaZ69JvB0hn1koATFaJ6/DrfKuPh7WnyjAGNPzJnQu9oN6bwyGnbN005jyMAWH4gt5SvTCsPvPl12eNYjmRkUlDOdZ7DADQAdB9OGgX0BLPTy/cyVDx6U055DDjw/O00MToMzT6yYwRQ/uJONwFAmGdWahMWOvTQy5TGR+jLtMFj";
                //param.org_company_code = "misa";
                string connectSetting = System.IO.File.ReadAllText($"{_urlStorage}\\app_setting.json");
                var param = JsonConvert.DeserializeObject<ConnectParam>(connectSetting);
                HttpClient client = new HttpClient();
                Uri uri = new Uri($"{_baseUrl}/api/oauth/actopen/connect");
                StringContent httpContent = new StringContent(JsonConvert.SerializeObject(param), Encoding.UTF8, "application/json");
                var response = client.PostAsync(uri, httpContent).Result;

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    ConnectResult connectResult = JsonConvert.DeserializeObject<ConnectResult>(jsonResponse);
                    if (connectResult.Success)
                    {
                        TokenInfo tokenInfo = JsonConvert.DeserializeObject<TokenInfo>(connectResult.Data);
                        SaveToken(tokenInfo);
                        this.label2.Text = "Đã kết nối";
                        MessageBox.Show("Kết nối amis thành công!");
                    }
                    else
                    {
                        MessageBox.Show($"Kết nối thất bại: {connectResult.ErrorMessage}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kết nối không thành công (Error: {ex.StackTrace})");
            }
        }

        #endregion


        #region Method
        public async Task<HttpResponseMessage> CallApi(HttpRequestMessage message)
        {
            var res = new HttpResponseMessage();
            try
            {
                res = await _client.SendAsync(message);
            }
            catch (Exception ex)
            {
                res.StatusCode = HttpStatusCode.BadRequest;
                res.ReasonPhrase = $"Call API fail: {ex.Message}";
                throw;
            }
            return res;
        }
        /// <summary>
        /// Lưu trữ thông tin token để khi call API lấy ra sử dụng (Demo lưu thông tin token vào file)
        /// Recommend: Khi thi công nên lưu cache để quản lý expire time của token
        /// </summary>
        /// <param name="tokenInfo"></param>
        /// Created by: LDLONG 20.03.2022
        private void SaveToken(TokenInfo tokenInfo)
        {
            if(tokenInfo != null)
            {
                TextWriter txt = new StreamWriter($"{_urlStorage}\\token_info.txt");
                txt.Write(JsonConvert.SerializeObject(tokenInfo));
                txt.Close();
            }
        }

        /// <summary>
        /// Lấy thông tin token để call API
        /// </summary>
        /// <returns></returns>
        /// Created by: LDLONG 20.03.2022
        public TokenInfo GetToken()
        {
            TokenInfo token = new TokenInfo();
            string tokenInfo = System.IO.File.ReadAllText($"{_urlStorage}\\token_info.json");
            var param = JsonConvert.DeserializeObject<TokenInfo>(tokenInfo);
            return token;
        }

        #endregion

        /// <summary>
        /// Đẩy dữ liệu chứng từ lên amis kế toán
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// Created date: LDLONG 30.04.2022
        private void PushVoucherDataAmisAccounting(object sender, EventArgs e)
        {
            var vouchertype = this.comboBoxVoucherTye.Text;
            IVoucherBussinessHandle voucherBussiness = InitVoucherBussinessHandle(vouchertype);
            VoucherRequestParam dataVoucher = new VoucherRequestParam();
            OriginData orgData = new OriginData();
            //Khởi tạo dữ liệu danh mục đẩy chứng từ
            voucherBussiness.InitDictionary(dataVoucher, orgData);

        }

        /// <summary>
        /// Khởi tạo đối tượng xử lý đẩy dữ liệu theo từng loại chứng từ
        /// </summary>
        /// <param name="vouchertype"></param>
        /// <returns></returns>
        private IVoucherBussinessHandle InitVoucherBussinessHandle(string vouchertype)
        {
            IVoucherBussinessHandle voucherBussiness = null;
            switch (vouchertype)
            {
                case "Đơn đặt hàng":
                    voucherBussiness = new SaOrderBussinesObject();
                    break;
                case "Chứng từ bán hàng":
                    voucherBussiness = new SaVoucherBussinessObject();
                    break;
                case "Chứng từ mua hàng":
                    voucherBussiness = new SaVoucherBussinessObject();
                    break;
                default:
                    break;
            }
            return voucherBussiness;
        }
    }
}