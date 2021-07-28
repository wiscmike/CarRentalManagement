using CarRentalManagement.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);

        IGenericRepository<Make> MakesRepository { get; }

        IGenericRepository<Model> ModelsRepository { get; }

        IGenericRepository<Vehicle> VehiclesRepository { get; }

        IGenericRepository<Booking> BookingsRepository { get; }

        IGenericRepository<Color> ColorsRepository { get; }

        IGenericRepository<Customer> CustomersRepository { get; }
    }
}
