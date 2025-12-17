#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 28)]
    public partial struct _DEVICE_DSM_DEFINITION
    {
        [FieldOffset(0)]
        public uint Action;
        [FieldOffset(4)]
        public byte SingleRange;
        [FieldOffset(8)]
        public uint ParameterBlockAlignment;
        [FieldOffset(12)]
        public uint ParameterBlockLength;
        [FieldOffset(16)]
        public byte HasOutput;
        [FieldOffset(20)]
        public uint OutputBlockAlignment;
        [FieldOffset(24)]
        public uint OutputBlockLength;
    }
}