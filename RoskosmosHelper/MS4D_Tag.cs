using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoskosmosHelper
{
    internal class MS4D_Tag
    {
        public string Name { get; set; }
        public MS4D_TypeRegion Region { get; set; }
        public int Address { get; set; }
        public MS4D_TypeData DataTypeDevice { get; set; }
        public MS4D_TypeData DataTypeScada { get; set; }
        public MS4D_TypeAccess Access { get; set; }
        public MS4D_TypeString TypeString { get; set; }
        public int LengthString { get; set; }
        public MS4D_Scale Scale { get; set; }
        public string Comment { get; set; }
    }

    internal enum MS4D_TypeRegion { COILS, DISCRETE_INPUTS, HOLDING_REGISTERS, INPUT_REGISTERS }
    internal enum MS4D_TypeData { BOOL, INT, WORD, DINT, DWORD, REAL, LREAL, STRING, LINT, LWORD }
    internal enum MS4D_TypeAccess { ReadOnly, WriteOnly, ReadWrite }
    internal enum MS4D_TypeString { ASCII, HEX, UNICODE }

    internal class MS4D_Scale
    {
        public int SourceMin { get; set; }
        public int SourceMax { get; set; }
        public int TargetMin { get; set; }
        public int TargetMax { get; set; }

        public MS4D_Scale()
        {
        }
        public MS4D_Scale(int sourceMin, int sourceMax, int targetMin, int targetMax)
        {
            SourceMin = sourceMin;
            SourceMax = sourceMax;
            TargetMin = targetMin;
            TargetMax = targetMax;
        }

        public override string ToString()
        {
            return $"{SourceMin};{SourceMax};{TargetMin};{TargetMax};";
        }
    }
}
