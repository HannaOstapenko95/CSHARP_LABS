using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile.CommonObjects.Camera
{
    public class FrontCamera : CameraBase
    {
        public FrontCamera(int numberOfCameras, int pixel) : base(numberOfCameras, pixel)
        {
        }

        public override string ToString()
        {
            return "Front Camera";
        }
    }
}
