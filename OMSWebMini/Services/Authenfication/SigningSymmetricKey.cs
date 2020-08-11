using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace OMSWebMini.Services.Authenfication
{

    //Реализация интерфейсов при помощи симметричного алгоритма
    public class SigningSymmetricKey : IJwtSigningEncodingKey, IJwtSigningDecodingKey
    {
        private readonly SymmetricSecurityKey _secretKey;

        public SigningSymmetricKey(string key)
        {
            this._secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        }

        // SigningAlgorithm implementation
        public string SigningAlgorithm { get; } = SecurityAlgorithms.HmacSha256;

        // GetKey implementation
        public SecurityKey GetKey() => this._secretKey;
    }
}
