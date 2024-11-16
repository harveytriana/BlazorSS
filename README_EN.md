# Drawing with C# in the Browser

The `<canvas>` element in the DOM, along with its JavaScript drawing API, enables the creation of dynamic graphics directly in the browser without relying on external plugins. Now, how can we generate graphics directly in the browser using pure C# without venturing into the JavaScript world? Skia is a 2D graphics library maintained by Google that can be integrated into .NET applications through the SkiaSharp library. For Blazor WebAssembly applications, it is used with native dependencies such as SkiaSharp.Views.Blazor and SkiaSharp.NativeAssets.Linux (when deploying to a Docker container or Linux). Since these dependencies are native and primarily written in C, you need to install the .NET Build Tools for WebAssembly.

> Among its technical features, Blazor WebAssembly allows you to take a DLL written in C, C++, Rust and incorporate it into the project using native dependencies.

### Technical Advantages

- Being Web Assembly, SkiaSharp offers native graphics performance, even in the browser.

- Being programmed in C#, we use a robust language, with strong typing, advanced debugging tools and access to the .NET ecosystem.

- It's worth noting that if you write a library using SkiaSharp, it can also be used and debugged in other .NET environments like MAUI, WinForm, and even .NET Framework.

## Some Examples

In this project I present some interesting examples with SkiaSharp on Blazor WebAssemply.

### Blank Grid

This is a basic way to demonstrate how to draw on a canvas. Compare it to the Canvas API JavaScript code.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/2.png" style="width:1036px; height:632px;">
</p>

### Timed Lines

Random lines are drawn on a canvas every 250 milliseconds. The canvas is responsive.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/3.png" style="width: 1101px; height: 663px;">
</p>

### Typographic Fonts

I show a technique on how we can use any type of font in browsers with SkiaSharp. Being Web Assembly, you have to have the resource on the client side. In the example I use a service to make this efficient, and you load it once, and on demand.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/4.png" style="width: 1101px; height: 663px;">
</p>

### LaTeX

LaTeX is a high-quality document preparation system widely used in academic and technical fields to create professionally formatted documents. It relies on markup commands that allow the author to focus on the content while the system automatically handles the design and formatting. It’s ideal for documents with complex mathematics, bibliographic references, and graphics, providing consistent and precise results. Here, a third-party library was used to decode LaTeX code and generate the graphic.
<p align="center">
  <img src="https://github.com/harveytriana/BlazorSS/blob/master/Screens/5.png" style="width: 1101px; height: 663px;">
</p>


## Conclusion

With **SkiaSharp** and **Blazor WebAssembly**, we have powerful tools to generate graphics directly in the browser, eliminating the need to rely on JavaScript. This approach not only simplifies development but also represents an advanced paradigm for web graphical applications.

## Annex - Docker

I have added a Dockerfile to build the image for this project. It is important to note that, since this is a web application, the commands used differ from those for a Web API. Additionally, a custom configuration file, nginx.conf, has been included to manage the server settings. Lastly, to resolve the required native dependencies, the Dockerfile commands include the installation of wasm-tools. As for the Blazor WebAssembly solution that uses native dependencies, to support Linux and Docker (of course), we added the SkiaSharp.NativeAssets.Linux reference.

---
<small>By: Luis Harvey Triana Vega</small>