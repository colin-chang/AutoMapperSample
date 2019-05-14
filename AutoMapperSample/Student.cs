using AutoMapper;

namespace AutoMapperSample
{
    public class Student
    {
        public string Name { get; set; }

        public int Score { get; set; }
    }

    public class StudentDto
    {
        public string Name { get; set; }

        public Grade Score { get; set; }
    }

    public enum Grade
    {
        A,
        B,
        C
    }

    public class ScoreResolver : IValueResolver<Student, StudentDto, Grade>
    {
        public Grade Resolve(Student source, StudentDto destination, Grade destMember, ResolutionContext context)
        {
            var score = source.Score;
            if (score >= 90)
                return Grade.A;
            else if (score >= 80)
                return Grade.B;
            else
                return Grade.C;
        }
    }

    public class ScoreConverter : ITypeConverter<Student, StudentDto>
    {
        public StudentDto Convert(Student source, StudentDto destination, ResolutionContext context)
        {
            var score = source.Score;
            Grade grade;
            if (score >= 90)
                grade = Grade.A;
            else if (score >= 80)
                grade = Grade.B;
            else
                grade = Grade.C;

            return new StudentDto {Score = grade};
        }
    }
}