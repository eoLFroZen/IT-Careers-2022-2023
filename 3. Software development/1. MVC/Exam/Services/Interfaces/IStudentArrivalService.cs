using Exam.Enums;
using Exam.Model;

namespace Exam.Services.Interfaces
{
    public interface IStudentArrivalService
    {
        (OnTimeEnum onTime, Time time) ValidateStudentArrival(ExamTimes examTimes);
    }
}
