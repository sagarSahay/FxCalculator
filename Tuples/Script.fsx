//let location = 77.51,166.40,21
//
//let longAlt location = 
// let long,_,alt= location
// (alt, long)
//
//printfn "%A" (snd(longAlt location))

let birthday = 09,08,86

let testFunc birthday =
   let dd,mm,yy = birthday
   (yy,dd,mm)

printfn "%A" (testFunc birthday)