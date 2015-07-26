using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using Friendly.InputMan.Win;
using System.Diagnostics;
using Codeer.Friendly.Windows.NativeStandardControls;

namespace Test
{
    [TestClass]
    public class GcTextBoxTest
    {
        WindowsAppFriend _app;
        WindowControl _main;
        GcTextBoxDriver _textBox;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            _main = WindowControl.FromZTop(_app);
            _textBox = new GcTextBoxDriver(_main.Dynamic()._textBox);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).Kill();
        }

        [TestMethod]
        public void TestEmulateChangeText()
        {
            _textBox.EmulateChangeText("abc");
            _textBox.Text.Is("abc");
        }

        [TestMethod]
        public void TestEmulateChangeTextAsync()
        {
            _main.Dynamic().ConnectTextBoxTextChanged();
            _textBox.EmulateChangeText("abc", new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _textBox.Text.Is("abc");
        }
    }
}
