using System;
using System.Text.RegularExpressions;

namespace Lesson2
{
    class Program
    {
        void daoNguoc()
        {
            String array;
            Console.WriteLine("Nhap 3 chu bat ky: ");
            array = Console.ReadLine();
            for (int i = array.Length - 1; i >= 0; i--)
                Console.Write("{0}", array[i]);
        }

        void checkLogin()
        {
            int count = 0;
            String userName, password;
            do
            {
                Console.Clear();
                Console.WriteLine("Nhap username: ");
                userName = Console.ReadLine();
                Console.WriteLine("Nhap password: ");
                password = Console.ReadLine();
                if (userName == "hoanglong" && password == "03032001")
                {
                    count = 3;
                    Console.WriteLine("Login success");
                    return;
                }
                else  count++;
            }
            while (count != 3);
            Console.WriteLine("Sai roi khong cho nhap nua");

        }

        void giaiPT2()
        {
            float a, b, c;
            Console.WriteLine("Nhap vao a : ");
            a = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao b : ");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao c : ");
            c = float.Parse(Console.ReadLine());
            float delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem : ");
                Console.WriteLine("X1 = {0}", ((-b - Math.Sqrt(delta)) / 2 * a));
                Console.WriteLine("X2 = {0}", ((-b + Math.Sqrt(delta)) / 2 * a));

            }
            else if (delta == 0)
            {
                Console.WriteLine("Phuong trinh co hai nghiem kep nghiem");
                Console.WriteLine("X1 = X2 {0}", -b / 2 * a);
            }
            else
                Console.WriteLine("Phuong trinh vo nghiem");
          
        }

        void dienich()
        {
            const double PI = 3.14;
            Boolean i = true;
            double input, choice, r, height, width,s, a, b, c;
            while(i)
            {
                Console.WriteLine("1. Dien tich hinh tron");
                Console.WriteLine("2. Dien tich HCN");
                Console.WriteLine("3. Dien tich hinh tam giac");
                Console.WriteLine("4. Thoat");
                Console.WriteLine("______Nhap lua chon cua ban______");
                choice = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Nhap ban kinh duong tron: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Dien tich duong tron: {0}", PI * r * r);
                        break;
                    case 2:
                        Console.WriteLine("Nhap chieu cao: ");
                        height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhap chieu rong: ");
                        width = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Dien tich HCN: {0}", height * width);
                        break;
                    case 3:
                        Console.WriteLine("Nhap canh a: ");
                        a = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhap canh b: ");
                        b = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Nhap canh c: ");
                        c = Convert.ToDouble(Console.ReadLine());
                        s = (a + b + c) / 2;
                        Console.WriteLine("Dien tich hinh tam giac: {0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
                        break;
                    case 4:
                        i = false;
                        break;
                    default:
                        Console.WriteLine("Lua chon k phu hop !!! Nhan phim bat ky de tiep tuc");
                        Console.ReadLine();
                        break;
                }
            }
        }

        double tinhToan( String by)
        {
            double a, b;
            Console.WriteLine("Nhap a: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            b = Convert.ToDouble(Console.ReadLine());
            return by == "cong" ? a + b : by == "tru" ? a - b : by == "nhan" ? a * b : by == "chia" ? a / b : 0;
        }

        void phepToanCoBan()
        {
            
            Boolean i = true;
            double choice;
            while (i)
            {
                Console.WriteLine("1. Cong");
                Console.WriteLine("2. Tru");
                Console.WriteLine("3. Nhan");
                Console.WriteLine("4. Chia");
                Console.WriteLine("5. Thoat");
                Console.WriteLine("______Nhap lua chon cua ban______");
                choice = Convert.ToDouble(Console.ReadLine());
                
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Phep Cong: {0}", tinhToan("cong"));
                        break;
                    case 2:
                        Console.WriteLine("Phep Tru: {0}", tinhToan("tru"));
                        break;
                    case 3:
                        Console.WriteLine("Phep Nhan: {0}", tinhToan("nhan"));
                        break;
                    case 4:
                        Console.WriteLine("Phep Chia: {0}", tinhToan("chia"));
                        break;
                    case 5:
                        i = false;
                        break;
                    default:
                        Console.WriteLine("Lua chon k phu hop !!! Nhan phim bat ky de tiep tuc");
                        Console.ReadLine();
                        break;
                }
            }
        }

        void showBangNhan()
        {
            int x;
            int result;

            Console.WriteLine("Nhap mot so bat ky:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hien thi bang nhan:");
            for (int i = 0; i<=10; i++)
            {
                result = x * i;
                Console.WriteLine("{0} x {1} = {2}", x, i, result);
            }
            Console.ReadKey();
        }

         bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*.?[0-9]+$");
            return regex.IsMatch(pText);
        }

       // Bài 7 mở rộng
        void showAndSum()
        {

            int i, sum = 0, count = 0;
            Console.WriteLine("Hien thi va tinh tong n so le");
            Console.WriteLine("Nhap so luong so le: ");
            int n = Convert.ToInt32(Console.ReadLine());
            
            String input;
            for (int index = 0; index < n; index++)
            {
                count = 0;
                do
                {
                    if (count == 3)
                    {
                        Console.WriteLine("Sai dinh dang 3 lan khong cho nhap nua");
                        return;
                    }
                    Console.Write("Nhap so le {0}: ", index + 1);
                    input = Console.ReadLine();
                    if (!IsNumber(input) || (Convert.ToInt32(input) % 2) == 0) { count++; Console.WriteLine("Sai Dinh dang!!!"); }
                    else count = 3;
                }
                while (!IsNumber(input) || (Convert.ToInt32(input) % 2) == 0 || count != 3);
                sum += Convert.ToInt32(input);
            }
                      
                  
        Console.WriteLine("Tong so le la: {0} ", sum);
           Console.ReadKey();
        }

        void findGiaiThua()
        {
            int i, f = 1, num;
            Console.WriteLine("Tim giai thua:");
            Console.WriteLine("Nhap mot so bat ky: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                f = f * i;

            Console.Write("Giai thua cua {0} la: {1}\n", num, f);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            Program test = new Program();
            
            double choice;

            do
            {
                Console.WriteLine("-------Menu--------");
                Console.WriteLine("1. Dao nguoc");
                Console.WriteLine("2. Kiem tra dang nhap");
                Console.WriteLine("3. Giai PT 2");
                Console.WriteLine("4. Dien tich");
                Console.WriteLine("5. Phep toan co ban");
                Console.WriteLine("6. Hien bang nhan");
                Console.WriteLine("7. Hien so le va tinh tong so le");
                Console.WriteLine("8. Tim giai thua");
                Console.WriteLine("9. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                Console.WriteLine("___________________________");
                choice = Convert.ToDouble(Console.ReadLine());
                Console.Clear();
                switch (choice)
                {
                    case 1:
                        test.daoNguoc();
                        break;
                    case 2:
                        test.checkLogin();
                        break;
                    case 3:
                        test.giaiPT2();
                        break;
                    case 4:
                        test.dienich();
                        break;
                    case 5:
                        test.phepToanCoBan();
                        break;
                    case 6:
                        test.showBangNhan();
                        break;
                    case 7:
                        test.showAndSum();
                        break;
                    case 8:
                        test.findGiaiThua();
                        break;
                    case 9:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong dung!!! Nhan phim bat ky de tiep tuc");
                        Console.ReadLine();
                        break;
                }

            } while (choice != 9);
        }
    }
}
