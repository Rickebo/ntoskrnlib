using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_EVENT_HEADER")]
    public sealed class EventHeader : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Size { get => ReadHere<ushort>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(2UL)]
        public ushort HeaderType { get => ReadHere<ushort>(nameof(HeaderType)); set => WriteHere(nameof(HeaderType), value); }

        [Offset(4UL)]
        public ushort Flags { get => ReadHere<ushort>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(6UL)]
        public ushort EventProperty { get => ReadHere<ushort>(nameof(EventProperty)); set => WriteHere(nameof(EventProperty), value); }

        [Offset(8UL)]
        public uint ThreadId { get => ReadHere<uint>(nameof(ThreadId)); set => WriteHere(nameof(ThreadId), value); }

        [Offset(12UL)]
        public uint ProcessId { get => ReadHere<uint>(nameof(ProcessId)); set => WriteHere(nameof(ProcessId), value); }

        [Offset(16UL)]
        public LargeInteger TimeStamp { get => ReadStructure<LargeInteger>(nameof(TimeStamp)); set => WriteStructure(nameof(TimeStamp), value); }

        [Offset(24UL)]
        public Guid ProviderId { get => ReadStructure<Guid>(nameof(ProviderId)); set => WriteStructure(nameof(ProviderId), value); }

        [Offset(40UL)]
        public EventDescriptor EventDescriptor { get => ReadStructure<EventDescriptor>(nameof(EventDescriptor)); set => WriteStructure(nameof(EventDescriptor), value); }

        [Offset(56UL)]
        public uint KernelTime { get => ReadHere<uint>(nameof(KernelTime)); set => WriteHere(nameof(KernelTime), value); }

        [Offset(60UL)]
        public uint UserTime { get => ReadHere<uint>(nameof(UserTime)); set => WriteHere(nameof(UserTime), value); }

        [Offset(56UL)]
        public ulong ProcessorTime { get => ReadHere<ulong>(nameof(ProcessorTime)); set => WriteHere(nameof(ProcessorTime), value); }

        [Offset(64UL)]
        public Guid ActivityId { get => ReadStructure<Guid>(nameof(ActivityId)); set => WriteStructure(nameof(ActivityId), value); }

        public EventHeader(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EventHeader>();
        }
    }
}