# EmanAltaherAssimant
ASP.NET Core 6 Web API project 
Project Setup 
a. Create a new .NET Core Web API project. 
b. Set up ASP.NET Identity for user management and authentication. 
c. Use JWT (Json Web Token) for user authentication. 
d. Implement a database using EF Core Code First approach, and ensure 
Identity tables are created in it. 

 Instructions on how to run and test the application:
 1. run code to open swagger.
 2. test on postman 
 3. to test Registar endpoit need to pass (firstName- lastName-email-username-password)
 4. go to jwt.io site to insure token is right.
 5. to test Login endpoint need to pass (email ,password)


Register endpoint:
Url: https://localhost:44322/api/User/Register 
Method Type : Post 
Request: 
{ 
 "firstName": "Eman", 
  "lastName": "Altaher", 
  "userName": "EmanTaher", 
  "email": "eman999awad@gmail.com", 
  "password": "Sust999Eman#" 
} 
Response: 
{ 
    "message": null, 
    "isAuthentecated": true, 
    "username": "EmanTaher", 
    "email": "eman999awad@gmail.com", 
    "roles": [ 
        "User" 
    ], 
    "token": 
"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJFbWFuVGFoZXIiLCJqdGkiOiIwMzI2NjJhMC04
YzA3LTQ0NDQtOWYyNy1jNjQ2MjMzYTk2MWEiLCJlbWFpbCI6ImVtYW45OTlhd2FkQGdtYWlsLm
NvbSIsInVpZCI6ImRhZTc0NGU4LTQzOTEtNDU0Ny05NTBmLTViYjk5ZGQ5ZTk1ZCIsInJvbGVzIjoiVX
NlciIsImV4cCI6MTczNDI2MzQwOCwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.B
CNHP7CHDUEFUJ5hQBPlgpoO_aPpDdvutVlU_Cn6mq0", 
    "expireOn": "2024-12-15T11:50:08Z" 
} 

Login endpoint:
Url: https://localhost:44322/api/User/Login 
Method Type : Post 
Request: 
{ 
    "email": "eman999awad@gmail.com", 
  "password": "Sust999Eman#" }
  Response: 
{ 
    "message": null, 
    "isAuthentecated": true, 
    "username": "EmanTaher", 
    "email": "eman999awad@gmail.com", 
    "roles": [ 
        "User" 
    ], 
    "token": 
"eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJzdWIiOiJFbWFuVGFoZXIiLCJqdGkiOiJkY2VlNzAwNi0yZ
DE2LTRmYjgtYmMyNi05ZDllMmFlZjU2NmYiLCJlbWFpbCI6ImVtYW45OTlhd2FkQGdtYWlsLmNvbS
IsInVpZCI6ImRhZTc0NGU4LTQzOTEtNDU0Ny05NTBmLTViYjk5ZGQ5ZTk1ZCIsInJvbGVzIjoiVXNlciIs
ImV4cCI6MTczNDI2NTkyMSwiaXNzIjoiU2VjdXJlQXBpIiwiYXVkIjoiU2VjdXJlQXBpVXNlciJ9.8a_X8un
_hHStVJiaJqUWRmPVpOFVjqhtJqrUi-YNZks", 
    "expireOn": "2024-12-15T12:32:01Z" 
} 
