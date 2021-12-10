using System;

namespace HelloWorld
{
    class Program
    {
        public static int epKieu(double number)
        {
            return (int)number;
        }

        void chuyenDoi()
        {
            Console.WriteLine("Chuyen doi kieu du lieu C#!");
            Console.WriteLine("___________________________");

            Decimal dec = 926534668654775808.859m;

            long value = Decimal.ToInt64(dec);

            int i = 56;
            float f = 53.55252f;
            double d = 234.5242;
            bool b = true;


            int r = epKieu(d);

            Console.WriteLine(b.ToString());
            Console.WriteLine(r.ToString());
            Console.WriteLine(value.ToString());
        }

        void bien()
        {
            Console.WriteLine("Khai bao va khoi tao bien C#!");
         

            short a;
            int b;
            double c;

            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("a={0}, b={1}, c={2}", a, b, c);
        }

         void hang()
        {
            Console.WriteLine("Hang so trong C#");
            

            const double pi = 3.14;

            double result;
            Console.WriteLine("Nhap ban kinh: ");
            result = Convert.ToDouble(Console.ReadLine());
            double dienTich = Math.Round(pi * (result * 2), 2);
            Console.WriteLine("\nBan kinh: {0}, Dien tich: {1}", result, dienTich);
            Console.ReadLine();
        }
        void dieuKien()
        {
            Console.WriteLine("Lenh if trong C#");
            Console.WriteLine("___________________________");

            int a = 10;
            if (a < 20) Console.WriteLine("a < 20");
            Console.WriteLine("Gia tri cua a la: {0}", a);

            a = 100;

            if (a > 20) Console.WriteLine("a > 20");
            else Console.WriteLine("a < 20");

            Console.WriteLine("Gia tri cua a la: {0}", a);

            int b = 200;
            if (a == 100 && b == 200) Console.WriteLine("Gia tri cua a la 100 va b la 200");

            Console.WriteLine("Gia tri chinh xac cua a va b la: {0} , {1}", a, b);

            Console.ReadLine();
        }

        void dieuKienSwitchCase()
        {
            Console.WriteLine("Lenh Switch trong C#");
            Console.WriteLine("___________________________");

            char grade = 'B';

            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Xuat sac!");
                    break;
                case 'B':
                case 'C':
                    Console.WriteLine("Gioi");
                    break;
                default:
                    Console.WriteLine("Gia tri khong phu hop");
                    break;
            }

            Console.WriteLine("Hoc luc cua ban la: {0}", grade);
            Console.WriteLine("Ra Gioi boi vi case B khong co break nen no tiep tuc chay xuong case C");
            Console.ReadLine();
        }

        void dieuKienSwitchCaseLong()
        {
            Console.WriteLine("Lenh Switch Long nhau trong C#");
            Console.WriteLine("___________________________");

            int a = 100;
            int b = 200;

            switch(a)
            {
                case 100:
                    Console.WriteLine("Dong nay thuoc lenh switch ben ngoai");
                    switch(b)
                    {
                        case 200:
                            Console.WriteLine("Dong nay thuoc lenh switch ben trong");
                            break;
                    }
                    break;
            }

            Console.WriteLine("Gia tri chinh xac cua a va b la: {0} , {1}", a, b);
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program test = new Program();
           
            double choice;

            do
            {
                Console.WriteLine("-------Menu--------");
                Console.WriteLine("1. Chuyen doi kieu du lieu");
                Console.WriteLine("2. Bien");
                Console.WriteLine("3. Hang");
                Console.WriteLine("4. Dieu kien");
                Console.WriteLine("5. Dieu kien Switch Case");
                Console.WriteLine("6. Dieu kien Switch Case long nhau");
                Console.WriteLine("7. Thoat");
                Console.WriteLine("Nhap lua chon cua ban: ");
                Console.WriteLine("___________________________");
                 choice = Convert.ToDouble(Console.ReadLine());
                
                switch (choice)
                {
                    case 1:
                        test.chuyenDoi();
                        break;
                    case 2:
                        test.bien();
                        break;
                    case 3:
                        test.hang();
                        break;
                    case 4:
                        test.dieuKien();
                        break;
                    case 5:
                        test.dieuKienSwitchCase();
                        break;
                    case 6:
                        test.dieuKienSwitchCaseLong();
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong dung!!! Nhan phim bat ky de tiep tuc");
                        Console.ReadLine();
                        break;
                }
                
            } while (choice != 7);
          
        }
    }
}
