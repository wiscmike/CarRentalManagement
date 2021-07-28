using CarRentalManagement.Server.Data;
using CarRentalManagement.Server.IRepository;
using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _dataContext;
        private IGenericRepository<Make> _makesRepository;
        private IGenericRepository<Model> _modelsRepository;
        private IGenericRepository<Vehicle> _vehiclesRepository;
        private IGenericRepository<Booking> _bookingsRepository;
        private IGenericRepository<Color> _colorsRepository;
        private IGenericRepository<Customer> _customersRepository;

        private bool disposedValue;

        public UnitOfWork(ApplicationDbContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IGenericRepository<Make> MakesRepository => _makesRepository ??= new GenericRepository<Make>(_dataContext);
        
        public IGenericRepository<Model> ModelsRepository => _modelsRepository ??= new GenericRepository<Model>(_dataContext);
        
        public IGenericRepository<Vehicle> VehiclesRepository => _vehiclesRepository ??= new GenericRepository<Vehicle>(_dataContext);
        
        public IGenericRepository<Booking> BookingsRepository => _bookingsRepository ??= new GenericRepository<Booking>(_dataContext);
        
        public IGenericRepository<Color> ColorsRepository => _colorsRepository ??= new GenericRepository<Color>(_dataContext);
        
        public IGenericRepository<Customer> CustomersRepository => _customersRepository ??= new GenericRepository<Customer>(_dataContext);

        public async Task Save(HttpContext httpContext)
        {
            var user = httpContext.User.Identity.Name;

            var entries = _dataContext.ChangeTracker.Entries()
                            .Where(e => e.State == EntityState.Modified ||
                                e.State == EntityState.Added);
            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user;
                }
            }
            await _dataContext.SaveChangesAsync();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    _dataContext.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~UnitOfWork()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}
