using HotelManagement.Data;
using HotelManagement.Data.Access;
using HotelManagement.Ultils;
using Microsoft.EntityFrameworkCore;
using System.Text;
namespace HotelManagement.BUS
{
    public class CustomerBUS
    {
        private CustomerDAO customerDAO = new CustomerDAO();

        public List<Customer> getAll()
        {
            return customerDAO.Customers.AsNoTracking().ToList();
        }
        public int add(Customer customer)
        {
            customerDAO.Customers.Add(customer);
            return customerDAO.SaveChanges();
        }

        public int update(Customer customer)
        {
            customerDAO.Entry(customer).State = EntityState.Detached;
            customerDAO.Customers.Attach(customer);
            customerDAO.Entry(customer).State = EntityState.Modified;

            Customer temp = customerDAO.Customers.First(item => item.Id.Equals(customer.Id));
            temp.FullName = customer.FullName;
            temp.Gender = customer.Gender;
            temp.Birthday = customer.Birthday;
            temp.CitizenID = customer.CitizenID;
            temp.PhoneNumber = customer.PhoneNumber;
            temp.Address = customer.Address;
            
            return customerDAO.SaveChanges(); 
        }

        public int delete(string id)
        {
            Customer temp = customerDAO.Customers.First(item => item.Id.Equals(id));
            customerDAO.Customers.Remove(temp);

            return customerDAO.SaveChanges();
        }
        public int getLength()
        {
            return getAll().Count();
        }

        public bool validateEmpty(Customer customer)
        {
            StringBuilder sb = new StringBuilder();
            if(customer.FullName.Length == 0)
            {
                sb.Append("Họ tên không được để trống!\n");
            }
            if (customer.CitizenID.Length == 0)
            {
                sb.Append("CCCD không được để trống!\n");
            }
            if (customer.PhoneNumber.Length == 0)
            {
                sb.Append("Sdt không được để trống!\n");
            }
            if (customer.Address.Length == 0)
            {
                sb.Append("Địa chỉ không được để trống!\n");
            }
            if(sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }
            return true;
        }

        public bool validate(Customer customer)
        {
            if (!validateEmpty(customer))
            {
                return false;
            }

            StringBuilder sb = new StringBuilder();
            if (!ValidationCustom.checkPhoneNumber(customer.PhoneNumber))
            {
                sb.Append("Số điện thoại không hợp lệ!\n");
            }

            if (!ValidationCustom.checkCitizenId(customer.CitizenID))
            {
                sb.Append("CCCD không hợp lệ!\n");
            }

            if(getAll().Any(item => !item.Id.Equals(customer.Id) && item.CitizenID.Equals(customer.CitizenID)))
            {
                sb.Append("CCCD đã tồn tại!\n");
            }

            if (sb.Length > 0)
            {
                MessageBox.Show(sb.ToString());
                return false;
            }

            return true;
        }

        public Customer getCustomerByCCCD(string cccd)
        {
            return getAll().Find(item => item.CitizenID.Equals(cccd));
        }
    }
}
