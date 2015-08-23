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
    public class GcComboBoxTest
    {
        WindowsAppFriend _app;
        WindowControl _main;
        GcComboBoxDriver _comboBox;
        GcComboBoxDriver _comboBoxShiftJIS;


        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            _main = WindowControl.FromZTop(_app);
            _comboBox = new GcComboBoxDriver(_main.Dynamic()._comboBox);
            _comboBoxShiftJIS = new GcComboBoxDriver(_main.Dynamic()._comboBox_ShiftJIS);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Process.GetProcessById(_app.ProcessId).Kill();
        }

        [TestMethod]
        public void TestEmulateChangeText()
        {
            _comboBox.EmulateChangeText("abc");
            _comboBox.Text.Is("abc");
        }

        [TestMethod]
        public void TestEmulateChangeTextAsync()
        {
            _main.Dynamic().ConnectComboBoxTextChanged();
            _comboBox.EmulateChangeText("abc", new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _comboBox.Text.Is("abc");
        }

        [TestMethod]
        public void TestEmulateChangeSelect()
        {
            _comboBox.EmulateChangeSelect(1);
            _comboBox.SelectedItemIndex.Is(1);
            _comboBox.Text.Is("b");
        }

        [TestMethod]
        public void TestEmulateChangeSelectAsync()
        {
            _main.Dynamic().ConnectComboBoxTextChanged();
            _comboBox.EmulateChangeSelect(1, new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _comboBox.SelectedItemIndex.Is(1);
        }
        [TestMethod]
        public void TestEmulateChangeComboboxMaxLength()
        {
            string source = "012345678901234567890123456789012345678901234567890123456789";
            string destination = "01234567890123456789012345678901234567890123456789";

            _comboBox.EmulateChangeMaxLength(50);
            _comboBox.EmulateChangeText(source);
            _comboBox.Text.Is(destination);
        }

        [TestMethod]
        public void TestEmulateChangeComboboxMaxLengthAsync()
        {
            string source = "012345678901234567890123456789012345678901234567890123456789";
            string destination = "01234567890123456789012345678901234567890123456789";

            _main.Dynamic().ConnectComboBoxTextMaxLengthChanged();
            _comboBox.EmulateChangeMaxLength(50, new Async());
            _main.Dynamic().ConnectTextBoxTextChanged();
            _comboBox.EmulateChangeText(source, new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _comboBox.Text.Is(destination);
        }
        [TestMethod]
        public void TestEmulateChangeShiftJISComboBoxMaxLength()
        {
            string source = "0123456789あいうえお亜意宇絵尾";
            string destination = "0123456789あいうえお";

            _comboBoxShiftJIS.EmulateChangeText(source);
            _comboBoxShiftJIS.Text.Is(destination);
        }

        [TestMethod]
        public void TestEmulateChangeShiftJISComboBoxMaxLengthAsync()
        {
            string source = "0123456789あいうえお亜意宇絵尾";
            string destination = "0123456789あいうえお";

            _main.Dynamic().ConnectSJISComboBoxTextChanged();
            _comboBoxShiftJIS.EmulateChangeText(source, new Async());
            new NativeMessageBox(_main.WaitForNextModal()).EmulateButtonClick("OK");
            _comboBoxShiftJIS.Text.Is(destination);
        }
    }
}
