using System;
using System.Collections.Generic;
using ntoskrnlib.Structure;

namespace ntoskrnlib.Win11.ntoskrnl.Dynamic
{
    [DynamicStructure("ntoskrnl!_RTL_USER_PROCESS_PARAMETERS")]
    public sealed class _RTL_USER_PROCESS_PARAMETERS : DynamicStructure
    {
        public uint MaximumLength { get; }
        public uint Length { get; }
        public uint Flags { get; }
        public uint DebugFlags { get; }
        public IntPtr ConsoleHandle { get; }
        public uint ConsoleFlags { get; }
        public IntPtr StandardInput { get; }
        public IntPtr StandardOutput { get; }
        public IntPtr StandardError { get; }
        public _CURDIR CurrentDirectory { get; }
        public _UNICODE_STRING DllPath { get; }
        public _UNICODE_STRING ImagePathName { get; }
        public _UNICODE_STRING CommandLine { get; }
        public IntPtr Environment { get; }
        public uint StartingX { get; }
        public uint StartingY { get; }
        public uint CountX { get; }
        public uint CountY { get; }
        public uint CountCharsX { get; }
        public uint CountCharsY { get; }
        public uint FillAttribute { get; }
        public uint WindowFlags { get; }
        public uint ShowWindowFlags { get; }
        public _UNICODE_STRING WindowTitle { get; }
        public _UNICODE_STRING DesktopInfo { get; }
        public _UNICODE_STRING ShellInfo { get; }
        public _UNICODE_STRING RuntimeData { get; }
        public byte[] CurrentDirectores { get; }
        public ulong EnvironmentSize { get; }
        public ulong EnvironmentVersion { get; }
        public IntPtr PackageDependencyData { get; }
        public uint ProcessGroupId { get; }
        public uint LoaderThreads { get; }
        public _UNICODE_STRING RedirectionDllName { get; }
        public _UNICODE_STRING HeapPartitionName { get; }
        public IntPtr DefaultThreadpoolCpuSetMasks { get; }
        public uint DefaultThreadpoolCpuSetMaskCount { get; }
        public uint DefaultThreadpoolThreadMaximum { get; }
        public uint HeapMemoryTypeMask { get; }

        public _RTL_USER_PROCESS_PARAMETERS(IMemorySource memory, MemoryPointer baseAddress) : base(memory, baseAddress)
        {
        }

        static _RTL_USER_PROCESS_PARAMETERS()
        {
            Dictionary<string, ulong[]> offsets = new Dictionary<string, ulong[]>()
            {
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.MaximumLength),
                    new ulong[]
                    {
                        0UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.Length),
                    new ulong[]
                    {
                        4UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.Flags),
                    new ulong[]
                    {
                        8UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DebugFlags),
                    new ulong[]
                    {
                        12UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ConsoleHandle),
                    new ulong[]
                    {
                        16UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ConsoleFlags),
                    new ulong[]
                    {
                        24UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.StandardInput),
                    new ulong[]
                    {
                        32UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.StandardOutput),
                    new ulong[]
                    {
                        40UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.StandardError),
                    new ulong[]
                    {
                        48UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CurrentDirectory),
                    new ulong[]
                    {
                        56UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DllPath),
                    new ulong[]
                    {
                        80UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ImagePathName),
                    new ulong[]
                    {
                        96UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CommandLine),
                    new ulong[]
                    {
                        112UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.Environment),
                    new ulong[]
                    {
                        128UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.StartingX),
                    new ulong[]
                    {
                        136UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.StartingY),
                    new ulong[]
                    {
                        140UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CountX),
                    new ulong[]
                    {
                        144UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CountY),
                    new ulong[]
                    {
                        148UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CountCharsX),
                    new ulong[]
                    {
                        152UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CountCharsY),
                    new ulong[]
                    {
                        156UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.FillAttribute),
                    new ulong[]
                    {
                        160UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.WindowFlags),
                    new ulong[]
                    {
                        164UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ShowWindowFlags),
                    new ulong[]
                    {
                        168UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.WindowTitle),
                    new ulong[]
                    {
                        176UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DesktopInfo),
                    new ulong[]
                    {
                        192UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ShellInfo),
                    new ulong[]
                    {
                        208UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.RuntimeData),
                    new ulong[]
                    {
                        224UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.CurrentDirectores),
                    new ulong[]
                    {
                        240UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.EnvironmentSize),
                    new ulong[]
                    {
                        1008UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.EnvironmentVersion),
                    new ulong[]
                    {
                        1016UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.PackageDependencyData),
                    new ulong[]
                    {
                        1024UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.ProcessGroupId),
                    new ulong[]
                    {
                        1032UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.LoaderThreads),
                    new ulong[]
                    {
                        1036UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.RedirectionDllName),
                    new ulong[]
                    {
                        1040UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.HeapPartitionName),
                    new ulong[]
                    {
                        1056UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DefaultThreadpoolCpuSetMasks),
                    new ulong[]
                    {
                        1072UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DefaultThreadpoolCpuSetMaskCount),
                    new ulong[]
                    {
                        1080UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.DefaultThreadpoolThreadMaximum),
                    new ulong[]
                    {
                        1084UL
                    }
                },
                {
                    nameof(_RTL_USER_PROCESS_PARAMETERS.HeapMemoryTypeMask),
                    new ulong[]
                    {
                        1088UL
                    }
                }
            };
            Register<_RTL_USER_PROCESS_PARAMETERS>((mem, ptr) => new _RTL_USER_PROCESS_PARAMETERS(mem, ptr), offsets);
        }
    }
}