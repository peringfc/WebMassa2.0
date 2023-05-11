using Microsoft.Extensions.Hosting;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System;
using WebGeradorMassaDados.Objetos;

namespace WebGeradorMassaDados.Regras
{
    public class Fabricar
    {
        Nomes GerarNomes = new Nomes();
        Docs docs = new Docs();
        public Pessoa Criar(int IdadeInicial , int IdadeFinal)
        {
            string sexo = Sexo();
            Pessoa Nascer = new Pessoa();

            switch (sexo.ToUpper())
            {
                case "F":
                    Nascer.nome = GerarNomes.mulher();
                    break;
                case "M":
                    Nascer.nome = GerarNomes.homem();
                    break;
                case "FEMININO":
                    Nascer.nome = GerarNomes.mulher();
                    break;
                case "MASCULINO":
                    Nascer.nome = GerarNomes.homem();
                    break;
                default:
                    Nascer.nome = string.Empty;
                    break;
            }

            Random XRandom = new Random();
            int Idade = XRandom.Next(IdadeInicial, IdadeFinal)*(-1);
            int dias = XRandom.Next(1,365); 

            Nascer.sobrenome = GerarNomes.sobrenome().Trim().TrimEnd().TrimStart();
            Nascer.datanascimento = DateTime.Now.AddYears(Idade).AddDays(-dias);
            Nascer.cpf = docs.GerarCpf();
            Nascer.sexo = sexo;
            Nascer.idade = DateTime.Now.Year - Nascer.datanascimento.Year;
            if (Nascer.idade <= 18)
            {
                Nascer.estadocivil = "Solteiro";
                if (Nascer.idade > 4)
                {
                    Nascer.Hobbie = HobbieCrianca();
                }
            }
            else
            {
                Nascer.email = Email(Nascer.nome+" "+ Nascer.sobrenome);
                Nascer.fone = fone();
                Nascer.estadocivil = EstadoCivil();
                Nascer.Hobbie = Hobbie();
            }



            return Nascer;
        }

        protected string Email(string nome)
        {
            Random random = new Random();
            string[] Listdomino =
                {
                   "gmail.com",
                   "hotmail.com",
                   "ig.com.br",
                   "uol.com.br",
                   "outlook.com",
                   "yahoo.com",
                   "email.com"
                };
            string email = nome.Replace(" ", ".") +"@"+ Listdomino[random.Next(Listdomino.Length)];
            return email;
        }

        protected string fone()
        {
           string[] ListPrefixo =
                { "50","55", "36", "40" , "33" , "34" ,"38", "35", "44", "99", "97", "98",
                  "94", "93"};
            Random Gerador = new Random();
            string DDD = Gerador.Next(11,55).ToString();
            string Prefixo = ListPrefixo[Gerador.Next(ListPrefixo.Length)] + Gerador.Next(10, 99).ToString();
            string SufixoPrefixo = Gerador.Next(1000, 9999).ToString() ;
            return "("+ DDD +") " + Prefixo + " - " + SufixoPrefixo;
        }

        protected string Sexo() 
        {
            string[] ListSexo =
                { "F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M",
                   "F","F","F","F","F","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M",
                   "F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M","F","M"
                  };
            Random Quantidade = new Random();
            return ListSexo[Quantidade.Next(ListSexo.Length)];

        }

        protected string EstadoCivil()
        {
            string[] ListEstadoCivil =
                { 
                   "Solteiro",
                   "Casado",
                   "Viuvo",
                   "Divorciado",
                   "Amasiado",
                   "Viúvo", 
                   "Separado"
                };
            Random Quantidade = new Random();
            return ListEstadoCivil[Quantidade.Next(ListEstadoCivil.Length)];

        }

        protected string Hobbie()
        {
            string[] ListHobbie =
                {
                    "1. Pintar em aquarela",
                    "2. Fazer aulas de teatro",
                    "3. Participar de uma comunidade/sociedade de bairro",
                    "4. Buscar ser um DJ",
                    "5. Ir à academia",
                    "6. Aprender a surfar",
                    "7. Dedicar-se à leitura",
                    "8. Jogar tênis",
                    "9. Aprender a tocar violão",
                    "10. Começar a frequentar concertos de música na cidade",
                    "11. Pescar",
                    "12. Voltar a praticar jogos de memória",
                    "13. Aprender a editar vídeos",
                    "14. Aprender artes marciais",
                    "15. Jogar cartas com amigos",
                    "16. Viajar",
                    "17. Descobrir um dom na cozinha e praticá-lo",
                    "18. Ensinar algo a alguém",
                    "19. Começar a praticar aulas de dança",
                    "20. Fazer natação",
                    "21. Dançar",
                    "22. Fazer musculação ou crossfit",
                    "23. Ter uma lista de livros para cada mês",
                    "24. Aprender a escalar",
                    "25. Fazer as próprias roupas por meio da costura",
                    "26. Andar de bicicleta pela cidade",
                    "27. Colecionar discos de vinil",
                    "28. Aprender a velejar",
                    "29. Jogar vôlei",
                    "30. Dedicar um dia da semana para um hobby entre amigos",
                    "31. Aprender a andar de skate",
                    "32. Escrever um livro",
                    "33. Aprender a desenhar",
                    "34. Ouvir músicas para adormecer",
                    "35. Dedicar-se a um instrumento de música desafiante",
                    "36. Ter um blog",
                    "37. Fazer um curso de programação",
                    "38. Virar fã de um esporte",
                    "39. Começar a investir dinheiro",
                    "40. Aprender uma nova língua",
                    "41. Dedicar-se a um voluntariado",
                    "42. Voltar a estudar e fazer um curso",
                    "43. Aprender a fotografar",
                    "44. Dedicar-se a jardinagem",
                    "45. Fazer cursos gratuitos de línguas ou conhecer alguém que não fala português",
                    "46. Partilhar talentos entre amigos",
                    "47. Visitar museus gratuitos",
                    "48. Fazer pães e bolos caseiros",
                    "49. Fazer bijuterias",
                    "50. Aprender a fazer massagem",
                    "51. Comprar livros em sebos",
                    "52. Aprender a cantar com vídeos gratuitos",
                    "53. Jogar xadrez com aplicativos gratuitos",
                    "54. Brechós com roupas e coisas usadas",
                    "55. Conhecer mais do mundo e da história com documentários",
                    "56.Virar ativista de um tema que considera importante",
                    "57.Frequentar um grupo",
                    "58.Investir tempo numa lista de sonhos e objetivos",
                    "59.Fazer caligrafia",
                    "60.Virar um conhecedor da astrologia",
                    "61.Ensinar truques para o seu cachorro",
                    "62.Meditação",
                    "63.Yoga",
                    "64.Corrida",
                    "65.Buscar ter um maior contato com a natureza",
                    "66.Ter um diário ou caderno de anotações",
                    "67.Conhecer mais do universo",
                    "68.Aprender a fazer velas e sabão",
                    "69.Dedicar - se a um trabalho de arte",
                    "70.Customizar roupas antigas",
                    "71.Fazer parte de um clube do livro",
                    "72.Decorar e fazer restaurações na casa",
                    "73.Caminhar em parques e fazer trilhas",
                    "74.Cuidar de um jardim ou de uma horta",
                    "75.Preparar almoços de domingo caprichados para a sua família",
                    "76.Acampar com amigos",
                    "77.Ir ao cinema",
                    "78.Experimentar novas receitas com dicas de programas culinários",
                    "79.Viajar uma vez ao mês para locais próximos",
                    "80.Praticar um esporte a dois"
                };
            Random Quantidade = new Random();
            return ListHobbie[Quantidade.Next(ListHobbie.Length)];

        }

        protected string HobbieCrianca()
        {
            string[] ListHobbie =
                {
                    "Futebol",
                    "Volei",
                    "Bolinha de gude",
                    "Basquete",
                    "Karate",
                    "Judo",
                    "Natação",
                    "Figurinha",
                    "Colecionar Tampinhas",
                    "Colecionar Bones ",
                    "Colecionar Copos",
                    "Rodar Peao",
                    "Colecionar Bonecos/Bonecas",
                    "Celos",
                    "Aquariomos",
                    "Bibelo de Pai"
                };
            Random Quantidade = new Random();
            return ListHobbie[Quantidade.Next(ListHobbie.Length)];

        }


    }
}
