using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKi
{
    public class Sach : TaiLieu
    {
        public string tenTG { get; set; }
        public int soTrang { get; set; }
        public Sach()
        {
        }

        public Sach(string tenTG, int soTrang)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }

        public Sach(string maXB, string tenTL, string nPH, string cateID, string tenTG, int soTrang) : base(maXB, tenTL, nPH, cateID)
        {
            this.tenTG = tenTG;
            this.soTrang = soTrang;
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ten tac gia: ");
            tenTG = Console.ReadLine();
            Console.WriteLine("So trang: ");
            soTrang = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ten tac gia: " + tenTG);
            Console.WriteLine("So trang: " + soTrang);
        }


    }
}
