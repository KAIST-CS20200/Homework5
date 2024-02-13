namespace CS220

open Microsoft.VisualStudio.TestTools.UnitTesting

[<TestClass>]
type TestClass () =
  let arrayEqual arr1 arr2 =
    Array.forall2 (fun inner1 inner2 ->
      Array.forall2 (fun expected actual ->
        expected = actual) inner1 inner2) arr1 arr2

  [<TestMethod; Timeout 1000; TestCategory "1">]
  member __.``Problem 1``() =
    let r = Mandelbrot.computeMandelbrot 4 2 1000 -2.0 1.0 -1.0 1.0
    let ans = [| [| 1; 3; 4; 4 |]; [| 0; 0; 0; 0 |] |]
    arrayEqual ans r |> Assert.IsTrue

  [<TestMethod; Timeout 1000; TestCategory "2">]
  member __.``Problem 2``() =
    let r = Mandelbrot.computeMandelbrot 4 4 1000 -1.0 -0.5 0.0 0.5
    let ans =
      [| [| 5; 5; 6; 12 |]
         [| 8; 7; 8; 0 |]
         [| 0; 24; 13; 0 |]
         [| 0; 0; 26; 0 |] |]
    arrayEqual ans r |> Assert.IsTrue

  [<TestMethod; Timeout 1000; TestCategory "3">]
  member __.``Problem 3``() =
    let r = Mandelbrot.computeMandelbrot 10 10 1000 -2.0 -1.0 -0.25 0.25
    let ans =
       [| [| 1; 3; 4; 4; 4; 5; 5; 7; 15; 24 |]
          [| 1; 4; 4; 4; 5; 5; 6; 8; 18; 0 |]
          [| 1; 4; 4; 4; 5; 6; 17; 10; 0; 0 |]
          [| 1; 4; 4; 6; 6; 7; 12; 14; 0; 0 |]
          [| 1; 5; 7; 7; 7; 8; 14; 0; 0; 0 |]
          [| 0; 0; 0; 0; 0; 0; 0; 0; 0; 0 |]
          [| 1; 5; 7; 7; 7; 8; 14; 0; 0; 0 |]
          [| 1; 4; 4; 6; 6; 7; 12; 14; 0; 0 |]
          [| 1; 4; 4; 4; 5; 6; 17; 10; 0; 0 |]
          [| 1; 4; 4; 4; 5; 5; 6; 8; 18; 0 |] |]
    arrayEqual ans r |> Assert.IsTrue
