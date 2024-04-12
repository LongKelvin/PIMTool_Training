using MetroSet_UI.Controls;
using MetroSet_UI.Enums;
using MetroSet_UI.Forms;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Winforms.Controls;
using PIMTool.Winforms.Interfaces;
using PIMTool.Winforms.UserControls;

namespace PIMTool.Winforms
{
    public partial class MainWindow : MetroSetForm, INavigationHandler
    {
        // UI Components
        private NavigationControl _navigationControl;

        private NavigationButtons _navigationButtons;

        // Repositories
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly ILogger<MainWindow> _logger;

        public MainWindow(
            NavigationControl navigationControl,
            IServiceProvider serviceProvider,
            IRepositoryWrapper repositoryWrapper,
            ILogger<MainWindow> logger)
        {
            // UI Components
            _navigationControl = navigationControl;

            InitializeComponent();
            InitializeNavigationControl();
            InitializeNavigationButtons();

            styleManager1.Style = Style.Light;

            // Repositories components
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;

            //var listEmployees = _repositoryWrapper.Employees.GetAllAsync();

            //foreach (var employee in listEmployees)
            //{
            //    _logger.LogInformation(message: employee.ToString());
            //}


            NavigateTo(nameof(ProjectList));
        }

        private void InitializeNavigationControl()
        {
            var newProjectWindow = Program.ServiceProvider.GetRequiredService<NewProject>();

            List<CustomUserControl> customUserControls =
            [
                new(nameof(ProjectList), new ProjectList()),
                new(nameof(NewProject), newProjectWindow),
            ];

            // create an instance of _navigationControl class
            _navigationControl.SetNavigationControl(customUserControls, panelContentViews);
        }

        private void InitializeNavigationButtons()
        {
            List<MetroSetButton> menuButtons = [btnProjectList, btnNewProject];

            // create a _navigationButtons instance
            _navigationButtons = new NavigationButtons(menuButtons,
                Color.FromKnownColor(KnownColor.ControlLight),
                Color.FromKnownColor(KnownColor.ControlDark));

            // Make a default selected button
            _navigationButtons.Highlight(btnProjectList);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(ProjectList));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(NewProject));
        }

        public void NavigateTo(string userControlName)
        {
            _navigationControl.Display(userControlName);
        }
    }
}