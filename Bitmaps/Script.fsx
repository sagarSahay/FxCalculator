open System.Drawing

let bitmap = new Bitmap(32,32)

let path = __SOURCE_DIRECTORY__ + "/"

bitmap.Save(path + "large.png")