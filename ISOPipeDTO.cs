using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Element.Reveal.DataLibrary
{
    public struct ISOCoordinate
    {
        public double x;
        public double y;
        public double z;
    };

    public class ISOPipeDTO : DTOBase    
    {
        private string[] _connection = new string[2];

        public ISOCoordinate[] Point = new ISOCoordinate[2];

        public float Length { get; set; }
        public float Size { get; set; }
        public string Material { get; set; }
        public string PipeEnd { get; set; }
        
        public string PipeTagNumber { get; set; }
        public string PipeThickness { get; set; }

        public string[] PipeConnection
        {
            get { return _connection; }
            set { _connection = value; }
        }


        public float GetLength()
        {
            double xLength = System.Math.Abs(Point[0].x - Point[1].x);
            double yLength = System.Math.Abs(Point[0].y - Point[1].y);
            double zLength = System.Math.Abs(Point[0].z - Point[1].z);

            if (xLength > 0.000001)
                Length += (float)xLength;
            if (yLength > 0.000001)
                Length += (float)yLength;
            if (zLength > 0.000001)
                Length += (float)zLength;

            return Length;
        }

    }
}
