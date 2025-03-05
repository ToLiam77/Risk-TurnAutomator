using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "Risk Battle Simulator API",
        Version = "v1",
        Description = "Simulates a battle between attackers and defenders using dice rolls.",
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// API Endpoint
app.MapGet("/battle", (int attTroops, int defTroops) =>
{
    var result = FindWinner(attTroops, defTroops);
    return Results.Json(result);
}).WithName("SimulateBattle");

app.Run();

// Battle Simulation Logic
static BattleResult FindWinner(int attTroops, int defTroops)
{
    var battleLog = new BattleResult { InitialAttackers = attTroops, InitialDefenders = defTroops };

    int roundCouter = 0;
    while (defTroops > 0 && attTroops > 1)
    {
        roundCouter++;

        int attDice = Math.Min(3, attTroops - 1);
        int defDice = Math.Min(2, defTroops);

        int[] attackerRolls = RollDice(attDice);
        int[] defenderRolls = RollDice(defDice);

        for (int i = 0; i < Math.Min(attDice, defDice); i++)
        {
            if (defenderRolls[i] >= attackerRolls[i])
                attTroops--;
            else
                defTroops--;
        }

        battleLog.Rounds.Add(new BattleRound
        {
            Round = roundCouter,
            AttackerRolls = attackerRolls,
            DefenderRolls = defenderRolls,
            RemainingAttackers = attTroops,
            RemainingDefenders = defTroops
        });
    }

    battleLog.AttackersRemaining = attTroops;
    battleLog.DefendersRemaining = defTroops;
    battleLog.Winner = defTroops == 0 ? "Attackers" : "Defenders";

    return battleLog;
}

static int[] RollDice(int numDice)
{
    int[] rolls = Enumerable.Range(0, numDice).Select(_ => Random.Shared.Next(1, 7)).ToArray();
    Array.Sort(rolls);
    Array.Reverse(rolls);
    return rolls;
}

// Data Models
public class BattleResult
{
    public int InitialAttackers { get; set; }
    public int InitialDefenders { get; set; }
    public int AttackersRemaining { get; set; }
    public int DefendersRemaining { get; set; }
    public string Winner { get; set; }
    public List<BattleRound> Rounds { get; set; } = new List<BattleRound>();
}

public class BattleRound
{
    public int Round { get; set; }
    public int[] AttackerRolls { get; set; }
    public int[] DefenderRolls { get; set; }
    public int RemainingAttackers { get; set; }
    public int RemainingDefenders { get; set; }
}