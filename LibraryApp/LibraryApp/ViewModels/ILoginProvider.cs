using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.ViewModels
{
    interface ILoginProvider
    {
        Task<string> LoginAsync();
    }
}
