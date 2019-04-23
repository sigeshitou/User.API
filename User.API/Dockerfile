#FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
#WORKDIR /app
#EXPOSE 80
#
#FROM microsoft/dotnet:2.2-sdk AS build
#WORKDIR /src
#COPY ["User.API/User.API.csproj", "User.API/"]
#RUN dotnet restore "User.API/User.API.csproj"
#COPY . .
#WORKDIR "/src/User.API"
#RUN dotnet build "User.API.csproj" -c Release -o /app
#
#FROM build AS publish
#RUN dotnet publish "User.API.csproj" -c Release -o /app
#
#FROM base AS final
#WORKDIR /app
#COPY --from=publish /app .
#ENTRYPOINT ["dotnet", "User.API.dll"]
#

 

FROM microsoft/aspnetcore as build-env

WORKDIR /src

COPY *.csproj /src

RUN dotnet restore

copy . ./src

RUN  dotnet publish -c Release -o out

FROM microsoft/aspnetcore


WORKDIR /app

copy --from=build-env /code/out ./

EXPOSE 80

RUN  dotnet User.API.dll