FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

COPY --from=mcr.microsoft.com/dotnet/runtime:8.0 /usr/share/dotnet /usr/share/dotnet

WORKDIR /source

COPY models/ ./models
COPY DeckBuilder.Entities/ ./DeckBuilder.Entities
COPY webapi/ ./webapi
COPY backend.slnx .

RUN dotnet restore

WORKDIR /source/DeckBuilder.Entities/DeckBuilder.Model
RUN dotnet build --configuration Release
WORKDIR /source

RUN dotnet publish -c release -o /app --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app ./

ENV ASPNETCORE_URLS="http://*:5000"

ENTRYPOINT [ "./webapi" ]

