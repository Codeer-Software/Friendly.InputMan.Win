using System;
using System.Reflection;
using System.Windows.Forms;
using System.Collections.Generic;
using Codeer.Friendly;
using Codeer.Friendly.Windows;
using Friendly.InputMan.Win.Inside;

namespace Friendly.InputMan.Win
{
#if ENG
    /// <summary>
    /// Provides operations on controls of type GrapeCity.Win.Editors.GcComboBox.
    /// </summary>
#else
    /// <summary>
    /// TypeがGrapeCity.Win.Editors.GcComboBoxのウィンドウに対応した操作を提供します。
    /// </summary>
#endif
    public class GcComboBoxDriver : ControlDriverBase
    {
#if ENG
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="appVar">Application variable object for the control.</param>
#else
        /// <summary>
        /// コンストラクタです。
        /// </summary>
        /// <param name="appVar">アプリケーション内変数。</param>
#endif
        public GcComboBoxDriver(AppVar appVar)
            : base(appVar) { }

#if ENG
        /// <summary>
        /// Returns the number of items in the list.
        /// </summary>
#else
        /// <summary>
        /// 一覧のアイテム数を取得します。
        /// </summary>
#endif
        public int ItemCount
        {
            get { return (int)(AppVar["Items"]()["Count"]().Core); }
        }

#if ENG
        /// <summary>
        /// Returns the index of the currently selected item.
        /// </summary>
#else
        /// <summary>
        /// 現在選択されているアイテムのインデックスを取得します。
        /// </summary>
#endif
        public int SelectedItemIndex
        {
            get { return (int)(AppVar["SelectedIndex"]().Core); }
        }

#if ENG
        /// <summary>
        /// Returns the text for an item in the list.
        /// </summary>
        /// <param name="index">Index of the item.</param>
        /// <returns>The item's text.</returns>
#else
        /// <summary>
        /// アイテムの文字列を取得します。
        /// </summary>
        /// <param name="index">インデックス。</param>
        /// <returns>アイテム文字列。</returns>
#endif
        public string GetItemText(int index)
        {
            return AppVar["Items"]()["[]"](index).ToString();
        }

#if ENG
        /// <summary>
        /// Modifies the control's text.
        /// </summary>
        /// <param name="text">Text to use.</param>
#else
        /// <summary>
        /// テキストを変更します。
        /// </summary>
        /// <param name="text">テキスト。</param>
#endif
        public void EmulateChangeText(string text)
        {
            App[GetType(), "EmulateChangeText"](AppVar, text);
        }

#if ENG
        /// <summary>
        /// Modifies the control's text.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="text">Text to use.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// テキストを変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="text">テキスト。</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeText(string text, Async async)
        {
            App[GetType(), "EmulateChangeText", async](AppVar, text);
        }

#if ENG
        /// <summary>
        /// Selects the item with the specified index.
        /// </summary>
        /// <param name="index">Item index.</param>
#else
        /// <summary>
        /// 指定のインデックスのアイテムを選択します。
        /// </summary>
        /// <param name="index">インデックス。</param>
#endif
        public void EmulateChangeSelect(int index)
        {
            App[GetType(), "EmulateChangeSelect"](AppVar, index);
        }

#if ENG
        /// <summary>
        /// Selects the item with the specified index.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="index">Item index.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// 指定のインデックスのアイテムを選択します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="index">インデックス。</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeSelect(int index, Async async)
        {
            App[GetType(), "EmulateChangeSelect", async](AppVar, index);
        }

        /// <summary>
        /// テキストを変更します。
        /// </summary>
        /// <param name="comboBox">コンボボックス。</param>
        /// <param name="text">テキスト。</param>
        static void EmulateChangeText(Control comboBox, string text)
        {
            comboBox.Focus();
            comboBox.Text = text;
        }

        /// <summary>
        /// 指定のインデックスのアイテムを選択します。
        /// </summary>
        /// <param name="comboBox">コンボボックス。</param>
        /// <param name="index">インデックス。</param>
        static void EmulateChangeSelect(Control comboBox, int index)
        {
            comboBox.Focus();
            Invoker.Call(comboBox, "set_SelectedIndex", index);
        }
#if ENG
        /// <summary>
        /// Sets the MaxLength Property.
        /// </summary>
        /// <param name="MaxLength">change max length in textbox.</param>
#else
        /// <summary>
        /// 最大文字列の長さ変更します。
        /// </summary>
        /// <param name="maxLength">最大文字列長</param>
#endif
        public void EmulateChangeMaxLength(System.Int32 maxLength)
        {
            App[GetType(), "EmulateChangeMaxLength"](AppVar, maxLength);
        }

#if ENG
        /// <summary>
        /// Sets the MaxLength Property.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="maxLength">Max length in Textbox.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// 最大文字列長を変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="maxLength">最大文字列長</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeMaxLength(System.Int32 maxLength, Async async)
        {
            App[GetType(), "EmulateChangeMaxLength", async](AppVar, maxLength);
        }

#if ENG
        /// <summary>
        /// Sets the background color.
        /// </summary>
        /// <param name="text">Text to use.</param>
        /// <param name="maxLength">Max length in Control.</param>
#else
        /// <summary>
        /// 最大文字列長を変更します。
        /// </summary>
        /// <param name="comboBox">コンボボックス。</param>
        /// <param name="maxLength">最大文字列長</param>
#endif
        static void EmulateChangeMaxLength(Control comboBox, System.Int32 maxLength)
        {
            comboBox.Focus();
            Invoker.Call(comboBox, "set_MaxLength", maxLength);
        }
    }
}