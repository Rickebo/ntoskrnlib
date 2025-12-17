#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntdll
{
    [StructLayout(LayoutKind.Explicit, Size = 36)]
    public partial struct _CM_FULL_RESOURCE_DESCRIPTOR
    {
        [FieldOffset(0)]
        public uint InterfaceType;
        [FieldOffset(4)]
        public uint BusNumber;
        [FieldOffset(8)]
        public _CM_PARTIAL_RESOURCE_LIST PartialResourceList;
    }
}