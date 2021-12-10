using System;

namespace Lesson4
{
    class Box
    {
        public double chieu_dai;
        public double chieu_rong;
        public double chieu_cao;
    }

    class BoxPrivate
    {
        private double chieu_dai;
        private double chieu_rong;
        private double chieu_cao;

        public void setChieuDai(double l)
        {
            chieu_dai = l;
        }

        public void setChieuRong(double w)
        {
            chieu_rong = w;
        }

        public void setChieuCao(double h)
        {
            chieu_cao = h;
        }

        public double tinhTheTich()
        {
            return chieu_dai * chieu_rong * chieu_cao;
        }
    }

    class Line
    {
        private double chieu_dai;
        public Line()
        {
            Console.WriteLine("Doi tuong dang dc tao");
        }
        public void setChieuDai(double l)
        {
            chieu_dai = l;
        }
        public double getChieuDai()
        {
            return chieu_dai;
        }
        ~Line() // destructor
        {
            Console.WriteLine("Doi tuong dang bi xoa");
        }
    }

    class ThanhVienStatic
    {
        public static int num;

        public void count()
        {
            num++;
        }

        public static int getNum()
        {
            return num;
        }
    }

    class Shape
    {
        protected int width;
        protected int height;   

        public void setWidth(int w)
        {
            width = w;
        }
        public void setHeight(int h)
        {
            height = h;
        }

    }
    class Rectangle : Shape
    {
        public int tinhDienTich()
        { return width * height; }
    }

    class HCN
    {
        protected double length;
        protected double width;

        public HCN(double l, double w)
        {
            length = l;
            width = w;
        }
        public double tinhDienTich()
        {
            return width * length;
        }

        public void display()
        {
            Console.WriteLine("Chieu dai: " + length);
            Console.WriteLine("Chieu rong: " + width);
            Console.WriteLine("Dien tich: " + tinhDienTich());
        }
    }

    class CPXD : HCN
    {
        private double cost;
        public CPXD (double l, double w) : base (l,w)
        { }
        public double tinhChiPhi()
        {
            return tinhDienTich() * 70;

        }
        public void hienThi()
        {
            base.display();
            Console.WriteLine("Chi phi: " + tinhChiPhi());
        }
}

    public interface CPS
    {
        int tinhChiPhi(int dien_tich);
    }
    class HCN2 : Shape, CPS
    {
        public int tinhDienTich()
        {
            return width * height;
        }
        public int tinhChiPhi(int dien_tich)
        {
            return dien_tich * 70;
        }
    }


    abstract class Shape2
    {
        public abstract int tinhDienTich();
    }
    class HCN3 : Shape2
    {
        private int width;
        private int height;
        public HCN3(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public override int tinhDienTich()
        {
           
            return width * height;
        }
    }

    class Shape3
    {
        protected int width, height;
        public Shape3(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class cha: ");
            return 0;
        }
    }

    class HCN4 : Shape3
    {
        public HCN4(int a = 0, int b = 3) : base(a, b)
        { 
        }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich cua class HCN: ");
            return width * height;
        }
    }

    class TamGiac : Shape3
    {
        public TamGiac(int a = 0, int b = 0) : base(a, b)
        { }
        public override int tinhDienTich()
        {
            Console.WriteLine("Dien tich hinh tam giac la: ");
            return (width * height) / 2;
        }
    }

    class ShowDuLieu
    {
        public void showDienTich(Shape3 s)
        {
            int a;
            a = s.tinhDienTich();
            Console.WriteLine("Dien tich: " + a);
        }
    }

    class BoxOperator
    {
        private double length;
        private double width;
        private double height;

        public double tinhTheTich()
        { return length * width * height; }

        public void setWidth(double w)
        {
            width = w;
        }
        public void setHeight(double h)
        {
            height = h;
        }
        public void setLength(double l)
        {
            length = l;
        }

        public static BoxOperator operator +(BoxOperator b, BoxOperator c)
        {
            BoxOperator box = new BoxOperator();
            box.length = b.length + c.length;
            box.width = b.width + c.width;
            box.height = b.height + c.height;
            return box;
        }
      
    }

    public interface Trade
    {
        void showInfoTrade();
        double getQuantity();
    }

    class ItemTrade : Trade
    {
        private string idItem;
        private string date;
        private double quantity;

        public ItemTrade()
        {
            idItem = "";
            date = "";
            quantity = 0;
        }
        public ItemTrade(string c, string d, double a)
        {
            idItem = c;
            date = d;
            quantity = a;
        }
        public double getQuantity()
        {
            return quantity;
        }
        public void showInfoTrade()
        {
            Console.WriteLine("Ma hang hoa: " + idItem);
            Console.WriteLine("Ngay giao dich: " + date);
            Console.WriteLine("So luong: " + getQuantity());
        }
    }
    class TestCsharp
    {
        void print(int i)
        {
            Console.WriteLine("In so nguyen: " + i);
        }
        void print(double f)
        {
            Console.WriteLine("In so thuc: " + f);
        }
        void print(string s)
        {
            Console.WriteLine("In chuoi: " + s);
        }

        static void Main(string[] args)
        {

            int choice;
            double the_tich = 0.0;
            do
            {
                
                Console.WriteLine("-------------Menu-------------");
                Console.WriteLine("1. Class trong C#");
                Console.WriteLine("2. Class dung ham set get trong C#");
                Console.WriteLine("3. Constructor trong C#");
                Console.WriteLine("4. Destructor trong C#");
                Console.WriteLine("5. Static trong C#");
                Console.WriteLine("6. Tinh ke thua trong C#");
                Console.WriteLine("7. Tinh ke thua trong C# khoi tao lop co so");
                Console.WriteLine("8. Tinh da ke thua trong C#");
                Console.WriteLine("9. Tinh da hinh trong C#");
                Console.WriteLine("10. Tinh da hinh dong trong C#");
                Console.WriteLine("11. Vi du minh hoa tinh da hinh dong trong C#");
                Console.WriteLine("12. Nap chong toan tu trong C#");
                Console.WriteLine("13.Vi du minh hoa Interface trong C#");
                Console.WriteLine("14. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                choice = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (choice)
                {
                   
                    case 1:
                        Console.WriteLine("Class trong C#");
                        Console.WriteLine("------------------");

                        Box box1 = new Box();
                   
                        box1.chieu_cao = 5;
                        box1.chieu_dai = 6;
                        box1.chieu_rong = 7;

                        the_tich = box1.chieu_cao * box1.chieu_dai * box1.chieu_rong;
                        Console.WriteLine("The tich cua Box1 la: " + the_tich);
                        break;
                    case 2:
                        BoxPrivate box2 = new BoxPrivate();
                        box2.setChieuDai(5);
                        box2.setChieuCao(7);
                        box2.setChieuRong(8);

                        the_tich = box2.tinhTheTich();
                        Console.WriteLine("The tich cua Box1 la: " + the_tich);
                        break;
                    case 3:
                        Console.WriteLine("Constructor trong C#");
                        Console.WriteLine("------------------------");

                        Line line = new Line();
                        line.setChieuDai(6.5);
                        Console.WriteLine("Chieu dai cua duong la: " + line.getChieuDai());
                        break;
                    case 4:
                        Console.WriteLine("Destructor trong C#");
                        Console.WriteLine("------------------------");
                        GC.Collect(); // don dep bo nho
                        break;
                    case 5:
                        Console.WriteLine("Phuong thuc static trong C#");
                        Console.WriteLine("------------------------");
                        ThanhVienStatic s = new ThanhVienStatic();
                        s.count();
                        s.count();
                        s.count();
                        Console.WriteLine("Gia tri cua num la: " + ThanhVienStatic.getNum());
                        break;
                    case 6:
                        Console.WriteLine("Tinh ke thua trong C#");
                        Console.WriteLine("------------------------");
                        Rectangle hcn = new Rectangle();
                        hcn.setWidth(5);
                        hcn.setHeight(7);
                        Console.WriteLine("Dien tich HCN la: " + hcn.tinhDienTich());
                        break;

                    case 7:
                        Console.WriteLine("Tinh ke thua trong C# co khoi tao lop co so");
                        Console.WriteLine("--------------------------------------------");
                        CPXD cp = new CPXD(4.5, 7.5);
                        cp.hienThi();
                        break;
                    case 8:
                        HCN2 hcn2 = new HCN2();
                        int dienTich;
                        hcn2.setWidth(5);
                        hcn2.setHeight(7);
                        dienTich = hcn2.tinhDienTich();
                        Console.WriteLine("Tong dien tich la: " + hcn2.tinhDienTich());
                        Console.WriteLine("Tong chi phi son la: " + hcn2.tinhChiPhi(dienTich));
                        break;
                    case 9:
                        TestCsharp p = new TestCsharp();
                        p.print(5);
                        p.print(50.2);
                        p.print("Hoc C#");
                        break;
                    case 10:
                        HCN3 r = new HCN3(10, 7);
                        double a = r.tinhDienTich();
                        Console.WriteLine("Dien tich: " + a);
                        break;
                    case 11:
                        ShowDuLieu c = new ShowDuLieu();
                        HCN4 rr = new HCN4(10, 7);
                        TamGiac t = new TamGiac(10, 5);
                        c.showDienTich(rr);
                        c.showDienTich(t);
                        break;
                    case 12:
                        BoxOperator boxop1 = new BoxOperator();
                        BoxOperator boxop2 = new BoxOperator();
                        BoxOperator boxop3 = new BoxOperator();
                        double the__tich = 0.0;

                        boxop1.setHeight(5.0);
                        boxop1.setLength(6.0);
                        boxop1.setWidth(7.0);

                        boxop2.setHeight(15.0);
                        boxop2.setLength(16.0);
                        boxop2.setWidth(17.0);
                        
                        the__tich = boxop3.tinhTheTich();
                        Console.WriteLine("The tich cua BoxOperator3 la: " + the__tich);
                        break;
                    case 13:
                        ItemTrade t1 = new ItemTrade("001", "03/03/2001", 789.00);
                        ItemTrade t2 = new ItemTrade("002", "04/03/2001", 452.00);
                        t1.showInfoTrade();
                        t2.showInfoTrade();
                        break;
                    case 14:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop !!!");
                        break;
                }

            } while (choice != 6);

            Console.ReadKey();
        }
    }
}
