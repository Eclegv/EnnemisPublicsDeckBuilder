# EnnemisPublicsDeckBuilder

## Running Locally 

### With Docker

Since this project images aren't push to docker or ghcr, you'll have to build it yourself
```
docker compose up -d --build
```
The build parameter forces a build of the Dockerfiles everytime you rerun the command

If you want to update the images because new commits appear, you'll just have to `git pull` then `docker compose up -d --build`

### Without docker

Without Docker is a bit more tricky because the project containing the entities (DeckBuilder.Entities/DeckBuilder.Model) needs to be built separatly because of build order causing a ruckus
#### Backend

##### Restore the packages
1. Go to backend folder
2. `dotnet restore`

##### Build Entities
1. `cd backend/DeckBuilder.Entities/DeckBuilder.Model`
2. `dotnet build --configuration Release`

##### Build the rest of the project
1. Go back to backend folder
2. `dotnet build --configuration Release`

##### Run Backend
 1. `dotnet run  --environment ASPNETCORE_ENVIRONMENT=Development --project webapi/webapi.csproj`

 #### Frontend

 ##### Restore the packages
 1. Go to frontend folder
 2. `npm install`

 ##### Run the frontend
 1. Go to frontend folder
 2. `npm run dev`