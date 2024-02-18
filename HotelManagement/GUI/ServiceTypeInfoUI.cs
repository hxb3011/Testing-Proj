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
using System.Xml.Linq;

namespace HotelManagement.GUI
{
    public partial class ServiceTypeInfoUI : Form
    {
        private bool isEdit = false;
        private ServiceBUS serviceBUS = new ServiceBUS();
        private ServiceUI serviceUI;
        public ServiceTypeInfoUI()
        {
            InitializeComponent();
        }

        public ServiceTypeInfoUI(ServiceUI serviceUI)
        {
            InitializeComponent();
            this.serviceUI = serviceUI;
        }

        #region method
        public void fillData(string id, string name, string type)
        {
            txtId.Text = id;
            txtName.Text = name;

            btnSave.Text = type;
            isEdit = type == "Lưu thông tin" ? true : false;
        }

        public void addType(string id, string name)
        {
            if (serviceBUS.validateType(id, name))
            {
                int result = serviceBUS.addType(new ServiceType() { Id = id, Name = name });
                if (result > 0)
                {
                    MessageBox.Show("Thêm loại dịch vụ thành công!");
                    this.serviceUI.initTypeTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm loại dịch vụ không thành công!");
                }
            }


        }

        public void updateType(string id, string name)
        {
            if (serviceBUS.validateType(id, name))
            {
                int result = serviceBUS.updateType(new ServiceType() { Id = id, Name = name });
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật loại dịch vụ thành công!");
                    this.serviceUI.initTypeTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật loại dịch vụ không thành công!");
                }
            }
        }

        #endregion


        #region event


        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            if (Validator.Instance.checkTextBox(txtName, errName, new string[] { "not-empty" }))
            {
                if (isEdit)
                {
                    updateType(id, name);
                }
                else
                {
                    addType(id, name);
                }
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txtName, errName, new string[] { "not-empty" });
        }
        #endregion


    }
}
