# build stage/image
FROM archlinux/archlinux:latest AS build
WORKDIR /source
RUN pacman -Syu dotnet-sdk --noconfirm

# copy csproj and restore as distinct layers
COPY *.csproj .
RUN dotnet restore

# copy and publish app and libraries
COPY . .
RUN dotnet publish -c release -o /app --no-restore

# final stage/image
FROM archlinux/archlinux:latest
WORKDIR /app
RUN pacman -Syu dotnet-runtime --noconfirm
COPY --from=build /app .
ENTRYPOINT ["dotnet", "SkiaSharpArchLinux.dll"]