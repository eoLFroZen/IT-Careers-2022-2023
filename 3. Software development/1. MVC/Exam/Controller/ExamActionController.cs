using Exam.Controller.Interfaces;
using Exam.Enums;
using Exam.Model;
using Exam.Services;
using Exam.Services.Interfaces;
using Exam.View;
using Exam.View.Interfaces;

namespace Exam.Controller
{
    public class ExamActionController : IExamActionController
    {
        private readonly IDisplay display;
        private readonly IStudentArrivalService studentArrivalService;

        public ExamActionController()
        {
            display = new Display();
            studentArrivalService = new StudentArrivalService();
        }

        public void ValidateStudentArrival()
        {
            ExamTimes examTimes = display.ReadInput();

            OnTimeEnum isOnTime;
            Time time;

            (isOnTime, time) = studentArrivalService.ValidateStudentArrival(examTimes);

            display.PrintResult(isOnTime, time);
        }
    }
}
