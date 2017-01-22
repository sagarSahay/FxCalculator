open System.Drawing
open System.IO
open System

type Plotter = {
    position: int*int
    color: Color
    direction: float
    bitmap: Bitmap
}

let naiveLine plotter (x1,y1)=
    let updatedPlotter = {plotter with position=(x1,y1)}
    let (x0,y0) = plotter.position
    let {bitmap = currentBitmap} = plotter
    let {color = currentColor} = plotter
    let xLen = float (x1- x0)
    let yLen = float(y1-y0)

    let x0,yo,x1,y1 = if x0 > x1 then x1,y1,x0,y0 else x0,y0,x1,y1
    if xLen <> 0.0 then
        for x in x0..x1 do
            let proportion = float(x-x0) / xLen
            let y = int ((proportion*yLen)) + y0
            printfn "%i" y 
            currentBitmap.SetPixel(x,y, currentColor)

    let x0,yo,x1,y1 = if y0 > y1 then x1,y1,x0,y0 else x0,y0,x1,y1
    if yLen <> 0.0 then
        for y in y0..y1 do
            let proportion = float(y-y0) / yLen
            let x = (int((proportion * xLen))) + x0
            printfn "%i" x
            currentBitmap.SetPixel(x,y, currentColor)

    updatedPlotter

let turn amt plotter =
    plotter

let move dist plotter = 
    plotter

let bitmap = new Bitmap(64, 64)

let initialPlotter = {position=(32, 32);color=Color.Red;direction=6.0;bitmap=bitmap}

let drawn = naiveLine initialPlotter (44,44)

//naiveLine (3,7) (4,27) Color.Red bitmap
//naiveLine (6,7) (10,27) Color.Blue bitmap
//naiveLine (10,7) (13,20) Color.Green bitmap
//naiveLine (13,7) (17,17) Color.Orange bitmap
//naiveLine (16,7) (22,17) Color.Black bitmap

let pathAndFileName = Path.Combine(__SOURCE_DIRECTORY__,"naiveRefactor.png")

drawn.bitmap.Save(pathAndFileName)