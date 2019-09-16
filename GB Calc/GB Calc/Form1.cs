using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GB_Calc
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void textBoxes_Leave(object sender, EventArgs e)
		{
			int currentPoints = GetIntValue(tbCurrentPoints);
			int currentMax = GetIntValue(tbCurrentMax);
			int yourPoints = GetIntValue(tbYourPoints);
			int theirPoints = GetIntValue(tbTheirPoints);

			Calc_PointsToLock(currentPoints, currentMax, yourPoints, theirPoints);

			int arcLevel = GetIntValue(nArcLevel);
			int rewardPoints = GetIntValue(tbRewardPoints);
			int rewardPrints = GetIntValue(tbRewardPrints);

			Calc_Rewards(arcLevel, rewardPoints, rewardPrints);
		}

		private int GetIntValue(TextBox textBox)
		{
			int oValue = 0;
			if (int.TryParse(textBox.Text, out oValue))
			{
				return oValue;
			}
			return 0;
		}
		private int GetIntValue(NumericUpDown numericUpDown)
		{
			return (int)numericUpDown.Value;
		}

		private void Calc_PointsToLock(int currentPoints, int currentMax, int yourPoints, int theirPoints)
		{
			int pointsLeft	= Calc_PointsLeft(currentMax, currentPoints);
			int pointLead	= Calc_Lead(yourPoints, theirPoints);
			int pointsAfterCatchup = Calc_PointsAfterCatchup(pointsLeft, pointLead);
			int pointsToLock = Calc_PointsToLockPlace(pointsLeft, pointLead, yourPoints);
		}

		private int Calc_PointsLeft(int currentMax, int currentPoints)
		{
			int pointsLeft = currentMax - currentPoints;
			labelPointsLeft.Text = pointsLeft.ToString();

			return pointsLeft;
		}
		private int Calc_Lead(int yourPoints, int theirPoints)
		{
			int pointLead = yourPoints - theirPoints;
			labelPointsLead.Text = pointLead.ToString();

			return pointLead;
		}
		private int Calc_PointsAfterCatchup(int pointsLeft, int pointLead)
		{
			int pointsAfterCatchup = pointsLeft - Math.Abs(pointLead);
			labelPointsCatchup.Text = pointsAfterCatchup.ToString();

			return pointsAfterCatchup;
		}
		private int Calc_PointsToLockPlace(decimal pointsLeft, decimal pointLead, int yourPoints)
		{
			int pointsToLockPlace = 0;
			if (pointLead > 0)
			{
				pointsToLockPlace = (int)Math.Ceiling((pointsLeft - pointLead) / 2);
				labelPoints2Lock.Text = pointsToLockPlace.ToString();
				labelPoints2LockTotal.Text = "(" + (yourPoints + pointsToLockPlace).ToString() + ")";
				return pointsToLockPlace;
			}
			else
			{
				pointsToLockPlace = (int)Math.Ceiling((pointsLeft + pointLead) / 2);
				labelPoints2Lock.Text = pointsToLockPlace.ToString();
				labelPoints2LockTotal.Text = "(" + (yourPoints + pointsToLockPlace).ToString() + ")";
				return pointsToLockPlace;
			}
		}

		private void Calc_Rewards(int arcLevel, int rewardPoints, int rewardPrints)
		{
			int percent = (int)Calc_Arc(arcLevel);

			Calc_RewardPoints(percent, rewardPoints);
		}

		private decimal Calc_Arc(int arcLevel)
		{
			decimal percent = Calc_ArcPercent(arcLevel);
			labelArcPercent.Text = percent.ToString() + "%";

			return percent;
		}
		private decimal Calc_ArcPercent(int arcLevel)
		{
			if (arcLevel <= 10)
			{
				switch (arcLevel)
				{
					case 1:
						return 10;
					case 2:
						return 12;
					case 3:
						return 14;
					case 4:
						return 17;
					case 5:
						return 19;
					case 6:
						return 22;
					case 7:
						return 24;
					case 8:
						return 26;
					case 9:
						return 29;
					case 10:
						return 31;
					default:
						return 0;
				}
			}
			else if (arcLevel <= 58)
			{
				return 21 + arcLevel;
			}
			else if (arcLevel <= 80)
			{
				return 79 + ((decimal)arcLevel - 58) / 2;
			}
			else
			{
				return 90;
			}


		}

		private int Calc_RewardPoints(int percent, int rewardPoints)
		{
			int points = (int)Math.Ceiling(rewardPoints * (1.0 + (percent / 100.0)));
			labelRewardPoints.Text = points.ToString();

			return points;
		}

		private int Calc_RewardPrints(int percent, int rewardPoints)
		{
			throw new NotImplementedException();
		}

	}
}
