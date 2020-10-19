namespace ExercicioComConjunto_II.Entities
{
    class Student
    {
        public int IdStudent { get; set; }

        public Student(int idStudent)
        {
            IdStudent = idStudent;
        }

        public override int GetHashCode()
        {
            return IdStudent.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Student))
            {
                return false;
            }
            Student other = obj as Student;
            return IdStudent.Equals(other.IdStudent);
        }
    }
}
