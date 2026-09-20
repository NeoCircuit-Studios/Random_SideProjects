using System;
using System.Runtime.InteropServices;
using System.IO;

class BreadEngine
{
    private static string DLLname = "BreadEngine.dll";


    // base fucn
    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void BreadEngineInit(string windowname);

    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void BreadEngineInitExistingWindow(IntPtr window);

    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    [return: MarshalAs(UnmanagedType.I1)] // bool returns 1 byte
    private static extern bool BreadEngineTargetCouldClose();

    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void BreadEngineSetTarget(bool value);

    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void BreadEngineUpdate();

    [DllImport("BreadEngine.dll", CallingConvention = CallingConvention.Cdecl)]
    private static extern void BreadEngineDestroy();


    public BreadEngine()
    {
        if (!File.Exists(Path.Combine(DLLname)))
        {
            // HEY did you forget to put the BreadEngine.dll in the build folder?

            // place "BreadEngine.dll" in -> bin/Debug/netX.X/
            // so e.g                     -> bin/Debug/net9.0/BreadEngine.dll
            // or                         -> bin/Release/net8.0/BreadEngine.dll

            // it should just be next to e.g mygame.exe

            Environment.FailFast(DLLname +
                " Is missing.. please place "
                + DLLname
                + " Next to youre Program in the Build Folder.");
            Environment.Exit(-650);
        }
    }

    public void Init(string WindowName)
    {
        BreadEngineInit(WindowName);
    }

    public void InitWithExistingWindow(IntPtr window)
    {
        BreadEngineInitExistingWindow(window);
    }

    public bool TargetCouldClose()
    {
        return BreadEngineTargetCouldClose();
    }

    public void SetTarget(bool value) 
    {
        BreadEngineSetTarget(value);
    }

    public void Update()
    {
        BreadEngineUpdate();
    }

    public void Destroy()
    {
        BreadEngineDestroy();
    }
}