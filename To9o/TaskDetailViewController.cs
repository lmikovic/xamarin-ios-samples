// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;
using Foundation;
using UIKit;

namespace StoryboardTables
{
	public partial class TaskDetailViewController : UITableViewController
	{
		Task currentTask {get;set;}
		public RootViewController Delegate {get;set;}

		public TaskDetailViewController (IntPtr handle) : base (handle)
		{

		}
		public override void RestoreUserActivityState (NSUserActivity activity)
		{
			base.RestoreUserActivityState (activity);
			var guid = activity.UserInfo [CoreSpotlight.CSSearchableItem.ActivityIdentifier];
			Console.WriteLine ("eeeeeeee RestoreUserActivityState " + guid);
		}
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			SaveButton.TouchUpInside += (sender, e) => {
				currentTask.Name = TitleText.Text;
				currentTask.Notes = NotesText.Text;
				currentTask.Done = DoneSwitch.On;
				Delegate.SaveTask(currentTask);
			};
			DeleteButton.TouchUpInside += (sender, e) => {
				Delegate.DeleteTask(currentTask);
			};

			TitleText.TextAlignment = UITextAlignment.Natural;
			NotesText.TextAlignment = UITextAlignment.Natural;
		}

		// this will be called before the view is displayed 
		public void SetTask (RootViewController d, Task task) {
			Delegate = d;
			currentTask = task;
		}
		// when displaying, set-up the properties
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			TitleText.Text = currentTask.Name;
			NotesText.Text = currentTask.Notes;
			DoneSwitch.On = currentTask.Done;
		}
	}
}