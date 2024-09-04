using System;
class EcoMaterialize
{
    private string ecoMaterialize;
    private string escolar;
    private string estrangeiro;
    private string historia;
    private string tecnologia;

    //GET
    public string GetEcoMaterialize()
    {
        return ecoMaterialize;
    }
    public string GetEscolar()
    {
        return escolar;
    }
    public string GetEstrangeiro()
    {
        return estrangeiro;
    }
    public string GetHistoria()
    {
        return historia;
    }
    public string GetTecnologia()
    {
        return tecnologia;
    }

    //SET
    public void SetEcoMaterialize(string novaEcoMaterialize)
    {
        ecoMaterialize = novaEcoMaterialize;
    }
    public void SetEscolar(string novaEscolar)
    {
        escolar = novaEscolar;
    }
    public void SetEstrangeiro(string novoEstrangeiro)
    {
        estrangeiro = novoEstrangeiro;
    }
    public void SetHistoria(string novaHistoria)
    {
        historia = novaHistoria;
    }
    public void SetTecnologia(string novaTecnologia)
    {
        tecnologia = novaTecnologia;
    }

    public EcoMaterialize(string novaEcoMaterialize, string novaEscolar, string novoEstrangeiro, string novaHistoria, string novaTecnologia)
    {
        ecoMaterialize = novaEcoMaterialize;
        escolar = novaEscolar;
        estrangeiro = novoEstrangeiro;
        historia = novaHistoria;
        tecnologia = novaTecnologia;
    }

    //Funções da classe
    public void Requisitos()
    {
        Console.WriteLine("EcoMaterialize: {0}, Escolar: {1}, Estrangeiro: {2}, História: {3}, Tecnologia: {4}",
                          GetEcoMaterialize(), GetEscolar(), GetEstrangeiro(), GetHistoria(), GetTecnologia());
    }
}

class HelloWorld
{
    static void Main()
    {
        int n = 0;
        string ecoMaterialize = "";
        string escolar = "";
        string estrangeiro = "";
        string historia = "";
        string tecnologia = "";

        Console.WriteLine("Quantos livros você deseja pegar ?");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Você tem algum tipo de livro em mente?");
            string resposta = Console.ReadLine().ToLower();

            if (resposta == "não")
            {
                Console.WriteLine("Você será direcionado para a página principal");
                break; // Sai do loop
            }

            if (resposta == "sim")
            {
                Console.WriteLine("Digite qual tipo de material você deseja pegar?");
                string tipoMaterial = Console.ReadLine().ToLower();

                if (tipoMaterial == "escolar")
                {
                    Console.WriteLine("Você será direcionado para a aba de material escolar");
                }
                else if (tipoMaterial == "tecnologia")
                {
                    Console.WriteLine("Você será direcionado para a aba de material tecnológico");
                }
                else if (tipoMaterial == "estrangeiro")
                {
                    Console.WriteLine("Você será direcionado para a aba de material estrangeiro");
                }
                else if (tipoMaterial == "historia")
                {
                    Console.WriteLine("Você será direcionado para a aba de livros com história");
                    Console.WriteLine("Você tem preferência de gênero? (sim/não)");
                    string generoResposta = Console.ReadLine().ToLower();

                    if (generoResposta == "não")
                    {
                        Console.WriteLine("Você será direcionado para a aba principal de livros com história");
                    }
                    else if (generoResposta == "sim")
                    {
                        Console.WriteLine("Qual gênero você prefere? (terror/narrativo/ação/romance)");
                        string genero = Console.ReadLine().ToLower();

                        if (genero == "terror")
                        {
                            Console.WriteLine("Você será direcionado para a aba de terror");
                        }
                        else if (genero == "narrativo")
                        {
                            Console.WriteLine("Você será direcionado para a aba de narrativo");
                        }
                        else if (genero == "ação")
                        {
                            Console.WriteLine("Você será direcionado para a aba de ação");
                        }
                        else if (genero == "romance")
                        {
                            Console.WriteLine("Você será direcionado para a aba de romance");
                        }
                    }
                }

                EcoMaterialize selecionado = new EcoMaterialize(ecoMaterialize, escolar, estrangeiro, historia, tecnologia);
                selecionado.Requisitos();
            }
        }
    }
}
    