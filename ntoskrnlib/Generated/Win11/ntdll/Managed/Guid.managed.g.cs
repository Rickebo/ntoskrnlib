using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_GUID")]
    public sealed class Guid : DynamicStructure
    {
        [Offset(0UL)]
        public uint Data1 { get => ReadHere<uint>(nameof(Data1)); set => WriteHere(nameof(Data1), value); }

        [Offset(4UL)]
        public ushort Data2 { get => ReadHere<ushort>(nameof(Data2)); set => WriteHere(nameof(Data2), value); }

        [Offset(6UL)]
        public ushort Data3 { get => ReadHere<ushort>(nameof(Data3)); set => WriteHere(nameof(Data3), value); }

        [Offset(8UL)]
        [Length(8)]
        public DynamicArray Data4 { get => ReadStructure<DynamicArray>(nameof(Data4)); set => WriteStructure(nameof(Data4), value); }

        public Guid(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Guid>();
        }
    }
}