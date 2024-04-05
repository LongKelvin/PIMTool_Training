using PIMTool.Core.Wrapper.Interfaces;

namespace PIMTool.Winforms
{
    public partial class MainWindow : Form
    {
        private readonly IRepositoryWrapper _repositoryWrapper;
        public MainWindow(IRepositoryWrapper repositoryWrapper)
        {
            InitializeComponent();
            _repositoryWrapper = repositoryWrapper;

            var listEmployees = _repositoryWrapper.Employees.GetAllAsync();

            foreach (var employee in listEmployees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
