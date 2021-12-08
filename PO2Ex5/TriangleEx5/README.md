<a name='assembly'></a>
# TriangleEx5

## Contents

- [Triangle](#T-TriangleEx5-Triangle 'TriangleEx5.Triangle')
  - [#ctor(cote1,cote2,cote3)](#M-TriangleEx5-Triangle-#ctor-System-Int32,System-Int32,System-Int32- 'TriangleEx5.Triangle.#ctor(System.Int32,System.Int32,System.Int32)')
  - [GetParameter()](#M-TriangleEx5-Triangle-GetParameter 'TriangleEx5.Triangle.GetParameter')
  - [Scale(scale)](#M-TriangleEx5-Triangle-Scale-System-Int32- 'TriangleEx5.Triangle.Scale(System.Int32)')

<a name='T-TriangleEx5-Triangle'></a>
## Triangle `type`

##### Namespace

TriangleEx5

##### Summary

Classe gérant des triangles de tout type avec trois côtés arbitraires

<a name='M-TriangleEx5-Triangle-#ctor-System-Int32,System-Int32,System-Int32-'></a>
### #ctor(cote1,cote2,cote3) `constructor`

##### Summary

Contructeur qui prend les trois côtés en paramètre.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| cote1 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Premier côté |
| cote2 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Seconde côté |
| cote3 | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Troisième côté |

<a name='M-TriangleEx5-Triangle-GetParameter'></a>
### GetParameter() `method`

##### Summary

Calcule le périmètre en fonction des valeurs contenues dans le triangle

##### Returns

Le périmètre calculé (int)

##### Parameters

This method has no parameters.

<a name='M-TriangleEx5-Triangle-Scale-System-Int32-'></a>
### Scale(scale) `method`

##### Summary

Construit un nouveau triangle à partir de celui-ci et d'un paramètre multiplicateur

##### Returns

Le nouveau Triangle

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scale | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Le multiplicateur |
