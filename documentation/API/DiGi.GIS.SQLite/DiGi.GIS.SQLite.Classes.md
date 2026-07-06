#### [DiGi\.GIS\.SQLite](index.md 'index')

## DiGi\.GIS\.SQLite\.Classes Namespace
### Classes

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions'></a>

## SQLiteExtractOptions Class

Configuration class for SQLite data extraction options, extending the base [DiGi\.GIS\.Classes\.ExtractOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.extractoptions 'DiGi\.GIS\.Classes\.ExtractOptions')\.

```csharp
public class SQLiteExtractOptions : DiGi.GIS.Classes.ExtractOptions
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → [DiGi\.Core\.Classes\.Object](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.object 'DiGi\.Core\.Classes\.Object') → [DiGi\.Core\.Classes\.SerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableobject 'DiGi\.Core\.Classes\.SerializableObject') → [DiGi\.Core\.Classes\.SerializableOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.core.classes.serializableoptions 'DiGi\.Core\.Classes\.SerializableOptions') → [DiGi\.GIS\.Classes\.ExtractOptions](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.extractoptions 'DiGi\.GIS\.Classes\.ExtractOptions') → SQLiteExtractOptions
### Constructors

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions()'></a>

## SQLiteExtractOptions\(\) Constructor

Initializes a new instance of the [SQLiteExtractOptions](DiGi.GIS.SQLite.Classes.md#DiGi.GIS.SQLite.Classes.SQLiteExtractOptions 'DiGi\.GIS\.SQLite\.Classes\.SQLiteExtractOptions') class\.

```csharp
public SQLiteExtractOptions();
```

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions(string,string)'></a>

## SQLiteExtractOptions\(string, string\) Constructor

Initializes a new instance of the [SQLiteExtractOptions](DiGi.GIS.SQLite.Classes.md#DiGi.GIS.SQLite.Classes.SQLiteExtractOptions 'DiGi\.GIS\.SQLite\.Classes\.SQLiteExtractOptions') class with specified source path and destination directory\.

```csharp
public SQLiteExtractOptions(string sourcePath, string destionationDirectory);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions(string,string).sourcePath'></a>

`sourcePath` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file path to the source SQLite database\.

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions(string,string).destionationDirectory'></a>

`destionationDirectory` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The directory where extracted data should be saved\.

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions(System.Text.Json.Nodes.JsonObject)'></a>

## SQLiteExtractOptions\(JsonObject\) Constructor

Initializes a new instance of the [SQLiteExtractOptions](DiGi.GIS.SQLite.Classes.md#DiGi.GIS.SQLite.Classes.SQLiteExtractOptions 'DiGi\.GIS\.SQLite\.Classes\.SQLiteExtractOptions') class using a JSON object for configuration\.

```csharp
public SQLiteExtractOptions(System.Text.Json.Nodes.JsonObject jsonObject);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SQLiteExtractOptions(System.Text.Json.Nodes.JsonObject).jsonObject'></a>

`jsonObject` [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject')

The [System\.Text\.Json\.Nodes\.JsonObject](https://learn.microsoft.com/en-us/dotnet/api/system.text.json.nodes.jsonobject 'System\.Text\.Json\.Nodes\.JsonObject') containing the extraction options\.
### Properties

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.DestionationDirectory'></a>

## SQLiteExtractOptions\.DestionationDirectory Property

Gets or sets the directory where the extracted data will be saved\.

```csharp
public string DestionationDirectory { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.SourcePath'></a>

## SQLiteExtractOptions\.SourcePath Property

Gets or sets the file path to the source SQLite database\.

```csharp
public string SourcePath { get; set; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

<a name='DiGi.GIS.SQLite.Classes.SQLiteExtractOptions.UpdateExisting'></a>

## SQLiteExtractOptions\.UpdateExisting Property

Gets or sets a value indicating whether existing files in the destination directory should be updated during extraction\.

```csharp
public bool UpdateExisting { get; set; }
```

#### Property Value
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')