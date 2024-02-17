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
    public partial class RoomTypeInfoUI : Form
    {
        private DataTable dataTableConvinience = new DataTable();
        private DataTable dataTableConvinienceRoomType = new DataTable();

        private bool isEdit = false;
        private RoomUI roomUI;

        private RoomBUS roomBus = new RoomBUS();

        private List<RoomType> roomTypeList;
        private List<RoomTypeConvinience> convinience_roomTypeList;
        private List<Convinience> convinienceList;

        public RoomTypeInfoUI(RoomUI roomUI)
        {
            InitializeComponent();
            initCbx();


            this.roomUI = roomUI;
        }

        #region method

        public void initCbx()
        {
            createHeaderText();

            roomTypeList = roomBus.getAllRoomType();
            convinience_roomTypeList = roomBus.getAllRoomTypeConvinience();
            convinienceList = roomBus.getAllConvinience();


            dataTableConvinience.Rows.Clear();
            dtgvConvinience.DataSource = null;
            foreach (Convinience conv in convinienceList)
            {
                dataTableConvinience.Rows.Add(conv.Id, conv.Name);
            }

            dtgvConvinience.DataSource = dataTableConvinience;

            foreach (DataGridViewColumn column in dtgvConvinience.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            createHeaderText2();
        }



        public void roomTypeIDData()
        {
            //foreach (var item in roomTypeList)
            //{
            //    if (item.Id == cbbRoomTypeID.Text)
            //    {
            //        labelNameTypeChange.Text = item.Name;
            //        labelUnitPriceChange.Text = item.UnitPrice.ToString();
            //    }
            //}
        }

        public void convinientRoomTypeData()
        {
            dataTableConvinienceRoomType.Rows.Clear();
            dtgvConvinienceRoomType.DataSource = null;
            foreach (var item in convinience_roomTypeList)
            {
                if (txbID.Text == item.RoomTypeId)
                {
                    foreach (var item1 in convinienceList)
                    {
                        if (item.ConvinienceId == item1.Id)
                        {
                            dataTableConvinienceRoomType.Rows.Add(item.ConvinienceId, item1.Name, item.Quantity);
                        }
                    }
                }
            }

            dtgvConvinienceRoomType.DataSource = dataTableConvinienceRoomType;
            foreach (DataGridViewColumn column in dtgvConvinienceRoomType.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        public void createHeaderText()
        {
            dataTableConvinience.Columns.Add("Mã tiện nghi");
            dataTableConvinience.Columns.Add("Tên tiện nghi");
        }

        public void createHeaderText2()
        {
            dataTableConvinienceRoomType.Columns.Add("Mã tiện nghi");
            dataTableConvinienceRoomType.Columns.Add("Tên tiện nghi");
            dataTableConvinienceRoomType.Columns.Add("Số lượng");
        }



        //Xem kiểu sự kiện "Thêm hay sửa"
        public void fillData(RoomType roomType, string type)
        {
            labelTitle.Text = type;
            txbID.Enabled = false;
            txbID.Text = roomType.Id;


            btnSave.Text = type;

            if (type == "Chi tiết loại phòng")
            {
                txbName.Enabled = false;
                txbPrice.Enabled = false;
                txbName.Text = roomType.Name;
                txbPrice.Text = roomType.UnitPrice.ToString();
                panel7.Enabled = false;
                tableLayoutPanelThongTin.Enabled = false;
                btnSave.Visible = false;
                btnReset.Visible = false;
                //Sao không chỉnh được nhỉ
            }
            else
            {
                isEdit = type == "Cập nhật loại phòng" ? true : false;
                if (isEdit)
                {
                    txbName.Text = roomType.Name;
                    txbPrice.Text = roomType.UnitPrice.ToString();
                }
                else
                {
                    txbName.Text = string.Empty;
                    txbPrice.Text = string.Empty;
                    panel7.Visible = false;
                    tableLayoutPanelThongTin.Visible = false;
                }
            }

            convinientRoomTypeData();
        }
        //Kiểm tra dữ liệu trước khi cập nhật hay tạo mới
        private bool validateForm()
        {
            bool isNameValid = Validator.Instance.checkTextBox(txbName, errName, new string[] { "not-empty" });
            bool isPriceValid = Validator.Instance.checkTextBox(txbPrice, errPrice, new string[] { "positive-number", "room-price" });
            
            return isNameValid && isPriceValid;
        }

        #endregion


        #region event
        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txbID.Text;
            String name = txbName.Text;
            String unitPrice = txbPrice.Text;

            if (!validateForm())
            {
                return;
            }
            
            RoomType roomType = new RoomType(id, name,Double.Parse(unitPrice));
            
            if (!roomBus.validate(roomType))
            {
                return;
            }
            
            if (isEdit)
            {
                if (roomBus.updateRoomType(roomType) > 0)
                {
                    MessageBox.Show("Cập nhật loại phòng thành công");
                    this.roomUI.initTableRoomType();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại phòng không thành công.");
                }
            }
            else
            {
                if (roomBus.addRoomType(roomType) > 0)
                {
                    MessageBox.Show("Thêm loại phòng thành công");
                    this.roomUI.initTableRoomType();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm loại phòng không thành công");
                }
            }
        }

       

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (isEdit)
            {
                foreach (var item in roomTypeList)
                {
                    if (txbID.Text == item.Id)
                    {
                        txbName.Text = item.Name;
                        txbPrice.Text = item.UnitPrice.ToString();
                    }
                }
            }
            else
            {
                txbName.Text = string.Empty;
                txbPrice.Text = string.Empty;
                cbbQuantity.Text = string.Empty;
            }

        }
        private void txbName_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txbName, errName, new string[] { "not-empty" });
        }

        private void txbPrice_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txbPrice, errPrice, new string[] { "positive-number", "room-price" });
        }
        #endregion

        int indexSearch = -1;

        int index = -1;
        private void dtgvConvinience_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            if (index < 0 || index >= convinienceList.Count)
            {
                btnActive.Text = "Thêm";
                return;
            }
            btnActive.Text = "Thêm";

            cbbQuantity.Enabled = true;
        }

        int index1 = -1;
        private void dtgvConvinienceRoomType_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index1 = e.RowIndex;
            if (index1 < 0 || index1 >= dtgvConvinienceRoomType.RowCount)
                return;
            btnActive.Text = "Xóa";
            cbbQuantity.Enabled = false;
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            if (btnActive.Text == "Thêm")
            {
                if (index < 0 || index >= convinienceList.Count)
                {
                    MessageBox.Show("Bạn chưa chọn tiện nghi muốn thêm");
                    return;
                }

                foreach (DataGridViewRow row in dtgvConvinienceRoomType.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        if (convinienceList[index].Id == row.Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Bạn không thể thêm tiện nghi này");
                            return;
                        }
                    }
                }

                RoomTypeConvinience convinience_RoomType;
                if (int.TryParse(cbbQuantity.Text, out var quantity) && (quantity > 0 && quantity < 5))
                {
                    convinience_RoomType = new RoomTypeConvinience()
                    {
                        RoomType = roomBus.getRoomTypeById(txbID.Text),
                        Convinience = roomBus.getConvinienceById(convinienceList[index].Id),
                        Quantity = quantity
                    };
                }
                else
                {
                    MessageBox.Show("Số lượng tiện nghi sai định dạng");
                    return;
                }

                if (roomBus.addRoomTypeConvinience(convinience_RoomType) > 0)
                {
                    MessageBox.Show("Thêm tiện nghi vào loại phòng thành công");
                    convinience_roomTypeList = roomBus.getAllRoomTypeConvinience();
                    convinientRoomTypeData();
                }
            }
            else if (btnActive.Text == "Xóa")
            {
                if (index1 < 0 || index1 >= dtgvConvinienceRoomType.RowCount)
                {
                    MessageBox.Show("Bạn chưa chọn tiện nghi muốn xóa");
                    return;
                }


                for (int i = 0; i < convinience_roomTypeList.Count; i++)
                {
                    if (convinience_roomTypeList[i].ConvinienceId == dtgvConvinienceRoomType.Rows[index1].Cells[0].Value.ToString()
                        && convinience_roomTypeList[i].RoomTypeId == txbID.Text)
                    {
                        if (MessageBox.Show("Bạn có muốn xóa tiện nghi " + convinience_roomTypeList[i].ConvinienceId + " khỏi loại phòng " + convinience_roomTypeList[i].RoomTypeId + " không.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                        {
                            if (roomBus.deleteRoomTypeConvinience(convinience_roomTypeList[i].ConvinienceId, convinience_roomTypeList[i].RoomTypeId) > 0)
                            {
                                MessageBox.Show("Xóa tiện nghi khỏi loại phòng này thành công");
                                convinience_roomTypeList = roomBus.getAllRoomTypeConvinience();
                                convinientRoomTypeData();
                                return;
                            }
                        }
                    }
                }
            }
        }


    }
}
