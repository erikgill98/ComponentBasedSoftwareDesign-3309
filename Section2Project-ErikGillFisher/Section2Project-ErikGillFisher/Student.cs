using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Section2Project_ErikGillFisher
{
	public class Student
	{
		//variables
		public String name;
		public List<Int32> scores;


		public Student(String studentName)
		{
			//setting name to parameter
			this.name = studentName;
			//creating empty list to store scores
			this.scores = new List<int>();
		}


		public Student(string studentName, List<int> scores)
		{
			//setting name to parameter
			this.name = studentName;
			//creating a list that passes scores into it
			this.scores = new List<int>(scores);
		}

		public Student()
		{
			//empty list for scores
			this.scores = new List<int>();
		}

		public int getTotalScore()
		{
			Int32 sum = 0;
			//getting sum of scores
			foreach (int score in scores)
			{
				sum += score;
			}
			return sum;
		}

		public int getScoreCount()
        {
			//returns and calculates the count
			return scores.Count();
        }

		public int getScoreAverage()
        {
			//returns and calculates the average
			return getTotalScore() / scores.Count();
        }

        public override string ToString()
        {
			return name + " | " + String.Join(" | ", scores.ToArray());
        }
    }
}
