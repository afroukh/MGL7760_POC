using MGL7760POC.Abstraction.Repositories;
using MGL7760POC.Abstraction.Repositories.Models;
using System;

public interface IImpotUnitOfWork
{
    IRepository<Declaration> DeclarationRepository { get; }
    void SaveChanges();
    void RollbackChanges();
    void Dispose(bool disposing);
}
