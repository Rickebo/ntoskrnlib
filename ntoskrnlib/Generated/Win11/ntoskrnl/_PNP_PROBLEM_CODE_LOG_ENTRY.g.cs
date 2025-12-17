#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 24)]
    public partial struct _PNP_PROBLEM_CODE_LOG_ENTRY
    {
        [FieldOffset(0)]
        public _LARGE_INTEGER Timestamp;
        [FieldOffset(8)]
        public uint Operation;
        [FieldOffset(12)]
        public uint ProblemCode;
        [FieldOffset(16)]
        public int ProblemStatus;
    }
}