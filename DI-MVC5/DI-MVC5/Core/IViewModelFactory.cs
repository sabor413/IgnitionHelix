using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI_MVC5.Core
{
    public interface IViewModelFactory
    {
        SignInViewModel Create(bool input);
    }
}
