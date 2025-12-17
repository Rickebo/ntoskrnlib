#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 8)]
    public partial struct _IMAGE_ARM64_RUNTIME_FUNCTION_ENTRY
    {
        [FieldOffset(0)]
        public uint BeginAddress;
        [FieldOffset(4)]
        public uint UnwindData;
        [FieldOffset(4)]
        public uint Flag;
        [FieldOffset(4)]
        public uint FunctionLength;
        [FieldOffset(4)]
        public uint RegF;
        [FieldOffset(4)]
        public uint RegI;
        [FieldOffset(4)]
        public uint H;
        [FieldOffset(4)]
        public uint CR;
        [FieldOffset(4)]
        public uint FrameSize;
    }
}