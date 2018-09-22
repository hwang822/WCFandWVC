https://www.youtube.com/watch?v=E7Voso411Vs&t=126s

Model.View.Control

Model: Application data and behaviour in terms of its problem domain, and independent of the UI
   Domain: Movie, Customer, Rental, Transaction.

View: The HTML markup that we display to the user

Controller: Responsible for handling an HTTP Request.

View <= Controller => Model

Router: responsiblity of a router a router based on some rules.

Go to Tools/Eextenssion and Updates... Download Productivity Power Tools 2017
                                        Web Essentials 2017

Create project C#/Web/Asp.net/MVC
    RouteConfig: 
	/movies/edit/1
MoviersCOntroler         eidt(1)

Add Dept, DeptView and DeptControler (MVC) in the porject.
first Add Controler Dept. and action results: Display
        public ActionResult Display()
        {
            Dept dept = new Dept() { Name = "Computer Science"};            
            return View(dept);
        }

DeptControler.cs will be added under Conrollers folder and Dept folder will be added under Views folder.


Add Dept.cs under Models.
    public class Dept
    {
        public int Id {get; set; }
        public string Name { get; set; }
    }

Add Display Acction Result View under Views/Dept/

@model MixwellMvc.Models.Dept
@{ 
    ViewBag.Titel = "Display";
    Layout = "~/Views/Shared/_Layout.cshtml";
}
<h2>@Model.Name</h2>

Run F5 will run localhost28327/Dept/Display
Computer Science

*************************************

Add bootswatch.com to get free themes to make web site more buitlful
Select Lumman => Light and shadow
selec bootsstreep.css
save .css file to project Content folder
add bootstrap-lumen.css to the Content.

Open App_start/BundleConfig.cs
change "~/Content/bootstrap.css", => "~/Content/bootstrap-lumen.css",

****************************************************
AP.NET MVC Fundamentals
Entity Framework(Code-firs)
Forms
Validation
Build RESful Services
Client-side Development
Authenication and Authorization


Action Results

Type					Helper Method
ViewResult				View()
RaitialViewResult		PartialView()
ContentResutl			Content()
RedirectResult			Redirect()
RedirectToRouteResult	RedirectToAction()
JsonResult				Json()
FileResult				File()
HttpNotFoundResult		HttpNotFound()
EmptyResult

**********************
Custom Route
define RouteConfig

Got Github
//https://github.com/mosh-hamedani/vidly-mvc-5/commits/master
