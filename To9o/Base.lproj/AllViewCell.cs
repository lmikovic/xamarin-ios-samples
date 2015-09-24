// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace StoryboardTables
{
	public partial class AllViewCell : UICollectionViewCell
	{
		public AllViewCell (IntPtr handle) : base (handle)
		{
		}

		/// <summary>
		/// Expose the check/box image
		/// </summary>
		public UIKit.UIImageView Done { get { return DoneImage; } }

		/// <summary>
		/// Expose the label
		/// </summary>
		public UIKit.UILabel Name { get{ return TodoName; } }
	}
}
