// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;
using Foundation;
using UIKit;
using CoreSpotlight;

namespace StoryboardTables
{
	public partial class TaskDetailViewController : UITableViewController
	{
//		Task currentTask {get;set;}
//		public RootViewController Delegate {get;set;}
//
//		public TaskDetailViewController (IntPtr handle) : base (handle)
//		{
//			
//		}
//		// this gets called periodically after activity.BecomeCurrent() is called
//		// //http://www.raywenderlich.com/84174/ios-8-handoff-tutorial
//		public override void UpdateUserActivityState (NSUserActivity activity)
//		{
//			Console.WriteLine ("UpdateUserActivityState for " + activity.Title);
//			// update activity 
//			if (currentTask != null && currentTask.Name != null && currentTask.Notes != null) {
//				activity.AddUserInfoEntries (NSDictionary.FromObjectAndKey (new NSString (currentTask.Name), new NSString ("name")));
//				activity.AddUserInfoEntries (NSDictionary.FromObjectAndKey (new NSString (currentTask.Id.ToString ()), new NSString ("id")));
//			}
//			base.UpdateUserActivityState (activity);
//		}
//		public override void RestoreUserActivityState (NSUserActivity activity)
//		{
//			base.RestoreUserActivityState (activity);
//			Console.Write ("RestoreUserActivityState ");
//			if (activity.ActivityType == "com.conceptdevelopment.to9o.detail") {
//				Console.WriteLine ("NSUserActivity=com.conceptdevelopment.to9o.detail");
//				if (activity.UserInfo == null || activity.UserInfo.Count == 0) {
//					// new task Activity
//					currentTask = new Task();
//				} else {
//
//					var id = activity.UserInfo.ObjectForKey ((NSString)"id").ToString ();
//
//					if (id == "0")
//						currentTask = new Task ();
//					else
//						currentTask = AppDelegate.Current.TaskMgr.GetTask (Convert.ToInt32 (id));
//				}
//			} 
//			if (activity.ActivityType == CSSearchableItem.ActionType) {
//				Console.WriteLine ("CSSearchableItem.ActionType");
//				var uid = activity.UserInfo [CoreSpotlight.CSSearchableItem.ActivityIdentifier];
//
//				currentTask = AppDelegate.Current.TaskMgr.GetTask (Convert.ToInt32 (uid.Description));
//
//				Console.WriteLine ("eeeeeeee RestoreUserActivityState " + uid);
//			}
//		}
//		public override void ViewDidLoad ()
//		{
//			base.ViewDidLoad ();
//			SaveButton.TouchUpInside += (sender, e) => {
//				currentTask.Name = TitleText.Text;
//				currentTask.Notes = NotesText.Text;
//				currentTask.Done = DoneSwitch.On;
//	//			Delegate.SaveTask(currentTask);
//				NavigationController.PopViewController(true);
//			};
//			DeleteButton.TouchUpInside += (sender, e) => {
//	//			Delegate.DeleteTask(currentTask);
//				NavigationController.PopViewController(true);
//			};
//
//			TitleText.TextAlignment = UITextAlignment.Natural;
//			NotesText.TextAlignment = UITextAlignment.Natural;
//
//
//			UserActivity = iOS9SearchModel.CreateNSUserActivity (currentTask?? new Task());
//
//		}
//
//		public override void ViewWillDisappear (bool animated)
//		{
//			base.ViewWillDisappear (animated);
//			if (UserActivity != null) {
//				UserActivity.ResignCurrent ();
//			}
//		}
//
//		// this will be called before the view is displayed 
//		public void SetTask (RootViewController d, Task task) {
//			Delegate = d;
//			currentTask = task;
//		}
//		// when displaying, set-up the properties
//		public override void ViewWillAppear (bool animated)
//		{
//			base.ViewWillAppear (animated);
//			TitleText.Text = currentTask.Name;
//			NotesText.Text = currentTask.Notes;
//			DoneSwitch.On = currentTask.Done;
//		}
	}
}