using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_AWEINFO")]
    public sealed class Aweinfo : DynamicStructure
    {
        [Offset(0UL)]
        public IntPtr AweInfoSignature { get => ReadHere<IntPtr>(nameof(AweInfoSignature)); set => WriteHere(nameof(AweInfoSignature), value); }

        [Offset(8UL)]
        public MiAweinfoFlags Flags { get => ReadStructure<MiAweinfoFlags>(nameof(Flags)); set => WriteStructure(nameof(Flags), value); }

        [Offset(16UL)]
        public ulong PageSize { get => ReadHere<ulong>(nameof(PageSize)); set => WriteHere(nameof(PageSize), value); }

        [Offset(24UL)]
        public RtlBitmapEx VadPhysicalPagesBitMap { get => ReadStructure<RtlBitmapEx>(nameof(VadPhysicalPagesBitMap)); set => WriteStructure(nameof(VadPhysicalPagesBitMap), value); }

        [Offset(40UL)]
        public IntPtr ControlArea { get => ReadHere<IntPtr>(nameof(ControlArea)); set => WriteHere(nameof(ControlArea), value); }

        [Offset(48UL)]
        public int ChangeClusterAttributeLock { get => ReadHere<int>(nameof(ChangeClusterAttributeLock)); set => WriteHere(nameof(ChangeClusterAttributeLock), value); }

        [Offset(52UL)]
        public uint CacheAttribute { get => ReadHere<uint>(nameof(CacheAttribute)); set => WriteHere(nameof(CacheAttribute), value); }

        [Offset(64UL)]
        public ExPushLockAutoExpand AwePagesLock { get => ReadStructure<ExPushLockAutoExpand>(nameof(AwePagesLock)); set => WriteStructure(nameof(AwePagesLock), value); }

        [Offset(80UL)]
        public IntPtr ChangeClusterAttributeWaitList { get => ReadHere<IntPtr>(nameof(ChangeClusterAttributeWaitList)); set => WriteHere(nameof(ChangeClusterAttributeWaitList), value); }

        public Aweinfo(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<Aweinfo>();
        }
    }
}