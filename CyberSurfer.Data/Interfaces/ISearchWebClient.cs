using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CyberSurfer.Data.Interfaces
{
    public interface ISearchWebClient
    {
        string Search(string searchUrl);
    }
}
