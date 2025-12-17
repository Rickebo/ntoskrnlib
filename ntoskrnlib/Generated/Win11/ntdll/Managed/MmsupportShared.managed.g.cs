using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_MMSUPPORT_SHARED")]
    public sealed class MmsupportShared : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr WorkingSetLockArray { get => ReadHere<IntPtr>(nameof(WorkingSetLockArray)); set => WriteHere(nameof(WorkingSetLockArray), value); }

        [Offset(8UL)]
        public ulong ReleasedCommitDebt { get => ReadHere<ulong>(nameof(ReleasedCommitDebt)); set => WriteHere(nameof(ReleasedCommitDebt), value); }

        [Offset(16UL)]
        public ulong ResetPagesRepurposedCount { get => ReadHere<ulong>(nameof(ResetPagesRepurposedCount)); set => WriteHere(nameof(ResetPagesRepurposedCount), value); }

        [Offset(24UL)]
        public IntPtr WsSwapSupport { get => ReadHere<IntPtr>(nameof(WsSwapSupport)); set => WriteHere(nameof(WsSwapSupport), value); }

        [Offset(32UL)]
        public IntPtr CommitReleaseContext { get => ReadHere<IntPtr>(nameof(CommitReleaseContext)); set => WriteHere(nameof(CommitReleaseContext), value); }

        [Offset(40UL)]
        public IntPtr AccessLog { get => ReadHere<IntPtr>(nameof(AccessLog)); set => WriteHere(nameof(AccessLog), value); }

        [Offset(48UL)]
        public ulong ChargedWslePages { get => ReadHere<ulong>(nameof(ChargedWslePages)); set => WriteHere(nameof(ChargedWslePages), value); }

        [Offset(56UL)]
        public ulong ActualWslePages { get => ReadHere<ulong>(nameof(ActualWslePages)); set => WriteHere(nameof(ActualWslePages), value); }

        [Offset(64UL)]
        public int WorkingSetCoreLock { get => ReadHere<int>(nameof(WorkingSetCoreLock)); set => WriteHere(nameof(WorkingSetCoreLock), value); }

        [Offset(72UL)]
        public IntPtr ShadowMapping { get => ReadHere<IntPtr>(nameof(ShadowMapping)); set => WriteHere(nameof(ShadowMapping), value); }

        public MmsupportShared(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmsupportShared>();
        }
    }
}