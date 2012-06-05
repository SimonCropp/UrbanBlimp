using System.Diagnostics;
using UrbanBlimp.Android;

namespace Android
{
    public class DeleteRegistrationServiceSamples
    {
        public void Simple()
        {
            var service = new DeleteRegistrationService
                              {
                                  RequestBuilder = CustomRequestBuilder.GetRequestBuilder()
                              };
            service.Execute("AndroidPushId", wasDeleted => Debug.WriteLine(wasDeleted), ExceptionHandler.Handle);
        }
    }
}