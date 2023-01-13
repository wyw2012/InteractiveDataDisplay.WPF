using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace CoordinateGraphSample.Models
{
    internal class LineGraphModel: ObservableObject
    {

        public LineGraphModel(string description, Brush stroke)
        {
           Description= description;
            Stroke= stroke;
        }
        private PointCollection points=new PointCollection();

        /// <summary>
        /// 
        /// </summary>
        public PointCollection Points
        {
            get => points;
            set => SetProperty(ref points, value);
        }


        public string Description { get; set; }
    

        private Brush stroke;

        /// <summary>
        /// 
        /// </summary>
        public Brush Stroke
        {
            get => stroke;
            set => SetProperty(ref stroke, value);
        }


        public double StrokeThickness { get; set; } = 2;

    }
}
