using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace GB_Calc
{
	public partial class Form1 : Form
	{
		private string		Settings_FileName	{ get; set; } = "Settings.xml";
		private Settings	Settings			{ get; set; } = new Settings();

		public Form1()
		{
			InitializeComponent();
			ReadSettings();

		}

		private void ReadSettings()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(Settings_FileName);

			XmlNode node;

			//---------------------------------------------------------------------------------

			// Points_Current
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Current");
			tbCurrentPoints.Text = node.InnerText;

			// Points_Max
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Max");
			tbCurrentMax.Text = node.InnerText;

			// Points_Yours
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Yours");
			tbYourPoints.Text = node.InnerText;

			// Points_Theirs
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Theirs");
			tbTheirPoints.Text = node.InnerText;

			// Points_Loose
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Loose");
			tbCurrentLoosePoints.Text = node.InnerText;

			//---------------------------------------------------------------------------------

			// Arc_Mode
			node = doc.DocumentElement.SelectSingleNode("/Settings/Arc/Mode");
			Mode_Set(node.InnerText);

			// Arc_Level
			node = doc.DocumentElement.SelectSingleNode("/Settings/Arc/Level");
			nArcLevel.Text = node.InnerText;

			//---------------------------------------------------------------------------------

			// Reward_Points
			node = doc.DocumentElement.SelectSingleNode("/Settings/Rewards/Points");
			tbRewardPoints.Text = node.InnerText;

			// Reward_Prints
			node = doc.DocumentElement.SelectSingleNode("/Settings/Rewards/Prints");
			tbRewardPrints.Text = node.InnerText;

			//---------------------------------------------------------------------------------

		}
		private void SaveSettings()
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(Settings_FileName);

			XmlNode node;

			//---------------------------------------------------------------------------------

			// Points_Current
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Current");
			node.InnerText = tbCurrentPoints.Text;

			// Points_Max
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Max");
			node.InnerText = tbCurrentMax.Text;

			// Points_Yours
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Yours");
			node.InnerText = tbYourPoints.Text;

			// Points_Theirs
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Theirs");
			node.InnerText = tbTheirPoints.Text;

			// Points_Loose
			node = doc.DocumentElement.SelectSingleNode("/Settings/Points/Loose");
			node.InnerText = tbCurrentLoosePoints.Text;

			//---------------------------------------------------------------------------------

			// Arc_Mode
			node = doc.DocumentElement.SelectSingleNode("/Settings/Arc/Mode");
			node.InnerText = Mode_Get().ToString();

			// Arc_Level
			node = doc.DocumentElement.SelectSingleNode("/Settings/Arc/Level");
			node.InnerText = nArcLevel.Text;

			//---------------------------------------------------------------------------------

			// Reward_Points
			node = doc.DocumentElement.SelectSingleNode("/Settings/Rewards/Points");
			node.InnerText = tbRewardPoints.Text;

			// Reward_Prints
			node = doc.DocumentElement.SelectSingleNode("/Settings/Rewards/Prints");
			node.InnerText = tbRewardPrints.Text;

			//---------------------------------------------------------------------------------

			doc.Save(Settings_FileName);
		}

		private void textBoxes_Leave(object sender, EventArgs e)
		{
			Calc_Main();
		}
		private int  TB_GetIntValue(TextBox textBox)
		{
			int oValue = 0;
			if (int.TryParse(textBox.Text, out oValue))
			{
				return oValue;
			}
			return 0;
		}
		private int  NB_GetIntValue(NumericUpDown numericUpDown)
		{
			return (int)numericUpDown.Value;
		}

		private void radioButtonMode_Click(object sender, EventArgs e)
		{
			RadioButton buttonClicked = (RadioButton)sender;

			if (buttonClicked == radioButtonModeCustom)
			{
				Mode_Reset(buttonClicked);
			}
			else
			{
				Mode_Reset(buttonClicked);
			}

			Calc_Main();
		}
		private void Mode_Reset(RadioButton button)
		{
			radioButtonMode80.Checked = false;
			radioButtonMode90.Checked = false;
			radioButtonModeCustom.Checked = false;

			button.Checked = true;
			nArcLevel.Enabled = !(radioButtonMode80.Checked | radioButtonMode90.Checked);
		}
		private void Mode_Set(int mode)
		{
			if (mode == 0)
			{
				Mode_Reset(radioButtonMode80);
			}
			else if (mode == 1)
			{
				Mode_Reset(radioButtonMode90);
			}
			else
			{
				Mode_Reset(radioButtonModeCustom);
			}
			Calc_Main();
		}
		private void Mode_Set(string modeStr)
		{
			int mode = 0;
			if (int.TryParse(modeStr, out mode))
			{
				Mode_Set(mode);
			}
			else
			{
				Mode_Set(1);
			}
		}
		private int	 Mode_Get()
		{
			if (radioButtonMode80.Checked)
			{
				return 0;
			}
			else if (radioButtonMode90.Checked)
			{
				return 1;
			}
			else
			{
				return 2;
			}
		}
		private bool Mode_IsCustom()
		{
			return radioButtonModeCustom.Checked;
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			SaveSettings();
		}

		private void Calc_Main()
		{
			int points_Current	= TB_GetIntValue(tbCurrentPoints);
			int points_Max		= TB_GetIntValue(tbCurrentMax);
			int points_Yours	= TB_GetIntValue(tbYourPoints);
			int points_Theirs	= TB_GetIntValue(tbTheirPoints);

			Calc_PointsToLock(points_Current, points_Max, points_Yours, points_Theirs);

			int arc_Level		= NB_GetIntValue(nArcLevel);
			int reward_Points	= TB_GetIntValue(tbRewardPoints);
			int reward_Prints	= TB_GetIntValue(tbRewardPrints);

			Calc_Rewards(arc_Level, reward_Points, reward_Prints);
		}

		
		private void Calc_PointsToLock(int points_Current, int points_Max, int points_Yours, int points_Theirs)
		{
			int pointsLeft	= Calc_PointsLeft(points_Max, points_Current);
			int pointLead	= Calc_Lead(points_Yours, points_Theirs);
			int pointsAfterCatchup = Calc_PointsAfterCatchup(pointsLeft, pointLead);
			int pointsToLock = Calc_PointsToLockPlace(pointsLeft, pointLead, points_Yours);
		}
		private int Calc_PointsLeft(int points_Max, int points_Current)
		{
			int points_Left = points_Max - points_Current;
			labelPointsLeft.Text = points_Left.ToString();

			return points_Left;
		}
		private int Calc_Lead(int points_Yours, int points_Theirs)
		{
			int points_Lead = points_Yours - points_Theirs;
			labelPointsLead.Text = points_Lead.ToString();

			return points_Lead;
		}
		private int Calc_PointsAfterCatchup(int points_Left, int point_Lead)
		{
			int points_AfterCatchup = points_Left - Math.Abs(point_Lead);
			labelPointsCatchup.Text = points_AfterCatchup.ToString();

			return points_AfterCatchup;
		}
		private int Calc_PointsToLockPlace(decimal points_Left, decimal points_Lead, int points_Yours)
		{
			int points_ToLockPlace = 0;
			if (points_Lead > 0)
			{
				points_ToLockPlace = (int)Math.Ceiling((points_Left - points_Lead) / 2);
				labelPoints2Lock.Text = points_ToLockPlace.ToString();
				labelPoints2LockTotal.Text = "(" + (points_Yours + points_ToLockPlace).ToString() + ")";
				return points_ToLockPlace;
			}
			else
			{
				points_ToLockPlace = (int)Math.Ceiling((points_Left + points_Lead) / 2);
				labelPoints2Lock.Text = points_ToLockPlace.ToString();
				labelPoints2LockTotal.Text = "(" + (points_Yours + points_ToLockPlace).ToString() + ")";
				return points_ToLockPlace;
			}
		}

		private void Calc_Rewards(int arc_Level, int reward_Points, int reward_Prints)
		{
			int arc_Percent = (int)Calc_Arc(arc_Level);

			int reward_PointsTotal = Calc_RewardPoints(arc_Percent, reward_Points);
			int reward_PrintsTotal = Calc_RewardPrints(arc_Percent, reward_Prints);
		}
		private decimal Calc_Arc(int arc_Level)
		{
			decimal percent = Calc_ArcPercent(arc_Level);
			labelArcPercent.Text = percent.ToString() + "%";

			return percent;
		}
		private decimal Calc_ArcPercent(int arc_Level)
		{
			if (Mode_IsCustom())
			{
				if (arc_Level <= 10)
				{
					switch (arc_Level)
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
				else if (arc_Level <= 58)
				{
					return 21 + arc_Level;
				}
				else if (arc_Level <= 80)
				{
					return 79 + ((decimal)arc_Level - 58) / 2;
				}
				else
				{
					decimal percent = 90 + ((decimal)arc_Level - 80) / 10;
					return Math.Min(percent, 100);
				}
			}
			else
			{
				if (radioButtonMode80.Checked)
				{
					return (decimal)80;
				}
				else
				{
					return (decimal)90;
				}
			}
		}
		private int Calc_RewardPoints(int arc_Percent, int reward_Points)
		{
			int reward_PointsTotal = (int)Math.Ceiling(reward_Points * (1.0 + (arc_Percent / 100.0)));
			labelRewardPoints.Text = reward_PointsTotal.ToString();

			return reward_PointsTotal;
		}
		private int Calc_RewardPrints(int arc_Percent, int reward_Prints)
		{
			int reward_PrintsTotal = (int)Math.Ceiling(reward_Prints * (1.0 + (arc_Percent / 100.0)));
			labelRewardPrints.Text = reward_PrintsTotal.ToString();

			return reward_PrintsTotal;
		}

		
	}
}
