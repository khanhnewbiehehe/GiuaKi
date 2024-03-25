using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKi
{
    public abstract class TaiLieu
    {
        public string maXB { get; set; }
        public string tenTL { get; set; }
        public string NPH { get; set; }
        public string cateID { get; set; }

        public TaiLieu() { }

        protected TaiLieu(string maXB, string tenTL, string nPH, string cateID)
        {
            this.maXB = maXB;
            this.tenTL = tenTL;
            NPH = nPH;
            this.cateID = cateID;
        }

        public virtual void Nhap()
        {
            Console.WriteLine("Ma xuat ban: ");
            maXB = Console.ReadLine();
            Console.WriteLine("Ten tai lieu: ");
            tenTL = Console.ReadLine();
            Console.WriteLine("Nha phat hanh: ");
            NPH = Console.ReadLine();
            Console.WriteLine("Ma danh muc: ");
            cateID = Console.ReadLine();
        }
        public virtual void Xuat()
        {
            Console.WriteLine("Ma xuat ban: " + maXB);
            Console.WriteLine("Ten tai lieu: " + tenTL);
            Console.WriteLine("Nha phat hanh: " + NPH);
            Console.WriteLine("Ma danh muc: " + cateID);
        }
    }
}
