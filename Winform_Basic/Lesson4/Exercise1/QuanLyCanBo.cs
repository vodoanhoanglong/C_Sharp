using System;
using System.Collections.Generic;

namespace Exercise1
{
    public interface QLCB
    {
        void input();
        void output();
    }
    class CanBo : QLCB
    {
        protected string born, gender ,address;
        protected string fullName;

        public string FullName { get => fullName; set => fullName = value; }

        public virtual void input()
        {
            Console.WriteLine("Nhap ho ten: ");
            FullName = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            born = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh ");
            gender = Console.ReadLine();
            Console.WriteLine("Nhap dia chi: ");
            address = Console.ReadLine();
        }
        public virtual void output()
        {
            Console.WriteLine("Ho ten: " + FullName);
            Console.WriteLine("Ngay sinh: " + born);
            Console.WriteLine("Gioi tinh: " + gender);
            Console.WriteLine("Dia chi: " + address);
        }

        public override string ToString()
        {
            return "Ho ten: " + FullName + "   Ngay Sinh: " + born + "    Gioi tinh: " + gender + "    Dia chi: " + address;
        }
    }

    class CongNhan : CanBo
    {
        private string bac;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap bac: ");
            bac = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Bac cua cong nhan la: " + bac);
        }
    }

    class KySu : CanBo
    {
        private string nganhDaoTao;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap nganh dao tao: ");
            nganhDaoTao = Console.ReadLine();
        }
        public override void output()
        {
            base.output();
            Console.WriteLine("Nganh dao tao cua ky su la: " + nganhDaoTao);
        }
    }

    class NhanVien : CanBo
    {
        private string work;
        public override void input()
        {
            base.input();
            Console.WriteLine("Nhap thong tin cong viec: ");
            work = Console.ReadLine();
        }

        public override void output()
        {
            base.output();
            Console.WriteLine("Thong tin cong viec cua nhan vien la: " + work);
        }
    }

    class QuanLyCanBo
    {
       static void Input(List<CanBo> canbo, string type)
        {
            int n;
            Console.Write("-- Nhap so luong can bo: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                CanBo CB;
                if (type == "CongNhan") CB = new CongNhan();
                else if (type == "KySu") CB = new KySu();
                else CB = new NhanVien();
                Console.WriteLine("- Nhap Can Bo thu {0}: ", i + 1);
                CB.input();
                canbo.Add(CB);
            }
            Console.Clear();
        }
        static void Output(List<CanBo> canbo)
        {
            Console.WriteLine("-- Thong tin tat ca cac can bo la: ");
            for (int i = 0; i < canbo.Count; i++)
            {
                Console.WriteLine("- Can bo thu {0}: ", i + 1);
                canbo[i].output();
            }
        }

        static void Search(List<CanBo> canbo)
        {
            string findByName;
            Console.WriteLine("Nhap ho ten can bo muon tim: ");
            findByName = Console.ReadLine();
            CanBo result = canbo.Find(x => x.FullName.Contains(findByName));
            if (result == null)
            { 
                Console.WriteLine("Khong tim thay can bo !!! Nhan phim bat ky de tiep tuc");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("Thong tin can bo la: {0} ", result);
        }   

        static void Main(string[] args)
        {
            int choice;
            List<CanBo> ListCB = new List<CanBo>();
          

            do
            {
                Console.WriteLine("------------------------Menu-------------------");
                Console.WriteLine("1. Nhap danh sach cong nhan");
                Console.WriteLine("2. Nhap danh sach ky su");
                Console.WriteLine("3. Nhap danh sach nhan vien");
                Console.WriteLine("4. Xuat danh sach tat ca cac can bo");
                Console.WriteLine("5. Tim kiem can bo theo ten");
                Console.WriteLine("6. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = Convert.ToInt32(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:      
                        Input(ListCB, "CongNhan");
                        break;
                    case 2:
                        Input(ListCB, "KySu");
                        break;
                    case 3:
                        Input(ListCB, "NhanVien");
                        break;
                    case 4:
                        Output(ListCB);
                        break;
                    case 5:
                        Search(ListCB);
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
