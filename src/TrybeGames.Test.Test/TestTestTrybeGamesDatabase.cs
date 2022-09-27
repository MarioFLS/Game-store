using Xunit;
using TrybeGames;
using System;
using FluentAssertions;
using TrybeGames.Test;

public class TestTestTrybeGamesDatabase
{
    [Trait("Category", "5 - Buscar jogos jogados por uma pessoa jogadora.")]
    [Theory(DisplayName = "Deve testar se TestGetGamesPlayedBy testa corretamente a função GetGamesPlayedBy.")]
    [MemberData(nameof(DataTestGetGamesPlayedBy))]
    public void TestGetGamesPlayedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected, bool isCorrect)
    {
        TestTrybeGamesDatabase instance = new();
        Action act = () => instance.TestGetGamesPlayedBy(databaseEntry, playerIdEntry, expected);
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
    public static TheoryData<TrybeGamesDatabase, int, List<Game>, bool> DataTestGetGamesPlayedBy => new ()
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            },
            true
        }
    };
}
public class TestTestTrybeGamesDatabase2
{
    [Trait("Category", "6 - Buscar jogos comprados por uma pessoa jogadora.")]
    [Theory(DisplayName = "Deve testar se TestGetGamesOwnedBy testa corretamente a função GetGamesOwnedBy.")]
    [MemberData(nameof(DataTestGetGamesOwnedBy))]
    public void TestGetGamesOwnedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected, bool isCorrect)
    {
        TestTrybeGamesDatabase instance = new();
        Action act = () => instance.TestGetGamesOwnedBy(databaseEntry, playerIdEntry, expected);
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

    public static TheoryData<TrybeGamesDatabase, int, List<Game>, bool> DataTestGetGamesOwnedBy => new ()
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            },
            true
        }
    };
}
public class TestTestTrybeGamesDatabase3
{
    [Trait("Category", "4 - Buscar jogos desenvolvidos por um estúdio de jogos.")]
    [Theory(DisplayName = "Deve testar se TestGetGamesDevelopedBy testa corretamente a função GetGamesDevelopedBy.")]
    [MemberData(nameof(DataTestGetGamesDevelopedBy))]
    public void TestGetGamesDevelopedBy(TrybeGamesDatabase databaseEntry, int gameStudioIdEntry, List<Game> expected, bool isCorrect)
    {
        TestTrybeGamesDatabase instance = new();
        Action act = () => instance.TestGetGamesDevelopedBy(databaseEntry, gameStudioIdEntry, expected);
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

    public static TheoryData<TrybeGamesDatabase, int, List<Game>, bool> DataTestGetGamesDevelopedBy => new ()
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Teste",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Teste"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Teste",
                        GamesOwned = new List<int> { 1 }
                    }
                }
            },
            1,
            new List<Game>
            {
                new Game
                {
                    Id = 1,
                    Name = "Teste",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            },
            true
        }
    };
}
