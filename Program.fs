module CS220.Program

open System
open Giraffe
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Logging

let js (path: string): HttpHandler =
  fun (_next: HttpFunc) (ctx: HttpContext) ->
    task {
        ctx.SetContentType "text/javascript"
        return! ctx.WriteFileStreamAsync (false, path, None, None)
    }

let webApp =
  choose [
    route "/" >=> htmlFile "index.html"
    routexp "/(.*)" (fun s -> js $"Mandelbrot/{Seq.item 1 s}")
  ]

let errorHandler (ex: Exception) (logger: ILogger) =
  clearResponse
  >=> setStatusCode 404 >=> text "Not found"

let configureApp (app: IApplicationBuilder) =
  app.UseGiraffeErrorHandler(errorHandler)
     .UseGiraffe(webApp)

let configureServices (services: IServiceCollection) =
  services.AddGiraffe () |> ignore

[<EntryPoint>]
let main _args =
  Host.CreateDefaultBuilder()
      .ConfigureWebHostDefaults(fun webHostbuilder ->
        webHostbuilder.Configure(configureApp)
                      .ConfigureServices(configureServices)
        |> ignore)
      .Build()
      .Run()
  0
