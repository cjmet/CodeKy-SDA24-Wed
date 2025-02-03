# SDA24-Wed In-Class Demo

## Code Kentucky - Software Development Module

### Aug 2024 - Wed Class

Built on the MauiMudBlazor Template, for future reference and use. But right now we're just working in command line.

&nbsp;

---

<details>
<summary>Angel Hornet Library Installation</summary>

- git submodule init
- git submodule update
</details>

<details>
<summary>Maui MudBlazor Template</summary>
Just a quick template for Maui MudBlazor Hybrid projects.


### Ready for more?

A common pitfall is to jump straight into different components. MudBalzor recommends that you read their Layout page to learn about basic project structure and different ways to use the main layout components.

- [MudBlazor Layouts](https://mudblazor.com/getting-started/layouts)
- [MudBlazor Wireframes](https://mudblazor.com/getting-started/wireframes)


<details>
<summary>Tutorials</summary>

- [Microsoft: Build a .NET MAUI Blazor Hybrid App](https://learn.microsoft.com/en-us/aspnet/core/blazor/hybrid/tutorials/maui?view=aspnetcore-8.0)
- [Microsoft: Build a mobile and desktop App with Blazor Hybrid and .NET MAUI](https://learn.microsoft.com/en-us/training/modules/build-blazor-hybrid/)
</details>

<details>
<summary>Access the Blazor Console</summary>

- F12 -> Console: To access the console for error messages etc, _While the App is Running_ press F12 and Select the Console Button
</details>
</details>


# Blog
## 2025-02-03
- [x] General Cleanup and Housekeeping
	- Oops, check for empty list in the add item front end.
- [x] Add IProduct and IProductRepository, ... 
	- [x] test compile before continuing.
- [x] Add ProductRepository, Basic Implementation, 
	- [x] test compile before continuing.
	- [x] Use two constructors for now, bypassing DI.
- [x] Wire the Repository into the front end and test it.
	- [x] Remove all traces of direct dbcontext access.
	- [x] Careful of state and both EF Core Tracking persistence and transience. 
## Later
- [ ] Add the Logic Layer and Interfaces ... same as Repository
	- [ ] Test Throughly.
- [ ] Convert to DI
	- [ ] Test Throughly.
	- [ ] I want to rewrite Logic and Repository as C#12 Primary Constructor syntax once we implement DI
- [ ] Done.
