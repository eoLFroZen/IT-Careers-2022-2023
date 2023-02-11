using Exam.Enums;
using Exam.Model;
using Exam.Services.Interfaces;

namespace Exam.Services
{
    public class StudentArrivalService : IStudentArrivalService
    {
        public (OnTimeEnum onTime, Time time) ValidateStudentArrival(ExamTimes examTimes)
        {
            if (examTimes.StudentArrival > examTimes.ExamStart)
            {
                Time lateTime = examTimes.StudentArrival - examTimes.ExamStart;
                return (OnTimeEnum.Late, lateTime);
            }

            Time earlyTime = examTimes.ExamStart - examTimes.StudentArrival;

            if (earlyTime < Constants.OnTimeMaxEarliness)
            {
                return (OnTimeEnum.OnTime, earlyTime);
            }

            return (OnTimeEnum.Early, earlyTime);
        }
    }
}
