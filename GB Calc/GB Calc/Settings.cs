using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GB_Calc
{
	public class Settings
	{
		public int Points_Current	{ get; set; } = 0;
		public int Points_Max		{ get; set; } = 0;
		public int Points_Yours		{ get; set; } = 0;
		public int Points_Theirs	{ get; set; } = 0;
		public int Points_Loose		{ get; set; } = 0;

		public int ArcMode			{ get; set; } = 1;
		public int ArcLevel			{ get; set; } = 0;

		public int Rewards_Points	{ get; set; } = 0;
		public int Rewards_Prints	{ get; set; } = 0;
		

		public Settings()
		{

		}
	}
}
