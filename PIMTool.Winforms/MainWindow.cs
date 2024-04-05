using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

using PIMTool.Core.Wrapper.Interfaces;

namespace PIMTool.Winforms
{
    public partial class MainWindow : Form
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        private readonly IConfiguration _configuration;
        private readonly ILogger<MainWindow> _logger;

        public MainWindow(IRepositoryWrapper repositoryWrapper,
            IConfiguration configuration,
            ILogger<MainWindow> logger)
        {
            InitializeComponent();
            _repositoryWrapper = repositoryWrapper;
            _configuration = configuration;
            _logger = logger;

            var listEmployees = _repositoryWrapper.Employees.GetAllAsync();

            foreach (var employee in listEmployees)
            {
                _logger.LogInformation(employee.ToString());
            }

            _logger.LogInformation($"Delete employee with id {4,5}");
        }
    }
}