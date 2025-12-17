using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_POP_FX_LOG_ENTRY")]
    public sealed class PopFxLogEntry : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Timestamp { get => ReadHere<ulong>(nameof(Timestamp)); set => WriteHere(nameof(Timestamp), value); }

        [Offset(8UL)]
        public byte Operation { get => ReadHere<byte>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(9UL)]
        public byte Component { get => ReadHere<byte>(nameof(Component)); set => WriteHere(nameof(Component), value); }

        [Offset(10UL)]
        public ushort Processor { get => ReadHere<ushort>(nameof(Processor)); set => WriteHere(nameof(Processor), value); }

        [Offset(12UL)]
        public ushort Process { get => ReadHere<ushort>(nameof(Process)); set => WriteHere(nameof(Process), value); }

        [Offset(14UL)]
        public ushort Thread { get => ReadHere<ushort>(nameof(Thread)); set => WriteHere(nameof(Thread), value); }

        [Offset(16UL)]
        public ulong Information { get => ReadHere<ulong>(nameof(Information)); set => WriteHere(nameof(Information), value); }

        public PopFxLogEntry(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<PopFxLogEntry>();
        }
    }
}