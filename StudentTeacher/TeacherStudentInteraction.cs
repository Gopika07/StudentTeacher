namespace StudentTeacher;

/// <inheritdoc />
public class TeacherStudentInteraction(Teacher teacher, StudentService students) : ITeacherStudentInteraction
{
    /// <inheritdoc />
    public void TeacherJoinsStudentsInClass()
    {
        teacher.GetIntoClass();
        students.GoSilentAll();
    }

    /// <inheritdoc />
    public void TeacherLeavesClassroom()
    {
        teacher.GetOutOfClass();
        students.MakeNoiseAll();
    }
}