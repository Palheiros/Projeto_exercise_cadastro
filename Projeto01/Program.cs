using Projeto01.Entities;
using Projeto01.Repositories;
using System;

namespace Projeto01
{
    class Program
    {
        //Método para execução do projeto
        static void Main(string[] args)
        {
            //instanciando a classe cliente
            var cliente = new Cliente();
            
            //instanciando a classe Endereco dentro de Cliente
            cliente.Endereco = new Endereco();

            //gerando o id do cliente
            cliente.IdCliente = Guid.NewGuid();
            
            //gerando o id do endereço
            cliente.Endereco.IdEndereco = Guid.NewGuid();

            Console.Write("Informe o nome do Cliente: ");
            cliente.Nome = Console.ReadLine();
            
            Console.Write("Informe o email do cliente: ");
            cliente.Email = Console.ReadLine();
            
            Console.Write("Informe o CPF do cliente: ");
            cliente.Cpf = Console.ReadLine();
            
            Console.Write("Informe da data de nascimento do cliente: ");
            cliente.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Informe o Logradouro: ");
            cliente.Endereco.Logradouro = Console.ReadLine();

            Console.Write("Informe o número: ");
            cliente.Endereco.Numero = Console.ReadLine();

            Console.Write("Informe o Bairro: ");
            cliente.Endereco.Bairro = Console.ReadLine();

            Console.Write("Informe a cidade: ");
            cliente.Endereco.Cidade = Console.ReadLine();

            Console.Write("Informe o Estado: ");
            cliente.Endereco.Estado = Console.ReadLine();

            Console.Write("Informe o CEP: ");
            cliente.Endereco.CEP = Console.ReadLine();

            //imprimindo
            //cw + 2x[tab]
            Console.WriteLine("\nDados do Cliente\n");

            Console.WriteLine("Id do Cliente..............:" + cliente.IdCliente);
            Console.WriteLine("Nome do Cliente............:" + cliente.Nome);
            Console.WriteLine("Email do Cliente...........:" + cliente.Email);
            Console.WriteLine("CPF do Cliente.............:" + cliente.Cpf);
            Console.WriteLine("Data de nascimento.........:" + cliente.DataNascimento);

            Console.WriteLine("\nEndereço do Cliente\n");

            Console.WriteLine("Id do Endereço..............:" + cliente.Endereco.IdEndereco);
            Console.WriteLine("Logradouro..................:" + cliente.Endereco.Logradouro);
            Console.WriteLine("Numero......................:" + cliente.Endereco.Numero);
            Console.WriteLine("Bairro......................:" + cliente.Endereco.Numero);
            Console.WriteLine("Cidade......................:" + cliente.Endereco.Cidade);
            Console.WriteLine("Estado......................:" + cliente.Endereco.Estado);
            Console.WriteLine("CEP.........................:" + cliente.Endereco.CEP);


            try
            {
                //objeto
                var clienteRepository = new ClienteRepository();

                //executando o método para gravar o arquivo
                clienteRepository.ExportarDados(cliente);

                Console.WriteLine("\nArquivo TXT gravado com sucesso!");

            }
            catch (Exception e)
            {
                Console.WriteLine("\nOcorreu um erro: " + e.Message);
            }

            //pausar o prompt do DOS

            Console.ReadKey();
        }
    }
}