using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace MengeCS
{
    class MengeWrapper
    {
#if DEBUG
        const string MENGE_DLL = "MengeCore_d";
#else
        const string MENGE_DLL = "MengeCore";
#endif

        [DllImport(MENGE_DLL)]
        public static extern bool InitSimulator([MarshalAs(UnmanagedType.LPStr)] String behaveFile,
                                                [MarshalAs(UnmanagedType.LPStr)] String sceneFile,
                                                [MarshalAs(UnmanagedType.LPStr)] String model,
                                                [MarshalAs(UnmanagedType.LPStr)] String pluginPath
                                                );

        [DllImport(MENGE_DLL)]
        public static extern float SetTimeStep(float timestep);

        [DllImport(MENGE_DLL)]
        public static extern bool DoStep();

        [DllImport(MENGE_DLL)]
        public static extern uint AgentCount();

        [DllImport(MENGE_DLL)]
        public static extern bool GetAgentPosition(uint i, ref float x, ref float y, ref float z);

        [DllImport(MENGE_DLL)]
        public static extern bool GetAgentVelocity(uint i, ref float x, ref float y, ref float z);

        [DllImport(MENGE_DLL)]
        public static extern bool GetAgentOrient(uint i, ref float x, ref float y);

        [DllImport(MENGE_DLL)]
        public static extern int GetAgentClass(uint i);

        [DllImport(MENGE_DLL)]
        public static extern float GetAgentRadius(uint i);

        [DllImport(MENGE_DLL)]
        public static extern int ExternalTriggerCount();

        [DllImport(MENGE_DLL)]
        public static extern IntPtr ExternalTriggerName(int i);

        [DllImport(MENGE_DLL, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern void FireExternalTrigger([MarshalAs(UnmanagedType.LPStr)] string lpString);
    }
}
