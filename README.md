# Mapper Benchmark 
 
<h3>1. Benchmark  Result :</h3>

    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-HIPRHG : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

<table>

<thead>

<tr>

<th>Method</th>

<th>Mean</th>

<th>Error</th>

<th>Min</th>

<th>Max</th>

<th>Median</th>

<th>Gen 0</th>

<th>Gen 1</th>

<th>Gen 2</th>

<th>Allocated</th>

</tr>

</thead>

<tbody>

<tr>

<td>ManuelMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10</td>

<td>46.33 ms</td>

<td>NA</td>

<td>46.33 ms</td>

<td>46.33 ms</td>

<td>46.33 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount100</td>

<td>45.80 ms</td>

<td>NA</td>

<td>45.80 ms</td>

<td>45.80 ms</td>

<td>45.80 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount1000</td>

<td>45.32 ms</td>

<td>NA</td>

<td>45.32 ms</td>

<td>45.32 ms</td>

<td>45.32 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10000</td>

<td>44.36 ms</td>

<td>NA</td>

<td>44.36 ms</td>

<td>44.36 ms</td>

<td>44.36 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10</td>

<td>149.30 ms</td>

<td>NA</td>

<td>149.30 ms</td>

<td>149.30 ms</td>

<td>149.30 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount100</td>

<td>141.98 ms</td>

<td>NA</td>

<td>141.98 ms</td>

<td>141.98 ms</td>

<td>141.98 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount1000</td>

<td>138.81 ms</td>

<td>NA</td>

<td>138.81 ms</td>

<td>138.81 ms</td>

<td>138.81 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10000</td>

<td>143.24 ms</td>

<td>NA</td>

<td>143.24 ms</td>

<td>143.24 ms</td>

<td>143.24 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10</td>

<td>15.48 ms</td>

<td>NA</td>

<td>15.48 ms</td>

<td>15.48 ms</td>

<td>15.48 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount100</td>

<td>15.64 ms</td>

<td>NA</td>

<td>15.64 ms</td>

<td>15.64 ms</td>

<td>15.64 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount1000</td>

<td>15.20 ms</td>

<td>NA</td>

<td>15.20 ms</td>

<td>15.20 ms</td>

<td>15.20 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10000</td>

<td>16.53 ms</td>

<td>NA</td>

<td>16.53 ms</td>

<td>16.53 ms</td>

<td>16.53 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

</tbody>

</table>

<h3>2. Benchmark  Result :</h3>

    
    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-KQFSQK : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

<table>

<thead>

<tr>

<th>Method</th>

<th>Mean</th>

<th>Error</th>

<th>Min</th>

<th>Max</th>

<th>Median</th>

<th>Gen 0</th>

<th>Gen 1</th>

<th>Gen 2</th>

<th>Allocated</th>

</tr>

</thead>

<tbody>

<tr>

<td>ManuelMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10</td>

<td>49.88 ms</td>

<td>NA</td>

<td>49.88 ms</td>

<td>49.88 ms</td>

<td>49.88 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount100</td>

<td>50.26 ms</td>

<td>NA</td>

<td>50.26 ms</td>

<td>50.26 ms</td>

<td>50.26 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount1000</td>

<td>49.35 ms</td>

<td>NA</td>

<td>49.35 ms</td>

<td>49.35 ms</td>

<td>49.35 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10000</td>

<td>52.85 ms</td>

<td>NA</td>

<td>52.85 ms</td>

<td>52.85 ms</td>

<td>52.85 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10</td>

<td>160.09 ms</td>

<td>NA</td>

<td>160.09 ms</td>

<td>160.09 ms</td>

<td>160.09 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount100</td>

<td>163.51 ms</td>

<td>NA</td>

<td>163.51 ms</td>

<td>163.51 ms</td>

<td>163.51 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount1000</td>

<td>169.73 ms</td>

<td>NA</td>

<td>169.73 ms</td>

<td>169.73 ms</td>

<td>169.73 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10000</td>

<td>163.67 ms</td>

<td>NA</td>

<td>163.67 ms</td>

<td>163.67 ms</td>

<td>163.67 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10</td>

<td>16.39 ms</td>

<td>NA</td>

<td>16.39 ms</td>

<td>16.39 ms</td>

<td>16.39 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount100</td>

<td>17.46 ms</td>

<td>NA</td>

<td>17.46 ms</td>

<td>17.46 ms</td>

<td>17.46 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount1000</td>

<td>16.22 ms</td>

<td>NA</td>

<td>16.22 ms</td>

<td>16.22 ms</td>

<td>16.22 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10000</td>

<td>17.07 ms</td>

<td>NA</td>

<td>17.07 ms</td>

<td>17.07 ms</td>

<td>17.07 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

</tbody>

</table>

<h3>3. Benchmark  Result :</h3>
    
    BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.592 (1909/November2018Update/19H2)
    Intel Core i7-9850H CPU 2.60GHz, 1 CPU, 12 logical and 6 physical cores
    .NET Core SDK=5.0.100
      [Host]     : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT  [AttachedDebugger]
      Job-DCGRNS : .NET Core 3.1.9 (CoreCLR 4.700.20.47201, CoreFX 4.700.20.47203), X64 RyuJIT

    IterationCount=1  RunStrategy=ColdStart  

<table>

<thead>

<tr>

<th>Method</th>

<th>Mean</th>

<th>Error</th>

<th>Min</th>

<th>Max</th>

<th>Median</th>

<th>Gen 0</th>

<th>Gen 1</th>

<th>Gen 2</th>

<th>Allocated</th>

</tr>

</thead>

<tbody>

<tr>

<td>ManuelMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ManuelLinqMappingDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10</td>

<td>57.56 ms</td>

<td>NA</td>

<td>57.56 ms</td>

<td>57.56 ms</td>

<td>57.56 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount100</td>

<td>53.01 ms</td>

<td>NA</td>

<td>53.01 ms</td>

<td>53.01 ms</td>

<td>53.01 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount1000</td>

<td>53.58 ms</td>

<td>NA</td>

<td>53.58 ms</td>

<td>53.58 ms</td>

<td>53.58 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AgileMapperLibraryDataCount10000</td>

<td>51.15 ms</td>

<td>NA</td>

<td>51.15 ms</td>

<td>51.15 ms</td>

<td>51.15 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>64 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10</td>

<td>165.70 ms</td>

<td>NA</td>

<td>165.70 ms</td>

<td>165.70 ms</td>

<td>165.70 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount100</td>

<td>159.10 ms</td>

<td>NA</td>

<td>159.10 ms</td>

<td>159.10 ms</td>

<td>159.10 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount1000</td>

<td>161.51 ms</td>

<td>NA</td>

<td>161.51 ms</td>

<td>161.51 ms</td>

<td>161.51 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805520 B</td>

</tr>

<tr>

<td>AutoMapperLibraryDataCount10000</td>

<td>176.04 ms</td>

<td>NA</td>

<td>176.04 ms</td>

<td>176.04 ms</td>

<td>176.04 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>805544 B</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>ExpressMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10</td>

<td>16.91 ms</td>

<td>NA</td>

<td>16.91 ms</td>

<td>16.91 ms</td>

<td>16.91 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount100</td>

<td>16.80 ms</td>

<td>NA</td>

<td>16.80 ms</td>

<td>16.80 ms</td>

<td>16.80 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount1000</td>

<td>17.84 ms</td>

<td>NA</td>

<td>17.84 ms</td>

<td>17.84 ms</td>

<td>17.84 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>MapsterLibraryDataCount10000</td>

<td>16.78 ms</td>

<td>NA</td>

<td>16.78 ms</td>

<td>16.78 ms</td>

<td>16.78 ms</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>24 B</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount100</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount1000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

<tr>

<td>TinyMapperLibraryDataCount10000</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>NA</td>

<td>-</td>

<td>-</td>

<td>-</td>

<td>-</td>

</tr>

</tbody>

</table>
