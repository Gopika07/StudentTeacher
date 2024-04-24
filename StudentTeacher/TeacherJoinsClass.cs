using MediatR;

namespace StudentTeacher;

/// <summary>
/// This event signals that the teacher joins the students in the classroom
/// </summary>
public class TeacherJoinsClass : INotification;