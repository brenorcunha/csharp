using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
//O Angular costuma causar um erro nas páginas, não permitindo que outras apps façam requests na API, esse código (+ o abaixo) resolve isso: 
builder.Services.AddCors();

// Add services to the container.
builder.Services.AddDbContext<World.Cup.Simulation.WorldContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ServerConnection")));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
//O Angular costuma causar um erro nas páginas, não permitindo que outras apps façam requests na API, esse código resolve isso: 
app.UseCors(p => p
    .AllowAnyHeader()
    .AllowAnyOrigin()
    .AllowAnyMethod());

app.MapGet("/api/teams/groups", async (World.Cup.Simulation.WorldContext context) =>
{
    var teams = await context.Teams.ToListAsync();
    var groups = teams.GroupBy(p => p.Group)
    .OrderBy(p => p.Key)
    .Select(p => p.Select(p => p));

    return Results.Ok(groups);
});

app.MapGet("/api/teams/{id}",async(World.Cup.Simulation.WorldContext context, Guid id) => 
{
    var team = await context.Teams.FindAsync(id);
    return Results.Ok(team);
});
app.MapGet("/api/teams",async (World.Cup.Simulation.WorldContext context) =>
{
    var teams = await context.Teams.ToListAsync();
    return Results.Ok(teams);
});
app.MapPost("/api/teams",async(World.Cup.Simulation.WorldContext context, Team team)=>
{
    //await e assync porque estamos trabalhando com contexto assincrono.
    await context.Teams.AddAsync(team);
    await context.SaveChangesAsync();
    return Results.Ok(team);
});

app.MapPut("/api/teams/{id}", async(World.Cup.Simulation.WorldContext context, Team team)=>
{
    var dbTeam = await context.Teams.FindAsync(team.Id);
    if(dbTeam== null) return Results.NotFound();

    dbTeam.Name = team.Name;
    dbTeam.Img = team.Img;

    context.Teams.Update(dbTeam);
    await context.SaveChangesAsync();

    return Results.Ok(dbTeam);
});

app.MapDelete("/api/teams/{id}", async (World.Cup.Simulation.WorldContext context, Guid id)=>
{
    var dbTeam = await context.Teams.FindAsync(id);
    if(dbTeam!=null)
    {
        context.Teams.Remove(dbTeam);
    }
    else
        return Results.NotFound();

    context.Teams.Remove(dbTeam);
    await context.SaveChangesAsync();

    return Results.NoContent();
});

app.UseAuthorization();

app.MapControllers();

app.Run();

public class Team{
    public Guid Id {get; set;}
    public string Name { get; set; }
    public string Group { get; set; }
    public string Img { get; set; }  
} 
/*  
Microsoft.EntityFrameworkCore 6.0.11 - dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.11
Microsoft.EntityFrameworkCore.Sqlserver - dotnet add package Microsoft.EntityFrameworkCore.Sqlserver -v 6.0.11
Microsoft.EntityFrameworkCore 6.0.11  Tools- dotnet add package Microsoft.EntityFrameworkCore.Tools -v 6.0.11
Install node.js from the official website, then type the commands here: 'node -v' and 'npm -v'.

dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
*/