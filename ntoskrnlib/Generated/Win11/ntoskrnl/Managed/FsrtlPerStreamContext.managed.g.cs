using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FSRTL_PER_STREAM_CONTEXT")]
    public sealed class FsrtlPerStreamContext : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry Links { get => ReadStructure<ListEntry>(nameof(Links)); set => WriteStructure(nameof(Links), value); }

        [Offset(16UL)]
        public IntPtr OwnerId { get => ReadHere<IntPtr>(nameof(OwnerId)); set => WriteHere(nameof(OwnerId), value); }

        [Offset(24UL)]
        public IntPtr InstanceId { get => ReadHere<IntPtr>(nameof(InstanceId)); set => WriteHere(nameof(InstanceId), value); }

        [Offset(32UL)]
        public IntPtr FreeCallback { get => ReadHere<IntPtr>(nameof(FreeCallback)); set => WriteHere(nameof(FreeCallback), value); }

        public FsrtlPerStreamContext(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsrtlPerStreamContext>();
        }
    }
}