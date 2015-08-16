using Codeer.Friendly;
using Codeer.Friendly.Windows;
using Friendly.InputMan.Win.Inside;
using System.Drawing;
using System.Windows.Forms;

namespace Friendly.InputMan.Win
{
#if ENG
    /// <summary>
    /// Base of control's driver.
    /// </summary>
#else
    /// <summary>
    /// コントロール操作の基本クラスです。
    /// </summary>
#endif
    public class ControlDriverBase : IAppVarOwner
    {

#if ENG
        /// <summary>
        /// Application manipulation object.
        /// </summary>
#else
        /// <summary>
        /// アプリケーション操作クラスです。
        /// </summary>
#endif
        public WindowsAppFriend App { get { return (WindowsAppFriend)AppVar.App; } }

#if ENG
        /// <summary>
        /// Returns an AppVar for a .NET object for the corresponding window.
        /// </summary>
#else
        /// <summary>
        /// 対応するウィンドウの.Netのオブジェクトが格納されたAppVarを取得します。
        /// </summary>
#endif
        public AppVar AppVar { get; set; }

#if ENG
        /// <summary>
        /// Returns the control's text.
        /// </summary>
#else
        /// <summary>
        /// テキストを取得します。
        /// </summary>
#endif
        public string Text
        {
            get { return (string)AppVar["Text"]().Core; }
        }

#if ENG
        /// <summary>
        /// Returns true if the item is set to visible.
        /// </summary>
#else
        /// <summary>
        /// 表示/非表示を取得します。
        /// </summary>
#endif
        public bool Visible
        {
            get { return (bool)AppVar["Visible"]().Core; }
        }

#if ENG
        /// <summary>
        /// Returns true if the control is enabled.
        /// </summary>
#else
        /// <summary>
        /// 活性/非活性を取得します。
        /// </summary>
#endif
        public bool Enabled
        {
            get { return (bool)AppVar["Enabled"]().Core; }
        }

#if ENG
        /// <summary>
        /// Returns control's background Color.
        /// </summary>
#else
        /// <summary>
        /// コントロールの背景色を取得します。
        /// </summary>
#endif
        public Color BackColor
        {
            get { return (Color)AppVar["BackColor"]().Core; }
        }

#if ENG
        /// <summary>
        /// Returns control's Foreground Color.
        /// </summary>
#else
        /// <summary>
        /// コントロールの前景色を取得します。
        /// </summary>
#endif
        public Color ForeColor
        {
            get { return (Color)AppVar["ForeColor"]().Core; }
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
        /// <param name="textBox">リッチテキストボックス。</param>
        /// <param name="maxLength">最大文字列長</param>
#endif
        static void EmulateChangeMaxLength(Control textBox, System.Int32 maxLength)
        {
            textBox.Focus();
            if(textBox is System.Windows.Forms.TextBox)
            {
                TextBox textControl = (System.Windows.Forms.TextBox)textBox;
                textControl.MaxLength = maxLength;
            }
        }

        internal ControlDriverBase(AppVar appVar)
        {
            AppVar = appVar;
            Initializer.Initialize(App);
        }
    }
}
