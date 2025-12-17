#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 2)]
    public partial struct _AER_ENDPOINT_DESCRIPTOR_FLAGS
    {
        [FieldOffset(0)]
        public ushort UncorrectableErrorMaskRW;
        [FieldOffset(0)]
        public ushort UncorrectableErrorSeverityRW;
        [FieldOffset(0)]
        public ushort CorrectableErrorMaskRW;
        [FieldOffset(0)]
        public ushort AdvancedCapsAndControlRW;
        [FieldOffset(0)]
        public ushort Reserved;
        [FieldOffset(0)]
        public ushort AsUSHORT;
    }
}