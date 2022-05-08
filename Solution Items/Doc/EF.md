# Enkle stikkord for oppsett av EF
- Løsningen bruker SQLite
- Database blir lageret på brukers private område.
- Etter at klasser er satt opp blir følgende kommandoer kjørt for å lage databasen

```
dotnet tool install --global dotnet-ef
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet ef migrations add InitialCreate
dotnet ef database update
```

Følgende pakker er tilgjengelig:

```
<PackageReference Include="MediatR" Version="10.0.1" />
   
    <PackageReference Include="Microsoft.EntityFrameworkCore" Version="6.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Design" Version="6.0.4">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Microsoft.EntityFrameworkCore.Sqlite" Version="6.0.4" />
    <PackageReference Include="Microsoft.EntityFrameworkCore.Tools" Version="6.0.4">
      <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
      <PrivateAssets>all</PrivateAssets>
    </PackageReference>
    <PackageReference Include="Swashbuckle.AspNetCore" Version="6.2.3" />   
```

## Linker
[Enkelt oppsett av EF](https://docs.microsoft.com/en-us/ef/core/get-started/overview/first-app?tabs=netcore-cli)