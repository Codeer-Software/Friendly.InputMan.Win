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
using System.Text;
using System.Linq;

namespace Test
{
    [TestClass]
    public class GcTextBoxTest
    {
        WindowsAppFriend _app;
        WindowControl _main;
        GcTextBoxDriver _textBox;
        GcTextBoxDriver _multiLineText;
        GcTextBoxDriver _textBoxShiftJIS;

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            _main = WindowControl.FromZTop(_app);
            _textBox = new GcTextBoxDriver(_main.Dynamic()._textBox);
            _textBoxShiftJIS = new GcTextBoxDriver(_main.Dynamic()._textBoxShiftJIS);
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
            _multiLineText.Multiline.IsTrue("_multiLineText is not true in Multiline Property.");
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
        [TestMethod]
        public void TestEmulateChangeTextMaxLength()
        {
            string source = "012345678901234567890123456789012345678901234567890123456789";
            string destination = "01234567890123456789012345678901234567890123456789";

            _textBox.EmulateChangeMaxLength(50);
            _textBox.EmulateChangeText(source);
            _textBox.Text.Is(destination);
        }

        [TestMethod]
        public void TestEmulateChangeTextMaxLengthAsync()
        {
            string source = "012345678901234567890123456789012345678901234567890123456789";
            string destination = "01234567890123456789012345678901234567890123456789";

            _main.Dynamic().ConnectTextBoxTextChanged();
            _textBox.EmulateChangeMaxLength(50, new Async());
            _main.Dynamic().ConnectTextBoxTextChanged();
            _textBox.EmulateChangeText(source, new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _textBox.Text.Is(destination);
        }

        [TestMethod]
        public void TestEmulateChangeShiftJISTextMaxLength()
        {
            string source = "0123456789あいうえお亜意宇絵尾";
            string destination = "0123456789あいうえお";

            _textBoxShiftJIS.EmulateChangeText(source);
            _textBoxShiftJIS.Text.Is(destination);
        }

        [TestMethod]
        public void TestEmulateChangeShiftJISTextMaxLengthAsync()
        {
            string source = "0123456789あいうえお亜意宇絵尾";
            string destination = "0123456789あいうえお";

            _main.Dynamic().ConnectSJISTextBoxTextChanged();
            _textBoxShiftJIS.EmulateChangeText(source, new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _textBoxShiftJIS.Text.Is(destination);
        }
    }
}
