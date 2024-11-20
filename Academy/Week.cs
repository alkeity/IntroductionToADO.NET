using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	internal class Week
	{
		static readonly string[] dayNames = new string[] { "Пн", "Вт", "Ср", "Чт", "Пт", "Сб", "Вс" };

		public static string ReadableDays(byte days)
		{
			string result = "";
			for (int i = 0; i < 7; i++)
			{
				if ((days & (1 << i)) != 0) result += dayNames[i] + " ";
			}
			if (result.Length > 0) result = result.Remove(result.Length - 1);
			return result;
		}

		public static byte CompressedDays(string days)
		{
			byte result = 0;
			for (byte i = 0; i < 7; i++)
			{
				if (days.Contains(dayNames[i])) result |= Convert.ToByte(1 << i);
			}
			return result;
		}
	}
}
