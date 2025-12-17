using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_WORKER_FACTORY_DEFERRED_WORK")]
    public sealed class WorkerFactoryDeferredWork : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AlpcSendMessage { get => ReadHere<IntPtr>(nameof(AlpcSendMessage)); set => WriteHere(nameof(AlpcSendMessage), value); }

        [Offset(8UL)]
        public IntPtr AlpcSendMessagePort { get => ReadHere<IntPtr>(nameof(AlpcSendMessagePort)); set => WriteHere(nameof(AlpcSendMessagePort), value); }

        [Offset(16UL)]
        public uint AlpcSendMessageFlags { get => ReadHere<uint>(nameof(AlpcSendMessageFlags)); set => WriteHere(nameof(AlpcSendMessageFlags), value); }

        [Offset(20UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        public WorkerFactoryDeferredWork(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WorkerFactoryDeferredWork>();
        }
    }
}