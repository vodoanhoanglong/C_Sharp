using System;

namespace Lesson3
{
    // phạm vi mặc định của lớp là: internal
    class Rectangle
    {
        // phạm vi mặc định của thành phần trong 1 lớp là: private
        private double length;
        private double width;

        double getArea()
        {
            return length * width;
        }

        public void accept()
        {
            Console.WriteLine("Nhap chieu dai: ");
            length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap chieu rong: ");
            width = Convert.ToDouble(Console.ReadLine());
        }

        public void display()
        {
            Console.WriteLine("Chieu dai: {0}", length);
            Console.WriteLine("Chieu rong: {0}", width);
            Console.WriteLine("Dien tich: {0}", getArea());
        }
    }

    class LearnArray
    {
        int[] n = new int[10];
        internal void display()
        {
            for (int i = 0; i < n.Length; i++)
                n[i] = i + 100;

            foreach(int j in n)
            {
                int i = j - 100;
                Console.WriteLine("Phan tu [{0}] = {1}", i, j);
            }
           
        }
        
    }

    class LearnString
    {
        internal void displayFullName()
        {
            string fName, lName;
            fName = "Vo Doan Hoang";
            lName = "Long";

            string fullName = fName + " " + lName;
            Console.WriteLine("Ho va ten: {0}", fullName);
        }

        internal void displayGreeting()
        {
            char[] letters = { 'H', 'e', 'l', 'l', 'o' };
            string greetings = new string(letters);
            Console.WriteLine(greetings);
        }

        internal void displayMessage()
        {
            string[] sarr = { "C#", "xin", "chao" };
            // Join method không cần khởi tạo instance vì nó là static method
            string message = String.Join(" ", sarr);
            Console.WriteLine("Thong diep: {0}", message);
        }

        internal void displayDate()
        {
            DateTime waiting = new DateTime(2021, 3, 3, 17, 58, 1);
            string chat = String.Format("Thong diep gui luc: {0:t}  {0:D}", waiting);
            Console.WriteLine("Thong diep: {0}", chat);
        }

        internal void displayCompare()
        {
            string str1 = "so sanh 1";
            string str2 = "so sanh 2";
            Console.WriteLine("So sanh chuoi trong C#");
            Console.WriteLine("_____________________________");

            if (String.Compare(str1, str2) == 0) Console.WriteLine("Chuoi giong nhau");
            else Console.WriteLine("Chuoi k giong nhau");
        }

        internal void displayContains()
        {

            string str = "so sanh 1";
            Console.WriteLine("Kiem tra trong chuoi trong C#");
            Console.WriteLine("_____________________________");
            if (str.Contains("so")) Console.WriteLine("Da tim thay trong chuoi");
        }

        internal void displayGetString()
        {
            Console.WriteLine("Lay chuoi con trong C#");
            Console.WriteLine("_____________________________");
            string str = "lay chuoi con";
            Console.WriteLine("Chuoi ban dau: " + str);
            string subStr = str.Substring(10);
            Console.WriteLine("Chuoi con: " + subStr);
        }

    }

    struct Book
    {
        private string bookName;
        private string author;
        private string type;
        private int bookId;

        public void input(string t, string a, string s, int id)
        {
            bookName = t;
            author = a;
            type = s;
            bookId = id;
        }

        public void display()
        {
            Console.WriteLine("Tieu de: " + bookName);
            Console.WriteLine("Tac gia: " + author);
            Console.WriteLine("The loai: " + type);
            Console.WriteLine("Ma sach: " + bookId);
        }
    }
    class ExecuteRectangle
    {
        int findMax(int num1, int num2)
        {
            int result;
            if (num1 > num2)
                result = num1;
            else result = num2;
            return result;
        }

        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;
            

            Console.WriteLine("Tinh dong goi trong C#");
            Console.WriteLine("_______________________");

            Rectangle rectangle = new Rectangle();
            rectangle.accept();
            rectangle.display();

            Console.WriteLine("Goi method trong C#");
            Console.WriteLine("____________________");

            ExecuteRectangle main = new ExecuteRectangle();
            Console.WriteLine("So lon nhat la: {0} ", main.findMax(a, b));

            Console.WriteLine("Mang trong C#");
            Console.WriteLine("_____________");

            LearnArray array = new LearnArray();
            array.display();

            Console.WriteLine("Cac cach tao chuoi trong C#");
            Console.WriteLine("_____________________________");

            LearnString str = new LearnString();
            str.displayFullName();
            str.displayGreeting();
            str.displayMessage();
            str.displayDate();
            str.displayCompare();
            str.displayContains();
            str.displayGetString();

            Console.WriteLine("Struct trong C#");
            Console.WriteLine("__________________");

            Book book = new Book();
            book.input("English", "LongDragon", "Tieng Anh", 605);
            Console.WriteLine("In thong tin");
            book.display();
        } 
    }
}
