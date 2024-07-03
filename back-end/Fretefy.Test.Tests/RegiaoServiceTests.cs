using Fretefy.Test.Domain.Entities;
using Fretefy.Test.Domain.Interfaces.Repositories;
using Fretefy.Test.Domain.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Fretefy.Test.Tests
{
    public class RegiaoServiceTests
    {
        private readonly Mock<IRegiaoRepository> _mockRegiaoRepository;
        private readonly Mock<ICidadeRepository> _mockCidadeRepository;
        private readonly Mock<IRegiaoCidadeRepository> _mockRegiaoCidadeRepository;
        private readonly RegiaoService _regiaoService;

        public RegiaoServiceTests()
        {
            _mockRegiaoRepository = new Mock<IRegiaoRepository>();
            _mockCidadeRepository = new Mock<ICidadeRepository>();
            _mockRegiaoCidadeRepository = new Mock<IRegiaoCidadeRepository>();
            _regiaoService = new RegiaoService(_mockRegiaoRepository.Object, _mockCidadeRepository.Object, _mockRegiaoCidadeRepository.Object);
        }

        [Fact]
        public void Get_ShouldReturnListOfRegioes()
        {
            // Arrange
            var regioes = new List<Regiao> { new Regiao { Id = Guid.NewGuid(), Nome = "Regiao1" } };
            _mockRegiaoRepository.Setup(r => r.GetRegiaoCompleta()).Returns(regioes);

            // Act
            var result = _regiaoService.Get();

            // Assert
            Assert.Single(result);
            Assert.Equal("Regiao1", result.First().Nome);
        }

        [Fact]
        public async Task AddRegiao_ShouldThrowException_WhenRegiaoExists()
        {
            // Arrange
            var regiao = new Regiao { Id = Guid.NewGuid(), Nome = "Regiao1", Cidades = new List<RegiaoCidade>() };
            _mockRegiaoRepository.Setup(r => r.ExisteRegiao(It.IsAny<string>())).ReturnsAsync(true);

            // Act & Assert
            var exception = await Assert.ThrowsAsync<Exception>(() => _regiaoService.AddRegiao(regiao));
            Assert.Equal("Região com nome Regiao1 já registrada na base de dados", exception.Message);
        }

        [Fact]
        public async Task UpdateRegiao_ShouldUpdateRegiaoCorrectly()
        {
            // Arrange
            var regiaoId = Guid.NewGuid();
            var regiao = new Regiao { Id = regiaoId, Nome = "Regiao1", Cidades = new List<RegiaoCidade>() };
            _mockRegiaoRepository.Setup(r => r.ExisteRegiao(It.IsAny<string>())).ReturnsAsync(false);
            _mockRegiaoRepository.Setup(r => r.Update(It.IsAny<Regiao>())).Returns(Task.CompletedTask);
            _mockRegiaoCidadeRepository.Setup(r => r.DeleteCidades(It.IsAny<Guid>()));

            // Act
            await _regiaoService.UpdateRegiao(regiao);

            // Assert
            _mockRegiaoRepository.Verify(r => r.Update(It.IsAny<Regiao>()), Times.Once);
            _mockRegiaoCidadeRepository.Verify(r => r.DeleteCidades(It.IsAny<Guid>()), Times.Once);
        }
    }
}


