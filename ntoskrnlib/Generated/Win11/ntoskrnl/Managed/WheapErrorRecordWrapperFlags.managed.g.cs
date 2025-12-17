using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_WHEAP_ERROR_RECORD_WRAPPER_FLAGS")]
    public sealed class WheapErrorRecordWrapperFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Preallocated { get => ReadHere<uint>(nameof(Preallocated)); set => WriteHere(nameof(Preallocated), value); }

        [Offset(0UL)]
        public uint FromPersistentStore { get => ReadHere<uint>(nameof(FromPersistentStore)); set => WriteHere(nameof(FromPersistentStore), value); }

        [Offset(0UL)]
        public uint PlatformPfaControl { get => ReadHere<uint>(nameof(PlatformPfaControl)); set => WriteHere(nameof(PlatformPfaControl), value); }

        [Offset(0UL)]
        public uint PlatformDirectedOffline { get => ReadHere<uint>(nameof(PlatformDirectedOffline)); set => WriteHere(nameof(PlatformDirectedOffline), value); }

        [Offset(0UL)]
        public uint Reserved { get => ReadHere<uint>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(0UL)]
        public uint AsULONG { get => ReadHere<uint>(nameof(AsULONG)); set => WriteHere(nameof(AsULONG), value); }

        public WheapErrorRecordWrapperFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<WheapErrorRecordWrapperFlags>();
        }
    }
}