using System;

public interface IImpotUnitOfWork
{
    void SaveChanges();
    void RollbackChanges();
    void Dispose(bool disposing);
}
