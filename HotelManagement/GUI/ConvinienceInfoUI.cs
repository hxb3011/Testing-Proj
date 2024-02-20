using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Ultils;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement.GUI
{
    public partial class ConvinienceInfoUI : Form
    {
        private bool isEdit = false;
        private RoomBUS roomBUS = new RoomBUS();
        private RoomUI roomUI;

        private List<RoomTypeConvinience> convinience_roomTypeList;
        private List<Convinience> convinienceList;

        public ConvinienceInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            convinienceList = roomBUS.getAllConvinience();
            this.roomUI = roomUI;
        }

        #region method

        public void fillData(Convinience conv, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = conv.Id;


            btnSave.Text = type;

            if (type == "Chi tiết tiện nghi")
            {
                txbName.Enabled = false;
                txbName.Text = conv.Name;
                btnReset.Visible = false;
                btnSave.Visible = false;
            }
            else
            {
                isEdit = type == "Cập nhật tiện nghi" ? true : false;
                if (isEdit)
                {
                    txbName.Text = conv.Name;
                }
                else
                {
                    txbName.Text = string.Empty;
                }
            }

        }
        //kiểm tra dữ liệu trươc khi gửi đi
        private bool validateForm()
        {
            return Validator.Instance.checkTextBox(txbName, errName, new string[] { "not-empty" });
        }
        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            string name = txbName.Text;

            if (!validateForm())
            {
                return;
            }    
            Convinience conv = new Convinience(id, name);
            if (isEdit)
            {
                if (roomBUS.updateConvinience(conv) > 0)
                {
                    MessageBox.Show("Cập nhật tiện nghi thành công");
                    this.roomUI.initTableConvinience();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật tiện nghi không thành công.");
                }
            }
            else
            {
                if (roomBUS.addConvinience(conv) > 0)
                {
                    MessageBox.Show("Thêm tiện nghi thành công");
                    this.roomUI.initTableConvinience();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm tiện nghi không thành công");
                }
            }
        }

     

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                foreach (var conv in convinienceList)
                {
                    if (conv.Id == txbID.Text)
                    {
                        txbName.Text = conv.Name;
                        return;
                    }
                }
            }
            else
            {
                txbName.Text = string.Empty;
                return;
            }
        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txbName, errName, new string[] { "not-empty" });
        }
        #endregion




    }
}
