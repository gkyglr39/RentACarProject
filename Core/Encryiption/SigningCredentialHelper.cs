using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Encryiption
{
    public class SigningCredentialHelper
    {

        public static SigningCredentials CreateSigningCredentials(SecurityKey key)
        {
            return new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
