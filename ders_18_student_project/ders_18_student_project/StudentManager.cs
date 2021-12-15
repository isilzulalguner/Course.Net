using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ders_18_student_project
{
    public class StudentManager
    {
        static StudentManager studentManager;

        List<Student> students = new List<Student>() //buradaki typemız Student, bu listenin her bir itemi student
        {
            new Student(1, "Ali Tuğrul", "ali@gmail.com", "(555) 444-3322", new DateTime(1971,1,1)),
            new Student(2, "Fatma Özmen", "fatma@gmail.com", "(554) 443-3221", new DateTime(1988,6,14)),
            new Student(3, "Zülal Güner", "zulal@gmail.com", "(553) 442-3120", new DateTime(1999,5,15)),
            new Student(4, "Kübra Yanık", "kubra@gmail.com", "(552) 441-3029", new DateTime(2000,3,19)),
            new Student(5, "Kaan Beyazıt", "kaan@gmail.com", "(551) 440-3928", new DateTime(1992,1,1)),
            new Student(6, "Çağdaş Kocaman", "cagdas@gmail.com", "(550) 449-3827", new DateTime(2003,11,25))
        };

        public List<Student> GetList()
        {
            try
            {
                return students;
            }
            catch
            {
                return new List<Student>()
                {
                    new Student(1, "Ali Tuğrul", "ali@gmail.com", "(555) 444-3322", new DateTime(1971,1,1)),
                    new Student(2, "Fatma Özmen", "fatma@gmail.com", "(554) 443-3221", new DateTime(1988,6,14)),
                    new Student(3, "Zülal Güner", "zulal@gmail.com", "(553) 442-3120", new DateTime(1999,5,15)),
                    new Student(4, "Kübra Yanık", "kubra@gmail.com", "(552) 441-3029", new DateTime(2000,3,19)),
                    new Student(5, "Kaan Beyazıt", "kaan@gmail.com", "(551) 440-3928", new DateTime(1992,1,1)),
                    new Student(6, "Çağdaş Kocaman", "cagdas@gmail.com", "(550) 449-3827", new DateTime(2003,11,25))
                };
            }
        }

        private StudentManager() { }

        public string AddStudent(Student student)
        {
            try
            {
                if (!IsStudentComplete(student))
                {
                    return "Öğrenci verileri hatalı";
                }

                students.Add(student);
                return student.Name + " öğrencisi başarıyla eklendi.";
            }

            catch (Exception ex)
            {

                return ex.Message;
            }

        }

        public string UpdateStudent(Student student)
        {
            try
            {
                //control
                for (int i = 0; i < students.Count; i++)
                {
                    if (students[i].Id == student.Id)
                    {
                        students[i] = student;
                        return student.Name + " öğrencisi başarıyla başarıyla güncellendi.";
                    }
                }
                return "Öğrenci bulunamadı.";

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string DeleteStudent(int studentId) 
        {
            try
            {
                foreach (var student in students)
                {
                    if (student.Id == studentId)
                    {
                        students.Remove(student);
                        return student.Name + " öğrencisi başarıyla silindi.";
                    }
                }
                return "Öğrenci bulunmadı.";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        bool IsStudentComplete(Student student)
        {
            try
            {
                if (string.IsNullOrEmpty(student.Name) || string.IsNullOrEmpty(student.Mail) || string.IsNullOrEmpty(student.Phone))
                {
                    return false;
                }
                if (!student.Mail.Contains('@'))
                {
                    return false;
                }
                if (student.Mail.Substring(student.Mail.Length - 4, 1) != "." && student.Mail.Substring(student.Mail.Length - 3, 1) != ".")
                {
                    // maildeki noktaları buluyor
                    return false;
                }

                MailAddress mail = new MailAddress(student.Mail);
                Convert.ToDateTime(student.Birthday);

                return true;
            }
            catch 
            {
                return false;
            }
            
        }

        public static StudentManager GetInstance() //static = classı newlemeden çağırabilsin
        {
            if (studentManager == null)
            {
                studentManager = new StudentManager();//bu classtan obje yarat ve döndür
            }
            return studentManager;
        }

        public int GetMaxId() {

            int maxId = students[students.Count - 1].Id;
            return maxId + 1;
        }

        public Student GetStudentById(int studentId) 
        {
            try
            {
                foreach (var item in students)
                {
                    if (item.Id == studentId)
                    {
                        return item;
                    }
                }
                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}
