using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Ultils;
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
    public partial class RoomInfoUI : Form
    {
        private bool isEdit = false;
        private RoomBUS roomBUS = new RoomBUS();
        private RoomUI roomUI;

        private List<String> status = new List<string>() { "Đã dọn dẹp", "Chưa dọn dẹp", "Sửa chữa" };
        private List<Room> roomList;
        private List<RoomType> roomTypeList;
        private List<RoomTypeConvinience> convinience_roomType;
        private List<Convinience> convinience;

        public RoomInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            initCbx();
            this.roomUI = roomUI;
        }

        #region method
        public void initCbx()
        {
            listViewConvinience.Columns.Add("Convinience id", 150);
            listViewConvinience.Columns.Add("Convinience name", 150);
            listViewConvinience.Columns.Add("Quantity ", 100);
            cbbStatus.Items.AddRange(status.ToArray());
            roomTypeList = roomBUS.getAllRoomType();
            roomList = roomBUS.getAllRoom();


            foreach (var item in roomTypeList)
            {
                cbbRoomTypeID.Items.Add(item.Id.ToString());
            }

            convinience_roomType = roomBUS.getAllRoomTypeConvinience();
            convinience = roomBUS.getAllConvinience();
        }

        public void roomTypeIDData()
        {
            foreach (var item in roomTypeList)
            {
                if (item.Id == cbbRoomTypeID.Text)
                {
                    labelNameTypeChange.Text = item.Name;
                    labelUnitPriceChange.Text = item.UnitPrice.ToString();
                }
            }
        }

        public void convinientData()
        {
            listViewConvinience.Items.Clear();
            //foreach (var item in )
            foreach (var item in convinience_roomType)
            {
                if (cbbRoomTypeID.Text == item.RoomTypeId)
                {
                    ListViewItem listViewItem = new ListViewItem(item.ConvinienceId);
                    foreach (var item1 in convinience)
                    {
                        if (item.ConvinienceId == item1.Id)
                        {
                            listViewItem.SubItems.Add(item1.Name);
                        }
                    }
                    listViewItem.SubItems.Add(item.Quantity.ToString());

                    listViewConvinience.Items.Add(listViewItem);
                }
            }
        }

        public void fillData(Room room, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = room.Id;
            cbbStatus.SelectedIndex = room.Status;


            btnSave.Text = type;
            if (type == "Chi tiết phòng")
            {
                cbbRoomTypeID.Text = room.RoomTypeId;
                cbbRoomTypeID.Enabled = false;
                cbbStatus.Enabled = false;
                btnReset.Visible = false;
                btnSave.Visible = false;
            }
            else
            {
                isEdit = type == "Cập nhật phòng" ? true : false;
                if (isEdit)
                {
                    cbbRoomTypeID.Text = room.RoomTypeId;
                }
                else
                {
                    cbbRoomTypeID.SelectedIndex = 0;
                }
            }



        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            int status = cbbStatus.SelectedIndex;
            string roomTypeID = cbbRoomTypeID.Text;

            Room room = new Room(id, status, roomTypeID);
            if (isEdit)
            {
                if (roomBUS.updateRoom(room) > 0)
                {
                    MessageBox.Show("Cập nhật phòng thành công");
                    this.roomUI.initTableRoom();
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Cập nhật phòng không thành công.");
                }
            }
            else
            {
                //if (roomBUS.add(room) > 0)
                //{
                //    MessageBox.Show("Thêm phòng thành công");
                //    this.roomUI.initTableRoom();
                //    this.Close();
                //}
                //else
                //{
                //    MessageBox.Show("Thêm phòng không thành công");
                //}
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {

            foreach (var item in roomList)
            {
                if (txbID.Text == item.Id)
                {
                    cbbStatus.SelectedIndex = item.Status;
                    cbbRoomTypeID.Text = item.RoomTypeId;
                }
            }
        }

        private void cbbRoomTypeID_SelectedValueChanged(object sender, EventArgs e)
        {
            roomTypeIDData();
            convinientData();
        }
        #endregion



    }
}
