using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_TPP_CLEANUP_GROUP_MEMBER_VFUNCS")]
    public sealed class TppCleanupGroupMemberVfuncs : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr Free { get => ReadHere<IntPtr>(nameof(Free)); set => WriteHere(nameof(Free), value); }

        [Offset(8UL)]
        public IntPtr CallbackEpilog { get => ReadHere<IntPtr>(nameof(CallbackEpilog)); set => WriteHere(nameof(CallbackEpilog), value); }

        [Offset(16UL)]
        public IntPtr StopCallbackGeneration { get => ReadHere<IntPtr>(nameof(StopCallbackGeneration)); set => WriteHere(nameof(StopCallbackGeneration), value); }

        [Offset(24UL)]
        public IntPtr CancelPendingCallbacks { get => ReadHere<IntPtr>(nameof(CancelPendingCallbacks)); set => WriteHere(nameof(CancelPendingCallbacks), value); }

        public TppCleanupGroupMemberVfuncs(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<TppCleanupGroupMemberVfuncs>();
        }
    }
}