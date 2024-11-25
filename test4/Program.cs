using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;
            //***************Tính chất đóng gói***************//
            Console.WriteLine("***************Tính chất đóng gói***************");
            Employee em = new Employee();

            em.ten = "Quang";
            em.luong = 0;
            em.tuoi = 23;

            Console.WriteLine("Tên " + em.ten);
            Console.WriteLine("Lương " + em.luong);
            Console.WriteLine("Tuổi " + em.tuoi);

            //***************Tính chất kế thừa***************//
            Console.WriteLine("***************Tính chất kế thừa***************");
            Cricle x = new Cricle { Canh = 5 };

            Console.WriteLine("Diện tích " + x.dienTichHinhTron());

            //***************Tính chất đa hình***************//
            Console.WriteLine("***************Tính chất đa hình***************");
            Animal a = new Dog();

            Animal b = new Animal();

            Animal c = new Cat();

            Console.WriteLine("chó: " + a.MakeSoud());
            Console.WriteLine("Mèo: " + c.MakeSoud());
            Console.WriteLine("Animal: " + b.MakeSoud());

            //***************Tính chất Trừu tượng***************//
            CD item1 = new CD("tile1", 100, DateTime.Today, 160);

            Book item2 = new Book("tile2", 120, DateTime.Today, 300);

            LibraryItem item3 = new Book("tile3", 120, DateTime.Today, 300);
            Console.WriteLine("***************Tính chất Trừu tượng***************");
            item1.ThongTin();
            
            item2.ThongTin();

            item3.ThongTin();

            Console.ReadLine();
        }
    }
}
