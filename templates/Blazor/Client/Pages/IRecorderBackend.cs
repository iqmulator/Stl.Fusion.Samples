using System.Threading;
using System.Threading.Tasks;

namespace Templates.Blazor.Client.Pages
{
    public interface IRecorderBackend
    {
        Task RecordingStartedAsync();
        Task RecordingDataAvailableAsync(string dataAsBase64);
        Task RecordingStoppedAsync();
    }
}
