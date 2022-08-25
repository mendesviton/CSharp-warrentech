using Dia2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarrenTech.CRUD;

namespace WarrenTech.Classes
{
    internal class TestaPessoas
    {
        public void Executa() { 
             PessoaFisica ppl = new PessoaFisica(fistname: "Vitor",lastname:"Daniel sdasd ",cpf: "1231232");
            PessoaFisica ppl1 = new PessoaFisica(fistname: "Vitor Daniel", lastname: "Daniel ", cpf: "1231232");
            

            System.Console.WriteLine(ppl.Saudacao());
            


            PessoaRepository crud = new PessoaRepository();

            System.Console.WriteLine(crud.Create(ppl));
            System.Console.WriteLine(crud.Create(ppl1));
            System.Console.WriteLine(crud.Update(ppl));

            /*for (int i = 0; i < crud.Read().Count; i++)
            {
                System.Console.WriteLine(crud.peopleList[i].firstName);   
            }*/
            foreach (var item in crud.Read())
            {
                System.Console.WriteLine(item.Saudacao());
                
            }


            System.Console.WriteLine(crud.Delete(1));
        }
        public void ExecutaJuridico()
        {
            PessoaJuridica pplj = new PessoaJuridica(fistname: "Vitor Daniel juridico", lastname: "Daniel ", CNPJ: "12312313");
            System.Console.WriteLine(pplj.Saudacao());

            PessoaJuridicaRepositorio crud = new PessoaJuridicaRepositorio();

            System.Console.WriteLine(crud.Create(pplj));
            System.Console.WriteLine(crud.Update(pplj));

            foreach (var item in crud.Read())
            {
                System.Console.WriteLine(item.Saudacao());

            }


            System.Console.WriteLine(crud.Delete(1));

        }

        public  void ExecutaPessoa()
        {
            Pessoa ppl = new Pessoa("vitor", "daniel");
            Pessoa pplJuridica = new PessoaJuridica("joao", "daniel","CNPJ 12234234");
            Pessoa pplFisica = new PessoaFisica("pedro", "daniel","CPF: 10156899901");
            

            System.Console.WriteLine(ppl.Saudacao());
            System.Console.WriteLine(pplJuridica.Saudacao());
            System.Console.WriteLine(pplFisica.Saudacao());


            BaseRepository<BaseModel> baseRepository = new BaseRepository<BaseModel>();   


            baseRepository.Create(pplJuridica);
            
            baseRepository.Create(pplFisica);
            baseRepository.Create(ppl);

            
            foreach (Pessoa item in baseRepository.Read())
            {
                System.Console.WriteLine(item.firstName);
            }
            

            


        }
        public void ExecutaProduto()
        {
            Produto produto = new Produto("cerrote","pra corstar");
            BaseRepository<BaseModel> baseRepository = new BaseRepository<BaseModel>();
            baseRepository.Create(produto);
            baseRepository.Update(produto); 
            baseRepository.Delete(1);

            foreach (Produto item in baseRepository.Read())
            {
                System.Console.WriteLine(item.nome);
            }
        }
        public void ExecutaBarbeiro()
        {
            Barbeiros barbeiro = new Barbeiros(name: "Ronaldo",email:"vitor6890@gmail.com",idade:18);
            Barbeiros barbeiro1 = new Barbeiros(name: "Fodase?",email:"vitor6890@gmail.com",idade:18);
            Barbeiros barbeiro2 = new Barbeiros(name: "Adriano",email:"vitor6890@gmail.com",idade:18);

            BaseRepository<Barbeiros> barberRepo = new BaseRepository<Barbeiros>();

            barberRepo.Create(barbeiro);
            barberRepo.Create(barbeiro1);
            barberRepo.Create(barbeiro2);

            foreach (var item in barberRepo.Read())
            {
                System.Console.WriteLine(item.nome);
            }

        }
    }
}
