using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace QLYSINHVIEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<Student> students = new List<Student>()
        {
            new Student { Id = 1, Name = "Ánh", Age = 14 },
            new Student { Id = 2, Name = "Hiếu", Age = 18 },
            new Student { Id = 3, Name = "Huy", Age = 15 },
            new Student { Id = 4, Name = "Thảo", Age = 17 },
            new Student { Id = 5, Name = "Huyền", Age = 19 }
        };

            // a
            Console.WriteLine("Danh sách tất cả học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine("Id: " + student.Id + ", Name: " + student.Name + ", Age: " + student.Age);
            }

            // b
            Console.WriteLine("\nDanh sách học sinh có tuổi từ 15 đến 18:");
            var studentsInRange = students.Where(s => s.Age >= 15 && s.Age <= 18);
            foreach (var student in studentsInRange)
            {
                Console.WriteLine("Id: " + student.Id + ", Name: " + student.Name + ", Age: " + student.Age);
            }

            // c. 
            Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
            var studentStartsWithA = students.FirstOrDefault(s => s.Name.StartsWith("A"));
            if (studentStartsWithA != null)
            {
                
                Console.WriteLine("Id: " + studentStartsWithA.Id + ", Name: " + studentStartsWithA.Name + ", Age: " + studentStartsWithA.Age);
            }
            else
            {
                Console.WriteLine("Không tìm thấy học sinh nào có tên bắt đầu bằng chữ A.");
            }
            // d
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine("\nTổng tuổi của tất cả học sinh: " + totalAge);

            // e
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("\nHọc sinh có tuổi lớn nhất:");
            Console.WriteLine("Id: " + oldestStudent.Id + ", Name: " + oldestStudent.Name + ", Age: " + oldestStudent.Age);

            // f
            Console.WriteLine("\nDanh sách học sinh sau khi sắp xếp theo tuổi tăng dần:");
            var sortedStudents = students.OrderBy(s => s.Age);
            foreach (var student in sortedStudents)
            {
                
                Console.WriteLine("Id: " + student.Id + ", Name: " + student.Name + ", Age:  " + student.Age);
              
                
            }

        }
    }
}
