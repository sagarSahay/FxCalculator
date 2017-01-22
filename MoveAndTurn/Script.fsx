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

let turn amt plotter:Plotter =
    let newDir = plotter.direction + amt
    let angled = { plotter with direction = newDir}
    printfn "%A" angled
    angled
    //plotter

let move dist plotter:Plotter = 
    let currPos = plotter.position
    let angle = plotter.direction
    let startX= fst currPos
    let startY = snd currPos
    let rads = (angle-90.0) * Math.PI/180.0
    let endX = (float startX) + (float dist) * cos rads
    let endY = (float startY) + (float dist) *sin rads
    let plotted = naiveLine plotter (int endX,int endY)
    printfn "%A" plotted
    plotted

let bitmap = new Bitmap(100,30)

let initialPlotter = {
    position=(5,20)
    color=Color.Red
    direction= 180.0
    bitmap=bitmap
    }


let pathAndFileName = Path.Combine(__SOURCE_DIRECTORY__,"turnAndMove.png")

//(move 30
//     (turn -90.0 
//        (move 25 initialPlotter))).bitmap.Save(pathAndFileName)


//(move 15
//    (turn 90.0 
//        (move 30 
//            (turn 180.0 
//                (move 20 
//                    (turn 90.0 
//                        (move 60 
//                            (turn 180.0 
//                                (move 15 initialPlotter))))))))).bitmap.Save(pathAndFileName)

(move 15 initialPlotter).bitmap.Save(pathAndFileName)