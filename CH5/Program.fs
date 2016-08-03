(*namespace Test*)
module Program =
    open PoliceChase
    [<EntryPoint>]
    let main argv =
        simulation() 
        printfn "%A" argv
        0 // return an integer exit code
  
