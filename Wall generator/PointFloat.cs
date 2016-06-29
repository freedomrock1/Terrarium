using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_generator {
    class PointFloat {
        public float x = 0, y = 0, z = 0;

        public PointFloat() { }

        public PointFloat(float x) {
            this.x = x;
        }

        public PointFloat(float x, float y) {
            this.x = x;
            this.y = y;
        }

        public PointFloat(float x, float y, float z) {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
