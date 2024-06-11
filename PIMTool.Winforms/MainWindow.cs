using MetroSet_UI.Forms;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper.Interfaces;
using PIMTool.Winforms.Controls;
using PIMTool.Winforms.Events;
using PIMTool.Winforms.Interfaces;
using PIMTool.Winforms.UserControls;

namespace PIMTool.Winforms
{
    public partial class MainWindow : MetroSetForm, INavigationHandler
    {
        // Repositories
        private readonly IRepositoryWrapper _repositoryWrapper;

        private readonly ILogger<MainWindow> _logger;

        private WindowsContainerManager _windowsContainerManager;
        public EventHandler<NavigationEventArgs> NavigationRequested { get; set; }

        public MainWindow(
            IServiceProvider serviceProvider,
            IRepositoryWrapper repositoryWrapper,
            ILogger<MainWindow> logger)
        {
            InitializeComponent();
            InitializeNavigationControl();

            _windowsContainerManager!.Display(nameof(ProjectList));

            // Repositories components
            _repositoryWrapper = repositoryWrapper;
            _logger = logger;
        }

        private void InitializeNavigationControl()
        {
            var newProjectWindow = Program.ServiceProvider.GetRequiredService<NewProject>();
            var projectListWindow = Program.ServiceProvider.GetRequiredService<ProjectList>();

            newProjectWindow.ProjectCreated += projectListWindow.LoadProjects;

            _windowsContainerManager = new WindowsContainerManager
            {
                ParrentControl = panelContentViews
            };
            _windowsContainerManager.AddUserControl(panelContentViews, newProjectWindow, projectListWindow);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(ProjectList));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NavigateTo(nameof(NewProject));
        }

        public void NavigateTo(string userControlName, object[]? data = null)
        {
            _windowsContainerManager.Display(userControlName, data);
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
        }
    }
}