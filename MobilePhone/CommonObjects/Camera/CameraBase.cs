using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Camera
{
    public class CameraBase
    {
        public int NumberOfCameras { get;}//1-2
        public int Pixel { get; } //Number of pixels
        public CameraBase(int numberOfCameras, int pixel)
        {
            NumberOfCameras = numberOfCameras;
            Pixel = pixel;
        }
        public override string ToString()
        {
            return "Camera";
        }
    }
}
