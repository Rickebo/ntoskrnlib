#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 376)]
    public partial struct _REGISTERED_INTERRUPT_CONTROLLER
    {
        [FieldOffset(0)]
        public _LIST_ENTRY ListEntry;
        [FieldOffset(16)]
        public IntPtr InternalData;
        [FieldOffset(24)]
        public uint InternalDataSize;
        [FieldOffset(32)]
        public _INTERRUPT_FUNCTION_TABLE FunctionTable;
        [FieldOffset(240)]
        public uint KnownType;
        [FieldOffset(244)]
        public uint Capabilities;
        [FieldOffset(248)]
        public uint Flags;
        [FieldOffset(252)]
        public uint MaxPriority;
        [FieldOffset(256)]
        public uint UnitId;
        [FieldOffset(264)]
        public _LIST_ENTRY LinesHead;
        [FieldOffset(280)]
        public _LIST_ENTRY OutputLinesHead;
        [FieldOffset(296)]
        public int MinLine;
        [FieldOffset(300)]
        public int MaxLine;
        [FieldOffset(304)]
        public uint MaxClusterSize;
        [FieldOffset(308)]
        public uint MaxClusters;
        [FieldOffset(312)]
        public uint InterruptReplayDataSize;
        [FieldOffset(316)]
        public uint Problem;
        [FieldOffset(320)]
        public int ProblemStatus;
        [FieldOffset(328)]
        public IntPtr ProblemSourceFile;
        [FieldOffset(336)]
        public uint ProblemSourceLine;
        [FieldOffset(340)]
        public uint CustomProblem;
        [FieldOffset(344)]
        public int CustomProblemStatus;
        [FieldOffset(352)]
        public _UNICODE_STRING ResourceId;
        [FieldOffset(368)]
        public IntPtr PowerHandle;
    }
}