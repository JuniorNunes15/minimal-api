using minimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades;

[TestClass]
public class AdministradorTest
{
    [TestMethod]
    public void TestarGetSetPropriedades()
    {
        // Arrange
        var adm = new Administrador();

        // Act
        adm.Id = 1;
        adm.Email = "teste";
        adm.Senha = "123";
        adm.perfil = "Adm";

        // Assert
        Assert.AreEqual(1, adm.Id);
        Assert.AreEqual("teste", adm.Email);
        Assert.AreEqual("123", adm.Senha);
        Assert.AreEqual("Adm", adm.perfil);
    }
}
