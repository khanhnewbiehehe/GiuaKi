using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKi
{
    public class Bao : TaiLieu
    {
        public DateTime ngayPH { get; set; }
        public Bao() { }
        public Bao(DateTime ngayPH)
        {
            this.ngayPH = ngayPH;
        }

        public Bao(string maXB, string tenTL, string nPH, string cateID, DateTime ngayPH ) : base(maXB, tenTL, nPH, cateID)
        {
            this.ngayPH = ngayPH;
        }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Ngay phat hanh (dd/MM/yyyy): ");
            string userInput = Console.ReadLine();
            if (DateTime.TryParseExact(userInput, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime inputDate))
            {
                ngayPH = inputDate;
            }
            else
            {
                Console.WriteLine("Invalid date format! Please enter date in the format dd/MM/yyyy.");
            }
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("Ngay phat hanh: " + ngayPH.ToString("dd/MM/yyyy"));
        }
    }
}
