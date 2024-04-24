using MediatR;

namespace StudentTeacher;

/// <summary>
/// When an <see cref="TeacherLeavesClass"/> event is published, this event handler is evoked.
/// </summary>
/// <param name="interaction"></param>
public class TeacherEntersClassHandler(ITeacherStudentInteraction interaction) : INotificationHandler<TeacherJoinsClass>
{
    public Task Handle(TeacherJoinsClass notification, CancellationToken cancellationToken)
    {
        interaction.TeacherJoinsStudentsInClass();
        return Task.CompletedTask;
    }
}