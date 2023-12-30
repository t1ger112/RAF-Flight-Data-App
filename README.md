# RAF-Flight-Data-App
Hello, I’m Freddie and I’ve been working on an agile information app for aircrew in the RAF. The challenge faced was based around the difficulties of an agile operating doctrine, and how the efficiency of this type of employment can be aided through the use of software solutions. Here is the code repo for my prototype application.

README: the search feature MAY NOT work as intended if the files are incorrectly installed, to ensure this does not happen please place the executeable file (filghtData.exe) and the csv file (airportsData.csv) together in the same folder. In the code repo, they are both stored together in the "RUN EXE FROM HERE" folder where it is reccomended to run the executeable program from without saving it elsewhere.

With it being from an unverified publisher(me), the executeable may be scanned by any antiviral software running on the user's machine. Upon finishing the scan, the program is then ready to use, as antivirus software may block it's ability to read the csv and other functionality in the meantime of the scan.

All CSV data sourced from "Our Airports" (https://ourairports.com/data/) and then merged into a single flatfile csv so that the data can be searched easily. The use of a CSV file for data storage was due to the fact that the app is to be used without an internet connection, like when flying in an aircraft.   

The main VB program is only that long as the search feature is duplicated five times (for each index of the array created from the line being searched for the searchterm). Without that being copy pasted, it would only be a third of the size. The interface may look slightly different based on the operating system type being used.

Some airfield searches of the 80,000 stored may still not work correctly, and due to csv compatibility issues, some keywords may not find the airfield. Here are some example airfield nav codes to enter that are tested to definitely work correctly:

- RAF Valley: "VLY"
- RAF Conningsby: "QCY"
- RAF Brize-Norton: "BZZ"
- Liverpool Airport: "LPL"
- Manchester Airport: "MAN"
- London Heathrow Airport: "LHR"

In the unlikey event that these codes are also not working, please refer to the first paragraph as the installation of the app may be incorrect.

