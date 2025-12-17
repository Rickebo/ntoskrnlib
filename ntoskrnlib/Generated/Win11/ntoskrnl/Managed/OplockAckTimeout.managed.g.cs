using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_OPLOCK_ACK_TIMEOUT")]
    public sealed class OplockAckTimeout : DynamicStructure
    {
        [Offset(0UL)]
        public Ktimer Timer { get => ReadStructure<Ktimer>(nameof(Timer)); set => WriteStructure(nameof(Timer), value); }

        [Offset(64UL)]
        public Kdpc Dpc { get => ReadStructure<Kdpc>(nameof(Dpc)); set => WriteStructure(nameof(Dpc), value); }

        [Offset(128UL)]
        public WorkQueueItem WorkItem { get => ReadStructure<WorkQueueItem>(nameof(WorkItem)); set => WriteStructure(nameof(WorkItem), value); }

        [Offset(160UL)]
        public IntPtr Oplock { get => ReadHere<IntPtr>(nameof(Oplock)); set => WriteHere(nameof(Oplock), value); }

        [Offset(168UL)]
        public IntPtr OplockRequestFileObject { get => ReadHere<IntPtr>(nameof(OplockRequestFileObject)); set => WriteHere(nameof(OplockRequestFileObject), value); }

        [Offset(176UL)]
        public uint OplockOwnerIntegrityLevel { get => ReadHere<uint>(nameof(OplockOwnerIntegrityLevel)); set => WriteHere(nameof(OplockOwnerIntegrityLevel), value); }

        [Offset(180UL)]
        public byte TimerSet { get => ReadHere<byte>(nameof(TimerSet)); set => WriteHere(nameof(TimerSet), value); }

        [Offset(181UL)]
        public byte AckDone { get => ReadHere<byte>(nameof(AckDone)); set => WriteHere(nameof(AckDone), value); }

        public OplockAckTimeout(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<OplockAckTimeout>();
        }
    }
}