using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MCUPDATE_INFO")]
    public sealed class McupdateInfo : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry List { get => ReadStructure<ListEntry>(nameof(List)); set => WriteStructure(nameof(List), value); }

        [Offset(16UL)]
        public uint Status { get => ReadHere<uint>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        [Offset(24UL)]
        public ulong Id { get => ReadHere<ulong>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(32UL)]
        [Length(2)]
        public DynamicArray VendorScratch { get => ReadStructure<DynamicArray>(nameof(VendorScratch)); set => WriteStructure(nameof(VendorScratch), value); }

        public McupdateInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<McupdateInfo>();
        }
    }
}