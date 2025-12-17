using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WNF_SILODRIVERSTATE")]
    public sealed class WnfSilodriverstate : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr ScopeMap { get => ReadHere<IntPtr>(nameof(ScopeMap)); set => WriteHere(nameof(ScopeMap), value); }

        [Offset(8UL)]
        public IntPtr PermanentNameStoreRootKey { get => ReadHere<IntPtr>(nameof(PermanentNameStoreRootKey)); set => WriteHere(nameof(PermanentNameStoreRootKey), value); }

        [Offset(16UL)]
        public IntPtr PersistentNameStoreRootKey { get => ReadHere<IntPtr>(nameof(PersistentNameStoreRootKey)); set => WriteHere(nameof(PersistentNameStoreRootKey), value); }

        [Offset(24UL)]
        public long PermanentNameSequenceNumber { get => ReadHere<long>(nameof(PermanentNameSequenceNumber)); set => WriteHere(nameof(PermanentNameSequenceNumber), value); }

        [Offset(32UL)]
        public WnfLock PermanentNameSequenceNumberLock { get => ReadStructure<WnfLock>(nameof(PermanentNameSequenceNumberLock)); set => WriteStructure(nameof(PermanentNameSequenceNumberLock), value); }

        [Offset(40UL)]
        public long PermanentNameSequenceNumberPool { get => ReadHere<long>(nameof(PermanentNameSequenceNumberPool)); set => WriteHere(nameof(PermanentNameSequenceNumberPool), value); }

        [Offset(48UL)]
        public long RuntimeNameSequenceNumber { get => ReadHere<long>(nameof(RuntimeNameSequenceNumber)); set => WriteHere(nameof(RuntimeNameSequenceNumber), value); }

        public WnfSilodriverstate(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WnfSilodriverstate>();
        }
    }
}