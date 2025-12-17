using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_TRIAGE_9F_POWER")]
    public sealed class Triage9FPower : DynamicStructure
    {
        [Offset(0UL)]
        public ushort Signature { get => ReadHere<ushort>(nameof(Signature)); set => WriteHere(nameof(Signature), value); }

        [Offset(2UL)]
        public ushort Revision { get => ReadHere<ushort>(nameof(Revision)); set => WriteHere(nameof(Revision), value); }

        [Offset(8UL)]
        public IntPtr IrpList { get => ReadHere<IntPtr>(nameof(IrpList)); set => WriteHere(nameof(IrpList), value); }

        [Offset(16UL)]
        public IntPtr ThreadList { get => ReadHere<IntPtr>(nameof(ThreadList)); set => WriteHere(nameof(ThreadList), value); }

        [Offset(24UL)]
        public IntPtr DelayedWorkQueue { get => ReadHere<IntPtr>(nameof(DelayedWorkQueue)); set => WriteHere(nameof(DelayedWorkQueue), value); }

        [Offset(32UL)]
        public IntPtr DelayedIoWorkQueue { get => ReadHere<IntPtr>(nameof(DelayedIoWorkQueue)); set => WriteHere(nameof(DelayedIoWorkQueue), value); }

        public Triage9FPower(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Triage9FPower>();
        }
    }
}