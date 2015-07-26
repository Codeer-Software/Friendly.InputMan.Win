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

        [TestInitialize]
        public void TestInitialize()
        {
            _app = new WindowsAppFriend(Process.Start(Target.Path));
            _main = WindowControl.FromZTop(_app);
            _comboBox = new GcComboBoxDriver(_main.Dynamic()._comboBox);
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
    }
}
