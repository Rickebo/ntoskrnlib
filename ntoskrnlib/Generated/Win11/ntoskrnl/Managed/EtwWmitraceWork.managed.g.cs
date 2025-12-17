using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_ETW_WMITRACE_WORK")]
    public sealed class EtwWmitraceWork : DynamicStructure
    {
        [Offset(0UL)]
        public uint LoggerId { get => ReadHere<uint>(nameof(LoggerId)); set => WriteHere(nameof(LoggerId), value); }

        [Offset(4UL)]
        public uint SiloSessionId { get => ReadHere<uint>(nameof(SiloSessionId)); set => WriteHere(nameof(SiloSessionId), value); }

        [Offset(8UL)]
        [Length(65)]
        public DynamicArray LoggerName { get => ReadStructure<DynamicArray>(nameof(LoggerName)); set => WriteStructure(nameof(LoggerName), value); }

        [Offset(73UL)]
        [Length(129)]
        public DynamicArray FileName { get => ReadStructure<DynamicArray>(nameof(FileName)); set => WriteStructure(nameof(FileName), value); }

        [Offset(204UL)]
        public uint MaximumFileSize { get => ReadHere<uint>(nameof(MaximumFileSize)); set => WriteHere(nameof(MaximumFileSize), value); }

        [Offset(208UL)]
        public uint MinBuffers { get => ReadHere<uint>(nameof(MinBuffers)); set => WriteHere(nameof(MinBuffers), value); }

        [Offset(212UL)]
        public uint MaxBuffers { get => ReadHere<uint>(nameof(MaxBuffers)); set => WriteHere(nameof(MaxBuffers), value); }

        [Offset(216UL)]
        public uint BufferSize { get => ReadHere<uint>(nameof(BufferSize)); set => WriteHere(nameof(BufferSize), value); }

        [Offset(220UL)]
        public uint Mode { get => ReadHere<uint>(nameof(Mode)); set => WriteHere(nameof(Mode), value); }

        [Offset(224UL)]
        public uint FlushTimer { get => ReadHere<uint>(nameof(FlushTimer)); set => WriteHere(nameof(FlushTimer), value); }

        [Offset(8UL)]
        public ulong MatchAny { get => ReadHere<ulong>(nameof(MatchAny)); set => WriteHere(nameof(MatchAny), value); }

        [Offset(16UL)]
        public ulong MatchAll { get => ReadHere<ulong>(nameof(MatchAll)); set => WriteHere(nameof(MatchAll), value); }

        [Offset(24UL)]
        public uint EnableProperty { get => ReadHere<uint>(nameof(EnableProperty)); set => WriteHere(nameof(EnableProperty), value); }

        [Offset(28UL)]
        public Guid Guid { get => ReadStructure<Guid>(nameof(Guid)); set => WriteStructure(nameof(Guid), value); }

        [Offset(44UL)]
        public byte Level { get => ReadHere<byte>(nameof(Level)); set => WriteHere(nameof(Level), value); }

        [Offset(232UL)]
        public int Status { get => ReadHere<int>(nameof(Status)); set => WriteHere(nameof(Status), value); }

        public EtwWmitraceWork(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<EtwWmitraceWork>();
        }
    }
}