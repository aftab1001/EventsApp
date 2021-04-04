using System.Threading.Tasks;
using EventsApp.Configuration.Dto;

namespace EventsApp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
