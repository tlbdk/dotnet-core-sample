# dotnet-core-sample
Simple .NET and EntityFramework Core sample

## TODO

* Ensure .Net Core logging
* Ensure distributed locking support
* Ensure encoding UTF8
* Make sure we save all dates in UTC
* Make sure we always return JSON dates in UTC
* Find out how to do seed data
    * Migrations will break when using the in-memmory database
* Find out how to do migrations
    * Split out data model in own project and have it handle this?
* Read appSettings.json and enviroment config
* Read production secrects
* Authentication / authorization
    * JWT token validation
    * ASP.NET Core Identity
* Import client side SSL certicate without using the certicate store
* Make it possible to debug and develop common nuget package without rebuild/publish first