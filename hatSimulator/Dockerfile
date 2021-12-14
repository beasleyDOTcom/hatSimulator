#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["hatSimulator.csproj", "."]
RUN dotnet restore "./hatSimulator.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "hatSimulator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "hatSimulator.csproj" -c Release -o /app/publish
# DO WE NEED THIS?
# RUN adduser \
#   --disabled-password \
#   --home /app \
#   --gecos '' app \
#   && chown -R app /app
# USER app
RUN addgroup --group face --gid 2000 \
&& adduser \
--uid 1000 \
--gid 2000 \
"mayonaise"

RUN chown mayonaise:face /app
USER mayonaise:face 

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV ASPNETCORE_HTTPS_PORT=$PORT
ENV ASPNETCORE_URLS=$("http://*:"+$PORT)
ENTRYPOINT ["dotnet", "hatSimulator.dll"]