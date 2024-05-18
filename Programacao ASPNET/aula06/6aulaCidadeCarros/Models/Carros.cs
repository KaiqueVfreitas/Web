using System;
using System.Collections.Generic;

namespace _6aulaCidadeCarros.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Ano { get; set; }
        public string Fabricante { get; set; }
    }

    public class Carros
    {
        private List<Carro> listaCarros;

        public Carros()
        {
            NovoCliente();
        }

        private void NovoCliente()
        {
            try
            {
                listaCarros = new List<Carro>()
                {
                    new Carro(){ Id = 1, Marca = "Volkswagen", Modelo = "Brasilia", Ano = "1980", Fabricante = "Volkswagen"},
                    new Carro(){ Id = 2, Marca = "Fiat", Modelo = "Challenger", Ano = "1972", Fabricante = "Dodge"},
                    new Carro(){ Id = 3, Marca = "Chevrolet", Modelo = "Corvette C1", Ano = "1961", Fabricante = "Chevrolet"},
                    new Carro(){ Id = 4, Marca = "Hornet", Modelo = "Hudson", Ano = "1955", Fabricante = "Motor Car"},
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Carro> ListarCarros()
        {
            try
            {
                return listaCarros;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
