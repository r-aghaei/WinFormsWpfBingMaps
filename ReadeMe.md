# WPF Bing Maps Control in Windows Forms

This example shows how you can use WPF Bing Maps Control in a Windows Forms application, enable animation and set the initial view of the map. To do so, follow these instructions:

1. Create a Windows Forms Application.
2. Install [Microsoft.Maps.MapControl.WPF](https://www.nuget.org/packages/Microsoft.Maps.MapControl.WPF/?WT.mc_id=DT-MVP-5003235) NuGet package.
3. Add a new *WPF UserControl* to your project: 

    Right-click on project → choose *Add New Item* → Add a new *User Control (WPF)* (It's located under WPF category)
4. Add the Map to your WPF user control. Basically you need to add the map assembly to the control by adding the following attribute to your user control:

       xmlns:m="clr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF"

    And adding the map element to the control:

       <Grid>
         <m:Map/>
       </Grid>

    Here is the full code for your user control. (Make sure you use the correct namespace):

       <UserControl x:Class="YOURNAMESPACE.UserControl1"
          xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
          xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
          xmlns:m="clr-namespace:Microsoft.Maps.MapControl.WPF;assembly=Microsoft.Maps.MapControl.WPF">
          <Grid>
              <m:Map CredentialsProvider="YOUR MAP KEY" x:Name="myMap" />
          </Grid>
       </UserControl >

    *• Note*: You need a Bing Maps key. If you don't have a Bing maps account, [create a Bing Maps account](https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/creating-a-bing-maps-account?WT.mc_id=DT-MVP-5003235) and then [get a Bing Maps key](https://docs.microsoft.com/en-us/bingmaps/getting-started/bing-maps-dev-center-help/getting-a-bing-maps-key?redirectedfrom=MSDN&WT.mc_id=DT-MVP-5003235) from it. For test purpose, you can ignore the map key.


5. Build your project.

5. Drop an instance of ElementHost control on your form. You can find it under the WPF Interoperability group in toolbox.

6. From the smart action panel (at top right of the ElementHost control), set the hosted content to `UserControl1` and dock it to the parent container.

7. Handle the Load event of the `Form` and use the following code:

        private void Form1_Load(object sender, EventArgs e)
        {
            this.userControl11.myMap.AnimationLevel = AnimationLevel.Full;
            this.userControl11.myMap.Loaded += MyMap_Loaded;
        }
        private void MyMap_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            var location = new Location(47.604, -122.329);
            this.userControl11.myMap.SetView(location, 12);
        }

    Make sure you use `using Microsoft.Maps.MapControl.WPF;`.

7. Run your application.

There you go, The map will appear in your Windows Forms Application and the map zooms in Seattle as center location:

![WPF Bing Maps in Windows Forms](wpfmap.gif)

**More information:**

You may want to take a look at the following links for more information:

* [WPF and Windows Forms Interoperation](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/advanced/wpf-and-windows-forms-interoperation?view=netframeworkdesktop-4.8&WT.mc_id=DT-MVP-5003235)
* [Walkthrough: Hosting a WPF Composite Control in Windows Forms](https://docs.microsoft.com/en-us/dotnet/desktop/wpf/advanced/walkthrough-hosting-a-wpf-composite-control-in-windows-forms?view=netframeworkdesktop-4.8&WT.mc_id=DT-MVP-5003235)
* [Create a WPF Application that uses Bing Maps Control](https://docs.microsoft.com/en-us/previous-versions/bing/wpf-control/hh830433(v=msdn.10)?WT.mc_id=DT-MVP-5003235)
* [How can I add a Bing Maps Component to my C# Winforms app?](https://stackoverflow.com/q/65450109/3110834)
* [Bing Maps WPF Control](https://docs.microsoft.com/en-us/previous-versions/bing/wpf-control/hh750210(v=msdn.10)?WT.mc_id=DT-MVP-5003235)
* [Developing with the Bing Maps WPF Control](https://docs.microsoft.com/en-us/previous-versions/bing/wpf-control/hh830431(v=msdn.10)?WT.mc_id=DT-MVP-5003235)
* [Bing Maps WPF Control API Reference](https://docs.microsoft.com/en-us/previous-versions/bing/wpf-control/mt712924(v=msdn.10)?WT.mc_id=DT-MVP-5003235)


  [1]: https://i.stack.imgur.com/L89m7.png