using Microsoft.AspNet.Identity;
using System;

namespace chinaCoders.Services
{
    internal class IdentityResultException : Exception
    {
        private IdentityResult result;

        public IdentityResultException(IdentityResult result)
        {
            this.result = result;
        }
        public IdentityResult Result { get; set; }

    }
}