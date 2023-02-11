using Exam.Enums;
using Exam.Model;

namespace Exam.View.Interfaces
{
    public interface IDisplay
    {
        ExamTimes ReadInput();

        void PrintResult(OnTimeEnum onTime, Time time);
    }
}
