using System.Windows;
using System.Windows.Forms;

namespace WPFCustomMessageBoxAdv
{
    /// <summary>
    /// Displays a message box.
    /// </summary>
    public static class CustomMessageBox
    {
        /// <summary>
        /// Displays a message box in front of the specified window. The message box displays a message and title bar caption; and it returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>
        /// <param name="button">(Default = MessageBoxButtons.OK) A System.Windows.Forms.MessageBoxButtons value that specifies which button or buttons to display.</param>
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult Show(string messageBoxText, string caption = "Message", MessageBoxButtons button = MessageBoxButtons.OK, MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = button,
                Icon = icon,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, title bar caption, OK button with a custom System.String value for the button's text, and icon; and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowOK(string messageBoxText, string okButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.OK,
                Icon = icon,
                OkButtonCaption = okButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, caption, OK/Cancel buttons with custom System.String values for the buttons' text, and icon;
        /// and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="okButtonText">A System.String that specifies the text to display within the OK button.</param>
        /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowOKCancel(string messageBoxText, string okButtonText, string cancelButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.OKCancel,
                Icon = icon,
                OkButtonCaption = okButtonText,
                CancelButtonCaption = cancelButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, caption, Yes/No buttons with custom System.String values for the buttons' text, and icon;
        /// and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
        /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowYesNo(string messageBoxText, string yesButtonText, string noButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.YesNo,
                Icon = icon,
                YesButtonCaption = yesButtonText,
                NoButtonCaption = noButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, caption, Yes/No buttons with custom System.String values for the buttons' text, and icon;
        /// and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="retryButtonText">A System.String that specifies the text to display within the Retry button.</param>
        /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowRetryCancel(string messageBoxText, string retryButtonText, string cancelButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.RetryCancel,
                Icon = icon,
                RetryButtonCaption = retryButtonText,
                CancelButtonCaption = cancelButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, caption, Yes/No/Cancel buttons with custom System.String values for the buttons' text, and icon;
        /// and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="yesButtonText">A System.String that specifies the text to display within the Yes button.</param>
        /// <param name="noButtonText">A System.String that specifies the text to display within the No button.</param>
        /// <param name="cancelButtonText">A System.String that specifies the text to display within the Cancel button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>v
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowYesNoCancel(string messageBoxText, string yesButtonText, string noButtonText, string cancelButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.YesNoCancel,
                Icon = icon,
                YesButtonCaption = yesButtonText,
                NoButtonCaption = noButtonText,
                CancelButtonCaption = cancelButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }

        /// <summary>
        /// Displays a message box that has a message, caption, Yes/No/Cancel buttons with custom System.String values for the buttons' text, and icon;
        /// and that returns a result.
        /// </summary>
        /// <param name="messageBoxText">A System.String that specifies the text to display.</param>
        /// <param name="abortButtonText">A System.String that specifies the text to display within the Abort button.</param>
        /// <param name="retryButtonText">A System.String that specifies the text to display within the Retry button.</param>
        /// <param name="ignoreButtonText">A System.String that specifies the text to display within the Ignore button.</param>
        /// <param name="caption">(Default = "Message") A System.String that specifies the title bar caption to display.</param>v
        /// <param name="icon">(Default = MessageBoxIcon.None) A System.Windows.MessageBoxIcon value that specifies the icon to display.</param>
        /// <param name="owner">A System.Windows.Window that represents the owner window of the message box.</param>
        /// <returns>A System.Windows.Form.DialogResult value that specifies which message box button is clicked by the user.</returns>
        public static DialogResult ShowAbortRetryIgnore(string messageBoxText, string abortButtonText, string retryButtonText, string ignoreButtonText, string caption = "Message", MessageBoxIcon icon = MessageBoxIcon.None, Window owner = null)
        {
            var msgData = new MessageBoxModel()
            {
                Message = messageBoxText,
                Caption = caption,
                Buttons = MessageBoxButtons.AbortRetryIgnore,
                Icon = icon,
                AbortButtonCaption = abortButtonText,
                RetryButtonCaption = retryButtonText,
                IgnoreButtonCaption = ignoreButtonText,
                Owner = owner
            };

            return msgData.ShowDialog();
        }
    }
}
