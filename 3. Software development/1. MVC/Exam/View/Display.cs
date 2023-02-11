using Exam.Enums;
using Exam.Model;
using Exam.View.Interfaces;
using System.Text;

namespace Exam.View
{
    public class Display : IDisplay
    {
        public ExamTimes ReadInput()
        {
            Time examStart = ReadTime();
            Time studentArrival = ReadTime();

            return new ExamTimes(examStart, studentArrival);
        }

        public void PrintResult(OnTimeEnum onTime, Time time)
        {
            string onTimeString = onTime.ToString().Replace("T", " t");
            Console.WriteLine(onTimeString);

            if (!(time is null))
            {
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(time);
                stringBuilder.Append(onTime == OnTimeEnum.Late ? " after" : " before");
                stringBuilder.AppendLine(" the start");

                Console.WriteLine(stringBuilder.ToString());
            }
        }

        private Time ReadTime()
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            return new Time(hours, minutes);
        }
    }
}
