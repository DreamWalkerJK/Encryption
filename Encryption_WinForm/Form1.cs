using System;
using System.Windows.Forms;
using EncryptOrDecrypt;

namespace Encryption_WinForm
{
    public partial class Form1 : Form
    {
        private string _Option = string.Empty;

        public Form1()
        {
            InitializeComponent();
            this._Option = btnMD5.Text;
            lbTitle.Text = this._Option;
        }

        /// <summary>
        /// 清除两个文本框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        /// <summary>
        /// 加密算法选项
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonOption_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button tempBtn = new Button();
                tempBtn = sender as Button;
                _Option = tempBtn.Text;
                lbTitle.Text = _Option;
            }
            else
            {
                MessageBox.Show("按钮出错！");
            }
        }

        /// <summary>
        /// 判断加密或解密
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonEncryptOrDecrypt_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                DateTime dtStart = DateTime.Now;

                Button tempBtn = new Button();
                tempBtn = sender as Button;
                switch (tempBtn.Text)
                {
                    case "加密":
                        EncrptOperation();
                        break;
                    case "解密":
                        DecryptOperation();
                        break;
                }

                DateTime dtEnd = DateTime.Now;
                TimeSpan ts = dtEnd.Subtract(dtStart);
                lbTime.Text = ts.ToString() + "ms";
            }
            else
            {
                MessageBox.Show("按钮出错！");
            }
        }

        /// <summary>
        /// 加密操作
        /// </summary>
        private void EncrptOperation()
        {
            if (string.IsNullOrEmpty(txtOrigin.Text.Trim()))
            {
                MessageBox.Show("需要加密的明文不可为空！");
                return;
            }

            EncryptOrDecryptOption encryptOrDecryptOption = new EncryptOrDecryptOption();
            txtEncrypt.Text = encryptOrDecryptOption.EncryptOptionStart(_Option, txtOrigin.Text);
        }

        /// <summary>
        /// 解密操作
        /// </summary>
        private void DecryptOperation()
        {
            if (string.IsNullOrEmpty(txtEncrypt.Text.Trim()))
            {
                MessageBox.Show("需要解密的密文不可为空！");
                return;
            }

            EncryptOrDecryptOption encryptOrDecryptOption = new EncryptOrDecryptOption();
            txtOrigin.Text = encryptOrDecryptOption.DecryptOptionStart(_Option, txtEncrypt.Text);
        }

        private void Clear()
        {
            txtOrigin.Clear();
            txtEncrypt.Clear();
            lbTime.Text = string.Empty;
        }
    }
}
