using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Codeer.Friendly;
using Codeer.Friendly.Dynamic;
using Codeer.Friendly.Windows;
using Codeer.Friendly.Windows.Grasp;
using Friendly.InputMan.Win;
using System.Diagnostics;
using Codeer.Friendly.Windows.NativeStandardControls;
using System.Drawing;

namespace Test
{
    [TestClass]
    public class GcTextBoxTest
    {
        WindowsAppFriend _app;
        WindowControl _main;
        GcTextBoxDriver _textBox;
        GcTextBoxDriver _multiLineText;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            _main = WindowControl.FromZTop(_app);
            _textBox = new GcTextBoxDriver(_main.Dynamic()._textBox);
            _multiLineText = new GcTextBoxDriver(_main.Dynamic()._multiLineText);
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

        [TestMethod]
        public void TestEmulateChangeTextMultiLine()
        {
            _multiLineText.MultiLine.IsFalse("_multiLineText is not true in MultiLine Property.");
            _multiLineText.EmulateChangeText("abc\r\nedf");
            _multiLineText.Text.Is("abc\r\nedf");
        }

        [TestMethod]
        public void TestEmulateChangeMultiLineTextAsync()
        {
            _main.Dynamic().ConnectMultiLineTextBoxChanged();
            _multiLineText.EmulateChangeText("abc\r\nedf", new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _multiLineText.Text.Is("abc\r\nedf");
        }
    }
}
