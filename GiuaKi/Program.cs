using System;

namespace GiuaKi
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Nhap so luong tai lieu muon them: ");
            DanhMuc dm = new DanhMuc();
            n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                TaiLieu tl;
                Console.WriteLine("Chon loai tai lieu muon them(S/B/TC): ");
                string loai = Console.ReadLine();
                if(loai == "B")
                {
                    tl = new Bao();
                }
                else
                {
                    if(loai == "S")
                    {
                        tl = new Sach();
                    }
                    else
                    {
                        tl = new TapChi();
                    }
                }
                tl.Nhap();
                dm.themmoi(tl);
            }
            Console.WriteLine("Nhap loai sach muon tim(S/B/TC): ");
            string tk = Console.ReadLine();
            Console.WriteLine("Ket qua: ");
            dm.timkiem(tk);
            Console.WriteLine("Bao co ngay phat hanh trong thang ba nam 2024: ");
            dm.ngayPHthang3nam2024();
        }
    }
}