using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace InfoManager.DataAccess
{
    class TestArrange
    {
        public static void RealizeFrameworkElement(FrameworkElement fe)
        {
            var size = new System.Windows.Size(double.MaxValue, double.MaxValue);
            if (fe.Width > 0 && fe.Height > 0) size = new System.Windows.Size(fe.Width, fe.Height);
            //fe.Measure(size);
            fe.Arrange(new Rect(new System.Windows.Point(10,100), fe.DesiredSize));
            //fe.UpdateLayout();
        }
    }
}
