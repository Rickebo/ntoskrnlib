#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 80)]
    public partial struct _LDR_DDAG_NODE
    {
        [FieldOffset(0)]
        public _LIST_ENTRY Modules;
        [FieldOffset(16)]
        public IntPtr ServiceTagList;
        [FieldOffset(24)]
        public uint LoadCount;
        [FieldOffset(28)]
        public uint LoadWhileUnloadingCount;
        [FieldOffset(32)]
        public uint LowestLink;
        [FieldOffset(40)]
        public _LDRP_CSLIST Dependencies;
        [FieldOffset(48)]
        public _LDRP_CSLIST IncomingDependencies;
        [FieldOffset(56)]
        public uint State;
        [FieldOffset(64)]
        public _SINGLE_LIST_ENTRY CondenseLink;
        [FieldOffset(72)]
        public uint PreorderNumber;
    }
}