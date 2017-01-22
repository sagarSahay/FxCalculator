open System.Drawing

let bitmap = new Bitmap(32, 32)

let path = __SOURCE_DIRECTORY__ + "/"

// left eye
bitmap.SetPixel(6, 2, Color.DarkOrange)
bitmap.SetPixel(6, 4, Color.DarkOrange)
bitmap.SetPixel(8, 2, Color.DarkOrange)
bitmap.SetPixel(8, 4, Color.DarkOrange)

// right eye
bitmap.SetPixel(12, 2, Color.DarkOrange)
bitmap.SetPixel(12, 4, Color.DarkOrange)
bitmap.SetPixel(14, 2, Color.DarkOrange)
bitmap.SetPixel(14, 4, Color.DarkOrange)

//Nose
bitmap.SetPixel(10, 8, Color.DarkOrange)
bitmap.SetPixel(10, 10, Color.DarkOrange)
bitmap.SetPixel(11, 8, Color.DarkOrange)
bitmap.SetPixel(11, 10, Color.DarkOrange)

//right dimple
bitmap.SetPixel(2, 14, Color.DarkOrange)
bitmap.SetPixel(2, 16, Color.DarkOrange)
bitmap.SetPixel(4, 14, Color.DarkOrange)
bitmap.SetPixel(4, 16, Color.DarkOrange)

//left dimple
bitmap.SetPixel(20, 14, Color.DarkOrange)
bitmap.SetPixel(20, 16, Color.DarkOrange)
bitmap.SetPixel(22, 14, Color.DarkOrange)
bitmap.SetPixel(22, 16, Color.DarkOrange)

// teeth
bitmap.SetPixel(6, 22, Color.DarkOrange)
bitmap.SetPixel(12, 24, Color.DarkOrange)
bitmap.SetPixel(13, 22, Color.DarkOrange)
bitmap.SetPixel(16, 24, Color.DarkOrange)
bitmap.SetPixel(17, 22, Color.DarkOrange)
bitmap.SetPixel(19, 24, Color.DarkOrange)




bitmap.Save(path + "plot.png")