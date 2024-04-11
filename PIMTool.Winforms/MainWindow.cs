using MetroSet_UI.Enums;
using MetroSet_UI.Forms;

using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Winforms.Controls;
using PIMTool.Winforms.UserControls;

namespace PIMTool.Winforms
{
    public partial class MainWindow : MetroSetForm
    {
        // UI Components
        private NavigationControl navigationControl;

        private NavigationButtons navigationButtons;

        // Repositories
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly ILogger<MainWindow> _logger;

        public MainWindow(
            IRepositoryWrapper repositoryWrapper,
            ILogger<MainWindow> logger)
        {
            // UI Components

            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();

            styleManager1.Style = Style.Light;

            // Repositories components
            _repositoryWrapper = repositoryWrapper;

            _logger = logger;

            var listEmployees = _repositoryWrapper.Employees.GetAllAsync();

            foreach (var employee in listEmployees)
            {
                _logger.LogInformation(message: employee.ToString());
            }
        }

        private void InitializeNavigationControl()
        {
            List<CustomUserControl> customUserControls =
            [
                new("UserControl1", new UserControl1()),
                new("UserControl2", new UserControl2()),
                new("UserControl3", new UserControl3()),
            ];

            // create an instance of NavigationControl class
            navigationControl = new NavigationControl(customUserControls, panelContentViews);
            navigationControl.Display("UserControl1");
        }

        private void InitializeNavigationButtons()
        {
            List<Button> menuButtons = [button1, button2, button3];

            // create a NavigationButtons instance
            navigationButtons = new NavigationButtons(menuButtons,
                Color.FromKnownColor(KnownColor.ControlLight),
                Color.FromKnownColor(KnownColor.ControlDark));

            // Make a default selected button
            navigationButtons.Highlight(button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            navigationControl.Display(0); // display window by index
            navigationButtons.Highlight(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            navigationControl.Display("UserControl2"); //display window by name
            navigationButtons.Highlight(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            navigationControl.Display("UserControl3");
            navigationButtons.Highlight(button3);

            MetroSetMessageBox.Show(this, "A new update available, do you want to update it now ?", "Available Update", MessageBoxButtons.YesNo);
        }
    }
}