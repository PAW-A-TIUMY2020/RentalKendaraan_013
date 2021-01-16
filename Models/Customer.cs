using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140013.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdCustomer { get; set; }
        [Required(ErrorMessage = "Nama Customer wajib diisi!")]
        public string NamaCustomer { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Nik hanya boleh diiisi dengan angka!")]
        public string Nik { get; set; }
        [Required(ErrorMessage = "Alamat wajib diisi!")]
        public string Alamat { get; set; }
        [MinLength(10, ErrorMessage = "No HP tidak boleh kurang dari 10 angka")]
        [MaxLength(13, ErrorMessage = "No HP tidak boleh lebih dari 13 angka")]
        public string NoHp { get; set; }
        [Required(ErrorMessage = "Gender wajib diisi!")]
        public int? IdGender { get; set; }

        public Gender IdGenderNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
    }
}
