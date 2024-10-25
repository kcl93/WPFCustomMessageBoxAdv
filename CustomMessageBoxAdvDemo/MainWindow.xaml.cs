﻿using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media.Imaging;
using WPFCustomMessageBoxAdv;
using MessageBox = System.Windows.Forms.MessageBox;

namespace CustomMessageBoxDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_StandardMessage_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(string.Join("\n", Enumerable.Repeat("Hello World!", 12)));
            Debug.WriteLine(result.ToString());
        }

        private void button_StandardMessageNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show(string.Join("\n", Enumerable.Repeat("Hello World!", 12)));
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaption_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello World!", "Hello World the title.");
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("Hello world!", "Hello World the title.", MessageBoxButtons.RetryCancel);
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionAndButton_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButtons.OKCancel);
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionAndButtonNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("Hello World!", "Hello World the title.", MessageBoxButtons.OKCancel);
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionButtonImage_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show(
                "Are you sure you want to eject the nuclear fuel rods?",
                "Confirm Fuel Ejection",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Exclamation);
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionButtonImageNew_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.Show("This is a message.", "This is a caption", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            Debug.WriteLine(result.ToString());
        }

        private void button_MessageWithCaptionButtonCustomImageNew_Click(object sender, RoutedEventArgs e)
        {
            var shield = Imaging.CreateBitmapSourceFromHIcon(
                SystemIcons.Shield.Handle,
                Int32Rect.Empty,
                BitmapSizeOptions.FromEmptyOptions());

            var msgBox = new MessageBoxModel()
            {
                Message = "This is a wide message with a windows shield beside it.",
                Caption = "This is a caption",
                Width = 900,
                MinButtonWidth = 100,
                RetryButtonWidth = 300,
                Buttons = MessageBoxButtons.RetryCancel,
                CustomIcon = shield
            };
            var result = msgBox.ShowDialog();

            Debug.WriteLine(result.ToString());
        }

        private void button_SelfUpdatingMessage_Click(object sender, RoutedEventArgs e)
        {
            var stopwatch = Stopwatch.StartNew();
            var msgBox = new MessageBoxModel()
            {
                Message = $"This message box is open since {(int)stopwatch.Elapsed.TotalSeconds}s",
                Caption = $"Open since {(int)stopwatch.Elapsed.TotalSeconds}s",
                Buttons = MessageBoxButtons.OK
            };
            var task = msgBox.Show();

            while (task.IsCompleted == false)
            {
                msgBox.Message = $"This message box is open since {(int)stopwatch.Elapsed.TotalSeconds}s";
                msgBox.Caption = $"Open since {(int)stopwatch.Elapsed.TotalSeconds}s";
                Task.Delay(100).Wait();
            }

            Debug.WriteLine(task.Result.ToString());
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            var result = CustomMessageBox.ShowAbortRetryIgnore(
                "You have unsaved changes.",
                "Unsaved Changes!",
                "This is a long text that wraps around",
                "Don't Save",
                "Cancel",
                MessageBoxIcon.Exclamation);

            Debug.WriteLine(result.ToString());
        }
    }
}
