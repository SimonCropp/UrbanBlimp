using System.Collections.Generic;
using System.Diagnostics;
using UrbanBlimp.Apple;

namespace Apple
{
    public class AddRegistrationServiceSamples
    {

        public void Simple()
        {
            var service = new AddRegistrationService
                              {
                                  RequestBuilder = ServerRequestBuilder.Instance
                              };
            var registration = new AddRegistrationRequest
                                   { 
                                       DeviceToken = "AppleDeviceId",
                                       Tags = new List<string> {"MyTag"},
                                       Alias = "MyAlias",
                                       Badge = 10
                                   };
            service.Execute(registration, response => Debug.WriteLine("Success"), ExceptionHandler.Handle);
        }

    }
}