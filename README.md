# RAF Flight-Data App

README: the search feature MAY NOT work as intended if the files are incorrectly installed, to ensure this does not happen please place the executeable file (filghtData.exe) and the csv file (airportsData.csv) together in the same folder. User antiviruses might not allow the executeable to be run from the zipped folder but a zipped and normal copy of those files are avaliable in the "all code files" folder. If wished to use the file, the a zipped copy of the visual studio code repo is also included in the "all code files" folder. To view the source code of the app, view the "Main VB App Source-Code" file where this is stored. A copy of the initial test python files are also included in the relevant folder. A demonstration of the solution is included in the video submission if it is wished not to endure the process of getting it working: https://youtu.be/eRt7M9XhH2g

All CSV data sourced from "Our Airports" https://ourairports.com/data/ and then merged into a single flatfile csv so that the data can be searched easily. The use of a CSV file for data storage was due to the fact that the app is to be used without an internet connection, like when flying in an aircraft. The main VB program is only that long as the search feature is duplicated five times (for each index of the array created from the line being searched for the searchterm). Without that being copy pasted, it would only be a third of the size. The interface may look slightly different based on the operating system type being used.

Some airfield searches of the nearly 80,000 stored may still not work correctly, and due to csv compatibility issues, some keywords may not find the airfield. Here are some example airfield nav codes to enter that are tested to definitely work correctly:

- RAF Valley: "VLY"
- RAF Conningsby: "QCY"
- RAF Brize-Norton: "BZZ"
- Liverpool Airport: "LPL"
- Manchester Airport: "MAN"
- London Heathrow Airport: "LHR"

In the unlikey event that these codes are also not working, please refer to the first readme paragraph as the installation of the app may be incorrect.

The "all code files" folder contains a copy of the python and VB source code, along with their respective csv files, and a zipped copy of the Visual Studio code repo for the solution. I hope you like the prototype I have created...
