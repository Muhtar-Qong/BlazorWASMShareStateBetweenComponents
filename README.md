# BlazorWASMShareStateBetweenComponents
This project presents share application state/data between components by using an in-memory state container service
in Blazor WebAssembly app. 
1. Create a "TestComponent" with an "InputSelect" component(form-control) and display some contries in it.
2. Then, create a "ShareStateService" and register it in Program.cs file. And inject the service in the 
"TestComponent" above.
2. Finally, select a country in the "InputSelect" and share the selected country accross the application 
by using a "ShareStateService. 
