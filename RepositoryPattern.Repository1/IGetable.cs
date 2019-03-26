using RepositoryPattern.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryPattern.Repository1
{
    public interface IGetable
    {
        void Get(RepositoryPatternContext context);
    }
}
