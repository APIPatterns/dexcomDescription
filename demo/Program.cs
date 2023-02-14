
using Dexcom;
using Microsoft.Kiota.Http.HttpClientLibrary;

var authProvider = new DexcomAuthenticationProvider("username", "password", "clientId", "clientSecret", "redirectUri");
var adapter = new HttpClientRequestAdapter(authProvider);
var dexcomClient = new DexcomClient(adapter);
