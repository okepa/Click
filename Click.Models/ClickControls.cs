using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Click.Models
{
    public struct MouseInput
    {
        public int X; // X coordinate
        public int Y; // Y coordinate
        public uint MouseData; // mouse data, e.g. for mouse wheel
        public uint DwFlags; // further mouse data, e.g. for mouse buttons
        public uint Time; // time of the event
        public IntPtr DwExtraInfo; // further information
    }

    public struct Input
    {
        public int Type; // type of the input, 0 for mouse  
        public MouseInput Data; // mouse data
    }
}
