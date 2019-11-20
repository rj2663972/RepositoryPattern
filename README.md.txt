Hi this is a base structure of Repository Pattern implemented in .Net Core 3.0.
Folder Structure: a) RP.Web (Frontend project in .Net core)
                  b) RP.API (Not iplemented)
                  c) RP.Application (Contains Interfaces and Services that will be injected in the controllers and they will interact with the corresponding repositories. )
                  d) RP.Domain (Contains DTO and Entities)
                  e) RP.Domain.Core (Contains Base DTO and Base Entities)
                  f) RP.Data (Contains DataContext ,Migrations and Repository)
