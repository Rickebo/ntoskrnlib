using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_REMOTE_PORT_VIEW")]
    public sealed class RemotePortView : DynamicStructure
    {
        [Offset(0UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public ulong ViewSize { get => ReadHere<ulong>(nameof(ViewSize)); set => WriteHere(nameof(ViewSize), value); }

        [Offset(16UL)]
        public IntPtr ViewBase { get => ReadHere<IntPtr>(nameof(ViewBase)); set => WriteHere(nameof(ViewBase), value); }

        public RemotePortView(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RemotePortView>();
        }
    }
}