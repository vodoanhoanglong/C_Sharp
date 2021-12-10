using System;
using System.Collections.Generic;

namespace Exercise2
{
    public interface QLS
    {
        void input();
        void output();
    }
    class TaiLieu : QLS
    {
        protected string docId, publishingName, type;
        protected int releaseTotal;

        public string Type { get => type; set => type = value; }

        public virtual void input()
        {
            Console.WriteLine("Nhap ma tai lieu: ");
            docId = Console.ReadLine();
            Console.WriteLine("Nhap ten nha xuat ban: ");
            publishingName = Console.ReadLine();
            Console.WriteLine("Nhap so ban phat hanh: ");
            releaseTotal = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void output()
        {
            Console.WriteLine("Ma tai lieu: " + docId);
            Console.WriteLine("Ten nha xuat ban: " + publishingName);
            Console.WriteLine("So ban phat hanh: " + releaseTotal);
        }

        public override string ToString()
        {
            return "Ma tai lieu: " + docId + "   Ten nha xuat ban: " + publishingName + "    So ban phat hanh: " + releaseTotal;
        }
    }

    class Sach : TaiLieu
    {
        private string author;
        private int pageTotal;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap ten tac gia: ");
            author = Console.ReadLine();
            Console.WriteLine("Nhap so trang: ");
            pageTotal = Convert.ToInt32(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Ten tac gia la: " + author);
            Console.WriteLine("So tran la: " + pageTotal);
        }
    }

    class TapChi : TaiLieu
    {
        private int releaseNumber, releaseMonth;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap so phat hanh: ");
            releaseNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap thang phat hanh: ");
            releaseMonth = Convert.ToInt32(Console.ReadLine());
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("So phat hanh la: " + releaseNumber);
            Console.WriteLine("Thanh phat hanh la: " + releaseMonth);
        }
    }

    class Bao : TaiLieu
    {
        private int releaseDay;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap ngay phat hanh: ");
            releaseDay = Convert.ToInt32(Console.ReadLine());
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Ngay phat hanh la: " + releaseDay);
        }
    }

    class QuanLySach
    {
        static void Input(List<TaiLieu> tailieu, string type)
        {
            int n;
            Console.Write("-- Nhap so luong tai lieu: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                TaiLieu TL;
                if (type == "Sach") TL = new Sach();
                else if (type == "Tap Chi") TL = new TapChi();
                else TL = new Bao();
                Console.WriteLine("- Nhap tai lieu thu {0}: ", i + 1);
                TL.input();
                TL.Type = type;
                tailieu.Add(TL);
            }
            Console.Clear();
        }
        static void Output(List<TaiLieu> tailieu)
        {
            Console.WriteLine("-- Thong tin tat ca tai lieu la: ");
            for (int i = 0; i < tailieu.Count; i++)
            {
                Console.WriteLine("- Tai lieu thu {0}: ", i + 1);
                tailieu[i].output();
            }
        }

        static void Search(List<TaiLieu> tailieu)
        {
            
            string findByType;
            List<TaiLieu> result = new List<TaiLieu>();
            Console.WriteLine("Nhap loai tai lieu muon tim: ");
            findByType = Console.ReadLine();
            for (int i = 0; i < tailieu.Count; i++)
                if (String.Compare(tailieu[i].Type, (string)findByType,
                  StringComparison.OrdinalIgnoreCase) == 0)
                    result.Add(tailieu[i]);
            if (result.Count == 0)
            {
                Console.WriteLine("Khong tim thay tai lieu !!! Nhan phim bat ky de tiep tuc");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Thong tin cac loai tai lieu tim thay la: ");
            Output(result);
        }

        static void Main(string[] args)
        {
            int choice;
            List<TaiLieu> ListTL = new List<TaiLieu>();


            do
            {
                Console.WriteLine("------------------------Menu-------------------");
                Console.WriteLine("1. Nhap sach");
                Console.WriteLine("2. Nhap tap chi");
                Console.WriteLine("3. Nhap bao");
                Console.WriteLine("4. Xuat danh sach tat ca tai lieu");
                Console.WriteLine("5. Tim kiem tai lieu theo loai");
                Console.WriteLine("6. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Input(ListTL, "Sach");
                        break;
                    case 2:
                        Input(ListTL, "Tap Chi");
                        break;
                    case 3:
                        Input(ListTL, "Bao");
                        break;
                    case 4:
                        Console.Clear();
                        Output(ListTL);
                        break;
                    case 5:
                        Console.Clear();
                        Search(ListTL);
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop !!!");
                        break;
                }
            } while (choice != 6);


        }
    }
}
