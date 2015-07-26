using Codeer.Friendly;
using Codeer.Friendly.Windows;
using Friendly.InputMan.Win.Inside;

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

        internal ControlDriverBase(AppVar appVar)
        {
            AppVar = appVar;
            Initializer.Initialize(App);
        }
    }
}
