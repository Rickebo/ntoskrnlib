using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_9F_PNP")]
    public sealed class Triage9FPnp : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Revision { get => ReadHere<ushort>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(8UL)]
        public IntPtr CompletionQueue { get => ReadHere<IntPtr>(nameof(CompletionQueue)); set => WriteHere(nameof(CompletionQueue), value); }

        [Offset(16UL)]
        public IntPtr DelayedWorkQueue { get => ReadHere<IntPtr>(nameof(DelayedWorkQueue)); set => WriteHere(nameof(DelayedWorkQueue), value); }

        [Offset(24UL)]
        public IntPtr DelayedIoWorkQueue { get => ReadHere<IntPtr>(nameof(DelayedIoWorkQueue)); set => WriteHere(nameof(DelayedIoWorkQueue), value); }

        [Offset(32UL)]
        public IntPtr DeviceNode { get => ReadHere<IntPtr>(nameof(DeviceNode)); set => WriteHere(nameof(DeviceNode), value); }

        public Triage9FPnp(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Triage9FPnp>();
        }
    }
}