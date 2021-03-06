using System;

namespace UrbanBlimp.Apple
{
    public class DeleteRegistrationService
    {
        public IRequestBuilder RequestBuilder;

        public void Execute(DeleteRegistrationRequest request, Action<DeleteRegistrationResponse> responseCallback, Action<Exception> exceptionCallback)
        {
            var webRequest = RequestBuilder.Build("https://go.urbanairship.com/api/device_tokens/" + request.DeviceToken);
			webRequest.Method = "Delete";
			webRequest.ContentType = "application/json";

            var asyncRequest = new AsyncRequest
            {
                Request = webRequest,
                ReadFromResponse = o => responseCallback(new DeleteRegistrationResponse()),
                ExceptionCallback = exceptionCallback,
            };

            asyncRequest.Execute();
        }
    }
}