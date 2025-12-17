using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EVENT_RECORD")]
    public sealed class EventRecord : DynamicStructure
    {
        [Offset(0UL)]
        public EventHeader EventHeader { get => ReadStructure<EventHeader>(nameof(EventHeader)); set => WriteStructure(nameof(EventHeader), value); }

        [Offset(80UL)]
        public EtwBufferContext BufferContext { get => ReadStructure<EtwBufferContext>(nameof(BufferContext)); set => WriteStructure(nameof(BufferContext), value); }

        [Offset(84UL)]
        public ushort ExtendedDataCount { get => ReadHere<ushort>(nameof(ExtendedDataCount)); set => WriteHere(nameof(ExtendedDataCount), value); }

        [Offset(86UL)]
        public ushort UserDataLength { get => ReadHere<ushort>(nameof(UserDataLength)); set => WriteHere(nameof(UserDataLength), value); }

        [Offset(88UL)]
        public IntPtr ExtendedData { get => ReadHere<IntPtr>(nameof(ExtendedData)); set => WriteHere(nameof(ExtendedData), value); }

        [Offset(96UL)]
        public IntPtr UserData { get => ReadHere<IntPtr>(nameof(UserData)); set => WriteHere(nameof(UserData), value); }

        [Offset(104UL)]
        public IntPtr UserContext { get => ReadHere<IntPtr>(nameof(UserContext)); set => WriteHere(nameof(UserContext), value); }

        public EventRecord(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventRecord>();
        }
    }
}