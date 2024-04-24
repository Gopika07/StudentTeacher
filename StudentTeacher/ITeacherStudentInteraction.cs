namespace StudentTeacher;

/// <summary>
/// This is the 'business logic' of the application.
/// </summary>
public interface ITeacherStudentInteraction
{
    /// <summary>
    /// This method is called when the teacher joins the students in the classroom.
    /// </summary>
    void TeacherJoinsStudentsInClass();
    
    /// <summary>
    /// This method is called then the teacher leaves the classroom for recess.
    /// </summary>
    void TeacherLeavesClassroom();
}