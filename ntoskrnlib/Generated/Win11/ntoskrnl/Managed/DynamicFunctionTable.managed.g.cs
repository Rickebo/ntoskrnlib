using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_DYNAMIC_FUNCTION_TABLE")]
    public sealed class DynamicFunctionTable : DynamicStructure
    {
        [Offset(0UL)]
        public ListEntry ListEntry { get => ReadStructure<ListEntry>(nameof(ListEntry)); set => WriteStructure(nameof(ListEntry), value); }

        [Offset(16UL)]
        public IntPtr FunctionTable { get => ReadHere<IntPtr>(nameof(FunctionTable)); set => WriteHere(nameof(FunctionTable), value); }

        [Offset(24UL)]
        public LargeInteger TimeStamp { get => ReadStructure<LargeInteger>(nameof(TimeStamp)); set => WriteStructure(nameof(TimeStamp), value); }

        [Offset(32UL)]
        public ulong MinimumAddress { get => ReadHere<ulong>(nameof(MinimumAddress)); set => WriteHere(nameof(MinimumAddress), value); }

        [Offset(40UL)]
        public ulong MaximumAddress { get => ReadHere<ulong>(nameof(MaximumAddress)); set => WriteHere(nameof(MaximumAddress), value); }

        [Offset(48UL)]
        public ulong BaseAddress { get => ReadHere<ulong>(nameof(BaseAddress)); set => WriteHere(nameof(BaseAddress), value); }

        [Offset(56UL)]
        public IntPtr Callback { get => ReadHere<IntPtr>(nameof(Callback)); set => WriteHere(nameof(Callback), value); }

        [Offset(64UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        [Offset(72UL)]
        public IntPtr OutOfProcessCallbackDll { get => ReadHere<IntPtr>(nameof(OutOfProcessCallbackDll)); set => WriteHere(nameof(OutOfProcessCallbackDll), value); }

        [Offset(80UL)]
        public uint Type { get => ReadHere<uint>(nameof(Type)); set => WriteHere(nameof(Type), value); }

        [Offset(84UL)]
        public uint EntryCount { get => ReadHere<uint>(nameof(EntryCount)); set => WriteHere(nameof(EntryCount), value); }

        [Offset(88UL)]
        public RtlBalancedNode TreeNodeMin { get => ReadStructure<RtlBalancedNode>(nameof(TreeNodeMin)); set => WriteStructure(nameof(TreeNodeMin), value); }

        [Offset(112UL)]
        public RtlBalancedNode TreeNodeMax { get => ReadStructure<RtlBalancedNode>(nameof(TreeNodeMax)); set => WriteStructure(nameof(TreeNodeMax), value); }

        public DynamicFunctionTable(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<DynamicFunctionTable>();
        }
    }
}