using Xunit;
using System.IO;
using System;
using FluentAssertions;
using TrybeGames.Test;
using TrybeGames;

namespace TrybeGames.Test.Test;

[Collection("Sequential")]
public class TestTestTrybeGames
{
    [Trait("Category", "1 - Adicionar uma nova pessoa jogadora ao banco de dados.")]
    [Theory(DisplayName = "Deve testar se AddPlayer adiciona uma pessoa jogadora corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddPlayer))]
    public void TestTestAddPlayer(string name, Player expected, bool isCorrect)
    {
        TestTrybeGamesController instance = new();
        Action act = () => instance.TestTestAddPlayer(name, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

    public static TheoryData<string, Player, bool> DataTestTestAddPlayer => new()
    {
        {
            "Teste",
            new Player(){ Name = "Teste", Id = 1 },
            true
        },
        {
            "Teste",
            new Player(){ Name = "Teste1", Id = 1 },
            false
        },
        {
            "Teste2",
            new Player(){ Name = "Teste2", Id = 3 },
            false
        },
        {
            "Teste2",
            new Player(){ Name = "Teste2", Id = 0 },
            false
        },
        {
            "Teste2",
            new Player(){ Name = "Teste1", Id = 1 },
            false
        }
    };
}
public class TestTestTrybeGames2
{
    [Trait("Category", "2 - Adicionar novo Estúdio de Jogos ao banco de dados.")]
    [Theory(DisplayName = "Deve testar se AddGameStudio adiciona um estúdio de jogos corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddGameStudio))]
    public void TestTestAddGameStudio(string name, GameStudio expected, bool isCorrect)
    {
        TestTrybeGamesController instance = new();
        Action act = () => instance.TestTestAddGameStudio(name, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

    public static TheoryData<string, GameStudio, bool> DataTestTestAddGameStudio => new()
    {
        {
            "Teste",
            new GameStudio(){ Name = "Teste", Id = 1 },
            true
        },
        {
            "Teste",
            new GameStudio(){ Name = "Teste1", Id = 1 },
            false
        },
        {
            "Teste2",
            new GameStudio(){ Name = "Teste2", Id = 3 },
            false
        },
        {
            "Teste2",
            new GameStudio(){ Name = "Teste2", Id = 0 },
            false
        },
        {
            "Teste2",
            new GameStudio(){ Name = "Teste1", Id = 1 },
            false
        }
    };
}
public class TestTestTrybeGames3
{
    [Trait("Category", "3 - Adicionar novo Jogo ao Banco de dados.")]
    [Theory(DisplayName = "Deve testar se AddGame adiciona um jogo corretamente ao banco de dados.")]
    [MemberData(nameof(DataTestTestAddGame))]
    public void TestTestAddGame(string name, string date, string gameType, Game expected, bool isCorrect)
    {
        TestTrybeGamesController instance = new();
        Action act = () => instance.TestTestAddGame(name, date, gameType, expected);
        if (isCorrect)
        {
            act.Should().NotThrow<Xunit.Sdk.XunitException>();
        }
        else
        {
            act.Should().Throw<Xunit.Sdk.XunitException>();
        }
        
        act.Should().NotThrow<NotImplementedException>();
    }

    public static TheoryData<string, string, string, Game, bool> DataTestTestAddGame => new ()
    {
        {
            "Teste",
            "01/01/2020",
            "0",
            new Game(){ Name = "Teste", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action },
            true
        },
        {
            "Teste",
            "01/01/2020",
            "1",
            new Game(){ Name = "Teste1", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Adventure },
            false
        },
        {
            "Teste2",
            "01/01/2020",
            "4",
            new Game(){ Name = "Teste2", Id = 3, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Simulation },
            false
        },
        {
            "Teste2",
            "01/01/2020",
            "0",
            new Game(){ Name = "Teste2", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Adventure },
            false
        },
        {
            "Teste2",
            "01/01/2020",
            "0",
            new Game(){ Name = "Teste1", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action },
            false
        },
        {
            "Teste",
            "01/01/2020",
            "3",
            new Game(){ Name = "Teste", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action },
            false
        },
        {
            "Teste",
            "02/01/2020",
            "0",
            new Game(){ Name = "Teste", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action },
            false
        },
        {
            "Teste1",
            "01/01/2020",
            "0",
            new Game(){ Name = "Teste", Id = 1, ReleaseDate = new DateTime(2020, 01, 01), GameType = GameType.Action },
            false
        },
    };
}
