using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TIMELINE_BITMAP")]
    public sealed class TimelineBitmap : DynamicStructure
    {
        [Offset(0UL)]
        public ulong Value { get => ReadHere<ulong>(nameof(Value)); set => WriteHere(nameof(Value), value); }

        [Offset(0UL)]
        public uint EndTime { get => ReadHere<uint>(nameof(EndTime)); set => WriteHere(nameof(EndTime), value); }

        [Offset(4UL)]
        public uint Bitmap { get => ReadHere<uint>(nameof(Bitmap)); set => WriteHere(nameof(Bitmap), value); }

        public TimelineBitmap(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TimelineBitmap>();
        }
    }
}