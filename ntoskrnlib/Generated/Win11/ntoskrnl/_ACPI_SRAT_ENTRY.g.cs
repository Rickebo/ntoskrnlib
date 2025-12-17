#pragma warning disable CS0649
using System;
using System.Runtime.InteropServices;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [StructLayout(LayoutKind.Explicit, Size = 40)]
    public partial struct _ACPI_SRAT_ENTRY
    {
        [FieldOffset(0)]
        public byte Type;
        [FieldOffset(1)]
        public byte Length;
        [FieldOffset(2)]
        public _unnamed_tag_ ApicAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ MemoryAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ X2ApicAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ GiccAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ GicItsAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ GenericInitiatorAffinity;
        [FieldOffset(2)]
        public _unnamed_tag_ GenericPortAffinity;
    }
}