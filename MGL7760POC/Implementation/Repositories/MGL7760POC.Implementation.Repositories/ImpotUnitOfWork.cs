using MGL7760POC.Abstraction.Repositories;
using MGL7760POC.Abstraction.Repositories.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MGL7760POC.Implementation.Repositories
{
    public class ImpotUnitOfWork : IImpotUnitOfWork
    {
        private ImpotsContext _context;
        private bool _disposed = false;

        IRepository<Declaration> _declarationRepository { get; set; }

        public ImpotUnitOfWork(ImpotsContext context)
        {
            this._context = context;
        }
        public IRepository<Declaration> DeclarationRepository
        {
            get
            {
                if (this._declarationRepository == null)
                    this._declarationRepository = new Repository<Declaration>(_context);
                return _declarationRepository;
            }
        }

        public void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
            {
                // free other managed objects that implement
                // IDisposable only
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }

            // release any unmanaged objects
            // set the object references to null

            _disposed = true;
        }

        public void RollbackChanges()
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
