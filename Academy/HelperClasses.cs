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

	public class Student
	{
		//int id;
		//string firstName;
		//string lastName;
		//string middleName;
		//DateTime birthDate;
		//int groupId;

		public int ID { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string MiddleName { get; set; }
		public DateTime BirthDate { get; set; }
		public int GroupID { get; set; }

		public Student() { }

        public Student(string fullName, DateTime birthDate, int groupId)
        {
			string[] fullNameArray = NameBreakdown(fullName);

			ID = 0;
			LastName = fullNameArray[0];
			FirstName = fullNameArray[1];
			MiddleName = fullNameArray.Length == 3 ? fullNameArray[2] : "";
			BirthDate = birthDate;
			GroupID = groupId;
        }

        public Student(int id, string fullName, DateTime birthDate, int groupId) : this(fullName, birthDate, groupId)
        {
			ID = id;
        }

        public Student(Student other)
        {
			ID = other.ID;
			LastName = other.LastName;
			FirstName = other.FirstName;
			MiddleName = other.MiddleName;
			BirthDate = other.BirthDate;
			GroupID = other.GroupID;
		}

        string[] NameBreakdown(string fullName)
		{
			string[] result = fullName.Split(' ');
			if (result.Length < 2 || result.Length > 4) { throw new Exception(); }
			return result;
		}
    }
}
