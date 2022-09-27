using Xunit;
using System;
using FluentAssertions;
using TrybeGames;
using Moq;

namespace TrybeGames.Test;

[Collection("Sequential")]
public class TestTrybeGamesController
{
    [Theory(DisplayName = "Deve testar se AddPlayer adiciona uma pessoa jogadora corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddPlayer))]
    public void TestTestAddPlayer(string name, Player expected)
    {
        // Arrange
        var mockConsole = new Mock<IConsole>();

        // Mocando função .ReadLine do console para retornar o nome do jogador
        mockConsole.Setup(c => c.ReadLine()).Returns(name);
        var database = new TrybeGamesDatabase();
        var controller = new TrybeGamesController(database, mockConsole.Object);

        // Act
        controller.AddPlayer();

        // Assert
        controller.database.Players[0].Should().BeEquivalentTo(expected);
    }

    public static TheoryData<string, Player> DataTestTestAddPlayer => new TheoryData<string, Player>
    {
        {
            "Teste",
            new Player(){ Name = "Teste", Id = 1 }
        }
    };

    [Theory(DisplayName = "Deve testar se AddGameStudio adiciona um estúdio de jogos corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddGameStudio))]
    public void TestTestAddGameStudio(string name, GameStudio expected)
    {
        throw new NotImplementedException();

        // Arrange

        // Act

        // Assert
    }

    public static TheoryData<string, GameStudio> DataTestTestAddGameStudio => new TheoryData<string, GameStudio>
    {
        {
            "Teste",
            new GameStudio(){ Name = "Teste", Id = 1 }
        }
    };

    [Theory(DisplayName = "Deve testar se AddGame adiciona um jogo corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddGame))]
    public void TestTestAddGame(string name, string date, string gameType, Game expected)
    {
        throw new NotImplementedException();

        // Arrange

        // Act

        // Assert
    }

    public static TheoryData<string, string, string, Game> DataTestTestAddGame => new TheoryData<string, string, string, Game>
    {
        {
            "Teste",
            "01/01/2020",
            "0",
            new Game(){ Name = "Teste", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action }
        }
    };
}
