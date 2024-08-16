namespace DEPI3StudentMVCWebAPPTask.Models
{
    public class StudentMock
    {
        List<Student> students;
        public StudentMock()
        {
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Mostafa Mohamed", ImgPath = "images/img1.jpg", Address = "Cairo" });
        }
        public List<Student> GetAllStudents()
        {
            return students;
        }
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(x => x.Id == id)??new Student();
        }
    }
}
