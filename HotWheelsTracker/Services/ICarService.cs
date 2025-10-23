using HotWheelsTracker.Models; // make sure the namespace points to where your Car model is
using System.Collections.Generic;

namespace HotWheelsTracker.Services
{
    public interface ICarService
    {
        IEnumerable<Car> GetAllCarsSortedByValue();
    }
}
