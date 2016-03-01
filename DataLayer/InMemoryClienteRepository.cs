using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class class InMemoryClienteRepository implements IClienteRepository {
		
    private ICollection<Cliente> clientes;
	
	public ICollection<Cliente> findAll(){}
	public Cliente findClienteByID(string id){}
	public void addCliente(Cliente cliente){}
	public void removeCliente(Cliente cliente){}

	}

}
