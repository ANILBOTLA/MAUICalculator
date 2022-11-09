namespace Calculator.Services
{
	public interface IHttpsClientHandlerService
	{
        HttpMessageHandler GetPlatformMessageHandler();
    }
}

