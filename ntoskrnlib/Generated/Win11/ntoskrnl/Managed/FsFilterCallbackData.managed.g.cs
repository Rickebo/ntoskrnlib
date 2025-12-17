using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!_FS_FILTER_CALLBACK_DATA")]
    public sealed class FsFilterCallbackData : DynamicStructure
    {
        [Offset(0UL)]
        public uint SizeOfFsFilterCallbackData { get => ReadHere<uint>(nameof(SizeOfFsFilterCallbackData)); set => WriteHere(nameof(SizeOfFsFilterCallbackData), value); }

        [Offset(4UL)]
        public byte Operation { get => ReadHere<byte>(nameof(Operation)); set => WriteHere(nameof(Operation), value); }

        [Offset(5UL)]
        public byte Reserved { get => ReadHere<byte>(nameof(Reserved)); set => WriteHere(nameof(Reserved), value); }

        [Offset(8UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(16UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(24UL)]
        public FsFilterParameters Parameters { get => ReadStructure<FsFilterParameters>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        public FsFilterCallbackData(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FsFilterCallbackData>();
        }
    }
}