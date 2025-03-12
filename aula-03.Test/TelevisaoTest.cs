using aula_03;

namespace aula_03.Test;

[TestClass]
public class TelevisaoTest
{
    [TestMethod]
    public void Dado_Tamanho_21_Deve_Retornar_Excecao()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Televisao(21f), $"O tamanho(21) não é suportado!");
    }

    [TestMethod]
    public void Dado_Tamanho_81_Deve_Retornar_Excecao()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => new Televisao(81f), $"O tamanho(81) não é suportado!");
    }

    [TestMethod]
    public void Dado_Tamanho_25_Deve_Criar_Instancia()
    {
        const float tamanho = 25f;

        Televisao televisao = new Televisao(tamanho);
        Assert.IsInstanceOfType(televisao, typeof(Televisao));
        Assert.AreEqual(tamanho, televisao.Tamanho);
    }

    [TestMethod]
    public void Deve_Criar_Instancia_Com_Volume_10()
    {
        const int volumePadrao = 10;

        Televisao televisao = new Televisao(25f);
        Assert.AreEqual(volumePadrao, televisao.Volume);
    }

    [TestMethod]
    public void Deve_Ter_Volume_11_Apos_Aumentar_Volume()
    {
        Televisao televisao = new Televisao(25f);
        televisao.AumentarVolume();
        Assert.AreEqual(11, televisao.Volume);
    }

    [TestMethod]
    public void Deve_Ter_Volume_09_Apos_Diminuir_Volume()
    {
        Televisao televisao = new Televisao(25f);
        televisao.DiminuirVolume();
        Assert.AreEqual(09, televisao.Volume);
    }

    [TestMethod]
    public void Deve_Ter_Volume_0_Ao_Mutar()
    {
        Televisao televisao = new Televisao(25f);
        televisao.AlternarModoMudo();
        Assert.AreEqual(0, televisao.Volume);
    }


    [TestMethod]
    public void Deve_Restaurar_Volume_Anterior_Ao_Desmutar()
    {
        Televisao televisao = new Televisao(25f);
        const int volumeInicial = 10;

        televisao.AlternarModoMudo();
        televisao.AlternarModoMudo();

        Assert.AreEqual(volumeInicial, televisao.Volume);
    }

    [TestMethod]
    public void Deve_Manter_Estado_Correto_Com_Multiplas_Alternancias_Mudo()
    {
        Televisao televisao = new Televisao(25f);
        const int volumeInicial = 10;

        televisao.AlternarModoMudo();
        Assert.AreEqual(0, televisao.Volume);

        televisao.AlternarModoMudo();
        Assert.AreEqual(volumeInicial, televisao.Volume);

        televisao.AlternarModoMudo();
        Assert.AreEqual(0, televisao.Volume);
    }

  [TestClass]
public class TelevisaoTest
{
    [TestMethod]
    public void Deve_Avancar_Canal_Corretamente()
    {
        Televisao televisao = new Televisao(32f);
        int canalAtual = televisao.Canal;

        televisao.AvancarCanal();

        Assert.AreEqual(canalAtual + 1, televisao.Canal, "O canal deveria avançar corretamente.");
    }

    [TestMethod]
    public void Deve_Retroceder_Canal_Corretamente()
    {
        Televisao televisao = new Televisao(40f);
        televisao.SelecionarCanal(5);
        
        televisao.RetrocederCanal();

        Assert.AreEqual(4, televisao.Canal, "O canal deveria retroceder corretamente.");
    }

    [TestMethod]
    public void Nao_Deve_Retroceder_Abaixo_Do_Canal_1()
    {
        Televisao televisao = new Televisao(55f);
        
        televisao.RetrocederCanal();

        Assert.AreEqual(1, televisao.Canal, "O canal não pode ser menor que 1.");
    }

    [TestMethod]
    public void Deve_Selecionar_Canal_Especifico()
    {
        Televisao televisao = new Televisao(50f);
        int canalEsperado = 505;

        televisao.SelecionarCanal(canalEsperado);

        Assert.AreEqual(canalEsperado, televisao.Canal, "O canal deveria ser alterado corretamente.");
    }

    [TestMethod]
    public void Nao_Deve_Selecionar_Canal_Negativo()
    {
        Televisao televisao = new Televisao(65f);

        televisao.SelecionarCanal(-5);

        Assert.AreNotEqual(-5, televisao.Canal, "O canal não pode ser negativo.");
    }
}

    
}
