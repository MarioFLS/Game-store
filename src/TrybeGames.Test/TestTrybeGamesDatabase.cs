using Xunit;
using System;
using FluentAssertions;
using TrybeGames;
using Moq;

namespace TrybeGames.Test;

[Collection("Sequential")]
public class TestTrybeGamesDatabase
{
    [Theory(DisplayName = "Deve testar se GetGamesPlayedBy retorna jogos jogados pela pessoa jogadora corretamente.")]
    [MemberData(nameof(DataTestGetGamesPlayedBy))]
    public void TestGetGamesPlayedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected)
    {

        // Arrange
        Player database = databaseEntry.Players.Find(p => p.Id == playerIdEntry);


        // Act
        List<Game> games = databaseEntry.GetGamesPlayedBy(database);

        // Assert

        games.Should().BeEquivalentTo(expected);
    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesPlayedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
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
            }
        }
    };

    [Theory(DisplayName = "Deve testar se GetGamesOwnedBy retorna jogos da pessoa jogadora corretamente.")]
    [MemberData(nameof(DataTestGetGamesOwnedBy))]
    public void TestGetGamesOwnedBy(TrybeGamesDatabase databaseEntry, int playerIdEntry, List<Game> expected)
    {

        // Arrange
        Player database = databaseEntry.Players.Find(p => p.Id == playerIdEntry);

        // Act
        List<Game> games = databaseEntry.GetGamesOwnedBy(database);

        // Assert

        games.Should().BeEquivalentTo(expected);
    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesOwnedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
    {
        {
            new TrybeGamesDatabase
            {
                Games = new List<Game>
                {
                    new Game
                    {
                        Id = 1,
                        Name = "Zelda Ocarina Of Time",
                        DeveloperStudio = 1,
                        Players = new List<int> { 1 }
                    }
                },
                GameStudios = new List<GameStudio>
                {
                    new GameStudio
                    {
                        Id = 1,
                        Name = "Nintendo"
                    }
                },
                Players = new List<Player>
                {
                    new Player
                    {
                        Id = 1,
                        Name = "Player 1",
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
                    Name = "Zelda Ocarina Of Time",
                    DeveloperStudio = 1,
                    Players = new List<int> { 1 }
                }
            }
        }
    };

    [Theory(DisplayName = "Deve testar se GetGamesDevelopedBy retorna jogos desenvolvidos pelo estúdio corretamente.")]
    [MemberData(nameof(DataTestGetGamesDevelopedBy))]
    public void TestGetGamesDevelopedBy(TrybeGamesDatabase databaseEntry, int gameStudioIdEntry, List<Game> expected)
    {

        // Arrange
        GameStudio database = databaseEntry.GameStudios.Find(gs => gs.Id == gameStudioIdEntry);
        // Act
        List<Game> games = databaseEntry.GetGamesDevelopedBy(database);
        // Assert
        games.Should().BeEquivalentTo(expected);
    }

    public static TheoryData<TrybeGamesDatabase, int, List<Game>> DataTestGetGamesDevelopedBy => new TheoryData<TrybeGamesDatabase, int, List<Game>>
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
            }
        }
    };
}
