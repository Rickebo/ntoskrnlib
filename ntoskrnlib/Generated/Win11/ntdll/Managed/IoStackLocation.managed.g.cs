using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_IO_STACK_LOCATION")]
    public sealed class IoStackLocation : DynamicStructure
    {
        [Offset(0UL)]
        public byte MajorFunction { get => ReadHere<byte>(nameof(MajorFunction)); set => WriteHere(nameof(MajorFunction), value); }

        [Offset(1UL)]
        public byte MinorFunction { get => ReadHere<byte>(nameof(MinorFunction)); set => WriteHere(nameof(MinorFunction), value); }

        [Offset(2UL)]
        public byte Flags { get => ReadHere<byte>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(3UL)]
        public byte Control { get => ReadHere<byte>(nameof(Control)); set => WriteHere(nameof(Control), value); }

        [Offset(8UL)]
        public UnnamedTag Parameters { get => ReadStructure<UnnamedTag>(nameof(Parameters)); set => WriteStructure(nameof(Parameters), value); }

        [Offset(40UL)]
        public IntPtr DeviceObject { get => ReadHere<IntPtr>(nameof(DeviceObject)); set => WriteHere(nameof(DeviceObject), value); }

        [Offset(48UL)]
        public IntPtr FileObject { get => ReadHere<IntPtr>(nameof(FileObject)); set => WriteHere(nameof(FileObject), value); }

        [Offset(56UL)]
        public IntPtr CompletionRoutine { get => ReadHere<IntPtr>(nameof(CompletionRoutine)); set => WriteHere(nameof(CompletionRoutine), value); }

        [Offset(64UL)]
        public IntPtr Context { get => ReadHere<IntPtr>(nameof(Context)); set => WriteHere(nameof(Context), value); }

        public IoStackLocation(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<IoStackLocation>();
        }
    }
}