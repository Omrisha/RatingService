# RatingService
Simple REST API service for querying rates value after conversion by base rates and specific destination rates.

The service is built with .NET Core 3.1 and C#.

## Live Demo


## Installation

- Run the command `git clone https://github.com/Omrisha/RatingService`
- Open the SLN file in Visual Studio/Rider/Visual Studio Code
- Run the project (or  `dotnet run` if in VSCode).  

## Usage

- GET /api/Rating/{baseRate}/{value}?symbol=
- GET /api/Rating/{baseRate}/{value}?symbol={rate}&symbol={rate}
 Get values after rate conversion for the requested base rate. the rates values can be set in query string by concatinating symbol values as you wish.

## JSON Example
```
{
    "name": "CAD",
    "value": 640.2681231500001
}
```