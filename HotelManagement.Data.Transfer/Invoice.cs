﻿using HotelManagement.Data.Transfer;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace HotelManagement.Data
{
    [Table("rent_room_detail")]
    public class RentRoomDetail
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [Column("AddedTime", TypeName = "datetime")]
        private string addedTime;

        [Column("PaidTime", TypeName = "datetime")]
        private string paidTime;

        [StringLength(50)]
        [Column("RoomID", TypeName = "varchar")]
        private string roomID;

        [ForeignKey("RoomID")]
        private Room room;

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        [StringLength(50)]
        [Column("InvoiceID", TypeName = "varchar")]
        private string invoiceID;

        [ForeignKey("InvoiceID")]
        private Invoice invoice;

        public string Id { get => id; set => id = value; }
        public string AddedTime { get => addedTime; set => addedTime = value; }
        public string PaidTime { get => paidTime; set => paidTime = value; }
        public string RoomID { get => roomID; set => roomID = value; }
        public Room Room { get => room; set => room = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
    }

    [Table("use_service_detail")]
    public class UseServiceDetail
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [Column("Quantity", TypeName = "int")]
        private string quantity;

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        [StringLength(50)]
        [Column("InvoiceID", TypeName = "varchar")]
        private string invoiceID;

        [ForeignKey("InvoiceID")]
        private Invoice invoice;

        [StringLength(50)]
        [Column("ServiceID", TypeName = "varchar")]
        private string serviceID;

        [ForeignKey("ServiceID")]
        private Service service;

        public string Id { get => id; set => id = value; }
        public string Quantity { get => quantity; set => quantity = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public string InvoiceID { get => invoiceID; set => invoiceID = value; }
        public Invoice Invoice { get => invoice; set => invoice = value; }
        public string ServiceID { get => serviceID; set => serviceID = value; }
        public Service Service { get => service; set => service = value; }
    }

    [Table("invoice")]
    public class Invoice
    {
        [Key]
        [StringLength(50)]
        [Column("ID", TypeName = "varchar")]
        private string id;

        [StringLength(50)]
        [Column("CustomerID", TypeName = "varchar")]
        private string customerID;

        [ForeignKey("CustomerID")]
        private Customer customer;

        [StringLength(50)]
        [Column("ReservationID", TypeName = "varchar")]
        private string reservationID;

        [ForeignKey("ReservationID")]
        public virtual Reservation Reservation { get; set; }

        private BigInteger staffID;

        [ForeignKey("StaffID")]
        private Staff staff;

        private List<RentRoomDetail> rentRoomDetails;

        private List<UseServiceDetail> useServiceDetails;

        public string Id { get => id; set => id = value; }
        public string CustomerID { get => customerID; set => customerID = value; }
        public Customer Customer { get => customer; set => customer = value; }
        public string ReservationID { get => reservationID; set => reservationID = value; }
        //public Reservation Reservation { get => reservation; set => reservation = value; }
        public BigInteger StaffID { get => staffID; set => staffID = value; }
        public Staff Staff { get => staff; set => staff = value; }
        public List<RentRoomDetail> RentRoomDetails { get => rentRoomDetails; set => rentRoomDetails = value; }
        public List<UseServiceDetail> UseServiceDetails { get => useServiceDetails; set => useServiceDetails = value; }
    }
}
