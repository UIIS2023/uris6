﻿using DocumentAPI.Models;

namespace DocumentAPI.Helpers
{
	public interface IAuthenticationHelper
	{
		public bool AuthenticatePrincipal(Principal principal);

		public string GenerateJwt(Principal principal);

	}
}
