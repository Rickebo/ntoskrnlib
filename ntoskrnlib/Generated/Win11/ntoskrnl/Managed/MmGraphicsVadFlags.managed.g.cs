using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_MM_GRAPHICS_VAD_FLAGS")]
    public sealed class MmGraphicsVadFlags : DynamicStructure
    {
        [Offset(0UL)]
        public uint Lock { get => ReadHere<uint>(nameof(Lock)); set => WriteHere(nameof(Lock), value); }

        [Offset(0UL)]
        public uint LockContended { get => ReadHere<uint>(nameof(LockContended)); set => WriteHere(nameof(LockContended), value); }

        [Offset(0UL)]
        public uint DeleteInProgress { get => ReadHere<uint>(nameof(DeleteInProgress)); set => WriteHere(nameof(DeleteInProgress), value); }

        [Offset(0UL)]
        public uint NoChange { get => ReadHere<uint>(nameof(NoChange)); set => WriteHere(nameof(NoChange), value); }

        [Offset(0UL)]
        public uint VadType { get => ReadHere<uint>(nameof(VadType)); set => WriteHere(nameof(VadType), value); }

        [Offset(0UL)]
        public uint Protection { get => ReadHere<uint>(nameof(Protection)); set => WriteHere(nameof(Protection), value); }

        [Offset(0UL)]
        public uint PreferredNode { get => ReadHere<uint>(nameof(PreferredNode)); set => WriteHere(nameof(PreferredNode), value); }

        [Offset(0UL)]
        public uint PageSize { get => ReadHere<uint>(nameof(PageSize)); set => WriteHere(nameof(PageSize), value); }

        [Offset(0UL)]
        public uint PrivateMemoryAlwaysSet { get => ReadHere<uint>(nameof(PrivateMemoryAlwaysSet)); set => WriteHere(nameof(PrivateMemoryAlwaysSet), value); }

        [Offset(0UL)]
        public uint WriteWatch { get => ReadHere<uint>(nameof(WriteWatch)); set => WriteHere(nameof(WriteWatch), value); }

        [Offset(0UL)]
        public uint FixedLargePageSize { get => ReadHere<uint>(nameof(FixedLargePageSize)); set => WriteHere(nameof(FixedLargePageSize), value); }

        [Offset(0UL)]
        public uint ZeroFillPagesOptional { get => ReadHere<uint>(nameof(ZeroFillPagesOptional)); set => WriteHere(nameof(ZeroFillPagesOptional), value); }

        [Offset(0UL)]
        public uint MemCommit { get => ReadHere<uint>(nameof(MemCommit)); set => WriteHere(nameof(MemCommit), value); }

        [Offset(0UL)]
        public uint GraphicsAlwaysSet { get => ReadHere<uint>(nameof(GraphicsAlwaysSet)); set => WriteHere(nameof(GraphicsAlwaysSet), value); }

        [Offset(0UL)]
        public uint GraphicsUseCoherentBus { get => ReadHere<uint>(nameof(GraphicsUseCoherentBus)); set => WriteHere(nameof(GraphicsUseCoherentBus), value); }

        [Offset(0UL)]
        public uint GraphicsNoCache { get => ReadHere<uint>(nameof(GraphicsNoCache)); set => WriteHere(nameof(GraphicsNoCache), value); }

        [Offset(0UL)]
        public uint GraphicsPageProtection { get => ReadHere<uint>(nameof(GraphicsPageProtection)); set => WriteHere(nameof(GraphicsPageProtection), value); }

        public MmGraphicsVadFlags(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<MmGraphicsVadFlags>();
        }
    }
}