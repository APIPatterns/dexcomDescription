using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;

internal class DexcomAuthenticationProvider : IAuthenticationProvider {
    private readonly string _clientId;
    private readonly string _clientSecret;
    private readonly string _password;
    private readonly string _redirectUri;
    private readonly string _username;
    public DexcomAuthenticationProvider(string username, string password, string clientId, string clientSecret, string redirectUri) {
        _username = username;
        _password = password;
        _clientId = clientId;
        _clientSecret = clientSecret;
        _redirectUri = redirectUri;
    }

    public Task AuthenticateRequestAsync(RequestInformation request, Dictionary<string, object>? additionalAuthenticationContext = null, CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }
    
}
