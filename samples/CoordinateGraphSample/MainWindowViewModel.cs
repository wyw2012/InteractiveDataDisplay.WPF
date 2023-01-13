using CoordinateGraphSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace CoordinateGraphSample
{
    internal class MainWindowViewModel:ObservableObject
    {
		public MainWindowViewModel()
		{
            Lines = new LineGraphModel[2];
            Lines[0] = new LineGraphModel("Line1",Brushes.Red);
            Lines[0].Points = new PointCollection() { new Point(1, 1), new Point(800, 800) };
            Lines[1] = new LineGraphModel("Line2", Brushes.Green);
            AddLine2Command = new RelayCommand(AddLine2);
        }
	
		public LineGraphModel[] Lines { get;  }

        public RelayCommand AddLine2Command { get; set; }
       
        private void AddLine2()
        {
            for (int i = 0; i < 100000; i++)
            {
                Lines[1].Points.Add(new Point() { X = i, Y = i/100 });
            }
        }
    }
}
