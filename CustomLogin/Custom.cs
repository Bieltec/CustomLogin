// using Microsoft.AspNetCore.Authentication;
// using Microsoft.AspNetCore.Http;
// using Microsoft.AspNetCore.Identity;
// using Microsoft.Extensions.Logging;
// using Microsoft.Extensions.Options;
// using System.Threading.Tasks;
// using System;
// using Pzm.PortalFornecedor.User;
// using System.Linq;

// namespace Pzm.PortalFornecedor
// {
//     public class CustomSignInManager : SignInManager<Volo.Abp.Identity.IdentityUser>
//     {
//         public CustomSignInManager(
//             UserManager<Volo.Abp.Identity.IdentityUser> userManager, 
//             IHttpContextAccessor contextAccessor, 
//             IUserClaimsPrincipalFactory<Volo.Abp.Identity.IdentityUser> claimsFactory, 
//             IOptions<IdentityOptions> optionsAccessor, 
//             ILogger<SignInManager<Volo.Abp.Identity.IdentityUser>> logger, 
//             IAuthenticationSchemeProvider schemes, 
//             IUserConfirmation<Volo.Abp.Identity.IdentityUser> confirmation) : 
//             base(userManager, contextAccessor, claimsFactory, optionsAccessor, logger, schemes, confirmation)
//         {
//         }

//         public override async Task<SignInResult> CheckPasswordSignInAsync(Volo.Abp.Identity.IdentityUser user, string password, bool lockoutOnFailure)
//         {
//             if (user.ExtraProperties.TryGetValue("Status", out var statusValue))
//             {
//                 bool status = Convert.ToBoolean(statusValue);
//                 if (!status)
//                 {
//                     return SignInResult.Failed;

//                 }
//             }
//             return await base.CheckPasswordSignInAsync(user, password, lockoutOnFailure);
//         }
//     }
// }
