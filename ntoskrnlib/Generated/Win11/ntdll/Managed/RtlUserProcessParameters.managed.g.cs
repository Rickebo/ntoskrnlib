using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntdll
{
    [DynamicStructure("ntdll!_RTL_USER_PROCESS_PARAMETERS")]
    public sealed class RtlUserProcessParameters : DynamicStructure
    {
        [Offset(0UL)]
        public uint MaximumLength { get => ReadHere<uint>(nameof(MaximumLength)); set => WriteHere(nameof(MaximumLength), value); }

        [Offset(4UL)]
        public uint Length { get => ReadHere<uint>(nameof(Length)); set => WriteHere(nameof(Length), value); }

        [Offset(8UL)]
        public uint Flags { get => ReadHere<uint>(nameof(Flags)); set => WriteHere(nameof(Flags), value); }

        [Offset(12UL)]
        public uint DebugFlags { get => ReadHere<uint>(nameof(DebugFlags)); set => WriteHere(nameof(DebugFlags), value); }

        [Offset(16UL)]
        public IntPtr ConsoleHandle { get => ReadHere<IntPtr>(nameof(ConsoleHandle)); set => WriteHere(nameof(ConsoleHandle), value); }

        [Offset(24UL)]
        public uint ConsoleFlags { get => ReadHere<uint>(nameof(ConsoleFlags)); set => WriteHere(nameof(ConsoleFlags), value); }

        [Offset(32UL)]
        public IntPtr StandardInput { get => ReadHere<IntPtr>(nameof(StandardInput)); set => WriteHere(nameof(StandardInput), value); }

        [Offset(40UL)]
        public IntPtr StandardOutput { get => ReadHere<IntPtr>(nameof(StandardOutput)); set => WriteHere(nameof(StandardOutput), value); }

        [Offset(48UL)]
        public IntPtr StandardError { get => ReadHere<IntPtr>(nameof(StandardError)); set => WriteHere(nameof(StandardError), value); }

        [Offset(56UL)]
        public Curdir CurrentDirectory { get => ReadStructure<Curdir>(nameof(CurrentDirectory)); set => WriteStructure(nameof(CurrentDirectory), value); }

        [Offset(80UL)]
        public UnicodeString DllPath { get => ReadStructure<UnicodeString>(nameof(DllPath)); set => WriteStructure(nameof(DllPath), value); }

        [Offset(96UL)]
        public UnicodeString ImagePathName { get => ReadStructure<UnicodeString>(nameof(ImagePathName)); set => WriteStructure(nameof(ImagePathName), value); }

        [Offset(112UL)]
        public UnicodeString CommandLine { get => ReadStructure<UnicodeString>(nameof(CommandLine)); set => WriteStructure(nameof(CommandLine), value); }

        [Offset(128UL)]
        public IntPtr Environment { get => ReadHere<IntPtr>(nameof(Environment)); set => WriteHere(nameof(Environment), value); }

        [Offset(136UL)]
        public uint StartingX { get => ReadHere<uint>(nameof(StartingX)); set => WriteHere(nameof(StartingX), value); }

        [Offset(140UL)]
        public uint StartingY { get => ReadHere<uint>(nameof(StartingY)); set => WriteHere(nameof(StartingY), value); }

        [Offset(144UL)]
        public uint CountX { get => ReadHere<uint>(nameof(CountX)); set => WriteHere(nameof(CountX), value); }

        [Offset(148UL)]
        public uint CountY { get => ReadHere<uint>(nameof(CountY)); set => WriteHere(nameof(CountY), value); }

        [Offset(152UL)]
        public uint CountCharsX { get => ReadHere<uint>(nameof(CountCharsX)); set => WriteHere(nameof(CountCharsX), value); }

        [Offset(156UL)]
        public uint CountCharsY { get => ReadHere<uint>(nameof(CountCharsY)); set => WriteHere(nameof(CountCharsY), value); }

        [Offset(160UL)]
        public uint FillAttribute { get => ReadHere<uint>(nameof(FillAttribute)); set => WriteHere(nameof(FillAttribute), value); }

        [Offset(164UL)]
        public uint WindowFlags { get => ReadHere<uint>(nameof(WindowFlags)); set => WriteHere(nameof(WindowFlags), value); }

        [Offset(168UL)]
        public uint ShowWindowFlags { get => ReadHere<uint>(nameof(ShowWindowFlags)); set => WriteHere(nameof(ShowWindowFlags), value); }

        [Offset(176UL)]
        public UnicodeString WindowTitle { get => ReadStructure<UnicodeString>(nameof(WindowTitle)); set => WriteStructure(nameof(WindowTitle), value); }

        [Offset(192UL)]
        public UnicodeString DesktopInfo { get => ReadStructure<UnicodeString>(nameof(DesktopInfo)); set => WriteStructure(nameof(DesktopInfo), value); }

        [Offset(208UL)]
        public UnicodeString ShellInfo { get => ReadStructure<UnicodeString>(nameof(ShellInfo)); set => WriteStructure(nameof(ShellInfo), value); }

        [Offset(224UL)]
        public UnicodeString RuntimeData { get => ReadStructure<UnicodeString>(nameof(RuntimeData)); set => WriteStructure(nameof(RuntimeData), value); }

        [Offset(240UL)]
        [Length(32)]
        public DynamicArray CurrentDirectores { get => ReadStructure<DynamicArray>(nameof(CurrentDirectores)); set => WriteStructure(nameof(CurrentDirectores), value); }

        [Offset(1008UL)]
        public ulong EnvironmentSize { get => ReadHere<ulong>(nameof(EnvironmentSize)); set => WriteHere(nameof(EnvironmentSize), value); }

        [Offset(1016UL)]
        public ulong EnvironmentVersion { get => ReadHere<ulong>(nameof(EnvironmentVersion)); set => WriteHere(nameof(EnvironmentVersion), value); }

        [Offset(1024UL)]
        public IntPtr PackageDependencyData { get => ReadHere<IntPtr>(nameof(PackageDependencyData)); set => WriteHere(nameof(PackageDependencyData), value); }

        [Offset(1032UL)]
        public uint ProcessGroupId { get => ReadHere<uint>(nameof(ProcessGroupId)); set => WriteHere(nameof(ProcessGroupId), value); }

        [Offset(1036UL)]
        public uint LoaderThreads { get => ReadHere<uint>(nameof(LoaderThreads)); set => WriteHere(nameof(LoaderThreads), value); }

        [Offset(1040UL)]
        public UnicodeString RedirectionDllName { get => ReadStructure<UnicodeString>(nameof(RedirectionDllName)); set => WriteStructure(nameof(RedirectionDllName), value); }

        [Offset(1056UL)]
        public UnicodeString HeapPartitionName { get => ReadStructure<UnicodeString>(nameof(HeapPartitionName)); set => WriteStructure(nameof(HeapPartitionName), value); }

        [Offset(1072UL)]
        public IntPtr DefaultThreadpoolCpuSetMasks { get => ReadHere<IntPtr>(nameof(DefaultThreadpoolCpuSetMasks)); set => WriteHere(nameof(DefaultThreadpoolCpuSetMasks), value); }

        [Offset(1080UL)]
        public uint DefaultThreadpoolCpuSetMaskCount { get => ReadHere<uint>(nameof(DefaultThreadpoolCpuSetMaskCount)); set => WriteHere(nameof(DefaultThreadpoolCpuSetMaskCount), value); }

        [Offset(1084UL)]
        public uint DefaultThreadpoolThreadMaximum { get => ReadHere<uint>(nameof(DefaultThreadpoolThreadMaximum)); set => WriteHere(nameof(DefaultThreadpoolThreadMaximum), value); }

        [Offset(1088UL)]
        public uint HeapMemoryTypeMask { get => ReadHere<uint>(nameof(HeapMemoryTypeMask)); set => WriteHere(nameof(HeapMemoryTypeMask), value); }

        public RtlUserProcessParameters(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        [RegisterMethod]
        public static void Register()
        {
            DynamicStructure.Register<RtlUserProcessParameters>();
        }
    }
}