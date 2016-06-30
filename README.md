#Turlogg

Turlogg is a fun project that I am working on to get to know and play with geoJson,
PostgreSQL, PostGis and ASP.Net Core 1.0.

My goal is to have pure fun with the project and hopefully I will learn a lot of new stuff
about working with geo-data.

Production: http://turlogg.teilin.net

#Local Development Configuration

To set the enviroment, use the enviroment variables on the platform:

```
REM On Windows
set ASPNETCORE_ENVIRONMENT=Development
REM On OSX
export ASPNETCORE_ENVIRONMENT=Development
```

To configure the secret values, use the user-secret command, e.g.:

```
dotnet user-secrets set ConnectionStrings:DefaultConnection ConnectionStrings
dotnet user-secrets set AppSettings:ConnectionString ConnectionString
dotnet user-secrets set AppSettings:NasjonalTurbaseApiKey NasjonalTurbaseApiKey
```

#Resources

In this project I am planning on combining data from Kartverket and Nasjonalturbase. I will also
use [LeafletJS](http://leafletjs.com).

* [LeafletJS](http://leafletjs.com)
* [GEONORGE](https://www.geonorge.no)
* [Kartverket: Gratis kartdata](http://www.kartverket.no/Kart/Gratis-kartdata/)
* [Turistforeningen: nasjonalturbase](http://www.nasjonalturbase.no)
* [Kartverket: Mitt Turkart](http://www.norgeskart.no/turkart/?_ga=1.265007375.1039435351.1467234080#9/282656/6555014)
