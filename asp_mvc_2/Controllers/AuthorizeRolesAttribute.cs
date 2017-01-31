using System;

namespace asp_mvc_2.Controllers
{
    internal class AuthorizeRolesAttribute : Attribute
    {
        private string v;

        public AuthorizeRolesAttribute(string v)
        {
            this.v = v;
        }
    }
}