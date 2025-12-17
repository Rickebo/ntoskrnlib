#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 184)]
    public partial struct _RTL_NLS_STATE
    {
        [FieldOffset(0)]
        public _CPTABLEINFO DefaultAcpTableInfo;
        [FieldOffset(64)]
        public _CPTABLEINFO DefaultOemTableInfo;
        [FieldOffset(128)]
        public IntPtr ActiveCodePageData;
        [FieldOffset(136)]
        public IntPtr OemCodePageData;
        [FieldOffset(144)]
        public IntPtr LeadByteInfo;
        [FieldOffset(152)]
        public IntPtr OemLeadByteInfo;
        [FieldOffset(160)]
        public IntPtr CaseMappingData;
        [FieldOffset(168)]
        public IntPtr UnicodeUpcaseTable844;
        [FieldOffset(176)]
        public IntPtr UnicodeLowercaseTable844;
    }
}