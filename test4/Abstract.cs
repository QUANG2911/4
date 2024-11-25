using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    abstract class LibraryItem
    {
        string title;
        int gia;
        DateTime ngaySanXuat;

        protected LibraryItem(string title, int gia, DateTime ngaySanXuat)
        {
            this.title = title;
            this.gia = gia;
            this.ngaySanXuat = ngaySanXuat;
        }

        public string Title { get => title; set => title = value; }
        public int Gia { get => gia; set => gia = value; }
        public DateTime NgaySanXuat { get => ngaySanXuat; set => ngaySanXuat = value; }

        public abstract void ThongTin();
    }

    class Book : LibraryItem
    {
        int soTrang;

        public Book(string title, int gia, DateTime ngaySanXuat, int soTrang) : base(title, gia, ngaySanXuat)
        {
            this.soTrang = soTrang;
        }

        public int SoTrang { get => soTrang; set => soTrang = value; }

        public override void ThongTin()
        {
            Console.WriteLine("*********Thông tin sách*********");
            Console.WriteLine("Tựa sách:" + Title + "\nGia: " + Gia + "\nNgày sản xuất: " + NgaySanXuat + "\nSố trang: " + soTrang);
        }
    }

    class CD : LibraryItem
    {
        int thoiLuong;

        public CD(string title, int gia, DateTime ngaySanXuat, int thoiLuong) : base(title, gia, ngaySanXuat)
        {
            this.thoiLuong = thoiLuong;
        }

        public int ThoiLuong { get => thoiLuong; set => thoiLuong = value; }

        public override void ThongTin()
        {
            Console.WriteLine("*********Thông tin CD*********");
            Console.WriteLine("Tựa sách:" + Title + "\nGia: " + Gia + "\nNgày sản xuất: " + NgaySanXuat + "\nThời lượng: " + thoiLuong);
        }

    }
}
