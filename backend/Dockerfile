FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
RUN ["dotnet", "dev-certs", "https"]
RUN ["dotnet", "dev-certs", "https", "--trust"]
EXPOSE 5000/tcp
CMD ["dotnet", "run"]