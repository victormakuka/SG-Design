using AuthLibrary.Services;
using Google;
using Google.Apis.Auth;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.DTOs;
using server.Models;

namespace server.Endpoints
{
    public static class UserEndpoints
    {
        public static IEndpointRouteBuilder MapUserAuth(this IEndpointRouteBuilder app)
        {
            app.MapPost("/google", async (DataContext context,ITokenService tokenService,[FromBody] GoogleLoginRequest model) => {

                try
                {
                    var settings = new GoogleJsonWebSignature.ValidationSettings()
                    {
                        Audience = new[] { "353535077307-nqv0s4rge8nh5d3a9eklcoacdijk61hf.apps.googleusercontent.com" }
                    };

                    var payload = await GoogleJsonWebSignature.ValidateAsync(model.IdToken, settings);

                    var user = await context.Users.FirstOrDefaultAsync(u => u.Email == payload.Email);

                    if(user is null)
                        user = new User
                        {
                            Email = payload.Email,
                            Name = payload.Name,
                            PhotoUrl = payload.Picture,
                        };

                    await context.SaveChangesAsync();

                    List<string> roles = ["user"];

                    var token = tokenService.GenerateToken(user, roles);


                    return Results.Ok(token);
                }
                catch (GoogleApiException ex)
                {
                    Console.WriteLine("Ocorreu uma exceção ao fazer o login com google" + ex.Message);
                    return Results.BadRequest("Erro interno do servidor");
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Ocorreu uma exceção ao fazer o login com google" + ex.Message);
                    return Results.BadRequest("Erro interno do servidor");
                }
            });

            app.MapPost("/create-me", async (DataContext context) =>
            {
                await context.Users.AddAsync(new User
                {
                    Email = "edvaldo@gmail.com",
                    Name = "Edvaldo",
                    PhotoUrl = "Mau",
                    Profission = "Programmer"
                });

                await context.SaveChangesAsync();

                return Results.Ok("Duro criado");
            });

            return app;
        }
    }
}
