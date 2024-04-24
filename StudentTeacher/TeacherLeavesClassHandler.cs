using MediatR;

namespace StudentTeacher;

/// <summary>
/// When an <see cref="TeacherLeavesClass"/> event is published, this event handler is evoked.
/// </summary>
/// <param name="interaction"></param>
public class TeacherLeavesClassHandler(ITeacherStudentInteraction interaction) : INotificationHandler<TeacherLeavesClass>
{
    public Task Handle(TeacherLeavesClass notification, CancellationToken cancellationToken)
    {
        interaction.TeacherLeavesClassroom();
        return Task.CompletedTask;
    }
}