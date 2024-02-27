﻿using Microsoft.AspNetCore.Mvc;
using Personality.Helper;
using Personality.Models;

namespace Personality.Controllers
{
   
        [ApiController]
        [Route("api/examRegistrations")]
        [Produces("application/json", "application/xml")]
        public class AuthenticationController : ControllerBase
        {
            private readonly IAuthenticationHelper authenticationHelper;

            public AuthenticationController(IAuthenticationHelper authenticationHelper)
            {
                this.authenticationHelper = authenticationHelper;
            }

            /// <summary>
            /// Metoda za autentifikaciju korisnika
            /// </summary>
            /// <param name="principal">Model sa podacima na osnovu kojih se vrši autentifikacija</param>
            /// <returns></returns>
            [HttpPost("authenticate")]
            [Consumes("application/json")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status401Unauthorized)]
            public IActionResult Authenticate(Principal principal)
            {
                //Pokušaj autentifikacije
                if (authenticationHelper.AuthenticatePrincipal(principal))
                {
                    var tokenString = authenticationHelper.GenerateJwt(principal);
                    return Ok(new { token = tokenString });
                }

                //Ukoliko autentifikacija nije uspela vraća se status 401
                return Unauthorized();
            }
        }
    
}
