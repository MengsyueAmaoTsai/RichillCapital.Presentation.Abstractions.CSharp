# RichillCapital.Identity.Api

## Run Tests

```powershell
dotnet test --no-build /p:CollectCoverage=true /p:CoverletOutputFormat=lcov /p:CoverletOutput=../../coverage/lcov.info -- MSTest.Parallelize.Workers=5
```

## Build Docker Image

```powershell
docker build -t richillcapital-identity-api:latest .
```

## Run as Docker Container

```powershell
docker run -d -p 80:80 --name richillcapital-identity-api richillcapital-identity-api:latest
```

## Run Infrastructure Docker Compose

```powershell
docker compose -f docker-compose.yaml up -d
```

### TODO:

- Authentication (TBD)
- BackgroundTask (Hangfire / Quartz)
- Realtime (SignalR)
- Payments (CoinPayments)
