# Starting image
FROM microsoft/dotnet:latest

# Copy files from directory to new directory
COPY . /api

WORKDIR ./api

run ["dotnet", "restore"]
RUN ["dotnet", "restore"]

ENV ASPNETCORE_URLS http://*:5001
EXPOSE 5000/tcp

ENTRYPOINT ["dotnet", "run"]