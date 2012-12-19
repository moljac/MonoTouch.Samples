
using System;
using System.Drawing;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CustomCell
{
	public partial class CustomListCell : UITableViewCell
	{  
		public CustomListCell () : base()
		{
			this.Accessory = UITableViewCellAccessory.DisclosureIndicator;
		}
		
		public CustomListCell (IntPtr handle) : base(handle)
		{
			this.Accessory = UITableViewCellAccessory.DisclosureIndicator;
		}

		public void UpdateWithData (string text)
		{  
			switch (text.ToLower()) 
			{
			case "technology":
				lblTotalQToBeAnswered.Text = "8";
				lblQCurrentlyAnswered.Text = "4";
				lblOverallRankScore.Text = "16";
				lblCategoryName.Text = "Technology";
				break;
			case "biology":
				lblTotalQToBeAnswered.Text = "2";
				lblQCurrentlyAnswered.Text = "3";
				lblOverallRankScore.Text = "26";
				lblCategoryName.Text = "Biology";
				break;
			case "science": 
				lblTotalQToBeAnswered.Text = "9";
				lblQCurrentlyAnswered.Text = "3";
				lblOverallRankScore.Text = "11";
				lblCategoryName.Text = "Science";
				break;
			case "teleportation": 
				lblTotalQToBeAnswered.Text = "7";
				lblQCurrentlyAnswered.Text = "3";
				lblOverallRankScore.Text = "44";
				lblCategoryName.Text = "Teleportation";
				break;
			case "multiverse": 
				lblTotalQToBeAnswered.Text = "4";
				lblQCurrentlyAnswered.Text = "2";
				lblOverallRankScore.Text = "6";
				lblCategoryName.Text = "Multiverse";
				break;
			case "peace": 
				lblTotalQToBeAnswered.Text = "2";
				lblQCurrentlyAnswered.Text = "2";
				lblOverallRankScore.Text = "87";
				lblCategoryName.Text = "Peace";
				break;
			}
	
		}

		public void CellStyle()
		{
			//TODO: WHY AM I UNABLE TO CALL THIS FROM CTOR
			lblTotalQToBeAnswered.BackgroundColor = UIColor.Red;
			lblTotalQToBeAnswered.TextAlignment = UITextAlignment.Center;
			lblTotalQToBeAnswered.Layer.CornerRadius = 4;
			lblTotalQToBeAnswered.TextColor = UIColor.White;

			lblQCurrentlyAnswered.BackgroundColor = UIColor.Green;
			lblQCurrentlyAnswered.TextAlignment = UITextAlignment.Center;
			lblQCurrentlyAnswered.Layer.CornerRadius = 4;
			lblQCurrentlyAnswered.TextColor = UIColor.White;

			lblOverallRankScore.BackgroundColor = UIColor.LightGray;
			lblOverallRankScore.TextAlignment = UITextAlignment.Center;
			lblOverallRankScore.Layer.CornerRadius = 4;
			lblOverallRankScore.TextColor = UIColor.White;

		}
		
	}
}

