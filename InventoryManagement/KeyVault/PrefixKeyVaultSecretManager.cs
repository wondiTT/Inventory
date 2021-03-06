using Microsoft.Azure.KeyVault.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureKeyVault;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryManagement.KeyVault
{
    public class PrefixKeyVaultSecretManager : IKeyVaultSecretManager
    {
        private readonly string _prefix;

        public PrefixKeyVaultSecretManager(string prefix)
        {
            _prefix = $"{prefix}-";
        }

        public string GetKey(SecretBundle secret)
        {
            var ergebnis = secret.SecretIdentifier.Name.Substring(_prefix.Length)
                .Replace("--", ConfigurationPath.KeyDelimiter);
            return ergebnis;
        }

        public bool Load(SecretItem secret)
        {
            return secret.Identifier.Name.StartsWith(_prefix);
        }
    }
}
