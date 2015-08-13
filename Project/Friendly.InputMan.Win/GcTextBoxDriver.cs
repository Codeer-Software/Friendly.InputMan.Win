using Codeer.Friendly;
using System.Windows.Forms;
using System.Drawing;

namespace Friendly.InputMan.Win
{
#if ENG
    /// <summary>
    /// Provides operations on controls of type GrapeCity.Win.Editors.GcTextBox.
    /// </summary>
#else
    /// <summary>
    /// TypeがGrapeCity.Win.Editors.GcTextBoxのウィンドウに対応した操作を提供します。
    /// </summary>
#endif
    public class GcTextBoxDriver : ControlDriverBase
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
        public GcTextBoxDriver(AppVar appVar)
            : base(appVar) { }

#if ENG
        /// <summary>
        /// Sets the control's text.
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
        /// Sets the control's text.
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

        /// <summary>
        /// テキストを変更します。
        /// </summary>
        /// <param name="textBox">リッチテキストボックス。</param>
        /// <param name="text">テキスト。</param>
        static void EmulateChangeText(Control textBox, string text)
        {
            textBox.Focus();
            textBox.Text = text;
        }

#if ENG
        /// <summary>
        /// Sets the background color.
        /// </summary>
        /// <param name="backgroundColor">change target color.</param>
#else
        /// <summary>
        /// 背景色を変更します。
        /// </summary>
        /// <param name="backgroundColor">背景色。</param>
#endif
        public void EmulateChangeBackColor(Color backgroudColor)
        {
            App[GetType(), "EmulateChangeBackColor"](AppVar, backgroudColor);
        }

#if ENG
        /// <summary>
        /// Returns true if textbox is multiline  enabled.
        /// </summary>
#else
        /// <summary>
        /// テキストボックスのマルチラインが有効ならばTrueを返します。
        /// </summary>
#endif
        public bool Multiline
        {
            get { return (bool)AppVar["Multiline"]().Core; }
        }

#if ENG
        /// <summary>
        /// Sets the background color.
        /// Executes asynchronously. 
        /// </summary>
        /// <param name="text">Text to use.</param>
        /// <param name="async">Asynchronous execution.</param>
#else
        /// <summary>
        /// 背景色を変更します。
        /// 非同期で実行します。
        /// </summary>
        /// <param name="backColor">背景色。</param>
        /// <param name="async">非同期実行オブジェクト。</param>
#endif
        public void EmulateChangeBackColor(Color backColor, Async async)
        {
            App[GetType(), "EmulateChangeBackColor", async](AppVar, backColor);
        }

#if ENG
        /// <summary>
        /// Sets the background color.
        /// </summary>
        /// <param name="text">Text to use.</param>
        /// <param name="backColor">Background color.</param>
#else
        /// <summary>
        /// 背景色を変更します。
        /// </summary>
        /// <param name="textBox">リッチテキストボックス。</param>
        /// <param name="backColor">背景色</param>
#endif
        static void EmulateChangeBackColor(Control textBox, Color backColor)
        {
            textBox.Focus();
            textBox.BackColor = backColor;
        }
    }
}
