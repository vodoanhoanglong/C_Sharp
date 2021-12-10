using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_PhanSo
{
    class PhanSo
    {
        private double tu, mau;

        public PhanSo()
        {
          
        }
        public PhanSo(double tu = 1, double mau = 1)
        {
            this.tu = tu;
            this.mau = mau;
        }

        ~PhanSo()
        { }

        public static double ucln(double a, double b)
        {
            double r = 1;
            while (r != 0)
            {
                r = a % b;
                a = b;
                b = r;
            }
            return a;
        }

  

        public void ouput()
        {
            Console.WriteLine(tu + "/" + mau);
            
        }

        public static PhanSo operator +(PhanSo b, PhanSo c)
        {
            PhanSo ps = new PhanSo();
            ps.tu = (b.tu * c.mau) + (b.mau * c.tu);
            ps.mau = b.mau * c.mau;

            double uc = ucln(ps.tu, ps.mau);
            ps.tu = ps.tu / uc;
            ps.mau = ps.mau / uc;

            return ps;

        }

        public static PhanSo operator -(PhanSo b, PhanSo c)
        {
            PhanSo ps = new PhanSo();
            ps.tu = (b.tu * c.mau) - (b.mau * c.tu);
            ps.mau = b.mau * c.mau;
            double uc = ucln(ps.tu, ps.mau);
            ps.tu = ps.tu / uc;
            ps.mau = ps.mau / uc;
            return ps;
        }

        public static PhanSo operator *(PhanSo b, PhanSo c)
        {
            PhanSo ps = new PhanSo();
            ps.tu = b.tu * c.tu;
            ps.mau = b.mau * c.mau;
            double uc = ucln(ps.tu, ps.mau);
            ps.tu = ps.tu / uc;
            ps.mau = ps.mau / uc;
            return ps;
        }

        public static PhanSo operator /(PhanSo b, PhanSo c)
        {
            PhanSo ps = new PhanSo();
            ps.tu = b.tu * c.mau;
            ps.mau = b.mau * c.tu;
            double uc = ucln(ps.tu, ps.mau);
            ps.tu = ps.tu / uc;
            ps.mau = ps.mau / uc;
            return ps;
        }
        public static double KiemTra(double a, double b)
        {
            for (int i = 2; i <= a && i <= b; i++)
                if (a % i == 0 && b % i == 0)
                    return 0; // khong toi gian
            return 1; // toi gian
        }

        static void Main(string[] args)
        {
            int n, choice;
            Console.WriteLine("Nhap so luong phan so: ");
            n = Convert.ToInt32(Console.ReadLine());
            PhanSo[] a = new PhanSo[n];
            for (int i = 0; i < n; i++)
            {
                double tu, mau;
                Console.WriteLine("Nhap phan so thu {0}: ", i + 1);
                Console.Write("Nhap tu:");
                tu = Convert.ToDouble(Console.ReadLine());
                Console.Write("Nhap mau:");
                mau = Convert.ToDouble(Console.ReadLine());
                a[i] = new PhanSo(tu, mau);

            }
      
    
          do
          {
              Console.WriteLine("-------------Menu-------------");
              Console.WriteLine("1. Cong PS");
              Console.WriteLine("2. Tru PS");
              Console.WriteLine("3. Nhan PS");
              Console.WriteLine("4. Chia PS");
              Console.WriteLine("5. Kiem tra toi gian");
              Console.WriteLine("6. Tim dang toi gian");
              Console.WriteLine("7. Thoat");
              Console.WriteLine("Nhap lua chon cua ban: ");
              choice = Convert.ToInt32(Console.ReadLine());
              Console.Clear();

              switch (choice)
              {
                  case 1:
                      PhanSo cong = a[0];
                      for (int i = 0; i<n - 1; i++)
                      {
                          cong += a[i + 1];
                      }
                        cong.ouput();
                      break;
                    case 2:
                        PhanSo tru = a[0];
                        for (int i = 0; i < n - 1; i++)
                        {
                            tru -= a[i + 1];    
                        }
                        tru.ouput();
                        break;
                    case 3:
                        PhanSo nhan = a[0];
                        for (int i = 0; i < n - 1; i++)
                        {
                            nhan *= a[i + 1];
                        }
                        nhan.ouput();
                        break;
                    case 4:
                        PhanSo chia = a[0];
                        for (int i = 0; i < n - 1; i++)
                        {
                            chia /= a[i + 1];
                        }
                        chia.ouput();
                        break;
                    case 5:
                        for (int i = 0; i < n; i++)
                        {
                            a[i].ouput();
                            if (KiemTra(a[i].tu, a[i].mau) == 1)
                                Console.WriteLine("Phan so toi gian");
                            else Console.WriteLine("Phan so chua toi gian");

                        }
                        break;
                    case 6:
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Phan tu thu {0}: ", i + 1);
                            a[i].ouput();
                            if (KiemTra(a[i].tu, a[i].mau) == 0)
                                Console.WriteLine("Phan so da duoc toi gian tu " + a[i].tu + "/" + a[i].mau + " sang " + a[i].tu / a[i].mau);
                        }
                        break;
                    case 7:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Lua chon khong phu hop !!!");
                        break;
                }
          } while (choice != 7) ;
      }

  }

}