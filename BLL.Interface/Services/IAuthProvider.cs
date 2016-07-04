using BLL.Interface.Entities;
using System;
using System.Collections.Generic;

namespace BLL.Interface.Services
{
    public interface IAuthProvider
    {
        bool Authenticate(string username, string password);
    }
}
