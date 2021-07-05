namespace anagrams

open System

module anagrams = 
    
    let checkAnagram (words : string array) = 
        let getKey (str : string) = 
            str.ToCharArray() 
            |> Array.sort 
            |> String

        words 
        |> Array.groupBy getKey 
        |> Array.filter (fun (sortedWord, originalWord) -> originalWord.Length > 1)



module Sum =
    let add x y = x + y : int

module ListOfWords = 
    let ReturnSameWord word : string = word

