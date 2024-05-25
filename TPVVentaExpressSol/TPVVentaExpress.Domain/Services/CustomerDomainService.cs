using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPVVentaExpress.Domain.Entities;
using TPVVentaExpress.Domain.Interfaces;

namespace TPVVentaExpress.Domain.Services
{
    public class CustomerDomainService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerDomainService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void RegisterCustomer(Customer customer)
        {
            // Lógica para registrar un nuevo cliente
            // Podría incluir validaciones adicionales, envío de notificaciones, etc.
            _customerRepository.Add(customer);
        }

        public void UpdateCustomerInformation(Customer customer)
        {
            // Lógica para actualizar la información del cliente
            // Podría incluir validaciones adicionales
            _customerRepository.Update(customer);
        }

        public Customer GetCustomerDetails(int customerId)
        {
            // Lógica para obtener los detalles de un cliente específico
            return _customerRepository.GetById(customerId);
        }

        public void DeleteCustomer(int customerId)
        {
            // Lógica para eliminar un cliente
            _customerRepository.Delete(customerId);
        }
    }

}
