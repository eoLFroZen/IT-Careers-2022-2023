namespace Exam.Model
{
    public class ExamTimes
    {
        public ExamTimes(Time examStart, Time studentArrival)
        {
            ExamStart = examStart;
            StudentArrival = studentArrival;
        }

        public Time ExamStart { get; set; }

        public Time StudentArrival { get; set; }
    }
}
