[![Build status](https://ci.appveyor.com/api/projects/status/et48yhs1isaten9t?svg=true)](https://ci.appveyor.com/project/tparnell8/xivsync-net)

## What is this?

A C# binding against the XVI sync API binding

## How to use?

basically new up a new `LodeStoneAPI();`

You can search for a character using the name/world, and then get the charater data from the id search results. Or you can find the ID by looking at the url of the character profile you are seraching for

```csharp
var api = new LodestoneApi();
var res = api.SearchCharacter("Lucia Yokoyama", "Midgardsormr");
var data = api.GetCharacter(res.Data.First().Id);
var data = api.GetCharacter("8696200");


```
