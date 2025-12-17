#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 152)]
    public partial struct _MSUBSECTION
    {
        [FieldOffset(0)]
        public _SUBSECTION Core;
        [FieldOffset(56)]
        public _RTL_BALANCED_NODE SubsectionNode;
        [FieldOffset(80)]
        public ulong NumberOfMappedViews;
        [FieldOffset(88)]
        public _LIST_ENTRY DereferenceList;
        [FieldOffset(104)]
        public uint NumberOfPfnReferences;
        [FieldOffset(108)]
        public uint LargeViews;
        [FieldOffset(112)]
        public IntPtr SubsectionExtentList;
        [FieldOffset(120)]
        public _MI_PROTOTYPE_PTES_NODE ProtosNode;
    }
}