<img src="https://raw.githubusercontent.com/SnowflakePowered/michi/master/michi.png" width=64> Michi
=====

[![NuGet](https://img.shields.io/nuget/v/Michi.svg)](https://www.nuget.org/packages/Michi)
[![Codecov](https://img.shields.io/codecov/c/github/SnowflakePowered/michi.svg)](https://codecov.io/github/SnowflakePowered/michi)
[![AppVeyor branch](https://img.shields.io/appveyor/ci/RonnChyran/michi.svg)](https://ci.appveyor.com/project/RonnChyran/michi)


Michi is a lightweight, barebones framework on implementing inter-process function calls from .NET.
Michi does not specify a wire format, handling of consumers must be implemented manually.

With Michi, you can call this:

```c#

public class MyCustomObject 
{
  public string StringToEcho { get; }
}

// some class declaration ...

[RemoteFunction("EchoObject", "@")]
public string Echo(MyCustomObject myObject)
{
  return myObject.StringToEcho;
}

[RemoteFunction("Echo", "@")]
public string Echo(string stringToEcho)
{
  return stringToEcho + " from C#!";
}
```

like this*: 

```es6
let requestObj = michi.create("EchoObject", "@", { "myObject" : { "StringToEcho" : "Hello World" } });
let response = await michi.request(requestObj);
console.log(response.Result); // "Hello World"

// ...

let requestObj = michi.create("Echo", "@", { "stringToEcho" : "Hello World" } );
let response = await michi.request(requestObj);
console.log(response.Result); // "Hello World from C#!"
```

or like this

```http
curl -XPOST -d '{ "stringToEcho" : "There's a man they call The Skipper fast asleep" }' 'http://localhost:8080/michi/@/Echo'

Connection: keep-alive
Content-Encoding: gzip
Content-Type: text/json
Vary: Accept-Encoding
X-Michi-Ver: 3.2.0

"There's a man they call The Skipper fast asleep from C#!"
```
You can do more things too like..

```c#
[RemoteFunction("ObjectsAreCool", "@")]
public object EchoObject(string stringToEcho)
{
  return { WhenYou = "Are too lazy to create a real class" };
}
```

and use that like this..

```es6
let requestObj = michi.create("ObjectsAreCool", "@");
let response = await michi.request(requestObj);
console.log(response.Result.WhenYou); // "Are too lazy to create a real class"
```


You can do even do things like..

```c#
[RemoteFunction("Error", "@")]
public void Error()
{
  throw new Exception("Error World!"); //throw a .NET Exception
}

[RemoteFunction("IGotYouFam", "BadIdeas")]
public void Exit()
{
  Environment.Exit(0); //Close everything unexpectedly
}
```

and call them like this:

```es6
let requestObj = michi.create("Error", "@");
let response = await michi.request(requestObj);
console.log(response.IsSuccess); // false
console.log(response.Error.Message); // "Error World!"

// ...

let requestObj = michi.create("IGotYouFam", "BadIdeas");
let response = await michi.request(requestObj);
//Error: WebSocket connection closed unexpectedly by the server. 
```

\*_michi.js not (yet) included_

But Michi is designed to be barebones and dependency-less, so none of these examples are possible until you implement a [`IRemoteHandler`](https://github.com/SnowflakePowered/michi/tree/master/Michi/Handlers) for these transports, see the wiki for more details. 


Michi was created for [Snowflake](http://snowflakepowe.red).

