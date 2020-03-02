using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Camera
{
    public class MainCamera : CameraBase
    {
        public MainCamera(int numberOfCameras, int pixel) : base(numberOfCameras, pixel)
        {
        }
        public override string ToString()
        {
            return "Main Camera";
        }
    }
}
