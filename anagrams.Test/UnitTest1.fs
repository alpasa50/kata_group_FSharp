module anagrams.Test

open NUnit.Framework
open anagrams

[<TestFixture>]
type TestClass () =

    [<Test>]
    member this.TestMethodPassing() =
        Assert.True(true)

    //[<Test>]
    // member this.FailEveryTime() = Assert.True(false)
    
    [<Test>]
     member this.TestingSumFunc() = 
        let expected = 13
        let actual = anagrams.Sum.add 5 8
        Assert.That(actual, Is.EqualTo(expected));

    // [<Test>]
    //  member this.WillReturnSameString() = 
    //     let expected = "hello"
    //     let actual = anagrams.ListOfWords.ReturnSameWord "hello"
    //     Assert.That(actual, Is.EqualTo(expected));

    [<Test>]
    //arrays of key : values [("moor", ["romo"; "moro"])]
     member this.CheckAnagramWillReturnArrayOfAnagrams() =
        let expected = [("moor", ["romo"; "moro"])]
        let actual = anagrams.checkAnagram([| "romo"; "moro" |])
        Assert.That(actual, Is.EqualTo(expected));

    [<Test>]
     member this.CheckAnagramIfThereIsNotAnagramsShouldReturnAnEmptyList() =
        let expected = []
        let actual = anagrams.checkAnagram([|"hola"; "adios"|])
        Assert.That(actual, Is.EqualTo(expected))

    // [<Test>]
    //  member this.NiceTestTry() =
    //     let actual = 0
    //     let expected = anagrams.a
    //     Assert.That(actual, Is.EqualTo(expected));

