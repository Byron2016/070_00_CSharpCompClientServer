<div>
	<div>
		<img src=https://raw.githubusercontent.com/Byron2016/00_forImages/main/images/Logo_01_00.png align=left alt=MyLogo width=200>
	</div>
	&nbsp;
	<div>
		<h1>070_00_CSharpCompClientServer</h1>
	</div>
</div>

&nbsp;

## Project Description

**ClientServer.Web** is a practice ot the using of a **Cliente - Server comunication c#**. With jquery, AJAX and Fetch, following gavilanch2's tutorial [Escenarios: C# vs Javascript vs AJAX | AJAX | Programando en ASP.NET MVC 5](https://www.youtube.com/watch?v=_G9_98x2oso) and the other help that you can find into **Reference** section.
&nbsp;

## Technologies used

![CSharp](https://img.shields.io/static/v1?label=&message=csharp&color=blueviolet&logo=csharp&logoColor=white&style=for-the-badge)
![.NET7.0](https://img.shields.io/static/v1?label=&message=.Net7.0&color=blueviolet&logo=.net&logoColor=white&style=for-the-badge)
![SQL](https://img.shields.io/static/v1?label=&message=SQLServer&color=red&logo=sql&logoColor=white&style=for-the-badge)
![JQuery](https://img.shields.io/static/v1?label=&message=jquery&color=blue&logo=sql&logoColor=white&style=for-the-badge)
![AJAX](https://img.shields.io/static/v1?label=&message=ajax&color=blue&logo=sql&logoColor=white&style=for-the-badge)
![FETCH](https://img.shields.io/static/v1?label=&message=Fetch&color=blue&logo=sql&logoColor=white&style=for-the-badge)

## References

- Ajax
	- By Satya Karki
		-  [How To Post Data In ASP.NET Using AJAX Without JSON Form Serializer](https://www.c-sharpcorner.com/article/how-to-post-data-in-asp-net-using-ajax-without-json-form-serializer/)
		-  [How To Post Data In ASP.NET Core Using Ajax](https://www.c-sharpcorner.com/article/how-to-post-data-in-asp-net-core-using-ajax/)

	- By Manas Mohapatra
	    - [AJAX In ASP.NET](https://www.c-sharpcorner.com/article/ajax-in-asp-net/)

	- By Desarrollo Web
	    - [AJAX](https://desarrolloweb.com/home/ajax#track1)
## Steps

1. Create these new projects with these caracteristics:
	- Type: ASP.NET Core Web App (Model-view-Controller)
	- Projects Name: ClientServer.Web
	- Solution Name: ClientServer
	- Framework: .NET 6.0 (Standard Term Support) 
	- Authentication type: Individual Accounts
	- Configure for HTTPS: true
	- Do not use top-level-statements: true

2. Modify view **index** of **controller** Home add this code:

	```c#
	@{
		ViewData["Title"] = "Home Page";
	}

	<div class="text-center">
		<h1 class="display-4">Ajax - jquery - Fetch ejamples</h1>
	</div>

	<!-- Nav tabs -->
	<ul class="nav nav-tabs" id="myTab" role="tablist">
		<li class="nav-item" role="presentation">
			<button class="nav-link active" id="home-tab" data-bs-toggle="tab" data-bs-target="#home" type="button" role="tab" aria-controls="home" aria-selected="true">Example 1</button>
		</li>
		<li class="nav-item" role="presentation">
			<button class="nav-link" id="profile-tab" data-bs-toggle="tab" data-bs-target="#profile" type="button" role="tab" aria-controls="profile" aria-selected="false">Example 2</button>
		</li>
		<li class="nav-item" role="presentation">
			<button class="nav-link" id="messages-tab" data-bs-toggle="tab" data-bs-target="#messages" type="button" role="tab" aria-controls="messages" aria-selected="false">Example 3</button>
		</li>
		<li class="nav-item" role="presentation">
			<button class="nav-link" id="settings-tab" data-bs-toggle="tab" data-bs-target="#settings" type="button" role="tab" aria-controls="settings" aria-selected="false">Example 4</button>
		</li>
	</ul>

	<!-- Tab panes -->
	<div class="tab-content">
		<div class="tab-pane active" id="home" role="tabpanel" aria-labelledby="home-tab">

			<div id="Ejemplo1">
				<h1 class="display-6">Example 1: jquery.post simple</h1>

				<form>
					<div class="mb-3">
						<label for="txtDuplicador" class="form-label">Valor a duplicar</label>
						<input type="text" class="form-control" id="txtDuplicador" aria-describedby="valorDuplicarHelp" value="2">
						<div id="valorDuplicarHelp" class="form-text">Ingresar el valor a duplicar.</div>
					</div>

					<div class="mb-3">
						<label class="form-label">Duplicado</label>
						<div class="col-auto">
							<span id="spanDuplicado" class="form-text">
							</span>
						</div>
					</div>

					<div class="mb-3">
						<button type="button" class="btn btn-primary" id="btnDuplicarJ">Double-JQUERY</button>
						<button type="button" class="btn btn-success" id="btnDuplicarA">Double-AJAX</button>
						<button type="button" class="btn btn-warning" id="btnDuplicarF">Double-FETCH</button>
					</div>
				</form>
			</div>

		</div>

		<div class="tab-pane" id="profile" role="tabpanel" aria-labelledby="profile-tab">

			<div id="Ejemplo2">
				<h1 class="display-6">Example 2: JQUERY - POST (sending an object)</h1>
				<form>
					<div class="mb-3">
						<label for="txtNombre" class="form-label">Name</label>
						<input type="text" class="form-control" id="txtNombre" aria-describedby="nombreHelp" value="nombre1">
						<div id="nombreHelp" class="form-text">Enter your name.</div>
					</div>
					<div class="mb-3">
						<label for="txtEdad" class="form-label">Age</label>
						<input type="number" class="form-control" id="txtEdad" aria-describedby="edadHelp" value="56">
						<div id="edadHelp" class="form-text">Enter your age.</div>
					</div>

					<div class="mb-3">
						<button type="button" class="btn btn-primary" id="btnCrearPersonaJ">Create-JQUERY</button>
						<button type="button" class="btn btn-success" id="btnCrearPersonaA">Create-AJAX</button>
						<button type="button" class="btn btn-warning" id="btnCrearPersonaF">Create-FETCH</button>
					</div>
				</form>
			</div>

		</div>
		
		<div class="tab-pane" id="messages" role="tabpanel" aria-labelledby="messages-tab">

			<div id="Ejemplo3">
				<h1 class="display-6">Example 3: JQUERY - GET (load a section of the page asynchronously)</h1>

				<form>
					<div class="mb-3">
						<button type="button" class="btn btn-primary" id="btnCargarJ">Create-JQUERY</button>
						<button type="button" class="btn btn-success" id="btnCargarA">Create-AJAX</button>
						<button type="button" class="btn btn-primary" id="btnCargarF">Create-FETCH</button>
						<button type="button" class="btn btn-warning" id="btnLimpiar">Clean</button>
					</div>
				</form>
				<div id="divGet"> </div>
			</div>

		</div>
		
		<div class="tab-pane" id="settings" role="tabpanel" aria-labelledby="settings-tab">

			<div id="Ejemplo4">
				<h1 class="display-6">Example 4: AJAX, envío de parámetros primitivos y complejos.</h1>

				<form>
					<div class="mb-3">
						<label for="txtNombre4" class="form-label">Nombre</label>
						<input type="text" class="form-control" id="txtNombre4" aria-describedby="nombreHelp4" value="nomb">
						<div id="nombreHelp4" class="form-text">Ingresar el nombre.</div>
					</div>
					<div class="mb-3">
						<label for="txtEdad4" class="form-label">Edad</label>
						<input type="number" class="form-control" id="txtEdad4" aria-describedby="edadHelp4" value="25">
						<div id="edadHelp4" class="form-text">Ingresar la edad.</div>
					</div>
					<div class="mb-3">
						<label for="txtDuplicador4" class="form-label">Valor a duplicar</label>
						<input type="text" class="form-control" id="txtDuplicador4" aria-describedby="valorDuplicarHelp4" value="6">
						<div id="valorDuplicarHelp4" class="form-text">Ingresar el valor a duplicar.</div>
					</div>

					<div class="mb-3">
						<button type="button" class="btn btn-primary" id="btnCrearPersona4">Crear</button>
						<button type="button" class="btn btn-success" id="btnCrearPersona4A">CrearAjax</button>
						<button type="button" class="btn btn-warning" id="btnCrearPersona4F">CrearFETCH</button>
					</div>
				</form>
			</div>


		</div>
	</div>

	@section scripts{
		<script>
			$(function (){
				//
			}
		</script>
	}
	```
3. JQUERY:

	- Sending a primitive param
		- Add Result class

			```c#
			namespace ClientServer.Web.Models
			{
				public class Result
				{
					public int amountDouble { get; set; }
					public int amountValue { get; set; }
				}
			}
			```

		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					public JsonResult ToDouble(int amountValue)
					{
						var amountDouble = amountValue * 2;

						var result = new Result()
						{
							AmountDouble = amountDouble,
							AmountValue = amountValue
						};

						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){

							function manejaErrorJquery(err) {
								if(err.status === 404){
									console.log(`Resource not found - ${err.status}`);
								} else {
									console.log(err.responseText);
								}
								console.log(err);
							}

							// Add event listener to btnDuplicarJ button
							const btnDuplicarJ = document.getElementById('btnDuplicarJ');
							btnDuplicarJ.addEventListener("click", ExOneJPost, false);

							function ExOneJPost() {
								console.log("Example 1");
								const url = '@Url.Action("ToDouble","Home")'
								const cantidad = document.getElementById('txtDuplicador').value;
								const data = { amountValue: cantidad };

								$.post(url, data)
									.done(
										function (data) {
											//se ejecuta si la operación fue un éxito
											console.clear();
											console.log("successes");
											console.log(data);
											$("#spanDuplicado").html(data.amountDouble);
										})
									.fail(manejaErrorJquery)
									.always(function () {
										//Esta función siempre se ejecuta
										console.log("always run");

									});
							}
						});
					</script>
				}
			```
		
	- Sending a complex param
		- Add Person class

			```c#
			namespace ClientServer.Web.Models
			{
				public class Person
				{
					public string? Name { get; set; }
					public int Age { get; set; }
				}
			}
			```

		- Add BaseResult class

			```c#
			namespace ClientServer.Web.Models
			{
				public class BaseResult
				{
					public bool Ok { get; set; }
					public string? Mensaje { get; set; }
				}
			}
			```

		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					public JsonResult ToDouble(int amountValue)
					{
						var amountDouble = amountValue * 2;

						var result = new Result()
						{
							AmountDouble = amountDouble,
							AmountValue = amountValue
						};

						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....

							const btnCrearPersonaJ = document.getElementById('btnCrearPersonaJ');
							btnCrearPersonaJ.addEventListener('click', ExTwoJPost, false);

							function ExTwoJPost(){
								console.clear();
								console.log("Example 2 jquery");
								const url = '@Url.Action("CreatePersonJ", "Home")';
								const name = $("#txtNombre").val();
								const age = $("#txtEdad").val();
								const data = { Name: name, Age: age };

								$.post(url, data)
									.done(function (data) {
										if (data.ok) {
											console.log(`DONE - OK Mensaje:  ${data.mensaje}`);
										} else {
											console.log(`DONE - NO OK Mensaje: ${data.mensaje}`);
										}
									})
									.fail(manejaErrorJquery)
									.always(function () {
										//Esta función siempre se ejecuta
										console.log("always run");

									});

							};
						});
					</script>
				}
			```

	- Returning a partial view
		- Add partial view **_PeopleList** to Homecontroller

			```c#
			@model IEnumerable<ClientServer.Web.Models.Person>

			<table class="table table-striped">
				<tr>
					<th>
						@Html.DisplayNameFor(model => model.Name)
					</th>
					<th>
						@Html.DisplayNameFor(model => model.Age)
					</th>
				</tr>
				@foreach (var item in Model)
				{
					<tr>
						<td>
							@Html.DisplayFor(Item => item.Name)
						</td>
						<td>
							@Html.DisplayFor(Item => item.Age)
						</td>
					</tr>
				}

			</table>
			```

		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					[HttpGet]
					public PartialViewResult AddPeopleListJ(string data, int valnum)
					{
						var valorPasado = data;
						var person = new List<Person>()
						{
							new Person(){Name = "a", Age=2},
							new Person(){Name = "a1", Age=19},
							new Person(){Name = "a2", Age=53},
						};

						return PartialView("_PeopleList", person);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....

							$("#btnLimpiar").click(function () {
								$("#divGet").html("");
							});

							const btnCargarJ = document.getElementById('btnCargarJ');
							btnCargarJ.addEventListener('click', ExTreeJGet, false);

							function ExTreeJGet() {
								console.clear();
								console.log("Example 3 jquery");

								const url = '@Url.Action("AddPeopleListJ", "Home")';

								$("#divGet").html("");

								console.log("antes llamar a .get");

								let data = { data: "param", valnum: 5 };

								$.get(url,data)
									.done(function (data) {
										console.log("respuesta en .get done");
										$("#divGet").append(data);
									})
									.fail(manejaErrorJquery)
									.always(function () {
										//Esta función siempre se ejecuta
										console.log("respuesta en .get always");

									});

								console.log("luego llamar a .get");
							}
						});
					</script>
				}
			```
4. AJAX:

	- Sending a primitive param
		<br></br>
		**Satya Karki** shows two forms to call a **ajax** function depending if it is serealizated o no. 

		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					[HttpPost]
					public JsonResult ToDoubleAjax([FromBody] int amountValue)
					{
						var amountDouble = amountValue * 2;

						var result = new Result()
						{
							AmountDouble = amountDouble,
							AmountValue = amountValue
						};

						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....
							const btnDuplicarA = document.getElementById('btnDuplicarA');
							btnDuplicarA.addEventListener("click", ExOneAPost, false);

							function ExOneAPost() {
								//Example 1: jQuery.post
								//www.youtube.com/watch?v=6kgYrpugYJA
								console.clear();
								console.log("Example 1 ajax");
								const url = '@Url.Action("ToDoubleAjax","Home")'
								const amountValue = document.getElementById('txtDuplicador').value;
								const data = amountValue;

								$.ajax({
									url: url,
									data: data,
									type: 'POST',
									contentType: 'application/json; charset=utf-8',
									beforeSend: function () {
										console.log("ANTES");
									},
									success: function (result) {
										console.clear();
										console.log(result);
										$("#spanDuplicado").html(result.amountDouble);
									},
									complete: function () {
										console.log("COMPLETE");
									},
									failure: function (jqXHR, textStatus, errorThrown) {
										//alert("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText); // Display error message
									},
									error: function () {
										//alert('Failed to receive the Data');
										console.log('Failed ');
										console.log("ERROR - " + xhr.responseText);
									}
								})
							};
							
						});
					</script>
				}
			```

	- Sending a complex param
		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....

					[HttpPost]
					public JsonResult CreatePersonAjax([FromBody] Person people)
					{
						//FromBody: learn.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api
						//Utilamos una clase base para todas nuestras comunicaciones para establecer un estandard
						var result = new BaseResult();

						try
						{
							if (people.Age < 18)
							{
								throw new ApplicationException("The person cannot be less than 18 years old");
							}

							//código para crear persona...
							result.Mensaje = "person created successfully";
							result.Ok = true;
						}
						catch (Exception ex)
						{
							result.Ok = false;
							result.Mensaje = ex.Message;
						}
						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....
							const btnCrearPersonaA = document.getElementById('btnCrearPersonaA');
							btnCrearPersonaA.addEventListener('click', ExTwoAPost, false);

							function ExTwoAPost() {
								console.clear();
								console.log("Example 2 ajax");
								const url = '@Url.Action("CreatePersonAjax", "Home")';
								const name = $("#txtNombre").val();
								const age = $("#txtEdad").val();
								const data = { Name: name, Age: age };

								$.ajax({
									url: url,
									data: JSON.stringify(data),
									type: 'POST',
									contentType: 'application/json; charset=utf-8',
									beforeSend: function () {
										console.log("ANTES");
									},
									success: function (result) {
										console.clear();
										console.log("DONE - " + result.mensaje);
									},
									complete: function () {
										console.log("COMPLETE");
									},
									failure: function (jqXHR, textStatus, errorThrown) {
										//alert("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText); // Display error message
									},
									error: function () {
										//alert('Failed to receive the Data');
										console.log('Failed ');
										console.log("ERROR - " + xhr.responseText);
									}
								})
							}

						});
					</script>
				}
			```

	- Returning a partial view
		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					[HttpGet]
					public PartialViewResult AddPeopleListJ(string data, int valnum)
					{
						var valorPasado = data;
						var person = new List<Person>()
						{
							new Person(){Name = "a", Age=2},
							new Person(){Name = "a1", Age=19},
							new Person(){Name = "a2", Age=53},
						};

						return PartialView("_PeopleList", person);
					}
					
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....
							const btnCargarA = document.getElementById('btnCargarA');
							btnCargarA.addEventListener('click', ExTreeAPost, false);

							function ExTreeAPost() {
								console.clear();
								console.log("Example 3 ajax");
								const url = '@Url.Action("AddPeopleListJ", "Home")';

								$("#divGet").html("");

								console.log("antes llamar a .get");

								let data = { data: "param", valnum: 5 };

								$.ajax({
									url: url,
									data: data,
									type: 'GET',
									contentType: 'application/json',
									dataType: 'text',
									beforeSend: function () {
										console.log("ANTES");
									},
									success: function (result) {
										console.log("EXITO");
										$("#divGet").append(result);
									},
									complete: function () {
										console.log("COMPLETE");
									},
									failure: function (jqXHR, textStatus, errorThrown) {
										//alert("Status: " + jqXHR.status + "; Error: " + jqXHR.responseText); // Display error message
									},
									error: function (xhr) {
										console.log("ERROR - " + xhr.responseText);
										console.log(xhr);
									}
								});

							}

							
						});
					</script>
				}
			```

5. FETCH:

	- Sending a primitive param
		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					[HttpPost]
					public JsonResult ToDoubleAjax([FromBody] int amountValue)
					{
						var amountDouble = amountValue * 2;

						var result = new Result()
						{
							AmountDouble = amountDouble,
							AmountValue = amountValue
						};

						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							$("#btnDuplicarF").click(function () {
								console.clear();
								console.log("ejemplo 1 FLECH");
								$("#spanDuplicado").html("");

								const url = "@Url.Action("ToDoubleAjax","Home")";
								const cantidad = $("#txtDuplicador").val();
								const data = cantidad;

								postData1(url, cantidad )
									.then(data => {
										console.log(data); // JSON data parsed by `data.json()` call
										$("#spanDuplicado").html(data.amountDouble);
									});

							});

							// Ejemplo implementando el metodo POST:
							async function postData1(url = '', data = 0) {
								console.log(data);
								// Opciones por defecto estan marcadas con un *
								const response = await fetch(url, {
									method: 'POST', // *GET, POST, PUT, DELETE, etc.
									mode: 'cors', // no-cors, *cors, same-origin
									cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
									credentials: 'same-origin', // include, *same-origin, omit
									headers: {
										'Content-Type': 'application/json'
										// 'Content-Type': 'application/x-www-form-urlencoded',
									},
									redirect: 'follow', // manual, *follow, error
									referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
									body: JSON.stringify(data) // body data type must match "Content-Type" header
								});
								return response.json(); // parses JSON response into native JavaScript objects
							}
						
						});
					</script>
				}
			```

	- Sending a complex param
		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....

					[HttpPost]
					public JsonResult CreatePersonAjax([FromBody] Person people)
					{
						//FromBody: learn.microsoft.com/en-us/aspnet/web-api/overview/formats-and-model-binding/parameter-binding-in-aspnet-web-api
						//Utilamos una clase base para todas nuestras comunicaciones para establecer un estandard
						var result = new BaseResult();

						try
						{
							if (people.Age < 18)
							{
								throw new ApplicationException("The person cannot be less than 18 years old");
							}

							//código para crear persona...
							result.Mensaje = "person created successfully";
							result.Ok = true;
						}
						catch (Exception ex)
						{
							result.Ok = false;
							result.Mensaje = ex.Message;
						}
						return Json(result);
					}
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....
							const btnCrearPersonaF = document.getElementById('btnCrearPersonaF');
							btnCrearPersonaF.addEventListener('click', ExTwoFPost, false);

							function ExTwoFPost() {
								console.clear();
								console.log("Example 2 fetch");
								const url = '@Url.Action("CreatePersonAjax", "Home")';
								const name = $("#txtNombre").val();
								const age = $("#txtEdad").val();
								const data = { Name: name, Age: age };

								postData2(url, data)
									.then(data => {
										console.log("DONE - " + data.mensaje); // JSON data parsed by `data.json()` call
									});

							}

							// Ejemplo implementando el metodo POST:
							async function postData2(url = '', data = {}) {
								console.log(data);
								// Opciones por defecto estan marcadas con un *
								const response = await fetch(url, {
									method: 'POST', // *GET, POST, PUT, DELETE, etc.
									mode: 'cors', // no-cors, *cors, same-origin
									cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
									credentials: 'same-origin', // include, *same-origin, omit
									headers: {
										'Content-Type': 'application/json'
										// 'Content-Type': 'application/x-www-form-urlencoded',
									},
									redirect: 'follow', // manual, *follow, error
									referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
									body: JSON.stringify(data) // body data type must match "Content-Type" header
								});
								return response.json(); // parses JSON response into native JavaScript objects
							}

						});
					</script>
				}
			```

	- Returning a partial view
		- Add method to HomeController

			```c#
			using ClientServer.Web.Models;
			using Microsoft.AspNetCore.Mvc;
			using System.Diagnostics;

			namespace ClientServer.Web.Controllers
			{
				public class HomeController : Controller
				{
					....
					[HttpGet]
					public PartialViewResult AddPeopleListJ(string data, int valnum)
					{
						var valorPasado = data;
						var person = new List<Person>()
						{
							new Person(){Name = "a", Age=2},
							new Person(){Name = "a1", Age=19},
							new Person(){Name = "a2", Age=53},
						};

						return PartialView("_PeopleList", person);
					}
					
				}
			}
			```

		- Add javascript code to index view of HomeController

			```javascript
				@section scripts{
					<script>
						$(function (){
							....
							const btnCargarF = document.getElementById('btnCargarF');
							btnCargarF.addEventListener('click', ExTreeFPost, false);

							function ExTreeFPost() {
								console.clear();
								console.log("Example 3 fetch");
								let url = '@Url.Action("AddPeopleListJ", "Home")';
								const data = { data: "param", valnum: 5 };

								url = `${url}?data=${data.data}&valnum=${data.valnum}`;

								$("#divGet").html("");

								console.log("antes llamar a .get");

								postData3(url, data)
									.then(data => {
										console.log("DONE " );
										$("#divGet").append(data); // JSON data parsed by `data.json()` call
									});

								console.log("luego llamar a .get");
							}

							// Ejemplo implementando el metodo POST:
							async function postData3(url = '', data = {}) {
								console.log(data);
								// Opciones por defecto estan marcadas con un *
								//OJO: con GET no puede enviarse body.
								const response = await fetch(url, {
									method: 'GET', // *GET, POST, PUT, DELETE, etc.
									mode: 'cors', // no-cors, *cors, same-origin
									cache: 'no-cache', // *default, no-cache, reload, force-cache, only-if-cached
									credentials: 'same-origin', // include, *same-origin, omit
									headers: {
										'Content-Type': 'application/json'
										// 'Content-Type': 'application/x-www-form-urlencoded',
									},
									redirect: 'follow', // manual, *follow, error
									referrerPolicy: 'no-referrer', // no-referrer, *no-referrer-when-downgrade, origin, origin-when-cross-origin, same-origin, strict-origin, strict-origin-when-cross-origin, unsafe-url
									//body: JSON.stringify(data) // body data type must match "Content-Type" header
								});

								console.log(response);
								return response.text();
								//return response.json(); // parses JSON response into native JavaScript objects
							}
							
						});
					</script>
				}
			```