using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_HEADER")]
    public sealed class EventFilterHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Id { get => ReadHere<ushort>(nameof(Id)); set => WriteHere(nameof(Id), value); }

        [Offset(2UL)]
        public byte Version { get => ReadHere<byte>(nameof(Version)); set => WriteHere(nameof(Version), value); }

        [Offset(3UL)]
        [Length(5)]
        public DynamicArray Reserved { get => ReadStructure<DynamicArray>(nameof(Reserved)); set => WriteStructure(nameof(Reserved), value); }

        [Offset(8UL)]
        public ulong InstanceId { get => ReadHere<ulong>(nameof(InstanceId)); set => WriteHere(nameof(InstanceId), value); }

        [Offset(16UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(20UL)]
        public uint NextOffset { get => ReadHere<uint>(nameof(NextOffset)); set => WriteHere(nameof(NextOffset), value); }

        public EventFilterHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventFilterHeader>();
        }
    }
}