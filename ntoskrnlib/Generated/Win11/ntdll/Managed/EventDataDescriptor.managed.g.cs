using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EVENT_DATA_DESCRIPTOR")]
    public sealed class EventDataDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Ptr { get => ReadHere<ulong>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(12UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(12UL)]
        public byte Type { get => ReadHere<byte>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(13UL)]
        public byte Reserved1 { get => ReadHere<byte>(nameof(Reserved1)); set => WriteHere(nameof(Reserved1), value); }

        [Offset(14UL)]
        public ushort Reserved2 { get => ReadHere<ushort>(nameof(Reserved2)); set => WriteHere(nameof(Reserved2), value); }

        public EventDataDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventDataDescriptor>();
        }
    }
}