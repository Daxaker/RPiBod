module Web

open Nancy
open BotModule 

let inline (?) (parameters:obj) param =
    (parameters :?> Nancy.DynamicDictionary).[param]

type HelloModule() as self =
    inherit NancyModule()
    do
        self.Get("/", fun _ -> Start())
        self.Get("/stop", fun _ -> Stop())