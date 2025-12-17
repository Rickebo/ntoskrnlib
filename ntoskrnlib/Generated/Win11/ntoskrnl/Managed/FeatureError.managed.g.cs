using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl
{
    [DynamicStructure("ntoskrnl!FEATURE_ERROR")]
    public sealed class FeatureError : DynamicStructure
    {
        [Offset(0UL)]
        public int hr { get => ReadHere<int>(nameof(hr)); set => WriteHere(nameof(hr), value); }

        [Offset(4UL)]
        public ushort lineNumber { get => ReadHere<ushort>(nameof(lineNumber)); set => WriteHere(nameof(lineNumber), value); }

        [Offset(8UL)]
        public IntPtr file { get => ReadHere<IntPtr>(nameof(file)); set => WriteHere(nameof(file), value); }

        [Offset(16UL)]
        public IntPtr process { get => ReadHere<IntPtr>(nameof(process)); set => WriteHere(nameof(process), value); }

        [Offset(24UL)]
        public IntPtr modulePath { get => ReadHere<IntPtr>(nameof(modulePath)); set => WriteHere(nameof(modulePath), value); }

        [Offset(32UL)]
        public uint callerReturnAddressOffset { get => ReadHere<uint>(nameof(callerReturnAddressOffset)); set => WriteHere(nameof(callerReturnAddressOffset), value); }

        [Offset(40UL)]
        public IntPtr callerModule { get => ReadHere<IntPtr>(nameof(callerModule)); set => WriteHere(nameof(callerModule), value); }

        [Offset(48UL)]
        public IntPtr message { get => ReadHere<IntPtr>(nameof(message)); set => WriteHere(nameof(message), value); }

        [Offset(56UL)]
        public ushort originLineNumber { get => ReadHere<ushort>(nameof(originLineNumber)); set => WriteHere(nameof(originLineNumber), value); }

        [Offset(64UL)]
        public IntPtr originFile { get => ReadHere<IntPtr>(nameof(originFile)); set => WriteHere(nameof(originFile), value); }

        [Offset(72UL)]
        public IntPtr originModule { get => ReadHere<IntPtr>(nameof(originModule)); set => WriteHere(nameof(originModule), value); }

        [Offset(80UL)]
        public uint originCallerReturnAddressOffset { get => ReadHere<uint>(nameof(originCallerReturnAddressOffset)); set => WriteHere(nameof(originCallerReturnAddressOffset), value); }

        [Offset(88UL)]
        public IntPtr originCallerModule { get => ReadHere<IntPtr>(nameof(originCallerModule)); set => WriteHere(nameof(originCallerModule), value); }

        [Offset(96UL)]
        public IntPtr originName { get => ReadHere<IntPtr>(nameof(originName)); set => WriteHere(nameof(originName), value); }

        public FeatureError(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<FeatureError>();
        }
    }
}