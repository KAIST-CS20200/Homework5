module CS220.Mandelbrot

open Browser.Dom
open Browser.Types

/// Write this function, which computes the Mandelbrot set:
/// https://en.wikipedia.org/wiki/Mandelbrot_set.
/// https://en.wikipedia.org/wiki/Plotting_algorithms_for_the_Mandelbrot_set
///
/// Please read the Wiki page first before you proceed.
///
/// This function takes in 7 parameters, and returns a 2D array (int array
/// array) as output. The parameters are:
/// 1. `width`: the number of horizontal pixels to draw.
/// 2. `height`: the number of vertical pixels to draw.
/// 3. `maxIter`: the maximum number of iterations to perform to check if a
///               given point is in the Mandelbrot set.
/// 4. `xMin`: the minimum x-coordinate of the region to draw (float).
/// 5. `xMax`: the maximum x-coordinate of the region to draw (float). `xMin`
///            and `xMax` define the horizontal range of the region to draw in
///            the complex plane.
/// 6. `yMin`: the minimum y-coordinate of the region to draw (float).
/// 7. `yMax`: the maximum y-coordinate of the region to draw (float). `yMin`
///            and `yMax` define the vertical range of the region to draw in the
///            complex plane.
///
/// This function returns the result for each pixel on a screen. For example, if
/// the `width` and `height` are 4 and 2, respectively, and if `xMin` and `xMax`
/// are -2.0 and 1.0, and if `yMin` and `yMax` are -1.0 and 1.0, then the
/// function returns a list that looks like: [ [1; 3; 4; 4]; [0; 0; 0; 0] ].
/// The number `0` in the list means that the corresponding pixel is in the
/// Mandelbrot set. The number greater than `0` means that the corresponding
/// pixel is not in the Mandelbrot set, and the number represents the number of
/// iterations it took to determine that the pixel is not in the Mandelbrot set.
/// The very first `1` in the above list corresponds to the pixel at the upper
/// left corner of the screen, and the very last `0` corresponds to the pixel at
/// the lower right corner of the screen.
///
/// You can safely assume that `width` and `height` are always greater than 0,
/// and `maxIter` is always greater than or equal to 0. You can also assume that
/// `xMin` is always less than `xMax`, and `yMin` is always less than `yMax`.
let computeMandelbrot width height maxIter xMin xMax yMin yMax =
  failwith "Implement"

///////////////////////////////////////////////////////////////////////////////
/// Do not modify below unless you know what you are doing.
///////////////////////////////////////////////////////////////////////////////

let show xMin xMax yMin yMax =
  let coords = computeMandelbrot 500 300 200 xMin xMax yMin yMax
  let width, height = 500, 300
  let canvas = document.getElementsByTagName("canvas")[0] :?> HTMLCanvasElement
  let ctx = canvas.getContext_2d ()
  let img = ctx.createImageData(float width, float height)
  for y = 0 to height-1 do
    for x = 0 to width-1 do
      let i = (x + y * width) * 4
      let color = coords[y][x] |> byte
      img.data[i] <- color
      img.data[i+1] <- color
      img.data[i+2] <- color
      img.data[i+3] <- 255uy
  ctx.putImageData (img, 0.0, 0.0)

let drawButton = document.getElementById "btn_draw"

let toValue (elm: HTMLElement) = (elm :?> HTMLInputElement).value |> float

let getInputs () =
  let xMin = document.getElementById "xmin" |> toValue
  let xMax = document.getElementById "xmax" |> toValue
  let yMin = document.getElementById "ymin" |> toValue
  let yMax = document.getElementById "ymax" |> toValue
  xMin, xMax, yMin, yMax

drawButton.onclick <- (fun _ ->
  let xMin, xMax, yMin, yMax = getInputs ()
  show xMin xMax yMin yMax)
