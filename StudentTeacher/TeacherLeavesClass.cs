using MediatR;

namespace StudentTeacher;

/// <summary>
/// This event signals that the teacher leaves the classroom
/// </summary>
public class TeacherLeavesClass : INotification;