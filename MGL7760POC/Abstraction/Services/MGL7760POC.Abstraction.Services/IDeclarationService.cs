using System;
using System.Collections.Generic;
using System.Text;

namespace MGL7760POC.Abstraction.Services
{
    public interface IDeclarationService
    {
        List<DeclarationDm> GetDeclarations();
    }
}
