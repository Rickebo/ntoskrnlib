#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 1)]
    public partial struct _PROCESS_EXECUTION_STATE
    {
        [FieldOffset(0)]
        public sbyte State;
        [FieldOffset(0)]
        public byte ProcessFrozen;
        [FieldOffset(0)]
        public byte ProcessSwapped;
        [FieldOffset(0)]
        public byte ProcessGraphicsFreezeOptimized;
        [FieldOffset(0)]
        public byte Reserved;
    }
}