using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_PRIORITY_INFO")]
    public sealed class IoPriorityInfo : DynamicStructure
    {
        [Offset(0UL)]
        public uint Size { get => ReadHere<uint>(nameof(Size)); set => WriteHere(nameof(Size), value); }

        [Offset(4UL)]
        public uint ThreadPriority { get => ReadHere<uint>(nameof(ThreadPriority)); set => WriteHere(nameof(ThreadPriority), value); }

        [Offset(8UL)]
        public uint PagePriority { get => ReadHere<uint>(nameof(PagePriority)); set => WriteHere(nameof(PagePriority), value); }

        [Offset(12UL)]
        public uint IoPriority { get => ReadHere<uint>(nameof(IoPriority)); set => WriteHere(nameof(IoPriority), value); }

        public IoPriorityInfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoPriorityInfo>();
        }
    }
}