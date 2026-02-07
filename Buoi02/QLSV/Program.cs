using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLSV
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            List<Student> students = new List<Student>();
            int SoLuong;
            while (true)
            {
                Console.Write("Nhập số lượng sv: ");
                if (int.TryParse(Console.ReadLine(), out SoLuong) && SoLuong > 0)
                {
                    break;
                }
                Console.WriteLine("Sai số lượng. Vui lòng nhập lại");
            }

            //Nhập liệu thông tin sv
            for (int i = 0; i < SoLuong; i++)
            {
                //Nhập liệu đúng
                Console.Write("Họ tên: ");
                string HoTen = Console.ReadLine().Trim();
                Console.Write("Chuyên ngành: ");
                string ChuyenNganh = Console.ReadLine().Trim();
                int mssv;
                while (true)
                {
                    Console.Write("Mã số sv: ");
                    if (int.TryParse(Console.ReadLine(), out mssv) && mssv > 0)
                    {
                        break;
                    }
                    Console.WriteLine("Sai MSSV. Vui lòng nhập lại");
                }
                double gpa;
                while(true)
                {
                    Console.Write("Điểm (GPA) [0-4]: ");
                    if (double.TryParse(Console.ReadLine(), out gpa) && gpa >= 0 && gpa <= 4)
                    {
                        break;
                    }
                    Console.WriteLine("Sai GPA. Vui lòng nhập lại");
                }

                students.Add(new Student(HoTen, ChuyenNganh, gpa, mssv));

                //In ds hiện có
                Console.WriteLine("\n\n=======Danh sách SV hiện có=======\n");
                foreach (var sv in students)
                {
                    Console.WriteLine(sv);
                }
            }
        }
    }
}
