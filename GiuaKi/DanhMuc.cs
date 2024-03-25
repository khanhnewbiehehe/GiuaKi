using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GiuaKi
{
    public class DanhMuc
    {
        public List<TaiLieu> dm;
        public DanhMuc()
        {
            dm = new List<TaiLieu>(); 
        }

        public void themmoi(TaiLieu TL)
        {
            dm.Add(TL);
        }


        public void timkiem(String loai)
        {
            if (loai == "S")
            {
                 var KQ = from tl in dm
                        where tl is Sach
                        select tl;
                foreach (TaiLieu tl in KQ)
                {
                    Console.WriteLine(tl.tenTL);
                }
            }
            else
            {
                if(loai == "B")
                {
                    var KQ = from tl in dm
                             where tl is Bao
                             select tl;
                    foreach (TaiLieu tl in KQ)
                    {
                        Console.WriteLine(tl.tenTL);
                    }
                }
                else
                {
                    var KQ = from tl in dm
                             where tl is TaiLieu
                             select tl;
                    foreach (TaiLieu tl in KQ)
                    {
                        Console.WriteLine(tl.tenTL);
                    }
                }
            }
            
        }

        public void ngayPHthang3nam2024()
        {
            var KQ = from tl in dm
                     where tl is Bao && ((Bao)tl).ngayPH.Month == 3 && ((Bao)tl).ngayPH.Year == 2024
                     select tl;
            foreach (TaiLieu tl in KQ)
            {
                Console.WriteLine(tl.tenTL);
            }
        }


    }
}
