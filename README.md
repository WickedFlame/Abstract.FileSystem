# Abstract.FileSystem
Abstraction for the .Net Filesystem classes

[![Build status](https://img.shields.io/appveyor/build/chriswalpen/Abstract-FileSystem/master?label=Master&logo=appveyor&style=for-the-badge)](https://ci.appveyor.com/project/chriswalpen/Abstract-FileSystem/branch/master)
[![Build status](https://img.shields.io/appveyor/build/chriswalpen/Abstract-FileSystem/dev?label=Dev&logo=appveyor&style=for-the-badge)](https://ci.appveyor.com/project/chriswalpen/Abstract-FileSystem/branch/dev)


Wrappers for some common classes from System.IO Namespace to create a layer of abstraction

Current implementaitons of System.IO
* Directory
* File

## Usage in code
Instead of using the Namespace System.IO include the Namespace Abstract.FileSystem to use Directory or File.

## Usage in Tests
Abstract.FileSystem.Directory and Abstract.FileSystem.File both have a Factory Property. This can be set through the static method Setup(Func\<IFileService\> service) or Setup(Func\<IDirectoryService\> service).
The Interface IFileService and IDirectoryService both provide the abstraction layers.

```
_service = new Mock<IDirectoryService>();
Directory.Setup(() => _service.Object);
```
Now all Access to Abstract.FileSystem.Directory use the Mock of IDirectoryServerice

# SystemPath
Path behaviour on Linux differs from Windows. For this reason there is a class for SystemPath that manages paths depending on the system that is run on.
```
var path = (SystemPath)"Test" / "Path";
path.ToString();
```
On a Windows this results in
```
Test\Path
```
while on a Unix system the result looks different
```
Test/Path
```