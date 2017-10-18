// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace CoursesIOSFull
{
    [Register ("CourseFullViewController")]
    partial class CourseFullViewController
    {
        [Outlet]
        UIKit.UIButton buttonNext { get; set; }


        [Outlet]
        UIKit.UIButton buttonPrev { get; set; }


        [Outlet]
        UIKit.UILabel labelTitle { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (buttonNext != null) {
                buttonNext.Dispose ();
                buttonNext = null;
            }

            if (buttonPrev != null) {
                buttonPrev.Dispose ();
                buttonPrev = null;
            }

            if (labelTitle != null) {
                labelTitle.Dispose ();
                labelTitle = null;
            }
        }
    }
}