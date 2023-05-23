using System;
using System.Windows.Forms;
using System.Windows.Input;

namespace WPFCustomMessageBoxAdv
{
    internal class ButtonClickCommand : ICommand
    {
        #pragma warning disable CS0067 // The event is never used
        public event EventHandler CanExecuteChanged;
        #pragma warning restore CS0067

        public Action<DialogResult> Action { get; set; }

        public DialogResult Result { get; set; } = DialogResult.None;

        public ButtonClickCommand()
        {

        }

        public ButtonClickCommand(Action<DialogResult> action, DialogResult result)
        {
            this.Action = action;
            this.Result = result;
        }

        public bool CanExecute(object parameter)
            => (this.Action != null);

        public void Execute(object parameter)
            => this.Action.Invoke(this.Result);
    }
}
