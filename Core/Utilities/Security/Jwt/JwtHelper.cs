using Core.Entities.Concrete;
using Core.Utilities.Security.Encryption;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        private readonly IConfiguration _configuration;
        private readonly TokenOptions _options;

        public JwtHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _options = _configuration.GetSection("TokenOptions").Get<TokenOptions>();
        }

        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey= SecurityKeyHelper.CreateSecurityKey(_options.SecurityKey);
        }
    }
}
