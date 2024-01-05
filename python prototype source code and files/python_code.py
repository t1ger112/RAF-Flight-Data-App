import csv              #imports different code libraries for csv reading
import unicodedata

#must have the "airportsFull.csv" file in the same directory to function!

#first header notice of the app title
print("=====================================================")
print(" This app is ACE (Agile-Combat-Employment)")
print("=====================================================")

#aircraft type selection function
def selection():
    global aircraftType #type of aircraft
    aircraftType = 9  #starts as number larger than 3 to fail the selection if this is unchanged
    global aircraftSelect #user input of what their aircraft type is
    
    print(" What is your current airframe type? (FJ for MQ-9)") #user prompts
    print(" [1: Fast-Jet] / [2: Multi-Engine] / [3: Rotary-Wing]") # user can enter a number (1-3) or the name of airframe type
    aircraftSelect = input("\n Aircraft Type: ") # user input stored as "aircraftSelect" variable
    
    #if user input starts with "F" or "f" or "1" then the aircraft type is set to 1 (fast-jet)
    if aircraftSelect.startswith("F") or aircraftSelect.startswith("f") or aircraftSelect.startswith("1"):
        aircraftType = int(1) #sets aircraft type as int
        print("\n You are flying a Fast-Jet aircraft") #user prompt of type

    #if user input starts with "M" or "m" or "2" then the aircraft type is set to 2 (multi-engine)
    if aircraftSelect.startswith("M") or aircraftSelect.startswith("m") or aircraftSelect.startswith("2"):
        aircraftType = int(2) #sets aircraft type as int
        print("\n You are flying a Multi-Engine airplane") #user prompt of type

    #if user input starts with "R" or "r" or "3" then the aircraft type is set to 3 (heli)
    if aircraftSelect.startswith("R") or aircraftSelect.startswith("r") or aircraftSelect.startswith("3"):
        aircraftType = int(3) #sets aircraft type as int
        print("\n You are flying a Rotary-Wing helicopter") #user prompt of type

selection() #calls the function once

while int(aircraftType) > 3: #if the aircraft type hasnt cahnged form 9 then no valid type was entered
        print("Invalid Aircraft Type, Please Try Again:") #user prompt
        selection() # loops the selection again for the user to re-enter a valid aircraft type

print("=====================================================")    #line seperator

#airfield data function
def readData():  
    global row
    global selectedPrimary    #variables declared as global if needed in any further subroutines
    global aircraftType
    global primaryAirfield
    found = False #boolean of if an airfield identifier was found

    print("") #new line
    primaryAirfield = input(" Enter an airfield to search for: ") #user input of airfield unique identifier
    print("")  #new line
    data = open("airportsFULL.csv","r", encoding='utf-8') #opens the csv file in read mode and converts all contents to UTF-8 format for compatibility
    contents = list(csv.reader(data, delimiter=',', quotechar='"', quoting = csv.QUOTE_NONE)) #reads the whole file and stores as "contents" in an array/list
    for row in contents: #for each row in contents do the search
        if primaryAirfield in row: #search, if the searchterm is in the current row/array being searched then display the data 
            found = True #sets the search to completed, as the searchterm is found
            selectedPrimary = row #for debugging purposes this variable can be called to see the  array that was found to contain the searchterm
            print(" Airfield found:","["+row[1]+"]",row[3]+":") #prints icao nav code and the airfield name
            print("")
            print(" ~","[IATA:", row[13]+"]", "[ICAO:", row[12]+"]") #prints nav codes
            #print(" ~","[TOWER FREQ: N/A", row[]+"]")
            #print(" ~","[TACAN: N/A", row[]+"]")
            #print(" ~","[VOR/ILS: N/A", row[]+"]")         #data not operational at the time of python prototype creation
            #print(" ~","[QFE BARO: N/A", row[]+"]")
            print(" ~","[LATITUDE: ", "N" + row[4]+"]", "[LONGITUDE: ", "E" + row[5]+"]") #prints lat-long of the airfield in degrees accurate
            #print(" ~","[RNY HEADINGS: N/A", row[]+"]")
            #print(" ~","[RNY LENGTHS: N/A", row[]+"]") #data not operational at the time of python prototype creation
            print(" ~","[RNY ELEVATION:", row[6]+"]") #prints airfield elevation for the pilots to input into INS or after getting QNH from controller can use to calculate true QFE
            print("\n=====================================================")
            if aircraftType == 1:
                print(" FAST-JET ALERTS/NOTICES:")           
                #print(" \n", row[])
            elif aircraftType == 2:                        #wold output alerts based of the airfield data, curated to offer three different alerts based off the aircraft type.
                print(" MULTI-ENGINE ALERTS/NOTICES:")     #feature not operational at the time of python prototype creation
                #print(" \n", row[])
            elif aircraftType == 3:
                print(" ROTARY-WING ALERTS/NOTICES:")
                #print(" \n", row[])
            print("=====================================================")
            
    #if no airfield was found for the searchterm because found is still false, then an error message is displayed stating so
    if found == False:  
        print(" ERROR: AIRFIELD NOT FOUND") #user notification of error
        print("=====================================================")
    data.close() #closes the csv file once used
    readData() #loops the search for the user to try again after failing to find an airfield

readData() #loops the search for the user to try again after finding an airfield and its data

