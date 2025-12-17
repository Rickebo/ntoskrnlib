using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FAST_IO_DISPATCH")]
    public sealed class FastIoDispatch : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfFastIoDispatch { get => ReadHere<uint>(nameof(SizeOfFastIoDispatch)); set => WriteHere(nameof(SizeOfFastIoDispatch), value); }

        [Offset(8UL)]
        public IntPtr FastIoCheckIfPossible { get => ReadHere<IntPtr>(nameof(FastIoCheckIfPossible)); set => WriteHere(nameof(FastIoCheckIfPossible), value); }

        [Offset(16UL)]
        public IntPtr FastIoRead { get => ReadHere<IntPtr>(nameof(FastIoRead)); set => WriteHere(nameof(FastIoRead), value); }

        [Offset(24UL)]
        public IntPtr FastIoWrite { get => ReadHere<IntPtr>(nameof(FastIoWrite)); set => WriteHere(nameof(FastIoWrite), value); }

        [Offset(32UL)]
        public IntPtr FastIoQueryBasicInfo { get => ReadHere<IntPtr>(nameof(FastIoQueryBasicInfo)); set => WriteHere(nameof(FastIoQueryBasicInfo), value); }

        [Offset(40UL)]
        public IntPtr FastIoQueryStandardInfo { get => ReadHere<IntPtr>(nameof(FastIoQueryStandardInfo)); set => WriteHere(nameof(FastIoQueryStandardInfo), value); }

        [Offset(48UL)]
        public IntPtr FastIoLock { get => ReadHere<IntPtr>(nameof(FastIoLock)); set => WriteHere(nameof(FastIoLock), value); }

        [Offset(56UL)]
        public IntPtr FastIoUnlockSingle { get => ReadHere<IntPtr>(nameof(FastIoUnlockSingle)); set => WriteHere(nameof(FastIoUnlockSingle), value); }

        [Offset(64UL)]
        public IntPtr FastIoUnlockAll { get => ReadHere<IntPtr>(nameof(FastIoUnlockAll)); set => WriteHere(nameof(FastIoUnlockAll), value); }

        [Offset(72UL)]
        public IntPtr FastIoUnlockAllByKey { get => ReadHere<IntPtr>(nameof(FastIoUnlockAllByKey)); set => WriteHere(nameof(FastIoUnlockAllByKey), value); }

        [Offset(80UL)]
        public IntPtr FastIoDeviceControl { get => ReadHere<IntPtr>(nameof(FastIoDeviceControl)); set => WriteHere(nameof(FastIoDeviceControl), value); }

        [Offset(88UL)]
        public IntPtr AcquireFileForNtCreateSection { get => ReadHere<IntPtr>(nameof(AcquireFileForNtCreateSection)); set => WriteHere(nameof(AcquireFileForNtCreateSection), value); }

        [Offset(96UL)]
        public IntPtr ReleaseFileForNtCreateSection { get => ReadHere<IntPtr>(nameof(ReleaseFileForNtCreateSection)); set => WriteHere(nameof(ReleaseFileForNtCreateSection), value); }

        [Offset(104UL)]
        public IntPtr FastIoDetachDevice { get => ReadHere<IntPtr>(nameof(FastIoDetachDevice)); set => WriteHere(nameof(FastIoDetachDevice), value); }

        [Offset(112UL)]
        public IntPtr FastIoQueryNetworkOpenInfo { get => ReadHere<IntPtr>(nameof(FastIoQueryNetworkOpenInfo)); set => WriteHere(nameof(FastIoQueryNetworkOpenInfo), value); }

        [Offset(120UL)]
        public IntPtr AcquireForModWrite { get => ReadHere<IntPtr>(nameof(AcquireForModWrite)); set => WriteHere(nameof(AcquireForModWrite), value); }

        [Offset(128UL)]
        public IntPtr MdlRead { get => ReadHere<IntPtr>(nameof(MdlRead)); set => WriteHere(nameof(MdlRead), value); }

        [Offset(136UL)]
        public IntPtr MdlReadComplete { get => ReadHere<IntPtr>(nameof(MdlReadComplete)); set => WriteHere(nameof(MdlReadComplete), value); }

        [Offset(144UL)]
        public IntPtr PrepareMdlWrite { get => ReadHere<IntPtr>(nameof(PrepareMdlWrite)); set => WriteHere(nameof(PrepareMdlWrite), value); }

        [Offset(152UL)]
        public IntPtr MdlWriteComplete { get => ReadHere<IntPtr>(nameof(MdlWriteComplete)); set => WriteHere(nameof(MdlWriteComplete), value); }

        [Offset(160UL)]
        public IntPtr FastIoReadCompressed { get => ReadHere<IntPtr>(nameof(FastIoReadCompressed)); set => WriteHere(nameof(FastIoReadCompressed), value); }

        [Offset(168UL)]
        public IntPtr FastIoWriteCompressed { get => ReadHere<IntPtr>(nameof(FastIoWriteCompressed)); set => WriteHere(nameof(FastIoWriteCompressed), value); }

        [Offset(176UL)]
        public IntPtr MdlReadCompleteCompressed { get => ReadHere<IntPtr>(nameof(MdlReadCompleteCompressed)); set => WriteHere(nameof(MdlReadCompleteCompressed), value); }

        [Offset(184UL)]
        public IntPtr MdlWriteCompleteCompressed { get => ReadHere<IntPtr>(nameof(MdlWriteCompleteCompressed)); set => WriteHere(nameof(MdlWriteCompleteCompressed), value); }

        [Offset(192UL)]
        public IntPtr FastIoQueryOpen { get => ReadHere<IntPtr>(nameof(FastIoQueryOpen)); set => WriteHere(nameof(FastIoQueryOpen), value); }

        [Offset(200UL)]
        public IntPtr ReleaseForModWrite { get => ReadHere<IntPtr>(nameof(ReleaseForModWrite)); set => WriteHere(nameof(ReleaseForModWrite), value); }

        [Offset(208UL)]
        public IntPtr AcquireForCcFlush { get => ReadHere<IntPtr>(nameof(AcquireForCcFlush)); set => WriteHere(nameof(AcquireForCcFlush), value); }

        [Offset(216UL)]
        public IntPtr ReleaseForCcFlush { get => ReadHere<IntPtr>(nameof(ReleaseForCcFlush)); set => WriteHere(nameof(ReleaseForCcFlush), value); }

        public FastIoDispatch(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FastIoDispatch>();
        }
    }
}