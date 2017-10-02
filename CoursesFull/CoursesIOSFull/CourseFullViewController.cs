using System;

using UIKit;

namespace CoursesIOSFull
{
    public partial class CourseFullViewController : UIViewController
    {
        public CourseFullViewController() : base("CourseFullViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            labelTitle.Text = "Tester init";
            buttonPrev.TouchUpInside += ButtonPrev_TouchUpInside;
            buttonNext.TouchUpInside += ButtonNext_TouchUpInside;
        }
        
        private void ButtonPrev_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Previous Clicked";
            
        }

        private void ButtonNext_TouchUpInside(object sender, EventArgs e)
        {
            labelTitle.Text = "Next Clicked";
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

