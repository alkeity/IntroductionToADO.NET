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

        public Group()
		{
			Id = 0;
			Name = string.Empty;
			StudyDays = 0;
			StartDate = DateTime.MinValue;
			StartTime = TimeSpan.Zero;
			StudyFieldID = 0;
			LearningFormID = 0;
		}

        public Group(Group other)
        {
            this.Id = other.Id;
			this.Name = other.Name;
			this.StudyDays = other.StudyDays;
			this.StartDate = other.StartDate;
			this.StartTime = other.StartTime;
			this.StudyFieldID = other.StudyFieldID;
			this.LearningFormID = other.LearningFormID;
        }

        public Group(string name, byte studyDays, DateTime startDate, TimeSpan startTime, int fieldID, int formID)
        {
            Name = name;
			StudyDays = studyDays;
			StartDate = startDate;
			StartTime = startTime;
			StudyFieldID = fieldID;
			LearningFormID = formID;
        }

		public Group(int id, string name, byte studyDays, DateTime startDate, TimeSpan startTime, int fieldID, int formID) : 
			this(name, studyDays, startDate, startTime, fieldID, formID)
		{
			Id = id;
		}

	}
}
