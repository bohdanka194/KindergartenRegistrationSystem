using System;
using System.Windows;

using RegistrationSystem.WPFUI.ViewModel;

namespace RegistrationSystem.WPFUI
{
    /// <summary>
    /// Interaction logic for RegistrationWindow.xaml
    /// </summary>
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
            RegistrationViewModel viewModel = new RegistrationViewModel(); // this creates an instance of the ViewModel
            this.DataContext = viewModel; // this sets the newly created ViewModel as the DataContext for the View
            if (viewModel.CloseAction == null)
            {
                viewModel.CloseAction = new Action(() => this.Close());
            }
        }
    }
}
