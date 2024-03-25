using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKi
{
    class TapChi : TaiLieu
    {
        public int soPH { get; set; }
        public int trangPH { get; set; }

        public TapChi()
        {
        }

        public TapChi(int soPH, int trangPH)
        {
            this.soPH = soPH;
            this.trangPH = trangPH;
        }

        public TapChi(string maXB, string tenTL, string nPH, string cateID, int soPH, int trangPH) : base(maXB, tenTL, nPH, cateID)
        {
            this.soPH = soPH;
            this.trangPH = trangPH;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("So phat hanh: ");
            soPH = int.Parse(Console.ReadLine());
            Console.WriteLine("Trang phat hanh: ");
            trangPH = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("So phat hanh: " + soPH);
            Console.WriteLine("Trang phat hanh: " + trangPH);
        }

    }
}
