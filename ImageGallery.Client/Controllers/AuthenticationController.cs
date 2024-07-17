using IdentityModel.Client;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;

namespace ImageGallery.Client.Controllers
{
    [Authorize]
    public class AuthenticationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AuthenticationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Authorize]
        public async Task Logout()
        {
            //var client = _httpClientFactory.CreateClient("IDPClient");

            //var discoverydocumentresponse = await client.GetDiscoveryDocumentAsync();
            //if (discoverydocumentresponse.IsError)
            //{
            //    throw new Exception(discoverydocumentresponse.Error);
            //}

            //var accessTokenRevokeResponse = await client.RevokeTokenAsync(new TokenRevocationRequest
            //{
            //    Address = discoverydocumentresponse.RevocationEndpoint,
            //    ClientId="imagegalleryclient",
            //    ClientSecret="secret",
            //    Token = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.AccessToken)
            //});
            //if (accessTokenRevokeResponse.IsError)
            //{
            //    throw new Exception(accessTokenRevokeResponse.Error);
            //}

            //var refreshTokenRevokeResponse = await client.RevokeTokenAsync(new TokenRevocationRequest
            //{
            //    Address = discoverydocumentresponse.RevocationEndpoint,
            //    ClientId = "imagegalleryclient",
            //    ClientSecret = "secret",
            //    Token = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.RefreshToken)
            //});
            //if (refreshTokenRevokeResponse.IsError)
            //{
            //    throw new Exception(refreshTokenRevokeResponse.Error);
            //}

            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            await HttpContext.SignOutAsync(OpenIdConnectDefaults.AuthenticationScheme);
        }

        public IActionResult AccessDenied()
        { 
            return View(); 
        }
    }
}