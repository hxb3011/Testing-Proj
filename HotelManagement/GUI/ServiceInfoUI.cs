using HotelManagement.BUS;
using HotelManagement.Data;
using HotelManagement.Data.Transfer.Ultils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HotelManagement.GUI
{
    public partial class ServiceInfoUI : Form
    {
        private bool isEdit = false;
        private ServiceUI serviceUI;
        private ServiceBUS serviceBUS = new ServiceBUS();
        public ServiceInfoUI()
        {
            InitializeComponent();
            initCbxServiceType();
        }

        public ServiceInfoUI(ServiceUI serviceUI)
        {
            InitializeComponent();
            this.serviceUI = serviceUI;
            initCbxServiceType();
        }

        #region method
        public void initCbxServiceType()
        {
            List<ServiceType> list = serviceBUS.getAllType();
            cbxServiceType.DataSource = null;
            cbxServiceType.DataSource = list;
            cbxServiceType.DisplayMember = "Name";
            cbxServiceType.ValueMember = "Id";
        }
        public void fillData(string id, string name, double unitPrice, string unit, string typeName, string type)
        {
            txtId.Text = id;
            txtName.Text = name;
            txtUnit.Text = unit;
            txtUnitPrice.Text = unitPrice.ToString();

            if (typeName != "")
            {
                cbxServiceType.Text = typeName;
            }
            else
            {
                cbxServiceType.SelectedIndex = 0;
            }

            btnSave.Text = type;
            isEdit = type == "Lưu thông tin" ? true : false;
        }

        public void addService(string id, string name, string unit, string unitPrice, string serviceTypeId)
        {
            
                Service service = new Service()
                { Id = id, Name = name, Unit = unit, UnitPrice = int.Parse(unitPrice) };
                service.ServiceTypeId = serviceTypeId;
                int result = serviceBUS.addService(service);
                if (result > 0)
                {
                    MessageBox.Show("Thêm dịch vụ thành công!");
                    this.serviceUI.initServiceTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Thêm dịch vụ không thành công!");
                }
            
        }

        public void updateService(string id, string name, string unit, string unitPrice, string serviceTypeId)
        {
            
                Service service = new Service()
                { Id = id, Name = name, Unit = unit, UnitPrice = int.Parse(unitPrice) };
                service.ServiceTypeId = serviceTypeId;
                int result = serviceBUS.updateService(service);
                if (result > 0)
                {
                    MessageBox.Show("Cập nhật dịch vụ thành công!");
                    this.serviceUI.initServiceTable();
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Cập nhật dịch vụ không thành công!");
                }
            
        }
        private bool validateForm()
        {
            bool isNameValid =
            Validator.Instance.checkTextBox(txtName, errName, new string[] { "not-empty" });

            bool isUnitValid =
            Validator.Instance.checkTextBox(txtUnit, errUnit, new string[] { "not-empty" });

            bool isUnitPriceValid  =
            Validator.Instance.checkTextBox(txtUnitPrice, errUnitPrice, new string[] {"positive-number" });

            return isNameValid && isUnitValid && isUnitPriceValid;  
        }

        #endregion


        #region event

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string name = txtName.Text;
            string unit = txtUnit.Text;
            string unitPrice = txtUnitPrice.Text;
            string serviceTypeId = cbxServiceType.SelectedValue.ToString() + "";
            if (validateForm())
            {
                if (isEdit)
                {
                    updateService(id, name, unit, unitPrice, serviceTypeId);
                }
                else
                {
                    addService(id, name, unit, unitPrice, serviceTypeId);
                }
            }    
        }

     

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtUnit.Text = "";
            txtUnitPrice.Text = "";
            cbxServiceType.SelectedIndex = 0;
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txtName, errName, new string[] { "not-empty" });
        }
        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txtUnitPrice, errUnitPrice, new string[] { "positive-number" });
        }
        private void txtUnit_TextChanged(object sender, EventArgs e)
        {
            Validator.Instance.checkTextBox(txtUnit, errUnit, new string[] { "not-empty" });

        }
        #endregion
    }
}
