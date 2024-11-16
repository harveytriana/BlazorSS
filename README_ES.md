# Dibujando con C\# en el Navegador

El elemento `<canvas>` del DOM, junto con su API de dibujo en JavaScript, permite generar gráficos dinámicos directamente en el navegador, sin depender de complementos externos. Bien, ¿Cómo generar gráficos directamente en el navegador utilizando puro C\# fuera del mundo JavaScript? Skia es una biblioteca gráfica 2D mantenida por Google que puede integrarse en aplicaciones .NET a través de la librería SkiaSharp. En el caso de aplicaciones Blazor WebAssembly, se utiliza mediante dependencias nativas como SkiaSharp.Views.Blazor y SkiaSharp.NativeAssets.Linux (cuando vas a publicar en un contenedor Docker o en Linux). Dado que estas dependencias son de naturaleza nativa y están escritas principalmente en C, es necesario instalar las Build Tools de .NET para WebAssembly.

> Dentro de sus características técnicas, Blazor WebAssembly permite tomar una DLL escrita en C, C++, Rust e incorporarla al proyecto usando dependencias nativas.

### Ventajas Técnicas

- Al ser Web Assembly, SkiaSharp ofrece un rendimiento gráfico nativo, incluso en el navegador.

- Al ser programado C#, usamos un lenguaje robusto, con tipado fuerte, herramientas de depuración avanzadas y acceso al ecosistema .NET.

- Es loable notar que si escribes una librería que usa SkiaSharp esta se podrá usar y depurar en otros entornos de .NET como MAUI, WinForm, incluso en .NET Framework. 

## Algunos Ejemplos

En este proyecto presento algunos ejemplos interesantes con SkiaSharp sobre Blazor WebAssemply.

### Cuadrícula en Blanco

Esta es una forma básica de demostrar cómo dibujar en un lienzo. Compárelo con el código JavaScript de la API Canvas.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/2.png" style="width:1036px; height:632px;">
</p>

### Líneas Temporizadas

Se dibujan líneas aleatorias en un lienzo cada 250 milisegundos. El lienzo es responsivo.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/3.png" style="width: 1101px; height: 663px;">
</p>

### Fuentes Tipográficas

Muestro una técnica de como podemos usar cualquier tipo de fuente tipográfica en navegados con SkiaSharp. Al ser Web Assembly, tienes que tener el recurso del lado del cliente. En el ejemplo uso un servicio para hacer esto eficiente, y cargas una sola vez, y en demanda.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/4.png" style="width: 1101px; height: 663px;">
</p>

### LaText 

LaTeX es un sistema de composición de documentos de alta calidad, especialmente utilizado en áreas académicas y técnicas para crear documentos con un formato profesional. Se basa en comandos de marcado que permiten al autor enfocarse en el contenido, mientras que el diseño y el formato son gestionados automáticamente por el sistema. Es ideal para documentos con matemáticas complejas, referencias bibliográficas, y gráficos, proporcionando resultados consistentes y precisos. Acá usó una librería de terceros para decodificar el codigo LaTex y generar el gráfico.  
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/5.png" style="width: 1101px; height: 663px;">
</p>

## Conclusión

Con **SkiaSharp** y **Blazor WebAssembly** contamos con herramientas potentes para generar gráficos directamente en el navegador, eliminando la necesidad de depender de JavaScript. Este enfoque no solo simplifica el desarrollo, sino que también representa un paradigma avanzado para aplicaciones gráficas en la web.

## Anexo - Docker

He añadido un Dockerfile para generar la imagen de este proyecto. Es importante destacar que, al tratarse de una aplicación de sitio web, los comandos utilizados difieren de los empleados en una Web API. Además, se ha incluido un archivo de configuración personalizado, nginx.conf, para gestionar la configuración del servidor. Por último, para resolver las dependencias nativas necesarias, los comandos del Dockerfile incorporan la instalación de wasm-tools. En cuanto a la solución Blazor WebAssembly que usa dependencias nativas, para dar soporte a Linux y Docker (por supuesto), agregamos la referencia SkiaSharp.NativeAssets.Linux.

---
<small>By: Luis Harvey Triana Vega</small>