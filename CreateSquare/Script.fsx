open System.Drawing
open System.IO

let bitmap = new Bitmap(16, 16)

let pathAndFileName = Path.Combine(__SOURCE_DIRECTORY__,"square.png")

let square() =
    for x in 2..10 do bitmap.SetPixel(x, 2, Color.Black)
    for x in 2..10 do bitmap.SetPixel(x, 10, Color.Black)
    for y in 2..10 do bitmap.SetPixel(2, y, Color.Black)
    for y in 2..10 do bitmap.SetPixel(10, y, Color.Black)

square()

bitmap.Save(pathAndFileName)

