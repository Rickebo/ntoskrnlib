using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OBJECT_HEADER_QUOTA_INFO")]
    public sealed class ObjectHeaderQuotaInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint PagedPoolCharge { get => ReadHere<uint>(nameof(PagedPoolCharge)); set => WriteHere(nameof(PagedPoolCharge), value); }

        [Offset(4UL)]
        public uint NonPagedPoolCharge { get => ReadHere<uint>(nameof(NonPagedPoolCharge)); set => WriteHere(nameof(NonPagedPoolCharge), value); }

        [Offset(8UL)]
        public uint SecurityDescriptorCharge { get => ReadHere<uint>(nameof(SecurityDescriptorCharge)); set => WriteHere(nameof(SecurityDescriptorCharge), value); }

        [Offset(12UL)]
        public uint Reserved1 { get => ReadHere<uint>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(16UL)]
        public IntPtr SecurityDescriptorQuotaBlock { get => ReadHere<IntPtr>(nameof(SecurityDescriptorQuotaBlock)); set => WriteHere(nameof(SecurityDescriptorQuotaBlock), value); }

        [Offset(24UL)]
        public ulong Reserved2 { get => ReadHere<ulong>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        public ObjectHeaderQuotaInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<ObjectHeaderQuotaInfo>();
        }
    }
}