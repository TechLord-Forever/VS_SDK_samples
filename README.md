
Visual Studio 2013 SDK Samples




Technologies 
Visual Studio 2013 

Topics 
Extensibility 

Platforms 
Desktop 

Requirements 


Primary language 
en-US

Updated 
5/30/2014

License 
Apache License, Version 2.0


View this sample online 
 

Visual Studio 2013 SDK Samples

Visual Studio 2013 is an integrated development environment (IDE) that allows you to develop a wide variety of software applications quickly and easily. The Visual Studio SDK provides a framework that you can use to extend the functionality of Visual Studio 2013.

To get started first you will need to download and installed Visual Studio 2013 and the Visual Studio 2013 SDK.  
1.Visual Studio 2013 
2.Visual Studio 2013 SDK 

 The Visual Studio 2013 SDK will help you extend all aspects of the Visual Studio IDE.  These samples will help provide examples on how to extend the following areas of Visual Studio:
•Adding menus and commands into the Menu system 
•Creating new Tool Windows 
•Extending the built in code editor 
•Creating new project and item templates 
•Creating and distributing custom controls 
•Adding new options in the Tools options dialog 
•Working with existing assests in project systems 
•Extending MSBuild 
•Creating new project systems 
•Managed, native and custom Debugger integration 



Sample index

 

Build Progress Bar - VS 2013

A Visual Studio Package which provides a new tool window called "Build Progress" which displays a WPF ProgressBar indicating percentage completion of the current solution build. Getting Started To build and run this sample, you must have Visual Studio 2013 installed, as 
  

Windows Forms Control Installer - VS 2013

This sample demonstrates how to create a Visual Studio package (VSPackage) that loads custom Windows Forms controls into the Toolbox. The code defines two toolbox items: MyCustomTextBox, which is a normal Windows Forms control, and MyCustomTextBoxWithPopup, which provides 
  

WPF Designer over XML - VS 2013

Inroduction Demonstrates how to create an extension with a WPF-based Visual Designer for editing XML files with a specific schema (XSD) in coordination with the Visual Studio XML Editor. In this sample we implement a basic view for a .vstemplate file. Requirements Visua
  

Code Sweep - VS 2013

Summary This sample allows the user to specify a set of terms to search for by specifying a set of XML files containing the term definitions. The user-configurable settings are stored in the project file. The scan can be invoked either on command or as an integrated part of 
  

Editor with Toolbox - VS 2013

This sample demonstrates how to create a package that provides an Editor type extended with Toolbox support.In this sample we implement an editor for a .tbx file and construct toolbox items that are available for the document. EditorWithToolboxGoals Provide an editor factory.
  

Reference Package - VS 2013

This sample shows how to create a Visual Studio package and how to add an entry into the Help About dialog. Reference Package   Introduction: This sample will show you how to create a Visual Studio 2013 Package and add an entry into the Visual Studio Help dialog.There is
  

Single File Generator - VS 2013

This sample demonstrates how to build a single file generator. Shows how to implement a single file generator. Shows how to use CodeDom to generate source code in Visual Basic, C#  Quick Navigation 1 Requirements 2 Download and Install 3 Building and Runn
  

Reference Service - VS 2013

This sample shows how to be a Visual Studio service provider and how to consume Visual Studio services. Introduction: There are three samples associated with this project, one for each programming language.C++The sample contains three main classes. A service provider packa
  

Menu and commands - VS 2013

This sample demonstrates how to create menu and command items and visualize them inside Visual Studio’s menus and toolbars. Goals Adding a menu item / command to Visual Studio and handling it Placing commands in various places (Solution Explorer toolbar, custom toolbar, Tool
  

WPF Tool Window - VS 2013

Summary This sample demonstrates how to create a package that provides tool windows which host Windows Forms controls and WPF controls.       Goals Exposing properties in the Properties window based on the selected item Tool window toolbars Tool window with visibi
  

Spell Checker - VS 2013

This sample uses smart tags and squiggles to display spelling errors in your comments inside of Visual Studio 2013. The extension provides an excellent example of how you use other services in combination with those provided in VS to add real-world functionality to the edi
  

Ook Language sample - VS 2013

Summary This is the example used during the Visual Studio Ecosystem Summit Presentation "Getting Linguistic: Integrating a Language into Visual Studio" by Chris Granger. It implements the following language features for the esoteric language "Ook!": General purpose token
  

Command Target RGB - VS 2013

A Visual Studio Package which provides a multi-instance tool window called "Red Green Blue" which hosts a toolbar with three buttons that will change the tool window's background color and move the toolbar in the frame. Getting Started To build and run this sample, you mu
  

Running Document Table Explorer - VS 2013

This sample demonstrates how to create an explorer that logs Running Document Table (RDT) events. Selecting an event from the grid displays its properties in the Properties Window. Goals Provides a tool to explore the RDT that follows recommended design patterns Expos
  

Caret Fish Eye - VS 2013

Summary This is a sample extension for Visual Studio 2013 that visually scales lines to be smaller the farther away from the caret's current position they are. It accomplishes this using the line transformation API. Requirements Visual Studio 2013 Visual Studio 201
  

Options Page - VS 2013

This sample demonstrates how to add custom options pages into the standard Visual Studio Options dialog. The sample adds two options pages and demonstrates how to customize the presentation and properties' persistence. Goals Integrate custom options pages into Visual Studios O
  

Completion Tooltip Customization - VS 2013

Summary This is a sample extension for the Visual Studio 2013 editor that replaces the completion tooltip UI. Requirements Visual Studio 2013   Visual Studio 2013 SDK     Download and install Download the zip file associated with the sample Unzip the sample 
  

Highlight Word - VS 2013

Summary This is a Visual Studio 2013 sample extension that uses tagging and adornments to highlight all the occurences of the word currently under the caret. Requirements Visual Studio 2013   Visual Studio 2013 SDK     Download and install Download the zip 
  

Combo Box - VS 2013

Summary This sample demonstrates how to create combo boxes on Visual Studio’s toolbars. Four types of combo boxes that can be created are shown in this sample.     Goals Adding a Drop Down Combo to Visual Studio and handling it Adding an Index Combo to Visual Studi
  

Typing Speed Meter - VS 2013

This is a sample editor extension for Visual Studio 2013 that uses and IVsTextViewCreationListener and an adornment to create a typing speed meter. The binaries for this sample can also be installed via the extension manager. Requirements Visual Studio 2013 Visual 
  

Source Control Provider - VS 2013

This sample demonstrates how to create a source code control provider. Implement a source control provider package Expose an Options page visible only when the provider is active Expose a tool window visible only when the provider is active Display menu items only wh
  

Basic Source Control Provider - VS 2013

This sample demonstrates how to create a source control provider that registers with Visual Studio and can be selected as active source control provider. Implement a source control provider package Expose an Options page visible only when the provider is active Ex
  

Inline XPS Viewer - VS 2013

Summary This is a sample adornment extension showing how to host a document viewer in Editor code window. In the doc viewer you can zoom in/out, view whole/2 pages, print and find text in the doc. Requirements Visual Studio 2013 Visual Studio 2013 SDK Download a
  

Diff Classifier - VS 2013

This is a sample Visual Studio 2013 classifier for diff/patch files. It provides formatting for the various line types found in diff files using the classification API. The binaries for this sample can also be installed via the extension manager. Requirements Visual S
  

Intra-text adornment - VS 2013

Summary This is a sample extension for the Visual Studio 2013 editor that replaces a hexadecimal color with a color swatch using intra-text adornments. Requirements Visual Studio 2013 Visual Studio 2013 SDK Download and install Download the zip file associated w
  

TodoGlyphFactory - VS 2013

This sample adds a glyph in the glyph margin on all lines that have comments with the word "todo" in them. It demonstrates how to create a custom glyph factory that uses a tagger. The binaries for this sample can also be installed via the extension manager. Requirement
  

Todo Classification - VS 2013

This is the sample code written during the Visual Studio Ecosystem Summit presentation "I Want Coloring: A scenario based look at the new editor". It provides a general purpose TodoTagger as well as classification and a glyph factory. The binaries for this sample can also 
  

MSDN Search - VS 2013

This sample demonstrates how to extend Quick Launch and add a search provider to search outside Tools Options / Menus / Open Documents (the built-in providers). In this sample Quick Launch display results from MSDN.   Quick Navigation 1 Requirements 2 Do
 
