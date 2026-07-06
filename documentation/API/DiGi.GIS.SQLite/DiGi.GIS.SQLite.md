#### [DiGi\.GIS\.SQLite](index.md 'index')

## DiGi\.GIS\.SQLite Namespace
### Classes

<a name='DiGi.GIS.SQLite.Convert'></a>

## Convert Class

```csharp
public static class Convert
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Convert
### Methods

<a name='DiGi.GIS.SQLite.Convert.ToDiGi(string)'></a>

## Convert\.ToDiGi\(string\) Method

Converts a SQLite file at the specified path into a [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') object\.

```csharp
public static DiGi.GIS.Classes.GISModel ToDiGi(string path);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToDiGi(string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the SQLite database file\.

#### Returns
[DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')  
A [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') instance if the file exists and contains valid data; otherwise, null\.

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_)'></a>

## Convert\.ToDiGi\<T\>\(SqliteConnection, Func\<T,bool\>\) Method

Deserializes a collection of objects implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') using an existing SQLite connection\.

```csharp
public static System.Collections.Generic.List<T> ToDiGi<T>(SqliteConnection sqliteConnection, System.Func<T,bool> func=null)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_).T'></a>

`T`

The type of objects to deserialize, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_).sqliteConnection'></a>

`sqliteConnection` [Microsoft\.Data\.Sqlite\.SqliteConnection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlite.sqliteconnection 'Microsoft\.Data\.Sqlite\.SqliteConnection')

An open [Microsoft\.Data\.Sqlite\.SqliteConnection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlite.sqliteconnection 'Microsoft\.Data\.Sqlite\.SqliteConnection') to the SQLite database\.

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_).T 'DiGi\.GIS\.SQLite\.Convert\.ToDiGi\<T\>\(SqliteConnection, System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate function used to filter the deserialized objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToDiGi_T_(SqliteConnection,System.Func_T,bool_).T 'DiGi\.GIS\.SQLite\.Convert\.ToDiGi\<T\>\(SqliteConnection, System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of deserialized objects of type \<typeparam ref="T" /\>, or null if the connection is null or no compatible types are found\.

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_)'></a>

## Convert\.ToDiGi\<T\>\(string, Func\<T,bool\>\) Method

Deserializes a collection of objects implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') from a SQLite database file at the specified path\.

```csharp
public static System.Collections.Generic.List<T> ToDiGi<T>(string path, System.Func<T,bool> func=null)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_).T'></a>

`T`

The type of objects to deserialize, which must implement [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\.
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path to the SQLite database file\.

<a name='DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_).func'></a>

`func` [System\.Func&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_).T 'DiGi\.GIS\.SQLite\.Convert\.ToDiGi\<T\>\(string, System\.Func\<T,bool\>\)\.T')[,](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.func-2 'System\.Func\`2')

An optional predicate function used to filter the deserialized objects\.

#### Returns
[System\.Collections\.Generic\.List&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToDiGi_T_(string,System.Func_T,bool_).T 'DiGi\.GIS\.SQLite\.Convert\.ToDiGi\<T\>\(string, System\.Func\<T,bool\>\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1 'System\.Collections\.Generic\.List\`1')  
A list of deserialized objects of type \<typeparam ref="T" /\>, or null if the path is invalid or the file does not exist\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite(thisDiGi.GIS.Classes.GISModel,string)'></a>

## Convert\.ToSQLite\(this GISModel, string\) Method

Serializes a [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') to a SQLite database using the [DiGi\.SQLite\.Classes\.SQLiteWrapper](https://learn.microsoft.com/en-us/dotnet/api/digi.sqlite.classes.sqlitewrapper 'DiGi\.SQLite\.Classes\.SQLiteWrapper')\.

```csharp
public static bool ToSQLite(this DiGi.GIS.Classes.GISModel gISModel, string path);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite(thisDiGi.GIS.Classes.GISModel,string).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') instance containing the data to be serialized\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite(thisDiGi.GIS.Classes.GISModel,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path where the SQLite database should be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serialization process completed successfully; otherwise, false\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,SqliteConnection)'></a>

## Convert\.ToSQLite\<T\>\(this IEnumerable\<T\>, SqliteConnection\) Method

Serializes a collection of objects implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') to a SQLite database using the provided connection\.

```csharp
public static bool ToSQLite<T>(this System.Collections.Generic.IEnumerable<T> serializableObjects, SqliteConnection sqliteConnection)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,SqliteConnection).T'></a>

`T`

A type that implements the [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') interface\.
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,SqliteConnection).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,SqliteConnection).T 'DiGi\.GIS\.SQLite\.Convert\.ToSQLite\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, SqliteConnection\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of objects to be serialized\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,SqliteConnection).sqliteConnection'></a>

`sqliteConnection` [Microsoft\.Data\.Sqlite\.SqliteConnection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlite.sqliteconnection 'Microsoft\.Data\.Sqlite\.SqliteConnection')

The active [Microsoft\.Data\.Sqlite\.SqliteConnection](https://learn.microsoft.com/en-us/dotnet/api/microsoft.data.sqlite.sqliteconnection 'Microsoft\.Data\.Sqlite\.SqliteConnection') used to access the SQLite database\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serialization process completed successfully; otherwise, false\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,string)'></a>

## Convert\.ToSQLite\<T\>\(this IEnumerable\<T\>, string\) Method

Serializes a collection of objects implementing [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') to a SQLite database at the specified path\.

```csharp
public static bool ToSQLite<T>(this System.Collections.Generic.IEnumerable<T> serializableObjects, string path)
    where T : DiGi.Core.Interfaces.ISerializableObject;
```
#### Type parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).T'></a>

`T`

A type that implements the [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject') interface\.
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).serializableObjects'></a>

`serializableObjects` [System\.Collections\.Generic\.IEnumerable&lt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')[T](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).T 'DiGi\.GIS\.SQLite\.Convert\.ToSQLite\<T\>\(this System\.Collections\.Generic\.IEnumerable\<T\>, string\)\.T')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1')

An [System\.Collections\.Generic\.IEnumerable&lt;&gt;](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1 'System\.Collections\.Generic\.IEnumerable\`1') of objects to be serialized\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_T_(thisSystem.Collections.Generic.IEnumerable_T_,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path where the SQLite database should be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serialization process completed successfully; otherwise, false\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_OLD(thisDiGi.GIS.Classes.GISModel,string)'></a>

## Convert\.ToSQLite\_OLD\(this GISModel, string\) Method

Serializes a [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') to a SQLite database using an older implementation method\.

```csharp
public static bool ToSQLite_OLD(this DiGi.GIS.Classes.GISModel gISModel, string path);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_OLD(thisDiGi.GIS.Classes.GISModel,string).gISModel'></a>

`gISModel` [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel')

The [DiGi\.GIS\.Classes\.GISModel](https://learn.microsoft.com/en-us/dotnet/api/digi.gis.classes.gismodel 'DiGi\.GIS\.Classes\.GISModel') instance containing the data to be serialized\.

<a name='DiGi.GIS.SQLite.Convert.ToSQLite_OLD(thisDiGi.GIS.Classes.GISModel,string).path'></a>

`path` [System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')

The file system path where the SQLite database should be stored\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the serialization process completed successfully; otherwise, false\.

<a name='DiGi.GIS.SQLite.Modify'></a>

## Modify Class

```csharp
public static class Modify
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Modify
### Methods

<a name='DiGi.GIS.SQLite.Modify.Extract(thisDiGi.GIS.SQLite.Classes.SQLiteExtractOptions)'></a>

## Modify\.Extract\(this SQLiteExtractOptions\) Method

Extracts data from ZipArchive files based on the provided options and converts them into SQLite structures\.

```csharp
public static bool Extract(this DiGi.GIS.SQLite.Classes.SQLiteExtractOptions sQLiteExtractOptions);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Modify.Extract(thisDiGi.GIS.SQLite.Classes.SQLiteExtractOptions).sQLiteExtractOptions'></a>

`sQLiteExtractOptions` [SQLiteExtractOptions](DiGi.GIS.SQLite.Classes.md#DiGi.GIS.SQLite.Classes.SQLiteExtractOptions 'DiGi\.GIS\.SQLite\.Classes\.SQLiteExtractOptions')

The extraction options containing source path, destination directory, and update settings\.

#### Returns
[System\.Boolean](https://learn.microsoft.com/en-us/dotnet/api/system.boolean 'System\.Boolean')  
True if the extraction process completed successfully; otherwise, false\.

<a name='DiGi.GIS.SQLite.Query'></a>

## Query Class

Provides query\-related utility methods for GIS SQLite operations, including the generation of unique references for serializable objects\.

```csharp
public static class Query
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Query
### Methods

<a name='DiGi.GIS.SQLite.Query.Reference(thisDiGi.Core.Interfaces.ISerializableObject)'></a>

## Query\.Reference\(this ISerializableObject\) Method

Generates a unique string reference for the specified [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')\. 
If the object implements [DiGi\.Core\.Interfaces\.IUniqueObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iuniqueobject 'DiGi\.Core\.Interfaces\.IUniqueObject'), its own reference is used; otherwise, a hash code of its JSON representation is returned\.

```csharp
public static string Reference(this DiGi.Core.Interfaces.ISerializableObject serializableObject);
```
#### Parameters

<a name='DiGi.GIS.SQLite.Query.Reference(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject'></a>

`serializableObject` [DiGi\.Core\.Interfaces\.ISerializableObject](https://learn.microsoft.com/en-us/dotnet/api/digi.core.interfaces.iserializableobject 'DiGi\.Core\.Interfaces\.ISerializableObject')

The serializable object for which to generate a unique reference\.

#### Returns
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
A unique string reference identifying the object, or `null` if the provided [serializableObject](DiGi.GIS.SQLite.md#DiGi.GIS.SQLite.Query.Reference(thisDiGi.Core.Interfaces.ISerializableObject).serializableObject 'DiGi\.GIS\.SQLite\.Query\.Reference\(this DiGi\.Core\.Interfaces\.ISerializableObject\)\.serializableObject') is null\.