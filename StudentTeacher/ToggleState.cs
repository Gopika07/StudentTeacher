using MediatR;

namespace StudentTeacher;

public class ToggleState(IMediator eventPublisher)
{
    private bool teacherInClass = true;

    public void Toggle()
    {
        if(teacherInClass)
        {
            eventPublisher.Publish(new TeacherJoinsClass());
        }
        else
        {
            eventPublisher.Publish(new TeacherLeavesClass());
        }
        teacherInClass = !teacherInClass;
    }
}