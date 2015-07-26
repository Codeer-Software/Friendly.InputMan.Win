namespace Test
{
    static class Target
    {
        internal static string Path
        {
#if DEBUG
            get { return System.IO.Path.GetFullPath("../../../Target/bin/Debug/Target.exe"); }
#else
            get { return System.IO.Path.GetFullPath("../../../Target/bin/Release/Target.exe"); }
#endif
        }
    }
}
