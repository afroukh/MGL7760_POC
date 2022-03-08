using MGL7760POC.Abstraction.Services;
using MGL7760POC.Abstraction.Services.Models;
using MGL7760POC.Implementation.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MGL7760POC.Implementation.Services
{
    public class DeclarationService : IDeclarationService
    {
        private readonly IImpotUnitOfWork _impotUnitOfWork;

        public DeclarationService(IImpotUnitOfWork impotUnitOfWork)
        {
            _impotUnitOfWork = impotUnitOfWork;
        }

        public List<DeclarationDm> GetDeclarations()
        {
            var declarationList = new List<DeclarationDm>();
            var declarations = _impotUnitOfWork.DeclarationRepository.Get().ToList();


            declarations.ForEach(d => declarationList.Add(new DeclarationDm { Id = d.Id, DateCreation = d.DateCreation }));

            return declarationList;
            
        }
    }
}
