﻿using ProjetoCliente.Models;

namespace ProjetoCliente.Repositorio
{
    public interface IClienteRepositorio
    {
        //Crud 
        IEnumerable<Cliente> TodosClientes();
        void Cadastrar(Cliente cliente); 
    }
}
