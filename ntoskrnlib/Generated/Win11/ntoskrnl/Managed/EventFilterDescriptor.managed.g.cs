using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_EVENT_FILTER_DESCRIPTOR")]
    public sealed class EventFilterDescriptor : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Ptr { get => ReadHere<ulong>(nameof(Ptr)); set => WriteHere(nameof(Ptr), value); }

        [Offset(8UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(12UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        public EventFilterDescriptor(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventFilterDescriptor>();
        }
    }
}