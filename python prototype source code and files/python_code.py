import csv
import unicodedata

#must have the "airportsFull.csv" file in the same directory to function!

print("=====================================================")
print(" This app is ACE (Agile-Combat-Employment)")
print("=====================================================")

def selection():
    global aircraftType
    aircraftType = 9
    global aircraftSelect
    
    print(" What is your current airframe type? (FJ for MQ-9)")
    print(" [1: Fast-Jet] / [2: Multi-Engine] / [3: Rotary-Wing]")
    aircraftSelect = input("\n Aircraft Type: ")
    
    if aircraftSelect.startswith("F") or aircraftSelect.startswith("f") or aircraftSelect.startswith("1"):
        aircraftType = int(1)
        print("\n You are flying a Fast-Jet aircraft")
    if aircraftSelect.startswith("M") or aircraftSelect.startswith("m") or aircraftSelect.startswith("2"):
        aircraftType = int(2)
        print("\n You are flying a Multi-Engine airplane")
    if aircraftSelect.startswith("R") or aircraftSelect.startswith("r") or aircraftSelect.startswith("3"):
        aircraftType = int(3)
        print("\n You are flying a Rotary-Wing helicopter") 
selection()

while int(aircraftType) > 3:
        print("Invalid Aircraft Type, Please Try Again:")
        selection()

print("=====================================================")    

def readData():  
    global row
    global selectedPrimary
    global aircraftType
    global primaryAirfield
    found = False

    print("")
    primaryAirfield = input(" Enter an airfield to search for: ")
    print("")  
    data = open("airportsFULL.csv","r", encoding='utf-8')
    contents = list(csv.reader(data, delimiter=',', quotechar='"', quoting = csv.QUOTE_NONE))
    for row in contents:
        if primaryAirfield in row:
            found = True
            selectedPrimary = row
            print(" Airfield found:","["+row[1]+"]",row[3]+":")
            print("")
            print(" ~","[IATA:", row[13]+"]", "[ICAO:", row[12]+"]")
            #print(" ~","[TOWER FREQ: N/A", row[]+"]")
            #print(" ~","[TACAN: N/A", row[]+"]")
            #print(" ~","[VOR/ILS: N/A", row[]+"]")
            #print(" ~","[QFE BARO: N/A", row[]+"]")
            print(" ~","[LATITUDE: ", "N" + row[4]+"]", "[LONGITUDE: ", "E" + row[5]+"]")
            #print(" ~","[RNY HEADINGS: N/A", row[]+"]")
            #print(" ~","[RNY LENGTHS: N/A", row[]+"]")
            print(" ~","[RNY ELEVATION:", row[6]+"]")
            print("\n=====================================================")
            if aircraftType == 1:
                print(" FAST-JET ALERTS/NOTICES:")
                #print(" \n", row[])
            elif aircraftType == 2:
                print(" MULTI-ENGINE ALERTS/NOTICES:")
                #print(" \n", row[])
            elif aircraftType == 3:
                print(" ROTARY-WING ALERTS/NOTICES:")
                #print(" \n", row[])
            print("=====================================================")
    if found == False:
        print(" ERROR: AIRFIELD NOT FOUND")
        print("=====================================================")
    data.close()
    readData()
readData()

