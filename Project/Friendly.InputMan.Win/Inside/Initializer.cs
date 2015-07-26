using System;
using System.Reflection;
using Codeer.Friendly.Windows;

namespace Friendly.InputMan.Win.Inside
{
    static class Initializer
    {
        internal static void Initialize(WindowsAppFriend app)
        {
            Type myType = typeof(Initializer);
            string key = myType.Module.Name + "[Initialize]";
            object isInit;
            if (!app.TryGetAppControlInfo(key, out isInit))
            {
                WindowsAppExpander.LoadAssembly(app, myType.Assembly);
                app.AddAppControlInfo(key, true);
            }
        }
    }
}
