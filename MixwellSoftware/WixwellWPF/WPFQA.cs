/*
1. What is the need of WPF when we had winform
   A-Run at Windows or Web
   B-Bindings 
   C-Resource and Styles
   D-XAML
   E-Animation
   F-Hardware acceleration
   G-resolutin independent
2. What is XAML in WPF and why do we need it?
   XAML for UI would run WPF or Sliverlight (in window, web, mobile...)
  
3. What is xmins in XAML file?
   "xmins" stands for XML namespaces.
      at XMAL file claim:
      <Window x:Class="MixwellWPF.Views.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
4. What is the difference between xmlns and xmlns:x in WPF?
    The first namespace is the default namespace and helps to resolve overall WPF elements.
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    The second namespace is prefixed by “x:” and helps to resolve XAML language definition.
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"   
  
5. When should we use "x:name" and "name".
    "name" is short hand of "x:name"

6. What are the different kinds of controls in WPF?
    Control, Shape, Panel, Content presenter.
 
7. Can you explain the complate WPF object hierarchy?  
   Object(inherited from .net object class)->Dispatcher(thereds go via dispatch object)->Dependency(WPF element is surrounded by other WPF elements)->Visual->
     UI Eleemnt (implement feature)->Framework element(tempalate, style, binding, resources...). 
  
8. Does that mean WPF has replaced DirectX?
  No replace DirectX, but relace winform.
 
9. So is XAML meant only for WPF?
   WPF XAML, Sliverlight XAML, WWF XAML.
 
10. Overall architecture of WPF? 
    Presentation Framework, Presentation Core, MilCore.
  
11. What is App.xaml in WPF project?
 
    App.xaml is the start up fileor a boot strapper file which triggers your first XAML page fro your WPF project.

12. What are resources in WPF?
   Resources are objects referred in WPF XAML. Could create C# object to binding to Resource with one way (only object change could inacte to resource) or 
   two binding could change each other between resouce and object.
  
13. Explain the difference between static and dynamic resource?
    static referred resources changed only once at design. Dynamatic referred resources changed as evertime binding object chagned.

14. when shoudl we use static resouce over dynameic reources  
    Dynamic resources reduce application performance.
 
15. Explain the need of binding and commands?
    WPF binding: send/receive data between WPF objects.
    command: send/receive action.

16. Explain one way, two way , one time and one way to source?
    Two way: sorce<->target
    One way: source -> targe.
    One way to source: targe->source
    One time: source ->targe only one time.
 
17. Explain WPF command with an example?
    WPF send acction through one command class/ICommand to reuse. 
  
18. How does "UpdateSourceTrigger" affect  Binding.
    If the source data is updated when the tiget is lost focus.
 
17. Explain the need of "INotifyPropertyChanged" interface?
   When bind two WPF objects the target data is update depending on the UpdateSourceTrigger events. 

18. What are value converters in WPF?
     Target and souce data type may need convert.
19. Explain multi binding and multivalue converter in WPF.
  

XX. Explain delegate command?
    Delegate command makes a MVVM command class independent of the view module"
 
XX. What is PRISM
    PRISM is a framework to develop composite application in WPF and Silverlight. Composite application are built
    using composition. Take prebuilt components, assemble them together and create the application.

 xx How are invidual units combined in to single unit?
   PRISM uses dependency injectin for the same. Like using delegating command to put commands function to one class.
  
 
 */
namespace WixwellWPF
{
    class WPFQA
    {
    }
}
