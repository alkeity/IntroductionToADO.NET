using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	public class Group
	{
		//int id;
		//string name;
		//byte studyDays;
		//DateTime startDate;
		//TimeSpan startTime;
		//int studyFieldID;
		//int learningFormID;

		public int Id { get; set; }
		public string Name { get; set; }
		public byte StudyDays { get; set; }
		public DateTime StartDate { get; set; }
		public TimeSpan StartTime { get; set; }
		public int StudyFieldID { get; set; }
		public int LearningFormID { get; set; }

        public Group(string name, byte studyDays, DateTime startDate, TimeSpan startTime, int fieldID, int formID)
        {
            Name = name;
			StudyDays = studyDays;
			StartDate = startDate;
			StartTime = startTime;
			StudyFieldID = fieldID;
			LearningFormID = formID;
        }

    }
}
